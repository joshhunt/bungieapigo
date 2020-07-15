using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
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
                    (Metrics != null && Metrics.Equals(input.Metrics))
                ) &&
                (
                    MetricsRootNodeHash == input.MetricsRootNodeHash ||
                    (MetricsRootNodeHash != null && MetricsRootNodeHash.Equals(input.MetricsRootNodeHash))
                ) ;
        }
    }
}

