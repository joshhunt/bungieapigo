using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyPlayer{

		/// <summary>
		/// Details about the player as they are known in game (platform display name, Destiny emblem)
		/// </summary>
		[DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
		public UserInfoCard DestinyUserInfo { get; set; }

		/// <summary>
		/// Class of the character if applicable and available.
		/// </summary>
		[DataMember(Name="characterClass", EmitDefaultValue=false)]
		public string CharacterClass { get; set; }

		[DataMember(Name="classHash", EmitDefaultValue=false)]
		public uint ClassHash { get; set; }

		[DataMember(Name="raceHash", EmitDefaultValue=false)]
		public uint RaceHash { get; set; }

		[DataMember(Name="genderHash", EmitDefaultValue=false)]
		public uint GenderHash { get; set; }

		/// <summary>
		/// Level of the character if available. Zero if it is not available.
		/// </summary>
		[DataMember(Name="characterLevel", EmitDefaultValue=false)]
		public long CharacterLevel { get; set; }

		/// <summary>
		/// Light Level of the character if available. Zero if it is not available.
		/// </summary>
		[DataMember(Name="lightLevel", EmitDefaultValue=false)]
		public long LightLevel { get; set; }

		/// <summary>
		/// Details about the player as they are known on BungieNet. This will be undefined if the player has marked their credential private, or does not have a BungieNet account.
		/// </summary>
		[DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
		public UserInfoCard BungieNetUserInfo { get; set; }

		/// <summary>
		/// Current clan name for the player. This value may be null or an empty string if the user does not have a clan.
		/// </summary>
		[DataMember(Name="clanName", EmitDefaultValue=false)]
		public string ClanName { get; set; }

		/// <summary>
		/// Current clan tag for the player. This value may be null or an empty string if the user does not have a clan.
		/// </summary>
		[DataMember(Name="clanTag", EmitDefaultValue=false)]
		public string ClanTag { get; set; }

		/// <summary>
		/// If we know the emblem's hash, this can be used to look up the player's emblem at the time of a match when receiving PGCR data, or otherwise their currently equipped emblem (if we are able to obtain it).
		/// </summary>
		[DataMember(Name="emblemHash", EmitDefaultValue=false)]
		public uint EmblemHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPlayer);
        }

		public bool Equals(DestinyPlayer input)
		{
			if (input == null) return false;

			return
				(
                    DestinyUserInfo == input.DestinyUserInfo ||
                    (DestinyUserInfo != null && DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) &&
				(
                    CharacterClass == input.CharacterClass ||
                    (CharacterClass != null && CharacterClass.Equals(input.CharacterClass))
                ) &&
				(
                    ClassHash == input.ClassHash ||
                    (ClassHash != null && ClassHash.Equals(input.ClassHash))
                ) &&
				(
                    RaceHash == input.RaceHash ||
                    (RaceHash != null && RaceHash.Equals(input.RaceHash))
                ) &&
				(
                    GenderHash == input.GenderHash ||
                    (GenderHash != null && GenderHash.Equals(input.GenderHash))
                ) &&
				(
                    CharacterLevel == input.CharacterLevel ||
                    (CharacterLevel != null && CharacterLevel.Equals(input.CharacterLevel))
                ) &&
				(
                    LightLevel == input.LightLevel ||
                    (LightLevel != null && LightLevel.Equals(input.LightLevel))
                ) &&
				(
                    BungieNetUserInfo == input.BungieNetUserInfo ||
                    (BungieNetUserInfo != null && BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) &&
				(
                    ClanName == input.ClanName ||
                    (ClanName != null && ClanName.Equals(input.ClanName))
                ) &&
				(
                    ClanTag == input.ClanTag ||
                    (ClanTag != null && ClanTag.Equals(input.ClanTag))
                ) &&
				(
                    EmblemHash == input.EmblemHash ||
                    (EmblemHash != null && EmblemHash.Equals(input.EmblemHash))
                ) ;
		}
	}
}

