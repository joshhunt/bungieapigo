using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Activity Modes are grouped into a few possible broad categories.
	/// </summary>
	
	public enum DestinyActivityModeCategory
	{
		/// <summary>
		/// None = 0
		/// Activities that are neither PVP nor PVE, such as social activities.
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// PvE = 1
		/// PvE activities, where you shoot aliens in the face.
		/// </summary>
		[EnumMember(Value = "1")]
		PvE = 1,

		/// <summary>
		/// PvP = 2
		/// PvP activities, where you shoot your &quot;friends&quot;.
		/// </summary>
		[EnumMember(Value = "2")]
		PvP = 2,

		/// <summary>
		/// PvECompetitive = 3
		/// PVE competitive activities, where you shoot whoever you want whenever you want. Or run around collecting small glowing triangles.
		/// </summary>
		[EnumMember(Value = "3")]
		PvECompetitive = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}