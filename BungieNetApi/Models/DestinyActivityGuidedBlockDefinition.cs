using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Guided Game information for this activity.
	/// </summary>
	[DataContract]
	public class DestinyActivityGuidedBlockDefinition{

		/// <summary>
		/// The maximum amount of people that can be in the waiting lobby.
		/// </summary>
		[DataMember(Name="guidedMaxLobbySize", EmitDefaultValue=false)]
		public long GuidedMaxLobbySize { get; set; }

		/// <summary>
		/// The minimum amount of people that can be in the waiting lobby.
		/// </summary>
		[DataMember(Name="guidedMinLobbySize", EmitDefaultValue=false)]
		public long GuidedMinLobbySize { get; set; }

		/// <summary>
		/// If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.
		/// </summary>
		[DataMember(Name="guidedDisbandCount", EmitDefaultValue=false)]
		public long GuidedDisbandCount { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGuidedBlockDefinition);
        }

		public bool Equals(DestinyActivityGuidedBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    GuidedMaxLobbySize == input.GuidedMaxLobbySize ||
                    (GuidedMaxLobbySize != null && GuidedMaxLobbySize.Equals(input.GuidedMaxLobbySize))
                ) &&
				(
                    GuidedMinLobbySize == input.GuidedMinLobbySize ||
                    (GuidedMinLobbySize != null && GuidedMinLobbySize.Equals(input.GuidedMinLobbySize))
                ) &&
				(
                    GuidedDisbandCount == input.GuidedDisbandCount ||
                    (GuidedDisbandCount != null && GuidedDisbandCount.Equals(input.GuidedDisbandCount))
                ) ;
		}
	}
}

