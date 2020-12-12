using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
    /// </summary>
    
    public enum BungieMembershipType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// TigerXbox = 1
        /// </summary>
        [EnumMember(Value = "1")]
        TigerXbox = 1,

        /// <summary>
        /// TigerPsn = 2
        /// </summary>
        [EnumMember(Value = "2")]
        TigerPsn = 2,

        /// <summary>
        /// TigerSteam = 3
        /// </summary>
        [EnumMember(Value = "3")]
        TigerSteam = 3,

        /// <summary>
        /// TigerBlizzard = 4
        /// </summary>
        [EnumMember(Value = "4")]
        TigerBlizzard = 4,

        /// <summary>
        /// TigerStadia = 5
        /// </summary>
        [EnumMember(Value = "5")]
        TigerStadia = 5,

        /// <summary>
        /// TigerDemon = 10
        /// </summary>
        [EnumMember(Value = "10")]
        TigerDemon = 10,

        /// <summary>
        /// BungieNext = 254
        /// </summary>
        [EnumMember(Value = "254")]
        BungieNext = 254,

        /// <summary>
        /// All = -1
        /// &quot;All&quot; is only valid for searching capabilities: you need to pass the actual matching BungieMembershipType for any query where you pass a known membershipId.
        /// </summary>
        [EnumMember(Value = "-1")]
        All = -1,

    }
}