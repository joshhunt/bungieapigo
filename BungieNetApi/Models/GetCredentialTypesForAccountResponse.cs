using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class GetCredentialTypesForAccountResponse
    {
        [DataMember(Name = "credentialType", EmitDefaultValue = false)]
        public BungieCredentialType CredentialType { get; set; }

        [DataMember(Name = "credentialDisplayName", EmitDefaultValue = false)]
        public string CredentialDisplayName { get; set; }

        [DataMember(Name = "isPublic", EmitDefaultValue = false)]
        public bool IsPublic { get; set; }

        [DataMember(Name = "credentialAsString", EmitDefaultValue = false)]
        public string CredentialAsString { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GetCredentialTypesForAccountResponse);
        }

        public bool Equals(GetCredentialTypesForAccountResponse input)
        {
            if (input == null) return false;

            return
                (
                    CredentialType == input.CredentialType ||
                    (CredentialType != null && CredentialType.Equals(input.CredentialType))
                ) &&
                (
                    CredentialDisplayName == input.CredentialDisplayName ||
                    (CredentialDisplayName != null && CredentialDisplayName.Equals(input.CredentialDisplayName))
                ) &&
                (
                    IsPublic == input.IsPublic ||
                    (IsPublic != null && IsPublic.Equals(input.IsPublic))
                ) &&
                (
                    CredentialAsString == input.CredentialAsString ||
                    (CredentialAsString != null && CredentialAsString.Equals(input.CredentialAsString))
                ) ;
        }
    }
}

