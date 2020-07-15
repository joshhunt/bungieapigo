using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// By public demand, Checklists are loose sets of "things to do/things you have done" in Destiny that we were actually able to track. They include easter eggs you find in the world, unique chests you unlock, and other such data where the first time you do it is significant enough to be tracked, and you have the potential to "get them all".
	/// </summary>
	/// <summary>
	/// These may be account-wide, or may be per character. The status of these will be returned in related "Checklist" data coming down from API requests such as GetProfile or GetCharacter.
	/// </summary>
	/// <summary>
	/// Generally speaking, the items in a checklist can be completed in any order: we return an ordered list which only implies the way we are showing them in our own UI, and you can feel free to alter it as you wish.
	/// </summary>
	/// <summary>
	/// Note that, in the future, there will be something resembling the old D1 Record Books in at least some vague form. When that is created, it may be that it will supercede much or all of this Checklist data. It remains to be seen if that will be the case, so for now assume that the Checklists will still exist even after the release of D2: Forsaken.
	/// </summary>
	[DataContract]
	public class DestinyChecklistDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// A localized string prompting you to view the checklist.
		/// </summary>
		[DataMember(Name="viewActionString", EmitDefaultValue=false)]
		public string ViewActionString { get; set; }

		/// <summary>
		/// Indicates whether you will find this checklist on the Profile or Character components.
		/// </summary>
		[DataMember(Name="scope", EmitDefaultValue=false)]
		public DestinyScope Scope { get; set; }

		/// <summary>
		/// The individual checklist items. Gotta catch 'em all.
		/// </summary>
		[DataMember(Name="entries", EmitDefaultValue=false)]
		public List<DestinyChecklistEntryDefinition> Entries { get; set; }

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
            return this.Equals(input as DestinyChecklistDefinition);
        }

		public bool Equals(DestinyChecklistDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    ViewActionString == input.ViewActionString ||
                    (ViewActionString != null && ViewActionString.Equals(input.ViewActionString))
                ) &&
				(
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) &&
				(
                    Entries == input.Entries ||
                    (Entries != null && Entries.Equals(input.Entries))
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

