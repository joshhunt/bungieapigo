using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Stat Groups (DestinyStatGroupDefinition) has the ability to override the localized text associated with stats that are to be shown on the items with which they are associated.
	/// </summary>
	/// <summary>
	/// This defines a specific overridden stat. You could theoretically check these before rendering your stat UI, and for each stat that has an override show these displayProperties instead of those on the DestinyStatDefinition.
	/// </summary>
	/// <summary>
	/// Or you could be like us, and skip that for now because the game has yet to actually use this feature. But know that it's here, waiting for a resilliant young designer to take up the mantle and make us all look foolish by showing the wrong name for stats.
	/// </summary>
	/// <summary>
	/// Note that, if this gets used, the override will apply only to items using the overriding Stat Group. Other items will still show the default stat's name/description.
	/// </summary>
	[DataContract]
	public class DestinyStatOverrideDefinition{

		/// <summary>
		/// The hash identifier of the stat whose display properties are being overridden.
		/// </summary>
		[DataMember(Name="statHash", EmitDefaultValue=false)]
		public uint StatHash { get; set; }

		/// <summary>
		/// The display properties to show instead of the base DestinyStatDefinition display properties.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyStatOverrideDefinition);
        }

		public bool Equals(DestinyStatOverrideDefinition input)
		{
			if (input == null) return false;

			return
				(
                    StatHash == input.StatHash ||
                    (StatHash != null && StatHash.Equals(input.StatHash))
                ) &&
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) ;
		}
	}
}

