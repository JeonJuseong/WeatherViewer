using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherViewer
{
    internal class FilteredForecast
    {
        internal string[] Temperature { get; set; }
        internal string[] PrecipitationType { get; set; }
        internal string[] Precipitation { get; set; }
        internal string[] Sky { get; set; }
        internal string[] Humidity { get; set; }
        internal string[] WindDirection { get; set; }
        internal string[] WindSpeed { get; set; }
    }

    internal class Item
    {
        public string Category { get; set; }
        public string FcstTime { get; set; }
        public string FcstValue { get; set; }
    }
    internal class DataHandler
    {

        internal static List<Item> ParseJson(string jsonData)
        {
            // JSON 데이터에서 "response" -> "body" -> "items" -> "item" 부분 추출
            var root = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
            var response = JsonConvert.DeserializeObject<Dictionary<string, object>>(root["response"].ToString());
            var body = JsonConvert.DeserializeObject<Dictionary<string, object>>(response["body"].ToString());
            var items = JsonConvert.DeserializeObject<Dictionary<string, List<Item>>>(body["items"].ToString());

            // "item" 리스트 반환
            return items["item"];
        }

        // fcstTime(예보 시각)기준으로 group화
        internal static Dictionary<string, List<(string fcstTime, string FcstValue)>> groupItemByCategory(List<Item> items)
        {
            return items.GroupBy(item => item.FcstTime)
                .ToDictionary(
                    group => group.Key,
                    group => group.Select(item => (item.Category, item.FcstValue)).ToList()
                );
        }

        // group한 데이터 중 Category 내 원하는 데이터 추출
        internal static Dictionary<string, string> ExtractCategoryValues
            (Dictionary<string, List<(string Category, string FcstValue)>> groupedData, string targetCategory)
        {
            return groupedData
                .Where(kv => kv.Value.Any(item => item.Category == targetCategory)) // 대상 Category가 포함된 그룹만 필터링
                .ToDictionary(
                    kv => kv.Key, // fcstTime (키)
                    kv => kv.Value
                        .FirstOrDefault(item => item.Category == targetCategory).FcstValue // 대상 Category의 FcstValue
                );
        }

        internal static FilteredForecast filteringForecastData(string jsonData, Form ParentsForm)
        {
            var groupedItems = groupItemByCategory(ParseJson(jsonData));

            for (int i = 0; i <= 6; i++)
            {
                var label = ParentsForm.Controls.Find($"timeLabel{i}", true).FirstOrDefault() as Label;
                if (label != null && i - 1 < groupedItems.Keys.Count())
                {
                    label.Text = groupedItems.Keys.ElementAt(i - 1).ToString();
                }
            }

            return new FilteredForecast
            {
                Temperature = ExtractCategoryValues(groupedItems, "T1H").Values.ToArray(),
                PrecipitationType = ExtractCategoryValues(groupedItems, "PTY").Values.ToArray(),
                Precipitation = ExtractCategoryValues(groupedItems, "RN1").Values.ToArray(),
                Sky = ExtractCategoryValues(groupedItems, "SKY").Values.ToArray(),
                Humidity = ExtractCategoryValues(groupedItems, "REH").Values.ToArray(),
                WindDirection = ExtractCategoryValues(groupedItems, "VEC").Values.ToArray(),
                WindSpeed = ExtractCategoryValues(groupedItems, "WSD").Values.ToArray()
            };
        }
    }
}
