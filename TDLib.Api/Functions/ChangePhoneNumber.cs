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
        /// Changes the phone number of the user and sends an authentication code to the user's new phone number. On success, returns information about the sent code
        /// </summary>
        public class ChangePhoneNumber : Function<AuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "changePhoneNumber";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new phone number of the user in international format 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("phone_number")]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// Settings for the authentication of the user's phone number
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("settings")]
            public PhoneNumberAuthenticationSettings Settings { get; set; }
        }
    }
}