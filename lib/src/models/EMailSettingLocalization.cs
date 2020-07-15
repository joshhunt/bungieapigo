using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Localized text relevant to a given EMail setting in a given localization.
	[DataContract]
	public class EMailSettingLocalization{

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as EMailSettingLocalization);
        }

		public bool Equals(EMailSettingLocalization input)
		{
			if (input == null) return false;

			return
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Title.GetHashCode();
				hashCode = hashCode * 59 + this.Description.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

