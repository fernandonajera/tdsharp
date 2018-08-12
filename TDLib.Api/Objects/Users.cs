using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class Users : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "users";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_ids")]
            public int[] UserIds { get; set; }
        }
    }
}