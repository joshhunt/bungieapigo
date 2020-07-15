using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// The definition information for a specific socket on an item. This will determine how the socket behaves in-game.
	/// </summary>
	[DataContract]
	public class DestinyItemSocketEntryDefinition{

		/// <summary>
		/// All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.
		/// </summary>
		[DataMember(Name="socketTypeHash", EmitDefaultValue=false)]
		public uint SocketTypeHash { get; set; }

		/// <summary>
		/// If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.
		/// </summary>
		[DataMember(Name="singleInitialItemHash", EmitDefaultValue=false)]
		public uint SingleInitialItemHash { get; set; }

		/// <summary>
		/// This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.
		/// </summary>
		/// <summary>
		/// If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs.
		/// </summary>
		[DataMember(Name="reusablePlugItems", EmitDefaultValue=false)]
		public List<DestinyItemSocketEntryPlugItemDefinition> ReusablePlugItems { get; set; }

		/// <summary>
		/// If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.
		/// </summary>
		/// <summary>
		/// Remember that Vendors are much more than conceptual vendors: they include "Collection Kiosks" and other entities. See DestinyVendorDefinition for more information.
		/// </summary>
		[DataMember(Name="preventInitializationOnVendorPurchase", EmitDefaultValue=false)]
		public bool PreventInitializationOnVendorPurchase { get; set; }

		/// <summary>
		/// If this is true, the perks provided by this socket shouldn't be shown in the item's tooltip. This might be useful if it's providing a hidden bonus, or if the bonus is less important than other benefits on the item.
		/// </summary>
		[DataMember(Name="hidePerksInItemTooltip", EmitDefaultValue=false)]
		public bool HidePerksInItemTooltip { get; set; }

		/// <summary>
		/// Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It's an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from.
		/// </summary>
		[DataMember(Name="plugSources", EmitDefaultValue=false)]
		public SocketPlugSources PlugSources { get; set; }

		/// <summary>
		/// If this socket's plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that's going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).
		/// </summary>
		/// <summary>
		///  As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation.
		/// </summary>
		[DataMember(Name="reusablePlugSetHash", EmitDefaultValue=false)]
		public uint ReusablePlugSetHash { get; set; }

		/// <summary>
		/// This field replaces "randomizedPlugItems" as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.
		/// </summary>
		/// <summary>
		///  If null, the item has no randomized plugs.
		/// </summary>
		[DataMember(Name="randomizedPlugSetHash", EmitDefaultValue=false)]
		public uint RandomizedPlugSetHash { get; set; }

		/// <summary>
		/// If true, then this socket is visible in the item's "default" state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you're looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
		/// </summary>
		[DataMember(Name="defaultVisible", EmitDefaultValue=false)]
		public bool DefaultVisible { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketEntryDefinition);
        }

		public bool Equals(DestinyItemSocketEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    SocketTypeHash == input.SocketTypeHash ||
                    (SocketTypeHash != null && SocketTypeHash.Equals(input.SocketTypeHash))
                ) &&
				(
                    SingleInitialItemHash == input.SingleInitialItemHash ||
                    (SingleInitialItemHash != null && SingleInitialItemHash.Equals(input.SingleInitialItemHash))
                ) &&
				(
                    ReusablePlugItems == input.ReusablePlugItems ||
                    (ReusablePlugItems != null && ReusablePlugItems.Equals(input.ReusablePlugItems))
                ) &&
				(
                    PreventInitializationOnVendorPurchase == input.PreventInitializationOnVendorPurchase ||
                    (PreventInitializationOnVendorPurchase != null && PreventInitializationOnVendorPurchase.Equals(input.PreventInitializationOnVendorPurchase))
                ) &&
				(
                    HidePerksInItemTooltip == input.HidePerksInItemTooltip ||
                    (HidePerksInItemTooltip != null && HidePerksInItemTooltip.Equals(input.HidePerksInItemTooltip))
                ) &&
				(
                    PlugSources == input.PlugSources ||
                    (PlugSources != null && PlugSources.Equals(input.PlugSources))
                ) &&
				(
                    ReusablePlugSetHash == input.ReusablePlugSetHash ||
                    (ReusablePlugSetHash != null && ReusablePlugSetHash.Equals(input.ReusablePlugSetHash))
                ) &&
				(
                    RandomizedPlugSetHash == input.RandomizedPlugSetHash ||
                    (RandomizedPlugSetHash != null && RandomizedPlugSetHash.Equals(input.RandomizedPlugSetHash))
                ) &&
				(
                    DefaultVisible == input.DefaultVisible ||
                    (DefaultVisible != null && DefaultVisible.Equals(input.DefaultVisible))
                ) ;
		}
	}
}

