using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GlobalAlertType
    {
        /// <summary>
        /// GlobalAlert = 0
        /// </summary>
        [EnumMember(Value = "0")]
        GlobalAlert = 0,

        /// <summary>
        /// StreamingAlert = 1
        /// </summary>
        [EnumMember(Value = "1")]
        StreamingAlert = 1,

    }
}