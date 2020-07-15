using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Localized text relevant to a given EMail setting in a given localization. Extra settings specifically for subscriptions.
	/// </summary>
	[DataContract]
	public class EMailSettingSubscriptionLocalization{

		[DataMember(Name="unknownUserDescription", EmitDefaultValue=false)]
		public string UnknownUserDescription { get; set; }

		[DataMember(Name="registeredUserDescription", EmitDefaultValue=false)]
		public string RegisteredUserDescription { get; set; }

		[DataMember(Name="unregisteredUserDescription", EmitDefaultValue=false)]
		public string UnregisteredUserDescription { get; set; }

		[DataMember(Name="unknownUserActionText", EmitDefaultValue=false)]
		public string UnknownUserActionText { get; set; }

		[DataMember(Name="knownUserActionText", EmitDefaultValue=false)]
		public string KnownUserActionText { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as EMailSettingSubscriptionLocalization);
        }

		public bool Equals(EMailSettingSubscriptionLocalization input)
		{
			if (input == null) return false;

			return
				(
                    UnknownUserDescription == input.UnknownUserDescription ||
                    (UnknownUserDescription != null && UnknownUserDescription.Equals(input.UnknownUserDescription))
                ) &&
				(
                    RegisteredUserDescription == input.RegisteredUserDescription ||
                    (RegisteredUserDescription != null && RegisteredUserDescription.Equals(input.RegisteredUserDescription))
                ) &&
				(
                    UnregisteredUserDescription == input.UnregisteredUserDescription ||
                    (UnregisteredUserDescription != null && UnregisteredUserDescription.Equals(input.UnregisteredUserDescription))
                ) &&
				(
                    UnknownUserActionText == input.UnknownUserActionText ||
                    (UnknownUserActionText != null && UnknownUserActionText.Equals(input.UnknownUserActionText))
                ) &&
				(
                    KnownUserActionText == input.KnownUserActionText ||
                    (KnownUserActionText != null && KnownUserActionText.Equals(input.KnownUserActionText))
                ) &&
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) ;
		}
	}
}

