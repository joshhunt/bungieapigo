using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// A Kiosk is a Vendor (DestinyVendorDefinition) that sells items based on whether you have already acquired that item before.
	/// </summary>
	/// <summary>
	/// This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the individual character's DestinyCharacterKiosksComponent.
	/// </summary>
	/// <summary>
	/// Note that, because this component returns vendorItemIndexes (that is to say, indexes into the Kiosk Vendor's itemList property), these results are necessarily content version dependent. Make sure that you have the latest version of the content manifest databases before using this data.
	/// </summary>
	[DataContract]
	public class DestinyKiosksComponent{

		/// <summary>
		/// A dictionary keyed by the Kiosk Vendor's hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can "see" in the Kiosk, and any other interesting metadata.
		/// </summary>
		[DataMember(Name="kioskItems", EmitDefaultValue=false)]
		public Map<String, List<DestinyKioskItem>> KioskItems { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyKiosksComponent);
        }

		public bool Equals(DestinyKiosksComponent input)
		{
			if (input == null) return false;

			return
				(
                    KioskItems == input.KioskItems ||
                    (KioskItems != null && KioskItems.Equals(input.KioskItems))
                ) ;
		}
	}
}

