using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Some items are &quot;sacks&quot; - they can be &quot;opened&quot; to produce other items. This is information related to its sack status, mostly UI strings. Engrams are an example of items that are considered to be &quot;Sacks&quot;.
	[DataContract]
	public class DestinyItemSackBlockDefinition{

		/// <summary>
		/// A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.
		/// </summary>
		[DataMember(Name="detailAction", EmitDefaultValue=false)]
		public string DetailAction { get; set; }

		/// <summary>
		/// The localized name of the action being performed when you open the sack.
		/// </summary>
		[DataMember(Name="openAction", EmitDefaultValue=false)]
		public string OpenAction { get; set; }

		[DataMember(Name="selectItemCount", EmitDefaultValue=false)]
		public long SelectItemCount { get; set; }

		[DataMember(Name="vendorSackType", EmitDefaultValue=false)]
		public string VendorSackType { get; set; }

		[DataMember(Name="openOnAcquire", EmitDefaultValue=false)]
		public bool OpenOnAcquire { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSackBlockDefinition);
        }

		public bool Equals(DestinyItemSackBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DetailAction == input.DetailAction ||
                    (DetailAction != null && DetailAction.Equals(input.DetailAction))
                ) &&
				(
                    OpenAction == input.OpenAction ||
                    (OpenAction != null && OpenAction.Equals(input.OpenAction))
                ) &&
				(
                    SelectItemCount == input.SelectItemCount ||
                    (SelectItemCount != null && SelectItemCount.Equals(input.SelectItemCount))
                ) &&
				(
                    VendorSackType == input.VendorSackType ||
                    (VendorSackType != null && VendorSackType.Equals(input.VendorSackType))
                ) &&
				(
                    OpenOnAcquire == input.OpenOnAcquire ||
                    (OpenOnAcquire != null && OpenOnAcquire.Equals(input.OpenOnAcquire))
                ) ;
		}
	}
}

