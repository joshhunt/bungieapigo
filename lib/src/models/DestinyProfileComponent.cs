using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// The most essential summary information about a Profile (in Destiny 1, we called these &quot;Accounts&quot;).
	[DataContract]
	public class DestinyProfileComponent{

		/// <summary>
		/// If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.
		/// </summary>
		[DataMember(Name="userInfo", EmitDefaultValue=false)]
		public UserInfoCard UserInfo { get; set; }

		/// <summary>
		/// The last time the user played with any character on this Profile.
		/// </summary>
		[DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
		public string DateLastPlayed { get; set; }

		/// <summary>
		/// If you want to know what expansions they own, this will contain that data.
		/// </summary>
		/// <summary>
		///  IMPORTANT: This field may not return the data you're interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they've purchased on the platform on which they last played, which now could be a different platform.
		/// </summary>
		/// <summary>
		///  If you don't care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be "good enough." Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC.
		/// </summary>
		[DataMember(Name="versionsOwned", EmitDefaultValue=false)]
		public DestinyGameVersions VersionsOwned { get; set; }

		/// <summary>
		/// A list of the character IDs, for further querying on your part.
		/// </summary>
		[DataMember(Name="characterIds", EmitDefaultValue=false)]
		public List<long> CharacterIds { get; set; }

		/// <summary>
		/// A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.
		/// </summary>
		/// <summary>
		///  It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won't see these as available: it will be whatever seasons are available for the platform on which they last played.
		/// </summary>
		[DataMember(Name="seasonHashes", EmitDefaultValue=false)]
		public List<uint> SeasonHashes { get; set; }

		/// <summary>
		/// If populated, this is a reference to the season that is currently active.
		/// </summary>
		[DataMember(Name="currentSeasonHash", EmitDefaultValue=false)]
		public uint CurrentSeasonHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileComponent);
        }

		public bool Equals(DestinyProfileComponent input)
		{
			if (input == null) return false;

			return
				(
                    UserInfo == input.UserInfo ||
                    (UserInfo != null && UserInfo.Equals(input.UserInfo))
                ) &&
				(
                    DateLastPlayed == input.DateLastPlayed ||
                    (DateLastPlayed != null && DateLastPlayed.Equals(input.DateLastPlayed))
                ) &&
				(
                    VersionsOwned == input.VersionsOwned ||
                    (VersionsOwned != null && VersionsOwned.Equals(input.VersionsOwned))
                ) &&
				(
                    CharacterIds == input.CharacterIds ||
                    (CharacterIds != null && CharacterIds.Equals(input.CharacterIds))
                ) &&
				(
                    SeasonHashes == input.SeasonHashes ||
                    (SeasonHashes != null && SeasonHashes.Equals(input.SeasonHashes))
                ) &&
				(
                    CurrentSeasonHash == input.CurrentSeasonHash ||
                    (CurrentSeasonHash != null && CurrentSeasonHash.Equals(input.CurrentSeasonHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
				hashCode = hashCode * 59 + this.DateLastPlayed.GetHashCode();
				hashCode = hashCode * 59 + this.VersionsOwned.GetHashCode();
				hashCode = hashCode * 59 + this.CharacterIds.GetHashCode();
				hashCode = hashCode * 59 + this.SeasonHashes.GetHashCode();
				hashCode = hashCode * 59 + this.CurrentSeasonHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

