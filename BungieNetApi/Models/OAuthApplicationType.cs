using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum OAuthApplicationType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Confidential = 1
        /// Indicates the application is server based and can keep its secrets from end users and other potential snoops.
        /// </summary>
        [EnumMember(Value = "1")]
        Confidential = 1,

        /// <summary>
        /// Public = 2
        /// Indicates the application runs in a public place, and it can&#39;t be trusted to keep a secret.
        /// </summary>
        [EnumMember(Value = "2")]
        Public = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}