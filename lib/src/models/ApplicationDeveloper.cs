using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class ApplicationDeveloper{

		[DataMember(Name="role", EmitDefaultValue=false)]
		public DeveloperRole Role { get; set; }

		[DataMember(Name="apiEulaVersion", EmitDefaultValue=false)]
		public long ApiEulaVersion { get; set; }

		/// <summary>
		/// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
		/// </summary>
		[DataMember(Name="user", EmitDefaultValue=false)]
		public UserInfoCard User { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationDeveloper);
        }

		public bool Equals(ApplicationDeveloper input)
		{
			if (input == null) return false;

			return
				(
                    Role == input.Role ||
                    (Role != null && Role.Equals(input.Role))
                ) &&
				(
                    ApiEulaVersion == input.ApiEulaVersion ||
                    (ApiEulaVersion != null && ApiEulaVersion.Equals(input.ApiEulaVersion))
                ) &&
				(
                    User == input.User ||
                    (User != null && User.Equals(input.User))
                ) ;
		}
	}
}

