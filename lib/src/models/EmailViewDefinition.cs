using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Represents a data-driven view for Email settings. Web&#x2F;Mobile UI can use this data to show new EMail settings consistently without further manual work.
	[DataContract]
	public class EmailViewDefinition{

		/// <summary>
		/// The identifier for this view.
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// The ordered list of settings to show in this view.
		/// </summary>
		[DataMember(Name="viewSettings", EmitDefaultValue=false)]
		public List<EmailViewDefinitionSetting> ViewSettings { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as EmailViewDefinition);
        }

		public bool Equals(EmailViewDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    ViewSettings == input.ViewSettings ||
                    (ViewSettings != null && ViewSettings.Equals(input.ViewSettings))
                ) ;
		}
	}
}

