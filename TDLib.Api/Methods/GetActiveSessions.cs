using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetActiveSessions : Method<Sessions>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getActiveSessions";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}