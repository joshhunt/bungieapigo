using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// A flags enumeration that represents a Fireteam Member's status.
    /// </summary>
    [Flags]
    public enum DestinyPartyMemberStates
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// FireteamMember = 1
        /// This one&#39;s pretty obvious - they&#39;re on your Fireteam.
        /// </summary>
        [EnumMember(Value = "1")]
        FireteamMember = 1,

        /// <summary>
        /// PosseMember = 2
        /// I don&#39;t know what it means to be in a &#39;Posse&#39;, but apparently this is it.
        /// </summary>
        [EnumMember(Value = "2")]
        PosseMember = 2,

        /// <summary>
        /// GroupMember = 4
        /// Nor do I understand the difference between them being in a &#39;Group&#39; vs. a &#39;Fireteam&#39;.
        /// I&#39;ll update these docs once I get more info. If I get more info. If you&#39;re reading this, I never got more info. You&#39;re on your own, kid.
        /// </summary>
        [EnumMember(Value = "4")]
        GroupMember = 4,

        /// <summary>
        /// PartyLeader = 8
        /// This person is the party leader.
        /// </summary>
        [EnumMember(Value = "8")]
        PartyLeader = 8,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}