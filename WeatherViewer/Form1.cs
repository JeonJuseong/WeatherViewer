using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherViewer
{
    public partial class Form1 : Form
    {
        static string baseUrl = "http://apis.data.go.kr/1360000/VilageFcstInfoService_2.0/getUltraSrtFcst";
        private string authKey;
        private string authKeyPath = @"data\authKey.txt";
        private LoadingHandler overlay;
        private IconHandler iconHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private async Task checkAPI(Action<bool> callback)
        {
            authKey = File.ReadAllText(authKeyPath);

            string jsonData = await ApiHandler.GetApiDataAsync(ApiHandler.generateURL(baseUrl, authKey));
            var items = DataHandler.ParseJson(jsonData);
            //var firstItem = items?.FirstOrDefault();

            if (items == null || items.Count == 0)
            {
                authKeyLabel.Text = "False";
                authKeyLabel.ForeColor = Color.Red;
                callback(false);
            }
            else callback(true);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // API 데이터를 불러오는 동안 로딩 상태를 표시
            authKeyLabel.Text = "API Loading...";
            authKeyLabel.ForeColor = Color.Orange;
            //반투명 윈도우 표시
            ShowOverlay();

            try
            {
                await checkAPI(result =>
                {
                    if (result == true)
                    {
                        authKeyLabel.Text = "True";
                        authKeyLabel.ForeColor = Color.Blue;
                    }
                    else
                    {
                        authKeyLabel.Text = "False";
                        authKeyLabel.ForeColor = Color.Red;
                        Form2 newForm = new Form2();
                        Thread.Sleep(1000);
                        newForm.Show();
                        if (newForm.DialogResult == DialogResult.OK)
                            authKey = File.ReadAllText(authKeyPath);
                    }
                });

            }
            catch
            {
                authKeyLabel.Text = "False";
                authKeyLabel.ForeColor = Color.Red;
                Form2 newForm = new Form2();
                newForm.ShowDialog();
                if (newForm.DialogResult == DialogResult.OK)
                    authKey = File.ReadAllText(authKeyPath);
            }
            finally
            {
                button1_Click(sender, e);
                HideOverlay();
            }
        }

        private string getNowTime()
        {
            DateTime now = DateTime.Now;
            int nowHour = now.Hour;
            int nowMinute = now.Minute;
            string nowDate = now.Date.ToString("yyyy.MM.dd");
            if (nowMinute < 30) nowHour--;
            string formattedHour = nowHour.ToString("D2");

            return nowDate + " " + formattedHour + ":30";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            iconHandler = new IconHandler();
            string jsonData = await ApiHandler.GetApiDataAsync(ApiHandler.generateURL(baseUrl, authKey));

            //var groupedItems = DataHandler.groupItemByCategory(DataHandler.ParseJson(jsonData));
            var foreCastData = DataHandler.filteringForecastData(jsonData, this);

            updateTimeLabel.Text = getNowTime();
            Label[] tempLabels = { tempLabel1, tempLabel2, tempLabel3, tempLabel4, tempLabel5, tempLabel6 };
            Label[] humiLabels = { humiLabel1, humiLabel2, humiLabel3, humiLabel4, humiLabel5, humiLabel6 };
            Label[] precLabels = { precLabel1, precLabel2, precLabel3, precLabel4, precLabel5, precLabel6 };
            Label[] windDirLabels = { windDirLabel1, windDirLabel2, windDirLabel3, windDirLabel4, windDirLabel5, windDirLabel6 };
            Label[] windSpdLabels = { windSpdLabel1, windSpdLabel2, windSpdLabel3, windSpdLabel4, windSpdLabel5, windSpdLabel6 };
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            for (int i = 0; i < 6; i++)
            {
                string PrecType = foreCastData.PrecipitationType[i];
                tempLabels[i].Text = foreCastData.Temperature[i] + " ℃";
                humiLabels[i].Text = foreCastData.Humidity[i] + " %";
                precLabels[i].Text = foreCastData.Precipitation[i];
                windDirLabels[i].Text = (foreCastData.WindDirection[i]).PadLeft(3, '0') + "°";
                windSpdLabels[i].Text = foreCastData.WindSpeed[i] + "m/s";

                //pictureBox에 로드된 이미지가 이미 있는 경우, 해당 pictureBox를 초기화해 최적화
                //->메모리 사전누수 방지
                if (pictureBoxes[i].Image != null)
                {
                    pictureBoxes[i].Image.Dispose();
                    pictureBoxes[i].Image = null;
                }

                //아래는 그림배치
                if (PrecType == "0") iconHandler.SkyCodeToIcon(pictureBoxes, foreCastData.Sky[i], i);
                else iconHandler.PrecTypeToIcon(pictureBoxes, PrecType, i);
            }
        }

        private void authKeyButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        // 반투명 윈도우 표시
        private void ShowOverlay()
        {
            if (overlay == null || overlay.IsDisposed)
            {
                overlay = new LoadingHandler(this);

                overlay.Owner = this;

                overlay.StartPosition = FormStartPosition.Manual;
            }

            overlay.Show();
        }

        // 반투명 윈도우 숨기기
        private void HideOverlay()
        {
            if (overlay != null)
            {
                overlay.Close();
                overlay.Dispose();
                overlay = null;
            }
        }
    }
}
