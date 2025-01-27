using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherViewer
{
    public partial class Form2 : Form
    {
        string authKey;
        private bool apiValidity;
        private string authKeyPath = @"data\authKey.txt";
        static string baseUrl = "http://apis.data.go.kr/1360000/VilageFcstInfoService_2.0/getUltraSrtFcst";

        public Form2()
        {
            InitializeComponent();
            FormClosing += Form2_FormClosing;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiKey = apiInsertBox.Text;
            if (apiKey == "")
            {
                MessageBox.Show("API키가 입력되지 않았습니다.\n올바른 API키를 입력해주세요.");
                return;
            }

            // 실행 파일의 디렉토리 가져오기
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // 상대 경로 설정
            string relativePath = @"data\authKey.txt";
            string fullPath = Path.Combine(baseDirectory, relativePath);

            try
            {
                // 디렉토리 생성 (존재하지 않으면 생성됨)
                string directoryPath = Path.GetDirectoryName(fullPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // 텍스트 파일에 데이터 저장
                File.WriteAllText(fullPath, apiKey);

                Console.WriteLine($"파일이 저장되었습니다: {fullPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류 발생: {ex.Message}");
            }

            apiValidity = await checkAPI();
            if (!apiValidity)
            {
                apiInsertBox.Text = null;
                MessageBox.Show(
                    "API키가 올바르지 않습니다!\n다시한번 확인해주세요.",
                    "입력값 경고",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!apiValidity)
            {
                apiInsertBox.Text = null;

                MessageBox.Show(
                    "API키가 올바르지 않습니다!\n다시한번 확인해주세요.",
                    "입력값 경고",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private async Task<bool> checkAPI()
        {
            authKey = apiInsertBox.Text;

            try
            {
                string jsonData = await ApiHandler.GetApiDataAsync(ApiHandler.generateURL(baseUrl, authKey));
                var items = DataHandler.ParseJson(jsonData);

                if (items == null || items.Count == 0) return false;
                else return true;
            }
            catch
            {
                return false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
