using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// All damage types that are possible in the game are defined here, along with localized info and icons as needed.
	/// </summary>
	[DataContract]
	public class DestinyDamageTypeDefinition{

		/// <summary>
		/// The description of the damage type, icon etc...
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// A variant of the icon that is transparent and colorless.
		/// </summary>
		[DataMember(Name="transparentIconPath", EmitDefaultValue=false)]
		public string TransparentIconPath { get; set; }

		/// <summary>
		/// If TRUE, the game shows this damage type's icon. Otherwise, it doesn't. Whether you show it or not is up to you.
		/// </summary>
		[DataMember(Name="showIcon", EmitDefaultValue=false)]
		public bool ShowIcon { get; set; }

		/// <summary>
		/// We have an enumeration for damage types for quick reference. This is the current definition's damage type enum value.
		/// </summary>
		[DataMember(Name="enumValue", EmitDefaultValue=false)]
		public DamageType EnumValue { get; set; }

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
            return this.Equals(input as DestinyDamageTypeDefinition);
        }

		public bool Equals(DestinyDamageTypeDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    TransparentIconPath == input.TransparentIconPath ||
                    (TransparentIconPath != null && TransparentIconPath.Equals(input.TransparentIconPath))
                ) &&
				(
                    ShowIcon == input.ShowIcon ||
                    (ShowIcon != null && ShowIcon.Equals(input.ShowIcon))
                ) &&
				(
                    EnumValue == input.EnumValue ||
                    (EnumValue != null && EnumValue.Equals(input.EnumValue))
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

