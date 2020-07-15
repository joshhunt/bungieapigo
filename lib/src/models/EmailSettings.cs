using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The set of all email subscription&#x2F;opt-in settings and definitions.
	[DataContract]
	public class EmailSettings{

		/// <summary>
		/// Keyed by the name identifier of the opt-in definition.
		/// </summary>
		[DataMember(Name="optInDefinitions", EmitDefaultValue=false)]
		public Map<String, EmailOptInDefinition> OptInDefinitions { get; set; }

		/// <summary>
		/// Keyed by the name identifier of the Subscription definition.
		/// </summary>
		[DataMember(Name="subscriptionDefinitions", EmitDefaultValue=false)]
		public Map<String, EmailSubscriptionDefinition> SubscriptionDefinitions { get; set; }

		/// <summary>
		/// Keyed by the name identifier of the View definition.
		/// </summary>
		[DataMember(Name="views", EmitDefaultValue=false)]
		public Map<String, EmailViewDefinition> Views { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as EmailSettings);
        }

		public bool Equals(EmailSettings input)
		{
			if (input == null) return false;

			return
				(
                    OptInDefinitions == input.OptInDefinitions ||
                    (OptInDefinitions != null && OptInDefinitions.Equals(input.OptInDefinitions))
                ) &&
				(
                    SubscriptionDefinitions == input.SubscriptionDefinitions ||
                    (SubscriptionDefinitions != null && SubscriptionDefinitions.Equals(input.SubscriptionDefinitions))
                ) &&
				(
                    Views == input.Views ||
                    (Views != null && Views.Equals(input.Views))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.OptInDefinitions.GetHashCode();
				hashCode = hashCode * 59 + this.SubscriptionDefinitions.GetHashCode();
				hashCode = hashCode * 59 + this.Views.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

