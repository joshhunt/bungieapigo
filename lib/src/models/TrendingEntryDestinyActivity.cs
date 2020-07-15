using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class TrendingEntryDestinyActivity{

		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }

		/// <summary>
		/// Represents the public-facing status of an activity: any data about what is currently active in the Activity, regardless of an individual character's progress in it.
		/// </summary>
		[DataMember(Name="status", EmitDefaultValue=false)]
		public DestinyPublicActivityStatus Status { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingEntryDestinyActivity);
        }

		public bool Equals(TrendingEntryDestinyActivity input)
		{
			if (input == null) return false;

			return
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
				(
                    Status == input.Status ||
                    (Status != null && Status.Equals(input.Status))
                ) ;
		}
	}
}

