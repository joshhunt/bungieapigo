using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The details of an overlay prompt to show to a user. They are all fairly self-explanatory localized strings that can be shown.
	[DataContract]
	public class DestinyVendorCategoryOverlayDefinition{

		[DataMember(Name="choiceDescription", EmitDefaultValue=false)]
		public string ChoiceDescription { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		/// <summary>
		/// If this overlay has a currency item that it features, this is said featured item.
		/// </summary>
		[DataMember(Name="currencyItemHash", EmitDefaultValue=false)]
		public uint CurrencyItemHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorCategoryOverlayDefinition);
        }

		public bool Equals(DestinyVendorCategoryOverlayDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ChoiceDescription == input.ChoiceDescription ||
                    (ChoiceDescription != null && ChoiceDescription.Equals(input.ChoiceDescription))
                ) &&
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) &&
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    CurrencyItemHash == input.CurrencyItemHash ||
                    (CurrencyItemHash != null && CurrencyItemHash.Equals(input.CurrencyItemHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ChoiceDescription.GetHashCode();
				hashCode = hashCode * 59 + this.Description.GetHashCode();
				hashCode = hashCode * 59 + this.Icon.GetHashCode();
				hashCode = hashCode * 59 + this.Title.GetHashCode();
				hashCode = hashCode * 59 + this.CurrencyItemHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

