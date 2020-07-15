using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The definition for information related to a key/value pair that is relevant for a particular Milestone or component within the Milestone. 
    /// </summary>
    /// <summary>
    /// This lets us more flexibly pass up information that's useful to someone, even if it's not necessarily us.
    /// </summary>
    [DataContract]
    public class DestinyMilestoneValueDefinition
    {
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneValueDefinition);
        }

        public bool Equals(DestinyMilestoneValueDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Key == input.Key ||
                    (Key != null && Key.Equals(input.Key))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) ;
        }
    }
}

