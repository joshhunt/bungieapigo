using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Represents a single state that a graph node might end up in. Depending on what&#39;s going on in the game, graph nodes could be shown in different ways or even excluded from view entirely.
	[DataContract]
	public class DestinyActivityGraphNodeStateEntry{

		[DataMember(Name="state", EmitDefaultValue=false)]
		public DestinyGraphNodeState State { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphNodeStateEntry);
        }

		public bool Equals(DestinyActivityGraphNodeStateEntry input)
		{
			if (input == null) return false;

			return
				(
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.State.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

