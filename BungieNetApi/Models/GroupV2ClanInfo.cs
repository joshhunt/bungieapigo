using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// This contract contains clan-specific group information. It does not include any investment data.
    /// </summary>
    [DataContract]
    public class GroupV2ClanInfo
    {
        [DataMember(Name = "clanCallsign", EmitDefaultValue = false)]
        public string ClanCallsign { get; set; }

        [DataMember(Name = "clanBannerData", EmitDefaultValue = false)]
        public ClanBanner ClanBannerData { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupV2ClanInfo);
        }

        public bool Equals(GroupV2ClanInfo input)
        {
            if (input == null) return false;

            return
                (
                    ClanCallsign == input.ClanCallsign ||
                    (ClanCallsign != null && ClanCallsign.Equals(input.ClanCallsign))
                ) &&
                (
                    ClanBannerData == input.ClanBannerData ||
                    (ClanBannerData != null && ClanBannerData.Equals(input.ClanBannerData))
                ) ;
        }
    }
}

