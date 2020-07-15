using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// If this record has an expiration after which it cannot be earned, this is some information about that expiration.
	[DataContract]
	public class DestinyRecordExpirationBlock{

		[DataMember(Name="hasExpiration", EmitDefaultValue=false)]
		public bool HasExpiration { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordExpirationBlock);
        }

		public bool Equals(DestinyRecordExpirationBlock input)
		{
			if (input == null) return false;

			return
				(
                    HasExpiration == input.HasExpiration ||
                    (HasExpiration != null && HasExpiration.Equals(input.HasExpiration))
                ) &&
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.HasExpiration.GetHashCode();
				hashCode = hashCode * 59 + this.Description.GetHashCode();
				hashCode = hashCode * 59 + this.Icon.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

