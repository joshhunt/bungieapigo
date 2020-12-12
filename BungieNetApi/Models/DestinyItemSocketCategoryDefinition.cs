using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Sockets are grouped into categories in the UI. These define which category and which sockets are under that category.
    /// </summary>
    [DataContract]
    public class DestinyItemSocketCategoryDefinition
    {
        /// <summary>
        /// The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.
        /// </summary>
        [DataMember(Name = "socketCategoryHash", EmitDefaultValue = false)]
        public uint SocketCategoryHash { get; set; }

        /// <summary>
        /// Use these indexes to look up the sockets in the "sockets.socketEntries" property on the item definition. These are the indexes under the category, in game-rendered order.
        /// </summary>
        [DataMember(Name = "socketIndexes", EmitDefaultValue = false)]
        public List<long> SocketIndexes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketCategoryDefinition);
        }

        public bool Equals(DestinyItemSocketCategoryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    SocketCategoryHash == input.SocketCategoryHash ||
                    (SocketCategoryHash.Equals(input.SocketCategoryHash))
                ) &&
                (
                    SocketIndexes == input.SocketIndexes ||
                    (SocketIndexes != null && SocketIndexes.SequenceEqual(input.SocketIndexes))
                ) ;
        }
    }
}

