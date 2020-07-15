using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
	/// </summary>
	[DataContract]
	public class DestinyDisplayPropertiesDefinition{

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// Note that "icon" is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition's icon was a big picture of a book.
		/// </summary>
		/// <summary>
		/// But usually, it will be a small square image that you can use as... well, an icon.
		/// </summary>
		/// <summary>
		/// They are currently represented as 96px x 96px images.
		/// </summary>
		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }

		[DataMember(Name="iconSequences", EmitDefaultValue=false)]
		public List<DestinyIconSequenceDefinition> IconSequences { get; set; }

		/// <summary>
		/// If this item has a high-res icon (at least for now, many things won't), then the path to that icon will be here.
		/// </summary>
		[DataMember(Name="highResIcon", EmitDefaultValue=false)]
		public string HighResIcon { get; set; }

		[DataMember(Name="hasIcon", EmitDefaultValue=false)]
		public bool HasIcon { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyDisplayPropertiesDefinition);
        }

		public bool Equals(DestinyDisplayPropertiesDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) &&
				(
                    IconSequences == input.IconSequences ||
                    (IconSequences != null && IconSequences.Equals(input.IconSequences))
                ) &&
				(
                    HighResIcon == input.HighResIcon ||
                    (HighResIcon != null && HighResIcon.Equals(input.HighResIcon))
                ) &&
				(
                    HasIcon == input.HasIcon ||
                    (HasIcon != null && HasIcon.Equals(input.HasIcon))
                ) ;
		}
	}
}

