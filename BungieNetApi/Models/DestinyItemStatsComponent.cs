using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// If you want the stats on an item's instanced data, get this component.
	/// </summary>
	/// <summary>
	/// These are stats like Attack, Defense etc... and *not* historical stats.
	/// </summary>
	/// <summary>
	/// Note that some stats have additional computation in-game at runtime - for instance, Magazine Size - and thus these stats might not be 100% accurate compared to what you see in-game for some stats. I know, it sucks. I hate it too.
	/// </summary>
	[DataContract]
	public class DestinyItemStatsComponent{

		/// <summary>
		/// If the item has stats that it provides (damage, defense, etc...), it will be given here.
		/// </summary>
		[DataMember(Name="stats", EmitDefaultValue=false)]
		public Dictionary<string, DestinyStat> Stats { get; set; }


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

