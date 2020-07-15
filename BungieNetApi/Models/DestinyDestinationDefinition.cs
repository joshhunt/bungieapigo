using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// On to one of the more confusing subjects of the API. What is a Destination, and what is the relationship between it, Activities, Locations, and Places?
	/// </summary>
	/// <summary>
	/// A "Destination" is a specific region/city/area of a larger "Place". For instance, a Place might be Earth where a Destination might be Bellevue, Washington. (Please, pick a more interesting destination if you come to visit Earth).
	/// </summary>
	[DataContract]
	public class DestinyDestinationDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// The place that "owns" this Destination. Use this hash to look up the DestinyPlaceDefinition.
		/// </summary>
		[DataMember(Name="placeHash", EmitDefaultValue=false)]
		public uint PlaceHash { get; set; }

		/// <summary>
		/// If this Destination has a default Free-Roam activity, this is the hash for that Activity. Use it to look up the DestinyActivityDefintion.
		/// </summary>
		[DataMember(Name="defaultFreeroamActivityHash", EmitDefaultValue=false)]
		public uint DefaultFreeroamActivityHash { get; set; }

		/// <summary>
		/// If the Destination has default Activity Graphs (i.e. "Map") that should be shown in the director, this is the list of those Graphs. At most, only one should be active at any given time for a Destination: these would represent, for example, different variants on a Map if the Destination is changing on a macro level based on game state.
		/// </summary>
		[DataMember(Name="activityGraphEntries", EmitDefaultValue=false)]
		public List<DestinyActivityGraphListEntryDefinition> ActivityGraphEntries { get; set; }

		/// <summary>
		/// A Destination may have many "Bubbles" zones with human readable properties.
		/// </summary>
		/// <summary>
		/// We don't get as much info as I'd like about them - I'd love to return info like where on the map they are located - but at least this gives you the name of those bubbles. bubbleSettings and bubbles both have the identical number of entries, and you should match up their indexes to provide matching bubble and bubbleSettings data.
		/// </summary>
		/// <summary>
		/// DEPRECATED - Just use bubbles, it now has this data.
		/// </summary>
		[DataMember(Name="bubbleSettings", EmitDefaultValue=false)]
		public List<DestinyDestinationBubbleSettingDefinition> BubbleSettings { get; set; }

		/// <summary>
		/// This provides the unique identifiers for every bubble in the destination (only guaranteed unique within the destination), and any intrinsic properties of the bubble.
		/// </summary>
		/// <summary>
		/// bubbleSettings and bubbles both have the identical number of entries, and you should match up their indexes to provide matching bubble and bubbleSettings data.
		/// </summary>
		[DataMember(Name="bubbles", EmitDefaultValue=false)]
		public List<DestinyBubbleDefinition> Bubbles { get; set; }

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
            return this.Equals(input as DestinyDestinationDefinition);
        }

		public bool Equals(DestinyDestinationDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    PlaceHash == input.PlaceHash ||
                    (PlaceHash != null && PlaceHash.Equals(input.PlaceHash))
                ) &&
				(
                    DefaultFreeroamActivityHash == input.DefaultFreeroamActivityHash ||
                    (DefaultFreeroamActivityHash != null && DefaultFreeroamActivityHash.Equals(input.DefaultFreeroamActivityHash))
                ) &&
				(
                    ActivityGraphEntries == input.ActivityGraphEntries ||
                    (ActivityGraphEntries != null && ActivityGraphEntries.Equals(input.ActivityGraphEntries))
                ) &&
				(
                    BubbleSettings == input.BubbleSettings ||
                    (BubbleSettings != null && BubbleSettings.Equals(input.BubbleSettings))
                ) &&
				(
                    Bubbles == input.Bubbles ||
                    (Bubbles != null && Bubbles.Equals(input.Bubbles))
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

