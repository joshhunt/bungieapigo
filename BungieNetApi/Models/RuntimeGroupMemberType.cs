using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The member levels used by all V2 Groups API. Individual group types use their own mappings in their native storage (general uses BnetDbGroupMemberType and D2 clans use ClanMemberLevel), but they are all translated to this in the runtime api. These runtime values should NEVER be stored anywhere, so the values can be changed as necessary.
    /// </summary>
    
    public enum RuntimeGroupMemberType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Beginner = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Beginner = 1,

        /// <summary>
        /// Member = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Member = 2,

        /// <summary>
        /// Admin = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Admin = 3,

        /// <summary>
        /// ActingFounder = 4
        /// </summary>
        [EnumMember(Value = "4")]
        ActingFounder = 4,

        /// <summary>
        /// Founder = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Founder = 5,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}