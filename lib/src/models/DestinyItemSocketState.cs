using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// The status of a given item's socket. (which plug is inserted, if any: whether it is enabled, what "reusable" plugs can be inserted, etc...)
	/// </summary>
	/// <summary>
	/// If I had it to do over, this would probably have a DestinyItemPlug representing the inserted item instead of most of these properties. :shrug:
	/// </summary>
	[DataContract]
	public class DestinyItemSocketState{

		/// <summary>
		/// The currently active plug, if any.
		/// </summary>
		/// <summary>
		/// Note that, because all plugs are statically defined, its effect on stats and perks can be statically determined using the plug item's definition. The stats and perks can be taken at face value on the plug item as the stats and perks it will provide to the user/item.
		/// </summary>
		[DataMember(Name="plugHash", EmitDefaultValue=false)]
		public uint PlugHash { get; set; }

		/// <summary>
		/// Even if a plug is inserted, it doesn't mean it's enabled.
		/// </summary>
		/// <summary>
		/// This flag indicates whether the plug is active and providing its benefits.
		/// </summary>
		[DataMember(Name="isEnabled", EmitDefaultValue=false)]
		public bool IsEnabled { get; set; }

		/// <summary>
		/// A plug may theoretically provide benefits but not be visible - for instance, some older items use a plug's damage type perk to modify their own damage type. These, though they are not visible, still affect the item. This field indicates that state.
		/// </summary>
		/// <summary>
		/// An invisible plug, while it provides benefits if it is Enabled, cannot be directly modified by the user.
		/// </summary>
		[DataMember(Name="isVisible", EmitDefaultValue=false)]
		public bool IsVisible { get; set; }

		/// <summary>
		/// If a plug is inserted but not enabled, this will be populated with indexes into the plug item definition's plug.enabledRules property, so that you can show the reasons why it is not enabled.
		/// </summary>
		[DataMember(Name="enableFailIndexes", EmitDefaultValue=false)]
		public List<long> EnableFailIndexes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketState);
        }

		public bool Equals(DestinyItemSocketState input)
		{
			if (input == null) return false;

			return
				(
                    PlugHash == input.PlugHash ||
                    (PlugHash != null && PlugHash.Equals(input.PlugHash))
                ) &&
				(
                    IsEnabled == input.IsEnabled ||
                    (IsEnabled != null && IsEnabled.Equals(input.IsEnabled))
                ) &&
				(
                    IsVisible == input.IsVisible ||
                    (IsVisible != null && IsVisible.Equals(input.IsVisible))
                ) &&
				(
                    EnableFailIndexes == input.EnableFailIndexes ||
                    (EnableFailIndexes != null && EnableFailIndexes.Equals(input.EnableFailIndexes))
                ) ;
		}
	}
}

