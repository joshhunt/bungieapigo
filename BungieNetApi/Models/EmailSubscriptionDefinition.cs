using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Defines a single subscription: permission to send emails for a specific, focused subject (generally timeboxed, such as for a specific release of a product or feature).
	/// </summary>
	[DataContract]
	public class EmailSubscriptionDefinition{

		/// <summary>
		/// The unique identifier for this subscription.
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.
		/// </summary>
		[DataMember(Name="localization", EmitDefaultValue=false)]
		public Dictionary<string, EMailSettingSubscriptionLocalization> Localization { get; set; }

		/// <summary>
		/// The bitflag value for this subscription. Should be a unique power of two value.
		/// </summary>
		[DataMember(Name="value", EmitDefaultValue=false)]
		public long Value { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as EmailSubscriptionDefinition);
        }

		public bool Equals(EmailSubscriptionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Localization == input.Localization ||
                    (Localization != null && Localization.Equals(input.Localization))
                ) &&
				(
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) ;
		}
	}
}

