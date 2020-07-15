using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Dictates a rule around whether the plug is enabled or insertable.
	/// In practice, the live Destiny data will refer to these entries by index. You can then look up that index in the appropriate property (enabledRules or insertionRules) to get the localized string for the failure message if it failed.
	[DataContract]
	public class DestinyPlugRuleDefinition{

		/// <summary>
		/// The localized string to show if this rule fails.
		/// </summary>
		[DataMember(Name="failureMessage", EmitDefaultValue=false)]
		public string FailureMessage { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPlugRuleDefinition);
        }

		public bool Equals(DestinyPlugRuleDefinition input)
		{
			if (input == null) return false;

			return
				(
                    FailureMessage == input.FailureMessage ||
                    (FailureMessage != null && FailureMessage.Equals(input.FailureMessage))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.FailureMessage.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

