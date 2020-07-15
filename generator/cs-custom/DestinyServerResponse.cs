using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Api
{
    /// <summary>
    /// InlineResponse20037
    /// </summary>
    [DataContract]
    public partial class DestinyServerResponse<T>
    {

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "Response", EmitDefaultValue = false)]
        public T Response { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "ErrorCode", EmitDefaultValue = false)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ThrottleSeconds
        /// </summary>
        [DataMember(Name = "ThrottleSeconds", EmitDefaultValue = false)]
        public int ThrottleSeconds { get; set; }

        /// <summary>
        /// Gets or Sets ErrorStatus
        /// </summary>
        [DataMember(Name = "ErrorStatus", EmitDefaultValue = false)]
        public string ErrorStatus { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MessageData
        /// </summary>
        [DataMember(Name = "MessageData", EmitDefaultValue = false)]
        public Dictionary<string, string> MessageData { get; set; }

        /// <summary>
        /// Gets or Sets DetailedErrorTrace
        /// </summary>
        [DataMember(Name = "DetailedErrorTrace", EmitDefaultValue = false)]
        public string DetailedErrorTrace { get; set; }

        public static DestinyServerResponse<object> ToSimple<TT>(DestinyServerResponse<TT> data)
        {
            var simpleData = new DestinyServerResponse<object>()
            {
                Response = data.Response,
                ErrorCode = data.ErrorCode,
                ThrottleSeconds = data.ThrottleSeconds,
                ErrorStatus = data.ErrorStatus,
                Message = data.Message,
                MessageData = data.MessageData,
                DetailedErrorTrace = data.DetailedErrorTrace,

            };

            return simpleData;
        }
    }
}
