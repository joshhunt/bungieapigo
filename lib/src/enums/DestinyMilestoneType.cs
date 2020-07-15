using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// The type of milestone. Milestones can be Tutorials, one-time/triggered/non-repeating but not necessarily tutorials, or Repeating Milestones.
	/// </summary>
	
	public enum DestinyMilestoneType
	{
		/// <summary>
		/// Unknown = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Unknown = 0,

		/// <summary>
		/// Tutorial = 1
		/// One-time milestones that are specifically oriented toward teaching players about new mechanics and gameplay modes.
		/// </summary>
		[EnumMember(Value = "1")]
		Tutorial = 1,

		/// <summary>
		/// OneTime = 2
		/// Milestones that, once completed a single time, can never be repeated.
		/// </summary>
		[EnumMember(Value = "2")]
		OneTime = 2,

		/// <summary>
		/// Weekly = 3
		/// Milestones that repeat&#x2F;reset on a weekly basis. They need not all reset on the same day or time, but do need to reset weekly to qualify for this type.
		/// </summary>
		[EnumMember(Value = "3")]
		Weekly = 3,

		/// <summary>
		/// Daily = 4
		/// Milestones that repeat or reset on a daily basis.
		/// </summary>
		[EnumMember(Value = "4")]
		Daily = 4,

		/// <summary>
		/// Special = 5
		/// Special indicates that the event is not on a daily&#x2F;weekly cadence, but does occur more than once. For instance, Iron Banner in Destiny 1 or the Dawning were examples of what could be termed &quot;Special&quot; events.
		/// </summary>
		[EnumMember(Value = "5")]
		Special = 5,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}