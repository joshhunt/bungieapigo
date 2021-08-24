using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum FriendRelationshipState
    {
        /// <summary>
        /// Unknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unknown = 0,

        /// <summary>
        /// Friend = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Friend = 1,

        /// <summary>
        /// IncomingRequest = 2
        /// </summary>
        [EnumMember(Value = "2")]
        IncomingRequest = 2,

        /// <summary>
        /// OutgoingRequest = 3
        /// </summary>
        [EnumMember(Value = "3")]
        OutgoingRequest = 3,

    }
}