using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// These definitions represent Factions in the game. Factions have ended up unilaterally being related to Vendors that represent them, but that need not necessarily be the case.
	/// A Faction is really just an entity that has a related progression for which a character can gain experience. In Destiny 1, Dead Orbit was an example of a Faction: there happens to be a Vendor that represents Dead Orbit (and indeed, DestinyVendorDefinition.factionHash defines to this relationship), but Dead Orbit could theoretically exist without the Vendor that provides rewards.
	[DataContract]
	public class DestinyFactionDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// The hash identifier for the DestinyProgressionDefinition that indicates the character's relationship with this faction in terms of experience and levels.
		/// </summary>
		[DataMember(Name="progressionHash", EmitDefaultValue=false)]
		public uint ProgressionHash { get; set; }

		/// <summary>
		/// The faction token item hashes, and their respective progression values.
		/// </summary>
		[DataMember(Name="tokenValues", EmitDefaultValue=false)]
		public Map<String, uint> TokenValues { get; set; }

		/// <summary>
		/// The faction reward item hash, usually an engram.
		/// </summary>
		[DataMember(Name="rewardItemHash", EmitDefaultValue=false)]
		public uint RewardItemHash { get; set; }

		/// <summary>
		/// The faction reward vendor hash, used for faction engram previews.
		/// </summary>
		[DataMember(Name="rewardVendorHash", EmitDefaultValue=false)]
		public uint RewardVendorHash { get; set; }

		/// <summary>
		/// List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown.
		/// </summary>
		[DataMember(Name="vendors", EmitDefaultValue=false)]
		public List<DestinyFactionVendorDefinition> Vendors { get; set; }

		/// <summary>
		/// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
		/// </summary>
		/// <summary>
		/// When entities refer to each other in Destiny content, it is this hash that they are referring to.
		/// </summary>
		[DataMember(Name="hash", EmitDefaultValue=false)]
		public uint Hash { get; set; }

		/// <summary>
		/// The index of the entity as it was found in the investment tables.
		/// </summary>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public long Index { get; set; }

		/// <summary>
		/// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
		/// </summary>
		[DataMember(Name="redacted", EmitDefaultValue=false)]
		public bool Redacted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyFactionDefinition);
        }

		public bool Equals(DestinyFactionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    ProgressionHash == input.ProgressionHash ||
                    (ProgressionHash != null && ProgressionHash.Equals(input.ProgressionHash))
                ) &&
				(
                    TokenValues == input.TokenValues ||
                    (TokenValues != null && TokenValues.Equals(input.TokenValues))
                ) &&
				(
                    RewardItemHash == input.RewardItemHash ||
                    (RewardItemHash != null && RewardItemHash.Equals(input.RewardItemHash))
                ) &&
				(
                    RewardVendorHash == input.RewardVendorHash ||
                    (RewardVendorHash != null && RewardVendorHash.Equals(input.RewardVendorHash))
                ) &&
				(
                    Vendors == input.Vendors ||
                    (Vendors != null && Vendors.Equals(input.Vendors))
                ) &&
				(
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
				(
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
				(
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
				hashCode = hashCode * 59 + this.ProgressionHash.GetHashCode();
				hashCode = hashCode * 59 + this.TokenValues.GetHashCode();
				hashCode = hashCode * 59 + this.RewardItemHash.GetHashCode();
				hashCode = hashCode * 59 + this.RewardVendorHash.GetHashCode();
				hashCode = hashCode * 59 + this.Vendors.GetHashCode();
				hashCode = hashCode * 59 + this.Hash.GetHashCode();
				hashCode = hashCode * 59 + this.Index.GetHashCode();
				hashCode = hashCode * 59 + this.Redacted.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

