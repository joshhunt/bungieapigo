using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// This is an experimental set of data that Bungie considers to be &quot;transitory&quot; - information that may be useful for API users, but that is coming from a non-authoritative data source about information that could potentially change at a more frequent pace than Bungie.net will receive updates about it.
	/// This information is provided exclusively for convenience should any of it be useful to users: we provide no guarantees to the accuracy or timeliness of data that comes from this source. Know that this data can potentially be out-of-date or even wrong entirely if the user disconnected from the game or suddenly changed their status before we can receive refreshed data.
	[DataContract]
	public class DestinyProfileTransitoryComponent{

		/// <summary>
		/// If you have any members currently in your party, this is some (very) bare-bones information about those members.
		/// </summary>
		[DataMember(Name="partyMembers", EmitDefaultValue=false)]
		public List<DestinyProfileTransitoryPartyMember> PartyMembers { get; set; }

		/// <summary>
		/// If you are in an activity, this is some transitory info about the activity currently being played.
		/// </summary>
		[DataMember(Name="currentActivity", EmitDefaultValue=false)]
		public DestinyProfileTransitoryCurrentActivity CurrentActivity { get; set; }

		/// <summary>
		/// Information about whether and what might prevent you from joining this person on a fireteam.
		/// </summary>
		[DataMember(Name="joinability", EmitDefaultValue=false)]
		public DestinyProfileTransitoryJoinability Joinability { get; set; }

		/// <summary>
		/// Information about tracked entities.
		/// </summary>
		[DataMember(Name="tracking", EmitDefaultValue=false)]
		public List<DestinyProfileTransitoryTrackingEntry> Tracking { get; set; }

		/// <summary>
		/// The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit.
		/// </summary>
		[DataMember(Name="lastOrbitedDestinationHash", EmitDefaultValue=false)]
		public uint LastOrbitedDestinationHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileTransitoryComponent);
        }

		public bool Equals(DestinyProfileTransitoryComponent input)
		{
			if (input == null) return false;

			return
				(
                    PartyMembers == input.PartyMembers ||
                    (PartyMembers != null && PartyMembers.Equals(input.PartyMembers))
                ) &&
				(
                    CurrentActivity == input.CurrentActivity ||
                    (CurrentActivity != null && CurrentActivity.Equals(input.CurrentActivity))
                ) &&
				(
                    Joinability == input.Joinability ||
                    (Joinability != null && Joinability.Equals(input.Joinability))
                ) &&
				(
                    Tracking == input.Tracking ||
                    (Tracking != null && Tracking.Equals(input.Tracking))
                ) &&
				(
                    LastOrbitedDestinationHash == input.LastOrbitedDestinationHash ||
                    (LastOrbitedDestinationHash != null && LastOrbitedDestinationHash.Equals(input.LastOrbitedDestinationHash))
                ) ;
		}
	}
}

