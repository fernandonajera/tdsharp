using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link is a link to a language pack. Call getLanguagePackInfo with the given language pack identifier to process the link
            /// </summary>
            public class InternalLinkTypeLanguagePack : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypeLanguagePack";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Language pack identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("language_pack_id")]
                public string LanguagePackId { get; set; }
            }
        }
    }
}