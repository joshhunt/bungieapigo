using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DateRange
    {
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public string Start { get; set; }

        [DataMember(Name = "end", EmitDefaultValue = false)]
        public string End { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DateRange);
        }

        public bool Equals(DateRange input)
        {
            if (input == null) return false;

            return
                (
                    Start == input.Start ||
                    (Start != null && Start.Equals(input.Start))
                ) &&
                (
                    End == input.End ||
                    (End != null && End.Equals(input.End))
                ) ;
        }
    }
}

