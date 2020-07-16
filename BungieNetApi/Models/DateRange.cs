using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [DataContract]
    public class DateRange
    {
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public DateTime Start { get; set; }

        [DataMember(Name = "end", EmitDefaultValue = false)]
        public DateTime End { get; set; }


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

