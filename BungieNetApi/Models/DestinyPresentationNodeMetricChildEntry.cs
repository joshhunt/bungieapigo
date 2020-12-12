using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyPresentationNodeMetricChildEntry
    {
        [DataMember(Name = "metricHash", EmitDefaultValue = false)]
        public uint MetricHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeMetricChildEntry);
        }

        public bool Equals(DestinyPresentationNodeMetricChildEntry input)
        {
            if (input == null) return false;

            return
                (
                    MetricHash == input.MetricHash ||
                    (MetricHash.Equals(input.MetricHash))
                ) ;
        }
    }
}

