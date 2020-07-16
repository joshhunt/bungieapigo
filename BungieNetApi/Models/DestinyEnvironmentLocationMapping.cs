using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyEnvironmentLocationMapping
    {
        /// <summary>
        /// The location that is revealed on the director by this mapping.
        /// </summary>
        [DataMember(Name = "locationHash", EmitDefaultValue = false)]
        public uint LocationHash { get; set; }

        /// <summary>
        /// A hint that the UI uses to figure out how this location is activated by the player.
        /// </summary>
        [DataMember(Name = "activationSource", EmitDefaultValue = false)]
        public string ActivationSource { get; set; }

        /// <summary>
        /// If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don't)
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        /// <summary>
        /// If this is populated, this is an objective related to the location.
        /// </summary>
        [DataMember(Name = "objectiveHash", EmitDefaultValue = false)]
        public uint ObjectiveHash { get; set; }

        /// <summary>
        /// If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don't)
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEnvironmentLocationMapping);
        }

        public bool Equals(DestinyEnvironmentLocationMapping input)
        {
            if (input == null) return false;

            return
                (
                    LocationHash == input.LocationHash ||
                    (LocationHash != null && LocationHash.Equals(input.LocationHash))
                ) &&
                (
                    ActivationSource == input.ActivationSource ||
                    (ActivationSource != null && ActivationSource.Equals(input.ActivationSource))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    ObjectiveHash == input.ObjectiveHash ||
                    (ObjectiveHash != null && ObjectiveHash.Equals(input.ObjectiveHash))
                ) &&
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) ;
        }
    }
}

