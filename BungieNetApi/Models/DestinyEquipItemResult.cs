using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The results of an Equipping operation performed through the Destiny API.
    /// </summary>
    [DataContract]
    public class DestinyEquipItemResult
    {
        /// <summary>
        /// The instance ID of the item in question (all items that can be equipped must, but definition, be Instanced and thus have an Instance ID that you can use to refer to them)
        /// </summary>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// A PlatformErrorCodes enum indicating whether it succeeded, and if it failed why.
        /// </summary>
        [DataMember(Name = "equipStatus", EmitDefaultValue = false)]
        public PlatformErrorCodes EquipStatus { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEquipItemResult);
        }

        public bool Equals(DestinyEquipItemResult input)
        {
            if (input == null) return false;

            return
                (
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId != null && ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
                (
                    EquipStatus == input.EquipStatus ||
                    (EquipStatus != null && EquipStatus.Equals(input.EquipStatus))
                ) ;
        }
    }
}

