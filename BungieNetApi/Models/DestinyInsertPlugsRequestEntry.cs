using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents all of the data related to a single plug to be inserted.
    /// </summary>
    /// <summary>
    /// Note that, while you *can* point to a socket that represents infusion, you will receive an error if you attempt to do so. Come on guys, let's play nice.
    /// </summary>
    [DataContract]
    public class DestinyInsertPlugsRequestEntry
    {
        /// <summary>
        /// The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.
        /// </summary>
        /// <summary>
        /// Don't point to or try to insert a plug into an infusion socket. It won't work.
        /// </summary>
        [DataMember(Name = "socketIndex", EmitDefaultValue = false)]
        public long SocketIndex { get; set; }

        /// <summary>
        /// This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and "default" sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don't give me that look.
        /// </summary>
        [DataMember(Name = "socketArrayType", EmitDefaultValue = false)]
        public DestinySocketArrayType SocketArrayType { get; set; }

        /// <summary>
        /// Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it's a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets.
        /// </summary>
        [DataMember(Name = "plugItemHash", EmitDefaultValue = false)]
        public uint PlugItemHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyInsertPlugsRequestEntry);
        }

        public bool Equals(DestinyInsertPlugsRequestEntry input)
        {
            if (input == null) return false;

            return
                (
                    SocketIndex == input.SocketIndex ||
                    (SocketIndex != null && SocketIndex.Equals(input.SocketIndex))
                ) &&
                (
                    SocketArrayType == input.SocketArrayType ||
                    (SocketArrayType != null && SocketArrayType.Equals(input.SocketArrayType))
                ) &&
                (
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash != null && PlugItemHash.Equals(input.PlugItemHash))
                ) ;
        }
    }
}

