using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Represents a socket that has a plug associated with it intrinsically. This is useful for situations where the weapon needs to have a visual plug/Mod on it, but that plug/Mod should never change.
    /// </summary>
    [DataContract]
    public class DestinyItemIntrinsicSocketEntryDefinition
    {
        /// <summary>
        /// Indicates the plug that is intrinsically inserted into this socket.
        /// </summary>
        [DataMember(Name = "plugItemHash", EmitDefaultValue = false)]
        public uint PlugItemHash { get; set; }

        /// <summary>
        /// Indicates the type of this intrinsic socket.
        /// </summary>
        [DataMember(Name = "socketTypeHash", EmitDefaultValue = false)]
        public uint SocketTypeHash { get; set; }

        /// <summary>
        /// If true, then this socket is visible in the item's "default" state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you're looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
        /// </summary>
        [DataMember(Name = "defaultVisible", EmitDefaultValue = false)]
        public bool DefaultVisible { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemIntrinsicSocketEntryDefinition);
        }

        public bool Equals(DestinyItemIntrinsicSocketEntryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash != null && PlugItemHash.Equals(input.PlugItemHash))
                ) &&
                (
                    SocketTypeHash == input.SocketTypeHash ||
                    (SocketTypeHash != null && SocketTypeHash.Equals(input.SocketTypeHash))
                ) &&
                (
                    DefaultVisible == input.DefaultVisible ||
                    (DefaultVisible != null && DefaultVisible.Equals(input.DefaultVisible))
                ) ;
        }
    }
}

