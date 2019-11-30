using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Contains auto-download settings presets for the user
        /// </summary>
        public class AutoDownloadSettingsPresets : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "autoDownloadSettingsPresets";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Preset with lowest settings; supposed to be used by default when roaming
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("low")]
            public AutoDownloadSettings Low { get; set; }

            /// <summary>
            /// Preset with medium settings; supposed to be used by default when using mobile data
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("medium")]
            public AutoDownloadSettings Medium { get; set; }

            /// <summary>
            /// Preset with highest settings; supposed to be used by default when connected on Wi-Fi
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("high")]
            public AutoDownloadSettings High { get; set; }
        }
    }
}