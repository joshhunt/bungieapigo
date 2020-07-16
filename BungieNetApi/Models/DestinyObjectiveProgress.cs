using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Returns data about a character's status with a given Objective. Combine with DestinyObjectiveDefinition static data for display purposes.
    /// </summary>
    [DataContract]
    public class DestinyObjectiveProgress
    {
        /// <summary>
        /// The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.
        /// </summary>
        [DataMember(Name = "objectiveHash", EmitDefaultValue = false)]
        public uint ObjectiveHash { get; set; }

        /// <summary>
        /// If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.
        /// </summary>
        [DataMember(Name = "destinationHash", EmitDefaultValue = false)]
        public uint DestinationHash { get; set; }

        /// <summary>
        /// If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        /// <summary>
        /// If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public long Progress { get; set; }

        /// <summary>
        /// As of Forsaken, objectives' completion value is determined dynamically at runtime.
        /// </summary>
        /// <summary>
        /// This value represents the threshold of progress you need to surpass in order for this objective to be considered "complete".
        /// </summary>
        /// <summary>
        /// If you were using objective data, switch from using the DestinyObjectiveDefinition's "completionValue" to this value.
        /// </summary>
        [DataMember(Name = "completionValue", EmitDefaultValue = false)]
        public long CompletionValue { get; set; }

        /// <summary>
        /// Whether or not the Objective is completed.
        /// </summary>
        [DataMember(Name = "complete", EmitDefaultValue = false)]
        public bool Complete { get; set; }

        /// <summary>
        /// If this is true, the objective is visible in-game. Otherwise, it's not yet visible to the player. Up to you if you want to honor this property.
        /// </summary>
        [DataMember(Name = "visible", EmitDefaultValue = false)]
        public bool Visible { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyObjectiveProgress);
        }

        public bool Equals(DestinyObjectiveProgress input)
        {
            if (input == null) return false;

            return
                (
                    ObjectiveHash == input.ObjectiveHash ||
                    (ObjectiveHash != null && ObjectiveHash.Equals(input.ObjectiveHash))
                ) &&
                (
                    DestinationHash == input.DestinationHash ||
                    (DestinationHash != null && DestinationHash.Equals(input.DestinationHash))
                ) &&
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    Progress == input.Progress ||
                    (Progress != null && Progress.Equals(input.Progress))
                ) &&
                (
                    CompletionValue == input.CompletionValue ||
                    (CompletionValue != null && CompletionValue.Equals(input.CompletionValue))
                ) &&
                (
                    Complete == input.Complete ||
                    (Complete != null && Complete.Equals(input.Complete))
                ) &&
                (
                    Visible == input.Visible ||
                    (Visible != null && Visible.Equals(input.Visible))
                ) ;
        }
    }
}

