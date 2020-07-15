using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyRecordTitleBlock{

		[DataMember(Name="hasTitle", EmitDefaultValue=false)]
		public bool HasTitle { get; set; }

		[DataMember(Name="titlesByGender", EmitDefaultValue=false)]
		public Dictionary<string, string> TitlesByGender { get; set; }

		/// <summary>
		/// For those who prefer to use the definitions.
		/// </summary>
		[DataMember(Name="titlesByGenderHash", EmitDefaultValue=false)]
		public Dictionary<string, string> TitlesByGenderHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordTitleBlock);
        }

		public bool Equals(DestinyRecordTitleBlock input)
		{
			if (input == null) return false;

			return
				(
                    HasTitle == input.HasTitle ||
                    (HasTitle != null && HasTitle.Equals(input.HasTitle))
                ) &&
				(
                    TitlesByGender == input.TitlesByGender ||
                    (TitlesByGender != null && TitlesByGender.Equals(input.TitlesByGender))
                ) &&
				(
                    TitlesByGenderHash == input.TitlesByGenderHash ||
                    (TitlesByGenderHash != null && TitlesByGenderHash.Equals(input.TitlesByGenderHash))
                ) ;
		}
	}
}

