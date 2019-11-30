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
        /// Sends a code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        public class SendPhoneNumberVerificationCode : Function<AuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendPhoneNumberVerificationCode";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The phone number of the user, in international format 
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