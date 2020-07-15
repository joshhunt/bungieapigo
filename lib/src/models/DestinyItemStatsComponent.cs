using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// If you want the stats on an item&#39;s instanced data, get this component.
	/// These are stats like Attack, Defense etc... and *not* historical stats.
	/// Note that some stats have additional computation in-game at runtime - for instance, Magazine Size - and thus these stats might not be 100% accurate compared to what you see in-game for some stats. I know, it sucks. I hate it too.
	[DataContract]
	public class DestinyItemStatsComponent{

		/// <summary>
		/// If the item has stats that it provides (damage, defense, etc...), it will be given here.
		/// </summary>
		[DataMember(Name="stats", EmitDefaultValue=false)]
		public Map<String, DestinyStat> Stats { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemStatsComponent);
        }

		public bool Equals(DestinyItemStatsComponent input)
		{
			if (input == null) return false;

			return
				(
                    Stats == input.Stats ||
                    (Stats != null && Stats.Equals(input.Stats))
                ) ;
		}
	}
}

