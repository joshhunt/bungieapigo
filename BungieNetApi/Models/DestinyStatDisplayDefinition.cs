using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Describes the way that an Item Stat (see DestinyStatDefinition) is transformed using the DestinyStatGroupDefinition related to that item. See both of the aforementioned definitions for more information about the stages of stat transformation.
	/// </summary>
	/// <summary>
	/// This represents the transformation of a stat into a "Display" stat (the closest value that BNet can get to the in-game display value of the stat)
	/// </summary>
	[DataContract]
	public class DestinyStatDisplayDefinition{

		/// <summary>
		/// The hash identifier for the stat being transformed into a Display stat.
		/// </summary>
		/// <summary>
		/// Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition's stats property.
		/// </summary>
		[DataMember(Name="statHash", EmitDefaultValue=false)]
		public uint StatHash { get; set; }

		/// <summary>
		/// Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0)
		/// </summary>
		[DataMember(Name="maximumValue", EmitDefaultValue=false)]
		public long MaximumValue { get; set; }

		/// <summary>
		/// If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There's no displayAsNumeric police.
		/// </summary>
		[DataMember(Name="displayAsNumeric", EmitDefaultValue=false)]
		public bool DisplayAsNumeric { get; set; }

		/// <summary>
		/// The interpolation table representing how the Investment Stat is transformed into a Display Stat. 
		/// </summary>
		/// <summary>
		/// See DestinyStatDefinition for a description of the stages of stat transformation.
		/// </summary>
		[DataMember(Name="displayInterpolation", EmitDefaultValue=false)]
		public List<InterpolationPoint> DisplayInterpolation { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyStatDisplayDefinition);
        }

		public bool Equals(DestinyStatDisplayDefinition input)
		{
			if (input == null) return false;

			return
				(
                    StatHash == input.StatHash ||
                    (StatHash != null && StatHash.Equals(input.StatHash))
                ) &&
				(
                    MaximumValue == input.MaximumValue ||
                    (MaximumValue != null && MaximumValue.Equals(input.MaximumValue))
                ) &&
				(
                    DisplayAsNumeric == input.DisplayAsNumeric ||
                    (DisplayAsNumeric != null && DisplayAsNumeric.Equals(input.DisplayAsNumeric))
                ) &&
				(
                    DisplayInterpolation == input.DisplayInterpolation ||
                    (DisplayInterpolation != null && DisplayInterpolation.Equals(input.DisplayInterpolation))
                ) ;
		}
	}
}

