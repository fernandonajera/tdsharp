using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageForwardOrigin : Object
        {
            /// <summary>
            /// Contains information about the origin of a forwarded message
            /// </summary>
            public class MessageForwardOriginUser : MessageForwardOrigin
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageForwardOriginUser";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the user that originally sent the message
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("sender_user_id")]
                public long SenderUserId { get; set; }
            }
        }
    }
}