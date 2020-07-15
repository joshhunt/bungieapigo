using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Human readable data about the bubble. Combine with DestinyBubbleDefinition - see DestinyDestinationDefinition.bubbleSettings for more information.
	/// </summary>
	/// <summary>
	/// DEPRECATED - Just use bubbles.
	/// </summary>
	[DataContract]
	public class DestinyDestinationBubbleSettingDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyDestinationBubbleSettingDefinition);
        }

		public bool Equals(DestinyDestinationBubbleSettingDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) ;
		}
	}
}

