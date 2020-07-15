using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Defines a single opt-in category: a wide-scoped permission to send emails for the subject related to the opt-in.
	/// </summary>
	[DataContract]
	public class EmailOptInDefinition{

		/// <summary>
		/// The unique identifier for this opt-in category.
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.
		/// </summary>
		[DataMember(Name="value", EmitDefaultValue=false)]
		public OptInFlags Value { get; set; }

		/// <summary>
		/// If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they're opting into.
		/// </summary>
		[DataMember(Name="setByDefault", EmitDefaultValue=false)]
		public bool SetByDefault { get; set; }

		/// <summary>
		/// Information about the dependent subscriptions for this opt-in.
		/// </summary>
		[DataMember(Name="dependentSubscriptions", EmitDefaultValue=false)]
		public List<EmailSubscriptionDefinition> DependentSubscriptions { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as EmailOptInDefinition);
        }

		public bool Equals(EmailOptInDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) &&
				(
                    SetByDefault == input.SetByDefault ||
                    (SetByDefault != null && SetByDefault.Equals(input.SetByDefault))
                ) &&
				(
                    DependentSubscriptions == input.DependentSubscriptions ||
                    (DependentSubscriptions != null && DependentSubscriptions.Equals(input.DependentSubscriptions))
                ) ;
		}
	}
}

