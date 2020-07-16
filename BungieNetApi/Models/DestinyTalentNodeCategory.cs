using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// An artificial construct provided by Bungie.Net, where we attempt to group talent nodes by functionality.
    /// </summary>
    /// <summary>
    /// This is a single set of references to Talent Nodes that share a common trait or purpose.
    /// </summary>
    [DataContract]
    public class DestinyTalentNodeCategory
    {
        /// <summary>
        /// Mostly just for debug purposes, but if you find it useful you can have it. This is BNet's manually created identifier for this category.
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// If true, we found the localized content in a related DestinyLoreDefinition instead of local BNet localization files. This is mostly for ease of my own future investigations.
        /// </summary>
        [DataMember(Name = "isLoreDriven", EmitDefaultValue = false)]
        public bool IsLoreDriven { get; set; }

        /// <summary>
        /// Will contain at least the "name", which will be the title of the category. We will likely not have description and an icon yet, but I'm going to keep my options open.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// The set of all hash identifiers for Talent Nodes (DestinyTalentNodeDefinition) in this Talent Grid that are part of this Category.
        /// </summary>
        [DataMember(Name = "nodeHashes", EmitDefaultValue = false)]
        public List<uint> NodeHashes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyTalentNodeCategory);
        }

        public bool Equals(DestinyTalentNodeCategory input)
        {
            if (input == null) return false;

            return
                (
                    Identifier == input.Identifier ||
                    (Identifier != null && Identifier.Equals(input.Identifier))
                ) &&
                (
                    IsLoreDriven == input.IsLoreDriven ||
                    (IsLoreDriven != null && IsLoreDriven.Equals(input.IsLoreDriven))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    NodeHashes == input.NodeHashes ||
                    (NodeHashes != null && NodeHashes.Equals(input.NodeHashes))
                ) ;
        }
    }
}

