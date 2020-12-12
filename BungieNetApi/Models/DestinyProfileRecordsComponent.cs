using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyProfileRecordsComponent
    {
        /// <summary>
        /// Your 'active' Triumphs score, maintained for backwards compatibility.
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public long Score { get; set; }

        /// <summary>
        /// Your 'active' Triumphs score.
        /// </summary>
        [DataMember(Name = "activeScore", EmitDefaultValue = false)]
        public long ActiveScore { get; set; }

        /// <summary>
        /// Your 'legacy' Triumphs score.
        /// </summary>
        [DataMember(Name = "legacyScore", EmitDefaultValue = false)]
        public long LegacyScore { get; set; }

        /// <summary>
        /// Your 'lifetime' Triumphs score.
        /// </summary>
        [DataMember(Name = "lifetimeScore", EmitDefaultValue = false)]
        public long LifetimeScore { get; set; }

        /// <summary>
        /// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
        /// </summary>
        [DataMember(Name = "trackedRecordHash", EmitDefaultValue = false)]
        public uint TrackedRecordHash { get; set; }

        [DataMember(Name = "records", EmitDefaultValue = false)]
        public Dictionary<string, DestinyRecordComponent> Records { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph categories.
        /// </summary>
        [DataMember(Name = "recordCategoriesRootNodeHash", EmitDefaultValue = false)]
        public uint RecordCategoriesRootNodeHash { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph Seals.
        /// </summary>
        [DataMember(Name = "recordSealsRootNodeHash", EmitDefaultValue = false)]
        public uint RecordSealsRootNodeHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileRecordsComponent);
        }

        public bool Equals(DestinyProfileRecordsComponent input)
        {
            if (input == null) return false;

            return
                (
                    Score == input.Score ||
                    (Score.Equals(input.Score))
                ) &&
                (
                    ActiveScore == input.ActiveScore ||
                    (ActiveScore.Equals(input.ActiveScore))
                ) &&
                (
                    LegacyScore == input.LegacyScore ||
                    (LegacyScore.Equals(input.LegacyScore))
                ) &&
                (
                    LifetimeScore == input.LifetimeScore ||
                    (LifetimeScore.Equals(input.LifetimeScore))
                ) &&
                (
                    TrackedRecordHash == input.TrackedRecordHash ||
                    (TrackedRecordHash.Equals(input.TrackedRecordHash))
                ) &&
                (
                    Records == input.Records ||
                    (Records != null && Records.SequenceEqual(input.Records))
                ) &&
                (
                    RecordCategoriesRootNodeHash == input.RecordCategoriesRootNodeHash ||
                    (RecordCategoriesRootNodeHash.Equals(input.RecordCategoriesRootNodeHash))
                ) &&
                (
                    RecordSealsRootNodeHash == input.RecordSealsRootNodeHash ||
                    (RecordSealsRootNodeHash.Equals(input.RecordSealsRootNodeHash))
                ) ;
        }
    }
}

