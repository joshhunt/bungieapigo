using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyHistoricalStatsDefinition
    {
        /// <summary>
        /// Unique programmer friendly ID for this stat
        /// </summary>
        [DataMember(Name = "statId", EmitDefaultValue = false)]
        public string StatId { get; set; }

        /// <summary>
        /// Statistic group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public DestinyStatsGroupType Group { get; set; }

        /// <summary>
        /// Time periods the statistic covers
        /// </summary>
        [DataMember(Name = "periodTypes", EmitDefaultValue = false)]
        public List<PeriodType> PeriodTypes { get; set; }

        /// <summary>
        /// Game modes where this statistic can be reported.
        /// </summary>
        [DataMember(Name = "modes", EmitDefaultValue = false)]
        public List<DestinyActivityModeType> Modes { get; set; }

        /// <summary>
        /// Category for the stat.
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public DestinyStatsCategoryType Category { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [DataMember(Name = "statName", EmitDefaultValue = false)]
        public string StatName { get; set; }

        /// <summary>
        /// Display name abbreviated
        /// </summary>
        [DataMember(Name = "statNameAbbr", EmitDefaultValue = false)]
        public string StatNameAbbr { get; set; }

        /// <summary>
        /// Description of a stat if applicable.
        /// </summary>
        [DataMember(Name = "statDescription", EmitDefaultValue = false)]
        public string StatDescription { get; set; }

        /// <summary>
        /// Unit, if any, for the statistic
        /// </summary>
        [DataMember(Name = "unitType", EmitDefaultValue = false)]
        public UnitType UnitType { get; set; }

        /// <summary>
        /// Optional URI to an icon for the statistic
        /// </summary>
        [DataMember(Name = "iconImage", EmitDefaultValue = false)]
        public string IconImage { get; set; }

        /// <summary>
        /// Optional icon for the statistic
        /// </summary>
        [DataMember(Name = "mergeMethod", EmitDefaultValue = false)]
        public long MergeMethod { get; set; }

        /// <summary>
        /// Localized Unit Name for the stat.
        /// </summary>
        [DataMember(Name = "unitLabel", EmitDefaultValue = false)]
        public string UnitLabel { get; set; }

        /// <summary>
        /// Weight assigned to this stat indicating its relative impressiveness.
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public long Weight { get; set; }

        /// <summary>
        /// The tier associated with this medal - be it implicitly or explicitly.
        /// </summary>
        [DataMember(Name = "medalTierHash", EmitDefaultValue = false)]
        public uint MedalTierHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsDefinition);
        }

        public bool Equals(DestinyHistoricalStatsDefinition input)
        {
            if (input == null) return false;

            return
                (
                    StatId == input.StatId ||
                    (StatId != null && StatId.Equals(input.StatId))
                ) &&
                (
                    Group == input.Group ||
                    (Group != null && Group.Equals(input.Group))
                ) &&
                (
                    PeriodTypes == input.PeriodTypes ||
                    (PeriodTypes != null && PeriodTypes.Equals(input.PeriodTypes))
                ) &&
                (
                    Modes == input.Modes ||
                    (Modes != null && Modes.Equals(input.Modes))
                ) &&
                (
                    Category == input.Category ||
                    (Category != null && Category.Equals(input.Category))
                ) &&
                (
                    StatName == input.StatName ||
                    (StatName != null && StatName.Equals(input.StatName))
                ) &&
                (
                    StatNameAbbr == input.StatNameAbbr ||
                    (StatNameAbbr != null && StatNameAbbr.Equals(input.StatNameAbbr))
                ) &&
                (
                    StatDescription == input.StatDescription ||
                    (StatDescription != null && StatDescription.Equals(input.StatDescription))
                ) &&
                (
                    UnitType == input.UnitType ||
                    (UnitType != null && UnitType.Equals(input.UnitType))
                ) &&
                (
                    IconImage == input.IconImage ||
                    (IconImage != null && IconImage.Equals(input.IconImage))
                ) &&
                (
                    MergeMethod == input.MergeMethod ||
                    (MergeMethod != null && MergeMethod.Equals(input.MergeMethod))
                ) &&
                (
                    UnitLabel == input.UnitLabel ||
                    (UnitLabel != null && UnitLabel.Equals(input.UnitLabel))
                ) &&
                (
                    Weight == input.Weight ||
                    (Weight != null && Weight.Equals(input.Weight))
                ) &&
                (
                    MedalTierHash == input.MedalTierHash ||
                    (MedalTierHash != null && MedalTierHash.Equals(input.MedalTierHash))
                ) ;
        }
    }
}

