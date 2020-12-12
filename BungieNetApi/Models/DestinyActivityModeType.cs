using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// For historical reasons, this list will have both D1 and D2-relevant Activity Modes in it. Please don't take this to mean that some D1-only feature is coming back!
    /// </summary>
    
    public enum DestinyActivityModeType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Story = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Story = 2,

        /// <summary>
        /// Strike = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Strike = 3,

        /// <summary>
        /// Raid = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Raid = 4,

        /// <summary>
        /// AllPvP = 5
        /// </summary>
        [EnumMember(Value = "5")]
        AllPvP = 5,

        /// <summary>
        /// Patrol = 6
        /// </summary>
        [EnumMember(Value = "6")]
        Patrol = 6,

        /// <summary>
        /// AllPvE = 7
        /// </summary>
        [EnumMember(Value = "7")]
        AllPvE = 7,

        /// <summary>
        /// Reserved9 = 9
        /// </summary>
        [EnumMember(Value = "9")]
        Reserved9 = 9,

        /// <summary>
        /// Control = 10
        /// </summary>
        [EnumMember(Value = "10")]
        Control = 10,

        /// <summary>
        /// Reserved11 = 11
        /// </summary>
        [EnumMember(Value = "11")]
        Reserved11 = 11,

        /// <summary>
        /// Clash = 12
        /// Clash -&gt; Destiny&#39;s name for Team Deathmatch. 4v4 combat, the team with the highest kills at the end of time wins.
        /// </summary>
        [EnumMember(Value = "12")]
        Clash = 12,

        /// <summary>
        /// Reserved13 = 13
        /// </summary>
        [EnumMember(Value = "13")]
        Reserved13 = 13,

        /// <summary>
        /// CrimsonDoubles = 15
        /// </summary>
        [EnumMember(Value = "15")]
        CrimsonDoubles = 15,

        /// <summary>
        /// Nightfall = 16
        /// </summary>
        [EnumMember(Value = "16")]
        Nightfall = 16,

        /// <summary>
        /// HeroicNightfall = 17
        /// </summary>
        [EnumMember(Value = "17")]
        HeroicNightfall = 17,

        /// <summary>
        /// AllStrikes = 18
        /// </summary>
        [EnumMember(Value = "18")]
        AllStrikes = 18,

        /// <summary>
        /// IronBanner = 19
        /// </summary>
        [EnumMember(Value = "19")]
        IronBanner = 19,

        /// <summary>
        /// Reserved20 = 20
        /// </summary>
        [EnumMember(Value = "20")]
        Reserved20 = 20,

        /// <summary>
        /// Reserved21 = 21
        /// </summary>
        [EnumMember(Value = "21")]
        Reserved21 = 21,

        /// <summary>
        /// Reserved22 = 22
        /// </summary>
        [EnumMember(Value = "22")]
        Reserved22 = 22,

        /// <summary>
        /// Reserved24 = 24
        /// </summary>
        [EnumMember(Value = "24")]
        Reserved24 = 24,

        /// <summary>
        /// AllMayhem = 25
        /// </summary>
        [EnumMember(Value = "25")]
        AllMayhem = 25,

        /// <summary>
        /// Reserved26 = 26
        /// </summary>
        [EnumMember(Value = "26")]
        Reserved26 = 26,

        /// <summary>
        /// Reserved27 = 27
        /// </summary>
        [EnumMember(Value = "27")]
        Reserved27 = 27,

        /// <summary>
        /// Reserved28 = 28
        /// </summary>
        [EnumMember(Value = "28")]
        Reserved28 = 28,

        /// <summary>
        /// Reserved29 = 29
        /// </summary>
        [EnumMember(Value = "29")]
        Reserved29 = 29,

        /// <summary>
        /// Reserved30 = 30
        /// </summary>
        [EnumMember(Value = "30")]
        Reserved30 = 30,

        /// <summary>
        /// Supremacy = 31
        /// </summary>
        [EnumMember(Value = "31")]
        Supremacy = 31,

        /// <summary>
        /// PrivateMatchesAll = 32
        /// </summary>
        [EnumMember(Value = "32")]
        PrivateMatchesAll = 32,

        /// <summary>
        /// Survival = 37
        /// </summary>
        [EnumMember(Value = "37")]
        Survival = 37,

        /// <summary>
        /// Countdown = 38
        /// </summary>
        [EnumMember(Value = "38")]
        Countdown = 38,

        /// <summary>
        /// TrialsOfTheNine = 39
        /// </summary>
        [EnumMember(Value = "39")]
        TrialsOfTheNine = 39,

        /// <summary>
        /// Social = 40
        /// </summary>
        [EnumMember(Value = "40")]
        Social = 40,

        /// <summary>
        /// TrialsCountdown = 41
        /// </summary>
        [EnumMember(Value = "41")]
        TrialsCountdown = 41,

        /// <summary>
        /// TrialsSurvival = 42
        /// </summary>
        [EnumMember(Value = "42")]
        TrialsSurvival = 42,

        /// <summary>
        /// IronBannerControl = 43
        /// </summary>
        [EnumMember(Value = "43")]
        IronBannerControl = 43,

        /// <summary>
        /// IronBannerClash = 44
        /// </summary>
        [EnumMember(Value = "44")]
        IronBannerClash = 44,

        /// <summary>
        /// IronBannerSupremacy = 45
        /// </summary>
        [EnumMember(Value = "45")]
        IronBannerSupremacy = 45,

        /// <summary>
        /// ScoredNightfall = 46
        /// </summary>
        [EnumMember(Value = "46")]
        ScoredNightfall = 46,

        /// <summary>
        /// ScoredHeroicNightfall = 47
        /// </summary>
        [EnumMember(Value = "47")]
        ScoredHeroicNightfall = 47,

        /// <summary>
        /// Rumble = 48
        /// </summary>
        [EnumMember(Value = "48")]
        Rumble = 48,

        /// <summary>
        /// AllDoubles = 49
        /// </summary>
        [EnumMember(Value = "49")]
        AllDoubles = 49,

        /// <summary>
        /// Doubles = 50
        /// </summary>
        [EnumMember(Value = "50")]
        Doubles = 50,

        /// <summary>
        /// PrivateMatchesClash = 51
        /// </summary>
        [EnumMember(Value = "51")]
        PrivateMatchesClash = 51,

        /// <summary>
        /// PrivateMatchesControl = 52
        /// </summary>
        [EnumMember(Value = "52")]
        PrivateMatchesControl = 52,

        /// <summary>
        /// PrivateMatchesSupremacy = 53
        /// </summary>
        [EnumMember(Value = "53")]
        PrivateMatchesSupremacy = 53,

        /// <summary>
        /// PrivateMatchesCountdown = 54
        /// </summary>
        [EnumMember(Value = "54")]
        PrivateMatchesCountdown = 54,

        /// <summary>
        /// PrivateMatchesSurvival = 55
        /// </summary>
        [EnumMember(Value = "55")]
        PrivateMatchesSurvival = 55,

        /// <summary>
        /// PrivateMatchesMayhem = 56
        /// </summary>
        [EnumMember(Value = "56")]
        PrivateMatchesMayhem = 56,

        /// <summary>
        /// PrivateMatchesRumble = 57
        /// </summary>
        [EnumMember(Value = "57")]
        PrivateMatchesRumble = 57,

        /// <summary>
        /// HeroicAdventure = 58
        /// </summary>
        [EnumMember(Value = "58")]
        HeroicAdventure = 58,

        /// <summary>
        /// Showdown = 59
        /// </summary>
        [EnumMember(Value = "59")]
        Showdown = 59,

        /// <summary>
        /// Lockdown = 60
        /// </summary>
        [EnumMember(Value = "60")]
        Lockdown = 60,

        /// <summary>
        /// Scorched = 61
        /// </summary>
        [EnumMember(Value = "61")]
        Scorched = 61,

        /// <summary>
        /// ScorchedTeam = 62
        /// </summary>
        [EnumMember(Value = "62")]
        ScorchedTeam = 62,

        /// <summary>
        /// Gambit = 63
        /// </summary>
        [EnumMember(Value = "63")]
        Gambit = 63,

        /// <summary>
        /// AllPvECompetitive = 64
        /// </summary>
        [EnumMember(Value = "64")]
        AllPvECompetitive = 64,

        /// <summary>
        /// Breakthrough = 65
        /// </summary>
        [EnumMember(Value = "65")]
        Breakthrough = 65,

        /// <summary>
        /// BlackArmoryRun = 66
        /// </summary>
        [EnumMember(Value = "66")]
        BlackArmoryRun = 66,

        /// <summary>
        /// Salvage = 67
        /// </summary>
        [EnumMember(Value = "67")]
        Salvage = 67,

        /// <summary>
        /// IronBannerSalvage = 68
        /// </summary>
        [EnumMember(Value = "68")]
        IronBannerSalvage = 68,

        /// <summary>
        /// PvPCompetitive = 69
        /// </summary>
        [EnumMember(Value = "69")]
        PvPCompetitive = 69,

        /// <summary>
        /// PvPQuickplay = 70
        /// </summary>
        [EnumMember(Value = "70")]
        PvPQuickplay = 70,

        /// <summary>
        /// ClashQuickplay = 71
        /// </summary>
        [EnumMember(Value = "71")]
        ClashQuickplay = 71,

        /// <summary>
        /// ClashCompetitive = 72
        /// </summary>
        [EnumMember(Value = "72")]
        ClashCompetitive = 72,

        /// <summary>
        /// ControlQuickplay = 73
        /// </summary>
        [EnumMember(Value = "73")]
        ControlQuickplay = 73,

        /// <summary>
        /// ControlCompetitive = 74
        /// </summary>
        [EnumMember(Value = "74")]
        ControlCompetitive = 74,

        /// <summary>
        /// GambitPrime = 75
        /// </summary>
        [EnumMember(Value = "75")]
        GambitPrime = 75,

        /// <summary>
        /// Reckoning = 76
        /// </summary>
        [EnumMember(Value = "76")]
        Reckoning = 76,

        /// <summary>
        /// Menagerie = 77
        /// </summary>
        [EnumMember(Value = "77")]
        Menagerie = 77,

        /// <summary>
        /// VexOffensive = 78
        /// </summary>
        [EnumMember(Value = "78")]
        VexOffensive = 78,

        /// <summary>
        /// NightmareHunt = 79
        /// </summary>
        [EnumMember(Value = "79")]
        NightmareHunt = 79,

        /// <summary>
        /// Elimination = 80
        /// </summary>
        [EnumMember(Value = "80")]
        Elimination = 80,

        /// <summary>
        /// Momentum = 81
        /// </summary>
        [EnumMember(Value = "81")]
        Momentum = 81,

        /// <summary>
        /// Dungeon = 82
        /// </summary>
        [EnumMember(Value = "82")]
        Dungeon = 82,

        /// <summary>
        /// Sundial = 83
        /// </summary>
        [EnumMember(Value = "83")]
        Sundial = 83,

        /// <summary>
        /// TrialsOfOsiris = 84
        /// </summary>
        [EnumMember(Value = "84")]
        TrialsOfOsiris = 84,

    }
}