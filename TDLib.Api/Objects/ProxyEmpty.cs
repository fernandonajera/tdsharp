using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class Proxy : Object
        {
            public class ProxyEmpty : Proxy
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "proxyEmpty";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}