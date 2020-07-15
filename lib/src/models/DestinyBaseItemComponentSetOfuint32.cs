using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyBaseItemComponentSetOfuint32{

		[DataMember(Name="objectives", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyBaseItemComponentSetOfuint32);
        }

		public bool Equals(DestinyBaseItemComponentSetOfuint32 input)
		{
			if (input == null) return false;

			return
				(
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.Equals(input.Objectives))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Objectives.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

