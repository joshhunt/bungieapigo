using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyPlatformSilverComponent{

		/// <summary>
		/// If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.
		/// </summary>
		[DataMember(Name="platformSilver", EmitDefaultValue=false)]
		public Dictionary<string, DestinyItemComponent> PlatformSilver { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPlatformSilverComponent);
        }

		public bool Equals(DestinyPlatformSilverComponent input)
		{
			if (input == null) return false;

			return
				(
                    PlatformSilver == input.PlatformSilver ||
                    (PlatformSilver != null && PlatformSilver.Equals(input.PlatformSilver))
                ) ;
		}
	}
}

