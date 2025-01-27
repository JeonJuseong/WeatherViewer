using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WeatherViewer
{
    public partial class Form1 : Form
    {
        static string baseUrl = "http://apis.data.go.kr/1360000/VilageFcstInfoService_2.0/getUltraSrtFcst";
        string authKey;
        private LoadingHandler overlay;
        private IconHandler iconHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string authKeyPath = @"data\authKey.txt";
            try
            {
                //반투명 윈도우 표시
                ShowOverlay();

                //최초 로드 시 authKeyPath에서 키를 검사하고 없으면, 키를 요청하는 창 호출
                //bin\Debug\data\authKey.txt;
                authKey = File.ReadAllText(authKeyPath);

                // API 데이터를 불러오는 동안 로딩 상태를 표시
                authKeyLabel.Text = "API Loading...";
                authKeyLabel.ForeColor = Color.Orange;

                string jsonData = await ApiHandler.GetApiDataAsync(ApiHandler.generateURL(baseUrl, authKey));
                var items = DataHandler.ParseJson(jsonData);
                var firstItem = items?.FirstOrDefault();

                // 데이터가 없으면 False 상태 표시 및 Form2 호출
                if (items == null || items.Count == 0)
                {
                    authKeyLabel.Text = "False";
                    authKeyLabel.ForeColor = Color.Red;
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    authKeyLabel.Text = "True";
                    authKeyLabel.ForeColor = Color.Blue;
                }

            }
            catch
            {
                authKeyLabel.Text = "False";
                authKeyLabel.ForeColor = Color.Red;
                Form2 newForm = new Form2();
                newForm.Show();
            }
            finally
            {
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
                precLabels[i].Text = foreCastData.Precipitation[i] + " mm";
                windDirLabels[i].Text = (foreCastData.WindDirection[i]).PadLeft(3, '0') + "°";
                windSpdLabels[i].Text = foreCastData.WindSpeed[i] + "m/s";

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
            overlay = new LoadingHandler
            {
                Owner = this, // Form1을 소유자로 설정
                Bounds = this.Bounds // Form1 크기와 위치를 따라감
            };

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
