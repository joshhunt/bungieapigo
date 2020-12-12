using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Defines a plug "Category" that is allowed to be plugged into a socket of this type.
    /// </summary>
    /// <summary>
    /// This should be compared against a given plug item's DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item's category.
    /// </summary>
    [DataContract]
    public class DestinyPlugWhitelistEntryDefinition
    {
        /// <summary>
        /// The hash identifier of the Plug Category to compare against the plug item's plug.plugCategoryHash.
        /// </summary>
        /// <summary>
        /// Note that this does NOT relate to any Definition in itself, it is only used for comparison purposes.
        /// </summary>
        [DataMember(Name = "categoryHash", EmitDefaultValue = false)]
        public uint CategoryHash { get; set; }

        /// <summary>
        /// The string identifier for the category, which is here mostly for debug purposes.
        /// </summary>
        [DataMember(Name = "categoryIdentifier", EmitDefaultValue = false)]
        public string CategoryIdentifier { get; set; }

        /// <summary>
        /// The list of all plug items (DestinyInventoryItemDefinition) that the socket may randomly be populated with when reinitialized.
        /// </summary>
        /// <summary>
        /// Which ones you should actually show are determined by the plug being inserted into the socket, and the socket’s type.
        /// </summary>
        /// <summary>
        /// When you inspect the plug that could go into a Masterwork Socket, look up the socket type of the socket being inspected and find the DestinySocketTypeDefinition.
        /// </summary>
        /// <summary>
        /// Then, look at the Plugs that can fit in that socket. Find the Whitelist in the DestinySocketTypeDefinition that matches the plug item’s categoryhash.
        /// </summary>
        /// <summary>
        /// That whitelist entry will potentially have a new “reinitializationPossiblePlugHashes” property.If it does, that means we know what it will roll if you try to insert this plug into this socket.
        /// </summary>
        [DataMember(Name = "reinitializationPossiblePlugHashes", EmitDefaultValue = false)]
        public List<uint> ReinitializationPossiblePlugHashes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPlugWhitelistEntryDefinition);
        }

        public bool Equals(DestinyPlugWhitelistEntryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    CategoryHash == input.CategoryHash ||
                    (CategoryHash.Equals(input.CategoryHash))
                ) &&
                (
                    CategoryIdentifier == input.CategoryIdentifier ||
                    (CategoryIdentifier != null && CategoryIdentifier.Equals(input.CategoryIdentifier))
                ) &&
                (
                    ReinitializationPossiblePlugHashes == input.ReinitializationPossiblePlugHashes ||
                    (ReinitializationPossiblePlugHashes != null && ReinitializationPossiblePlugHashes.SequenceEqual(input.ReinitializationPossiblePlugHashes))
                ) ;
        }
    }
}

