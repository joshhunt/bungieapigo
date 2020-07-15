using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyArtifactCharacterScoped{

		[DataMember(Name="artifactHash", EmitDefaultValue=false)]
		public uint ArtifactHash { get; set; }

		[DataMember(Name="pointsUsed", EmitDefaultValue=false)]
		public long PointsUsed { get; set; }

		[DataMember(Name="resetCount", EmitDefaultValue=false)]
		public long ResetCount { get; set; }

		[DataMember(Name="tiers", EmitDefaultValue=false)]
		public List<DestinyArtifactTier> Tiers { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyArtifactCharacterScoped);
        }

		public bool Equals(DestinyArtifactCharacterScoped input)
		{
			if (input == null) return false;

			return
				(
                    ArtifactHash == input.ArtifactHash ||
                    (ArtifactHash != null && ArtifactHash.Equals(input.ArtifactHash))
                ) &&
				(
                    PointsUsed == input.PointsUsed ||
                    (PointsUsed != null && PointsUsed.Equals(input.PointsUsed))
                ) &&
				(
                    ResetCount == input.ResetCount ||
                    (ResetCount != null && ResetCount.Equals(input.ResetCount))
                ) &&
				(
                    Tiers == input.Tiers ||
                    (Tiers != null && Tiers.Equals(input.Tiers))
                ) ;
		}
	}
}

