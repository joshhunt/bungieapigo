using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// In Destiny, &quot;Races&quot; are really more like &quot;Species&quot;. Sort of. I mean, are the Awoken a separate species from humans? I&#39;m not sure. But either way, they&#39;re defined here. You&#39;ll see Exo, Awoken, and Human as examples of these Species. Players will choose one for their character.
	[DataContract]
	public class DestinyRaceDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// An enumeration defining the existing, known Races/Species for player characters. This value will be the enum value matching this definition.
		/// </summary>
		[DataMember(Name="raceType", EmitDefaultValue=false)]
		public DestinyRace RaceType { get; set; }

		/// <summary>
		/// A localized string referring to the singular form of the Race's name when referred to in gendered form. Keyed by the DestinyGender.
		/// </summary>
		[DataMember(Name="genderedRaceNames", EmitDefaultValue=false)]
		public Map<String, string> GenderedRaceNames { get; set; }

		[DataMember(Name="genderedRaceNamesByGenderHash", EmitDefaultValue=false)]
		public Map<String, string> GenderedRaceNamesByGenderHash { get; set; }

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
            return this.Equals(input as DestinyRaceDefinition);
        }

		public bool Equals(DestinyRaceDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    RaceType == input.RaceType ||
                    (RaceType != null && RaceType.Equals(input.RaceType))
                ) &&
				(
                    GenderedRaceNames == input.GenderedRaceNames ||
                    (GenderedRaceNames != null && GenderedRaceNames.Equals(input.GenderedRaceNames))
                ) &&
				(
                    GenderedRaceNamesByGenderHash == input.GenderedRaceNamesByGenderHash ||
                    (GenderedRaceNamesByGenderHash != null && GenderedRaceNamesByGenderHash.Equals(input.GenderedRaceNamesByGenderHash))
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
	}
}

