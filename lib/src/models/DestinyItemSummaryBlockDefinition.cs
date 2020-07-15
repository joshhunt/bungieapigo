using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// This appears to be information used when rendering rewards. We don&#39;t currently use it on BNet.
	[DataContract]
	public class DestinyItemSummaryBlockDefinition{

		/// <summary>
		/// Apparently when rendering an item in a reward, this should be used as a sort priority. We're not doing it presently.
		/// </summary>
		[DataMember(Name="sortPriority", EmitDefaultValue=false)]
		public long SortPriority { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSummaryBlockDefinition);
        }

		public bool Equals(DestinyItemSummaryBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    SortPriority == input.SortPriority ||
                    (SortPriority != null && SortPriority.Equals(input.SortPriority))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.SortPriority.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

