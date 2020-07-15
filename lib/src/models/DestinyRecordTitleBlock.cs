using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyRecordTitleBlock{

		[DataMember(Name="hasTitle", EmitDefaultValue=false)]
		public bool HasTitle { get; set; }

		[DataMember(Name="titlesByGender", EmitDefaultValue=false)]
		public Map<String, string> TitlesByGender { get; set; }

		/// <summary>
		/// For those who prefer to use the definitions.
		/// </summary>
		[DataMember(Name="titlesByGenderHash", EmitDefaultValue=false)]
		public Map<String, string> TitlesByGenderHash { get; set; }


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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.HasTitle.GetHashCode();
				hashCode = hashCode * 59 + this.TitlesByGender.GetHashCode();
				hashCode = hashCode * 59 + this.TitlesByGenderHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

