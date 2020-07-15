using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Destinations and Activities may have default Activity Graphs that should be shown when you bring up the Director and are playing in either.
	/// This contract defines the graph referred to and the gating for when it is relevant.
	[DataContract]
	public class DestinyActivityGraphListEntryDefinition{

		/// <summary>
		/// The hash identifier of the DestinyActivityGraphDefinition that should be shown when opening the director.
		/// </summary>
		[DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
		public uint ActivityGraphHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphListEntryDefinition);
        }

		public bool Equals(DestinyActivityGraphListEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ActivityGraphHash == input.ActivityGraphHash ||
                    (ActivityGraphHash != null && ActivityGraphHash.Equals(input.ActivityGraphHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ActivityGraphHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

