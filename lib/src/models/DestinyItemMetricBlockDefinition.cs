using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// The metrics available for display and selection on an item.
	[DataContract]
	public class DestinyItemMetricBlockDefinition{

		/// <summary>
		/// Hash identifiers for any DestinyPresentationNodeDefinition entry that can be used to list available metrics. Any metric listed directly below these nodes, or in any of these nodes' children will be made available for selection.
		/// </summary>
		[DataMember(Name="availableMetricCategoryNodeHashes", EmitDefaultValue=false)]
		public List<uint> AvailableMetricCategoryNodeHashes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemMetricBlockDefinition);
        }

		public bool Equals(DestinyItemMetricBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    AvailableMetricCategoryNodeHashes == input.AvailableMetricCategoryNodeHashes ||
                    (AvailableMetricCategoryNodeHashes != null && AvailableMetricCategoryNodeHashes.Equals(input.AvailableMetricCategoryNodeHashes))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.AvailableMetricCategoryNodeHashes.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

