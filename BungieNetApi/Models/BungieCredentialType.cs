using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// The types of credentials the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.CredentialType.
    /// </summary>
    
    public enum BungieCredentialType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Xuid = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Xuid = 1,

        /// <summary>
        /// Psnid = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Psnid = 2,

        /// <summary>
        /// Wlid = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Wlid = 3,

        /// <summary>
        /// Fake = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Fake = 4,

        /// <summary>
        /// Facebook = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Facebook = 5,

        /// <summary>
        /// Google = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Google = 8,

        /// <summary>
        /// Windows = 9
        /// </summary>
        [EnumMember(Value = "9")]
        Windows = 9,

        /// <summary>
        /// DemonId = 10
        /// </summary>
        [EnumMember(Value = "10")]
        DemonId = 10,

        /// <summary>
        /// SteamId = 12
        /// </summary>
        [EnumMember(Value = "12")]
        SteamId = 12,

        /// <summary>
        /// BattleNetId = 14
        /// </summary>
        [EnumMember(Value = "14")]
        BattleNetId = 14,

        /// <summary>
        /// StadiaId = 16
        /// </summary>
        [EnumMember(Value = "16")]
        StadiaId = 16,

        /// <summary>
        /// TwitchId = 18
        /// </summary>
        [EnumMember(Value = "18")]
        TwitchId = 18,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}