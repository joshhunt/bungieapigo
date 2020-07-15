using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// If an item has a related gearset, this is the list of items in that set, and an unlock expression that evaluates to a number representing the progress toward gearset completion (a very rare use for unlock expressions!)
	/// </summary>
	[DataContract]
	public class DestinyItemGearsetBlockDefinition{

		/// <summary>
		/// The maximum possible number of items that can be collected.
		/// </summary>
		[DataMember(Name="trackingValueMax", EmitDefaultValue=false)]
		public long TrackingValueMax { get; set; }

		/// <summary>
		/// The list of hashes for items in the gearset. Use them to look up DestinyInventoryItemDefinition entries for the items in the set.
		/// </summary>
		[DataMember(Name="itemList", EmitDefaultValue=false)]
		public List<uint> ItemList { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemGearsetBlockDefinition);
        }

		public bool Equals(DestinyItemGearsetBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    TrackingValueMax == input.TrackingValueMax ||
                    (TrackingValueMax != null && TrackingValueMax.Equals(input.TrackingValueMax))
                ) &&
				(
                    ItemList == input.ItemList ||
                    (ItemList != null && ItemList.Equals(input.ItemList))
                ) ;
		}
	}
}

