using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("color")]
    public string color { get; set; }

    [JsonProperty("compatibility")]
    public string[] compatibility { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("horoscope")]
    public string horoscope { get; set; }

    [JsonProperty("luckyNumber")]
    public int luckyNumber { get; set; }

    [JsonProperty("luckyTime")]
    public string luckyTime { get; set; }

    [JsonProperty("mood")]
    public string mood { get; set; }

    [JsonProperty("sign")]
    public string sign { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
