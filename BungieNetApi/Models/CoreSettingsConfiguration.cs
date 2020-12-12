using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class CoreSettingsConfiguration
    {
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public string Environment { get; set; }

        [DataMember(Name = "systems", EmitDefaultValue = false)]
        public Dictionary<string, CoreSystem> Systems { get; set; }

        [DataMember(Name = "ignoreReasons", EmitDefaultValue = false)]
        public List<CoreSetting> IgnoreReasons { get; set; }

        [DataMember(Name = "forumCategories", EmitDefaultValue = false)]
        public List<CoreSetting> ForumCategories { get; set; }

        [DataMember(Name = "groupAvatars", EmitDefaultValue = false)]
        public List<CoreSetting> GroupAvatars { get; set; }

        [DataMember(Name = "destinyMembershipTypes", EmitDefaultValue = false)]
        public List<CoreSetting> DestinyMembershipTypes { get; set; }

        [DataMember(Name = "recruitmentPlatformTags", EmitDefaultValue = false)]
        public List<CoreSetting> RecruitmentPlatformTags { get; set; }

        [DataMember(Name = "recruitmentMiscTags", EmitDefaultValue = false)]
        public List<CoreSetting> RecruitmentMiscTags { get; set; }

        [DataMember(Name = "recruitmentActivities", EmitDefaultValue = false)]
        public List<CoreSetting> RecruitmentActivities { get; set; }

        [DataMember(Name = "userContentLocales", EmitDefaultValue = false)]
        public List<CoreSetting> UserContentLocales { get; set; }

        [DataMember(Name = "systemContentLocales", EmitDefaultValue = false)]
        public List<CoreSetting> SystemContentLocales { get; set; }

        [DataMember(Name = "clanBannerDecals", EmitDefaultValue = false)]
        public List<CoreSetting> ClanBannerDecals { get; set; }

        [DataMember(Name = "clanBannerDecalColors", EmitDefaultValue = false)]
        public List<CoreSetting> ClanBannerDecalColors { get; set; }

        [DataMember(Name = "clanBannerGonfalons", EmitDefaultValue = false)]
        public List<CoreSetting> ClanBannerGonfalons { get; set; }

        [DataMember(Name = "clanBannerGonfalonColors", EmitDefaultValue = false)]
        public List<CoreSetting> ClanBannerGonfalonColors { get; set; }

        [DataMember(Name = "clanBannerGonfalonDetails", EmitDefaultValue = false)]
        public List<CoreSetting> ClanBannerGonfalonDetails { get; set; }

        [DataMember(Name = "clanBannerGonfalonDetailColors", EmitDefaultValue = false)]
        public List<CoreSetting> ClanBannerGonfalonDetailColors { get; set; }

        [DataMember(Name = "clanBannerStandards", EmitDefaultValue = false)]
        public List<CoreSetting> ClanBannerStandards { get; set; }

        [DataMember(Name = "destiny2CoreSettings", EmitDefaultValue = false)]
        public Destiny2CoreSettings Destiny2CoreSettings { get; set; }

        /// <summary>
        /// The set of all email subscription/opt-in settings and definitions.
        /// </summary>
        [DataMember(Name = "emailSettings", EmitDefaultValue = false)]
        public EmailSettings EmailSettings { get; set; }

        [DataMember(Name = "fireteamActivities", EmitDefaultValue = false)]
        public List<CoreSetting> FireteamActivities { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as CoreSettingsConfiguration);
        }

        public bool Equals(CoreSettingsConfiguration input)
        {
            if (input == null) return false;

            return
                (
                    Environment == input.Environment ||
                    (Environment != null && Environment.Equals(input.Environment))
                ) &&
                (
                    Systems == input.Systems ||
                    (Systems != null && Systems.SequenceEqual(input.Systems))
                ) &&
                (
                    IgnoreReasons == input.IgnoreReasons ||
                    (IgnoreReasons != null && IgnoreReasons.SequenceEqual(input.IgnoreReasons))
                ) &&
                (
                    ForumCategories == input.ForumCategories ||
                    (ForumCategories != null && ForumCategories.SequenceEqual(input.ForumCategories))
                ) &&
                (
                    GroupAvatars == input.GroupAvatars ||
                    (GroupAvatars != null && GroupAvatars.SequenceEqual(input.GroupAvatars))
                ) &&
                (
                    DestinyMembershipTypes == input.DestinyMembershipTypes ||
                    (DestinyMembershipTypes != null && DestinyMembershipTypes.SequenceEqual(input.DestinyMembershipTypes))
                ) &&
                (
                    RecruitmentPlatformTags == input.RecruitmentPlatformTags ||
                    (RecruitmentPlatformTags != null && RecruitmentPlatformTags.SequenceEqual(input.RecruitmentPlatformTags))
                ) &&
                (
                    RecruitmentMiscTags == input.RecruitmentMiscTags ||
                    (RecruitmentMiscTags != null && RecruitmentMiscTags.SequenceEqual(input.RecruitmentMiscTags))
                ) &&
                (
                    RecruitmentActivities == input.RecruitmentActivities ||
                    (RecruitmentActivities != null && RecruitmentActivities.SequenceEqual(input.RecruitmentActivities))
                ) &&
                (
                    UserContentLocales == input.UserContentLocales ||
                    (UserContentLocales != null && UserContentLocales.SequenceEqual(input.UserContentLocales))
                ) &&
                (
                    SystemContentLocales == input.SystemContentLocales ||
                    (SystemContentLocales != null && SystemContentLocales.SequenceEqual(input.SystemContentLocales))
                ) &&
                (
                    ClanBannerDecals == input.ClanBannerDecals ||
                    (ClanBannerDecals != null && ClanBannerDecals.SequenceEqual(input.ClanBannerDecals))
                ) &&
                (
                    ClanBannerDecalColors == input.ClanBannerDecalColors ||
                    (ClanBannerDecalColors != null && ClanBannerDecalColors.SequenceEqual(input.ClanBannerDecalColors))
                ) &&
                (
                    ClanBannerGonfalons == input.ClanBannerGonfalons ||
                    (ClanBannerGonfalons != null && ClanBannerGonfalons.SequenceEqual(input.ClanBannerGonfalons))
                ) &&
                (
                    ClanBannerGonfalonColors == input.ClanBannerGonfalonColors ||
                    (ClanBannerGonfalonColors != null && ClanBannerGonfalonColors.SequenceEqual(input.ClanBannerGonfalonColors))
                ) &&
                (
                    ClanBannerGonfalonDetails == input.ClanBannerGonfalonDetails ||
                    (ClanBannerGonfalonDetails != null && ClanBannerGonfalonDetails.SequenceEqual(input.ClanBannerGonfalonDetails))
                ) &&
                (
                    ClanBannerGonfalonDetailColors == input.ClanBannerGonfalonDetailColors ||
                    (ClanBannerGonfalonDetailColors != null && ClanBannerGonfalonDetailColors.SequenceEqual(input.ClanBannerGonfalonDetailColors))
                ) &&
                (
                    ClanBannerStandards == input.ClanBannerStandards ||
                    (ClanBannerStandards != null && ClanBannerStandards.SequenceEqual(input.ClanBannerStandards))
                ) &&
                (
                    Destiny2CoreSettings == input.Destiny2CoreSettings ||
                    (Destiny2CoreSettings != null && Destiny2CoreSettings.Equals(input.Destiny2CoreSettings))
                ) &&
                (
                    EmailSettings == input.EmailSettings ||
                    (EmailSettings != null && EmailSettings.Equals(input.EmailSettings))
                ) &&
                (
                    FireteamActivities == input.FireteamActivities ||
                    (FireteamActivities != null && FireteamActivities.SequenceEqual(input.FireteamActivities))
                ) ;
        }
    }
}

