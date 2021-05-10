using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyStringVariablesComponent
    {
        [DataMember(Name = "integerValuesByHash", EmitDefaultValue = false)]
        public Dictionary<string, long> IntegerValuesByHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyStringVariablesComponent);
        }

        public bool Equals(DestinyStringVariablesComponent input)
        {
            if (input == null) return false;

            return
                (
                    IntegerValuesByHash == input.IntegerValuesByHash ||
                    (IntegerValuesByHash != null && IntegerValuesByHash.SequenceEqual(input.IntegerValuesByHash))
                ) ;
        }
    }
}

