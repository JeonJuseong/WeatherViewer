using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherViewer
{
    internal class ApiHandler
    {
        private static readonly ApiHandler instance = new ApiHandler();
        private ApiHandler()
        {

        }

        public static ApiHandler Instance => instance;

        //호출 시 비동기적으로 입력받은 url로 부터 API데이터를 수신한다.
        internal static async Task<string> GetApiDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        internal static string generateURL(string baseUrl, string authKey)
        {
            DateTime now = DateTime.Now;
            int nowHour = now.Hour;
            int nowMinute = now.Minute;
            string nowDate = now.Date.ToString("yyyyMMdd");
            if (nowMinute < 40) nowHour--;
            string formattedHour = nowHour.ToString("D2");

            var queryParams = new Dictionary<string, string>
            {
                { "serviceKey", authKey },
                { "numOfRows", "1000" },
                { "pageNo", "1" },
                { "dataType", "JSON"},
                { "base_date", nowDate },
                { "base_time", formattedHour+nowMinute },
                { "nx", "87" },
                { "ny", "89" }
            };

            string queryString = string.Join("&", queryParams.Select(kvp => $"{kvp.Key}={kvp.Value}"));
            string finalUrl = $"{baseUrl}?{queryString}";

            //MessageBox.Show(finalUrl);

            return finalUrl;
        }
    }
}
