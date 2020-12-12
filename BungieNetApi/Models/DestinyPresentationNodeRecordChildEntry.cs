using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyPresentationNodeRecordChildEntry
    {
        [DataMember(Name = "recordHash", EmitDefaultValue = false)]
        public uint RecordHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeRecordChildEntry);
        }

        public bool Equals(DestinyPresentationNodeRecordChildEntry input)
        {
            if (input == null) return false;

            return
                (
                    RecordHash == input.RecordHash ||
                    (RecordHash.Equals(input.RecordHash))
                ) ;
        }
    }
}

