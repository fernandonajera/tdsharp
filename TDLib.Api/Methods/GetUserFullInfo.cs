using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetUserFullInfo : Method<UserFullInfo>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getUserFullInfo";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("user_id")]
        public int UserId { get; set; }

    }

}