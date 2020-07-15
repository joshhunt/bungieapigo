using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyBaseItemComponentSetOfint32{

		[DataMember(Name="objectives", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Objectives { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyBaseItemComponentSetOfint32);
        }

		public bool Equals(DestinyBaseItemComponentSetOfint32 input)
		{
			if (input == null) return false;

			return
				(
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.Equals(input.Objectives))
                ) ;
		}
	}
}

