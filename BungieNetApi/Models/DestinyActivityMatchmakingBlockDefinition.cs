using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Information about matchmaking and party size for the activity.
	/// </summary>
	[DataContract]
	public class DestinyActivityMatchmakingBlockDefinition{

		/// <summary>
		/// If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.
		/// </summary>
		[DataMember(Name="isMatchmade", EmitDefaultValue=false)]
		public bool IsMatchmade { get; set; }

		/// <summary>
		/// The minimum # of people in the fireteam for the activity to launch.
		/// </summary>
		[DataMember(Name="minParty", EmitDefaultValue=false)]
		public long MinParty { get; set; }

		/// <summary>
		/// The maximum # of people allowed in a Fireteam.
		/// </summary>
		[DataMember(Name="maxParty", EmitDefaultValue=false)]
		public long MaxParty { get; set; }

		/// <summary>
		/// The maximum # of people allowed across all teams in the activity.
		/// </summary>
		[DataMember(Name="maxPlayers", EmitDefaultValue=false)]
		public long MaxPlayers { get; set; }

		/// <summary>
		/// If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.
		/// </summary>
		[DataMember(Name="requiresGuardianOath", EmitDefaultValue=false)]
		public bool RequiresGuardianOath { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityMatchmakingBlockDefinition);
        }

		public bool Equals(DestinyActivityMatchmakingBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    IsMatchmade == input.IsMatchmade ||
                    (IsMatchmade != null && IsMatchmade.Equals(input.IsMatchmade))
                ) &&
				(
                    MinParty == input.MinParty ||
                    (MinParty != null && MinParty.Equals(input.MinParty))
                ) &&
				(
                    MaxParty == input.MaxParty ||
                    (MaxParty != null && MaxParty.Equals(input.MaxParty))
                ) &&
				(
                    MaxPlayers == input.MaxPlayers ||
                    (MaxPlayers != null && MaxPlayers.Equals(input.MaxPlayers))
                ) &&
				(
                    RequiresGuardianOath == input.RequiresGuardianOath ||
                    (RequiresGuardianOath != null && RequiresGuardianOath.Equals(input.RequiresGuardianOath))
                ) ;
		}
	}
}

