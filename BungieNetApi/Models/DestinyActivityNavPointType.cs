using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum DestinyActivityNavPointType
    {
        /// <summary>
        /// Inactive = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Inactive = 0,

        /// <summary>
        /// PrimaryObjective = 1
        /// </summary>
        [EnumMember(Value = "1")]
        PrimaryObjective = 1,

        /// <summary>
        /// SecondaryObjective = 2
        /// </summary>
        [EnumMember(Value = "2")]
        SecondaryObjective = 2,

        /// <summary>
        /// TravelObjective = 3
        /// </summary>
        [EnumMember(Value = "3")]
        TravelObjective = 3,

        /// <summary>
        /// PublicEventObjective = 4
        /// </summary>
        [EnumMember(Value = "4")]
        PublicEventObjective = 4,

        /// <summary>
        /// AmmoCache = 5
        /// </summary>
        [EnumMember(Value = "5")]
        AmmoCache = 5,

        /// <summary>
        /// PointTypeFlag = 6
        /// </summary>
        [EnumMember(Value = "6")]
        PointTypeFlag = 6,

        /// <summary>
        /// CapturePoint = 7
        /// </summary>
        [EnumMember(Value = "7")]
        CapturePoint = 7,

        /// <summary>
        /// DefensiveEncounter = 8
        /// </summary>
        [EnumMember(Value = "8")]
        DefensiveEncounter = 8,

        /// <summary>
        /// GhostInteraction = 9
        /// </summary>
        [EnumMember(Value = "9")]
        GhostInteraction = 9,

        /// <summary>
        /// KillAi = 10
        /// </summary>
        [EnumMember(Value = "10")]
        KillAi = 10,

        /// <summary>
        /// QuestItem = 11
        /// </summary>
        [EnumMember(Value = "11")]
        QuestItem = 11,

        /// <summary>
        /// PatrolMission = 12
        /// </summary>
        [EnumMember(Value = "12")]
        PatrolMission = 12,

        /// <summary>
        /// Incoming = 13
        /// </summary>
        [EnumMember(Value = "13")]
        Incoming = 13,

        /// <summary>
        /// ArenaObjective = 14
        /// </summary>
        [EnumMember(Value = "14")]
        ArenaObjective = 14,

        /// <summary>
        /// AutomationHint = 15
        /// </summary>
        [EnumMember(Value = "15")]
        AutomationHint = 15,

        /// <summary>
        /// TrackedQuest = 16
        /// </summary>
        [EnumMember(Value = "16")]
        TrackedQuest = 16,

    }
}