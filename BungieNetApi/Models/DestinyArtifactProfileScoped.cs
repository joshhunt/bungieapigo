using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Represents a Seasonal Artifact and all data related to it for the requested Account.
    /// </summary>
    /// <summary>
    /// It can be combined with Character-scoped data for a full picture of what a character has available/has chosen, or just these settings can be used for overview information.
    /// </summary>
    [DataContract]
    public class DestinyArtifactProfileScoped
    {
        [DataMember(Name = "artifactHash", EmitDefaultValue = false)]
        public uint ArtifactHash { get; set; }

        /// <summary>
        /// Information about a current character's status with a Progression. A progression is a value that can increase with activity and has levels. Think Character Level and Reputation Levels. Combine this "live" data with the related DestinyProgressionDefinition for a full picture of the Progression.
        /// </summary>
        [DataMember(Name = "pointProgression", EmitDefaultValue = false)]
        public DestinyProgression PointProgression { get; set; }

        [DataMember(Name = "pointsAcquired", EmitDefaultValue = false)]
        public long PointsAcquired { get; set; }

        /// <summary>
        /// Information about a current character's status with a Progression. A progression is a value that can increase with activity and has levels. Think Character Level and Reputation Levels. Combine this "live" data with the related DestinyProgressionDefinition for a full picture of the Progression.
        /// </summary>
        [DataMember(Name = "powerBonusProgression", EmitDefaultValue = false)]
        public DestinyProgression PowerBonusProgression { get; set; }

        [DataMember(Name = "powerBonus", EmitDefaultValue = false)]
        public long PowerBonus { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyArtifactProfileScoped);
        }

        public bool Equals(DestinyArtifactProfileScoped input)
        {
            if (input == null) return false;

            return
                (
                    ArtifactHash == input.ArtifactHash ||
                    (ArtifactHash != null && ArtifactHash.Equals(input.ArtifactHash))
                ) &&
                (
                    PointProgression == input.PointProgression ||
                    (PointProgression != null && PointProgression.Equals(input.PointProgression))
                ) &&
                (
                    PointsAcquired == input.PointsAcquired ||
                    (PointsAcquired != null && PointsAcquired.Equals(input.PointsAcquired))
                ) &&
                (
                    PowerBonusProgression == input.PowerBonusProgression ||
                    (PowerBonusProgression != null && PowerBonusProgression.Equals(input.PowerBonusProgression))
                ) &&
                (
                    PowerBonus == input.PowerBonus ||
                    (PowerBonus != null && PowerBonus.Equals(input.PowerBonus))
                ) ;
        }
    }
}

