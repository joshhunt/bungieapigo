using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyBaseItemComponentSetOfint64
    {
        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyBaseItemComponentSetOfint64);
        }

        public bool Equals(DestinyBaseItemComponentSetOfint64 input)
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

