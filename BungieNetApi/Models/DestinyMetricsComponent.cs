using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyMetricsComponent
    {
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public Dictionary<string, DestinyMetricComponent> Metrics { get; set; }

        [DataMember(Name = "metricsRootNodeHash", EmitDefaultValue = false)]
        public uint MetricsRootNodeHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMetricsComponent);
        }

        public bool Equals(DestinyMetricsComponent input)
        {
            if (input == null) return false;

            return
                (
                    Metrics == input.Metrics ||
                    (Metrics != null && Metrics.SequenceEqual(input.Metrics))
                ) &&
                (
                    MetricsRootNodeHash == input.MetricsRootNodeHash ||
                    (MetricsRootNodeHash.Equals(input.MetricsRootNodeHash))
                ) ;
        }
    }
}

