using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// An individual Destiny Entity returned from the entity search.
    /// </summary>
    [DataContract]
    public class DestinyEntitySearchResultItem
    {
        /// <summary>
        /// The hash identifier of the entity. You will use this to look up the DestinyDefinition relevant for the entity found.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// The type of entity, returned as a string matching the DestinyDefinition's contract class name. You'll have to have your own mapping from class names to actually looking up those definitions in the manifest databases.
        /// </summary>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Basic display properties on the entity, so you don't have to look up the definition to show basic results for the item.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// The ranking value for sorting that we calculated using our relevance formula. This will hopefully get better with time and iteration.
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public double Weight { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEntitySearchResultItem);
        }

        public bool Equals(DestinyEntitySearchResultItem input)
        {
            if (input == null) return false;

            return
                (
                    Hash == input.Hash ||
                    (Hash.Equals(input.Hash))
                ) &&
                (
                    EntityType == input.EntityType ||
                    (EntityType != null && EntityType.Equals(input.EntityType))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    Weight == input.Weight ||
                    (Weight.Equals(input.Weight))
                ) ;
        }
    }
}

