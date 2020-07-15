using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class EmailViewDefinitionSetting{

		/// <summary>
		/// The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// A dictionary of localized text for the EMail setting, keyed by the locale.
		/// </summary>
		[DataMember(Name="localization", EmitDefaultValue=false)]
		public Map<String, EMailSettingLocalization> Localization { get; set; }

		/// <summary>
		/// If true, this setting should be set by default if the user hasn't chosen whether it's set or cleared yet.
		/// </summary>
		[DataMember(Name="setByDefault", EmitDefaultValue=false)]
		public bool SetByDefault { get; set; }

		/// <summary>
		/// The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.
		/// </summary>
		[DataMember(Name="optInAggregateValue", EmitDefaultValue=false)]
		public OptInFlags OptInAggregateValue { get; set; }

		/// <summary>
		/// The subscriptions to show as children of this setting, if any.
		/// </summary>
		[DataMember(Name="subscriptions", EmitDefaultValue=false)]
		public List<EmailSubscriptionDefinition> Subscriptions { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as EmailViewDefinitionSetting);
        }

		public bool Equals(EmailViewDefinitionSetting input)
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
                    SetByDefault == input.SetByDefault ||
                    (SetByDefault != null && SetByDefault.Equals(input.SetByDefault))
                ) &&
				(
                    OptInAggregateValue == input.OptInAggregateValue ||
                    (OptInAggregateValue != null && OptInAggregateValue.Equals(input.OptInAggregateValue))
                ) &&
				(
                    Subscriptions == input.Subscriptions ||
                    (Subscriptions != null && Subscriptions.Equals(input.Subscriptions))
                ) ;
		}
	}
}

