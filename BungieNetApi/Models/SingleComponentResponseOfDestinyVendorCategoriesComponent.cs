using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class SingleComponentResponseOfDestinyVendorCategoriesComponent{

		/// <summary>
		/// A vendor can have many categories of items that they sell. This component will return the category information for available items, as well as the index into those items in the user's sale item list.
		/// </summary>
		/// <summary>
		/// Note that, since both the category and items are indexes, this data is Content Version dependent. Be sure to check that your content is up to date before using this data. This is an unfortunate, but permanent, limitation of Vendor data.
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DestinyVendorCategoriesComponent Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyVendorCategoriesComponent);
        }

		public bool Equals(SingleComponentResponseOfDestinyVendorCategoriesComponent input)
		{
			if (input == null) return false;

			return
				(
                    Data == input.Data ||
                    (Data != null && Data.Equals(input.Data))
                ) &&
				(
                    Privacy == input.Privacy ||
                    (Privacy != null && Privacy.Equals(input.Privacy))
                ) &&
				(
                    Disabled == input.Disabled ||
                    (Disabled != null && Disabled.Equals(input.Disabled))
                ) ;
		}
	}
}

