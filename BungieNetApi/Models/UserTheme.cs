using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class UserTheme
    {
        [DataMember(Name = "userThemeId", EmitDefaultValue = false)]
        public long UserThemeId { get; set; }

        [DataMember(Name = "userThemeName", EmitDefaultValue = false)]
        public string UserThemeName { get; set; }

        [DataMember(Name = "userThemeDescription", EmitDefaultValue = false)]
        public string UserThemeDescription { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as UserTheme);
        }

        public bool Equals(UserTheme input)
        {
            if (input == null) return false;

            return
                (
                    UserThemeId == input.UserThemeId ||
                    (UserThemeId != null && UserThemeId.Equals(input.UserThemeId))
                ) &&
                (
                    UserThemeName == input.UserThemeName ||
                    (UserThemeName != null && UserThemeName.Equals(input.UserThemeName))
                ) &&
                (
                    UserThemeDescription == input.UserThemeDescription ||
                    (UserThemeDescription != null && UserThemeDescription.Equals(input.UserThemeDescription))
                ) ;
        }
    }
}

