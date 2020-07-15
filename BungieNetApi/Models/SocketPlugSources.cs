using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Indicates how a socket is populated, and where you should look for valid plug data.
    /// </summary>
    /// <summary>
    ///  This is a flags enumeration/bitmask field, as you may have to look in multiple sources across multiple components for valid plugs.
    /// </summary>
    /// <summary>
    ///  For instance, a socket could have plugs that are sourced from its own definition, as well as plugs that are sourced from Character-scoped AND profile-scoped Plug Sets. Only by combining plug data for every indicated source will you be able to know all of the plugs available for a socket.
    /// </summary>
    [Flags]
    public enum SocketPlugSources
    {
        /// <summary>
        /// None = 0
        /// If there&#39;s no way we can detect to insert new plugs.
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// InventorySourced = 1
        /// Use plugs found in the player&#39;s inventory, based on the socket type rules (see DestinySocketTypeDefinition for more info)
        /// Note that a socket - like Shaders - can have *both* reusable plugs and inventory items inserted theoretically.
        /// </summary>
        [EnumMember(Value = "1")]
        InventorySourced = 1,

        /// <summary>
        /// ReusablePlugItems = 2
        /// Use the DestinyItemSocketsComponent.sockets.reusablePlugs property to determine which plugs are valid for this socket. This may have to be combined with other sources, such as plug sets, if those flags are set.
        ///  Note that &quot;Reusable&quot; plugs may not necessarily come from a plug set, nor from the &quot;reusablePlugItems&quot; in the socket&#39;s Definition data. They can sometimes be &quot;randomized&quot; in which case the only source of truth at the moment is still the runtime DestinyItemSocketsComponent.sockets.reusablePlugs property.
        /// </summary>
        [EnumMember(Value = "2")]
        ReusablePlugItems = 2,

        /// <summary>
        /// ProfilePlugSet = 4
        /// Use the ProfilePlugSets (DestinyProfileResponse.profilePlugSets) component data to determine which plugs are valid for this socket.
        /// </summary>
        [EnumMember(Value = "4")]
        ProfilePlugSet = 4,

        /// <summary>
        /// CharacterPlugSet = 8
        /// Use the CharacterPlugSets (DestinyProfileResponse.characterPlugSets) component data to determine which plugs are valid for this socket.
        /// </summary>
        [EnumMember(Value = "8")]
        CharacterPlugSet = 8,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}