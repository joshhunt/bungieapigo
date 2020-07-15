using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Defines a Character Class in Destiny 2. These are types of characters you can play, like Titan, Warlock, and Hunter.
	/// </summary>
	[DataContract]
	public class DestinyClassDefinition{

		/// <summary>
		/// In Destiny 1, we added a convenience Enumeration for referring to classes. We've kept it, though mostly for posterity. This is the enum value for this definition's class.
		/// </summary>
		[DataMember(Name="classType", EmitDefaultValue=false)]
		public DestinyClass ClassType { get; set; }

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// A localized string referring to the singular form of the Class's name when referred to in gendered form. Keyed by the DestinyGender.
		/// </summary>
		[DataMember(Name="genderedClassNames", EmitDefaultValue=false)]
		public Dictionary<string, string> GenderedClassNames { get; set; }

		[DataMember(Name="genderedClassNamesByGenderHash", EmitDefaultValue=false)]
		public Dictionary<string, string> GenderedClassNamesByGenderHash { get; set; }

		/// <summary>
		/// Mentors don't really mean anything anymore. Don't expect this to be populated.
		/// </summary>
		[DataMember(Name="mentorVendorHash", EmitDefaultValue=false)]
		public uint MentorVendorHash { get; set; }

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
            return this.Equals(input as DestinyClassDefinition);
        }

		public bool Equals(DestinyClassDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ClassType == input.ClassType ||
                    (ClassType != null && ClassType.Equals(input.ClassType))
                ) &&
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    GenderedClassNames == input.GenderedClassNames ||
                    (GenderedClassNames != null && GenderedClassNames.Equals(input.GenderedClassNames))
                ) &&
				(
                    GenderedClassNamesByGenderHash == input.GenderedClassNamesByGenderHash ||
                    (GenderedClassNamesByGenderHash != null && GenderedClassNamesByGenderHash.Equals(input.GenderedClassNamesByGenderHash))
                ) &&
				(
                    MentorVendorHash == input.MentorVendorHash ||
                    (MentorVendorHash != null && MentorVendorHash.Equals(input.MentorVendorHash))
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

