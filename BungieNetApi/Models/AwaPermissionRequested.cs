using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class AwaPermissionRequested
    {
        /// <summary>
        /// Type of advanced write action.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public AwaType Type { get; set; }

        /// <summary>
        /// Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.
        /// </summary>
        [DataMember(Name = "affectedItemId", EmitDefaultValue = false)]
        public long AffectedItemId { get; set; }

        /// <summary>
        /// Destiny membership type of the account to modify.
        /// </summary>
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public BungieMembershipType MembershipType { get; set; }

        /// <summary>
        /// Destiny character ID, if applicable, that will be affected by the action.
        /// </summary>
        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as AwaPermissionRequested);
        }

        public bool Equals(AwaPermissionRequested input)
        {
            if (input == null) return false;

            return
                (
                    Type == input.Type ||
                    (Type != null && Type.Equals(input.Type))
                ) &&
                (
                    AffectedItemId == input.AffectedItemId ||
                    (AffectedItemId.Equals(input.AffectedItemId))
                ) &&
                (
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) &&
                (
                    CharacterId == input.CharacterId ||
                    (CharacterId.Equals(input.CharacterId))
                ) ;
        }
    }
}

