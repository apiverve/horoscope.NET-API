using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Zodiac data
    /// </summary>
    public class Zodiac
    {
        [JsonProperty("element")]
        public string Element { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stone")]
        public string Stone { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("compatibility")]
        public string[] Compatibility { get; set; }

        [JsonProperty("horoscope")]
        public string Horoscope { get; set; }

        [JsonProperty("luckyNumber")]
        public int LuckyNumber { get; set; }

        [JsonProperty("luckyTime")]
        public string LuckyTime { get; set; }

        [JsonProperty("mood")]
        public string Mood { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }

        [JsonProperty("zodiac")]
        public Zodiac Zodiac { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
