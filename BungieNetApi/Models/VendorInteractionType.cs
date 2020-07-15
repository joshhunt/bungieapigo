using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// An enumeration of the known UI interactions for Vendors.
	/// </summary>
	
	public enum VendorInteractionType
	{
		/// <summary>
		/// Unknown = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Unknown = 0,

		/// <summary>
		/// Undefined = 1
		/// An empty interaction. If this ends up in content, it is probably a game bug.
		/// </summary>
		[EnumMember(Value = "1")]
		Undefined = 1,

		/// <summary>
		/// QuestComplete = 2
		/// An interaction shown when you complete a quest and receive a reward.
		/// </summary>
		[EnumMember(Value = "2")]
		QuestComplete = 2,

		/// <summary>
		/// QuestContinue = 3
		/// An interaction shown when you talk to a Vendor as an intermediary step of a quest.
		/// </summary>
		[EnumMember(Value = "3")]
		QuestContinue = 3,

		/// <summary>
		/// ReputationPreview = 4
		/// An interaction shown when you are previewing the vendor&#39;s reputation rewards.
		/// </summary>
		[EnumMember(Value = "4")]
		ReputationPreview = 4,

		/// <summary>
		/// RankUpReward = 5
		/// An interaction shown when you rank up with the vendor.
		/// </summary>
		[EnumMember(Value = "5")]
		RankUpReward = 5,

		/// <summary>
		/// TokenTurnIn = 6
		/// An interaction shown when you have tokens to turn in for the vendor.
		/// </summary>
		[EnumMember(Value = "6")]
		TokenTurnIn = 6,

		/// <summary>
		/// QuestAccept = 7
		/// An interaction shown when you&#39;re accepting a new quest.
		/// </summary>
		[EnumMember(Value = "7")]
		QuestAccept = 7,

		/// <summary>
		/// ProgressTab = 8
		/// Honestly, this doesn&#39;t seem consistent to me. It is used to give you choices in the Cryptarch as well as some reward prompts by the Eververse vendor. I&#39;ll have to look into that further at some point.
		/// </summary>
		[EnumMember(Value = "8")]
		ProgressTab = 8,

		/// <summary>
		/// End = 9
		/// These seem even less consistent. I don&#39;t know what these are.
		/// </summary>
		[EnumMember(Value = "9")]
		End = 9,

		/// <summary>
		/// Start = 10
		/// Also seem inconsistent. I also don&#39;t know what these are offhand.
		/// </summary>
		[EnumMember(Value = "10")]
		Start = 10,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}