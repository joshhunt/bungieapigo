using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Raw data about the customization options chosen for a character's face and appearance.
	/// </summary>
	/// <summary>
	/// You can look up the relevant class/race/gender combo in DestinyCharacterCustomizationOptionDefinition for the character, and then look up these values within the CustomizationOptions found to pull some data about their choices. Warning: not all of that data is meaningful. Some data has useful icons. Others have nothing, and are only meant for 3D rendering purposes (which we sadly do not expose yet)
	/// </summary>
	[DataContract]
	public class DestinyCharacterCustomization{

		[DataMember(Name="personality", EmitDefaultValue=false)]
		public uint Personality { get; set; }

		[DataMember(Name="face", EmitDefaultValue=false)]
		public uint Face { get; set; }

		[DataMember(Name="skinColor", EmitDefaultValue=false)]
		public uint SkinColor { get; set; }

		[DataMember(Name="lipColor", EmitDefaultValue=false)]
		public uint LipColor { get; set; }

		[DataMember(Name="eyeColor", EmitDefaultValue=false)]
		public uint EyeColor { get; set; }

		[DataMember(Name="hairColors", EmitDefaultValue=false)]
		public List<uint> HairColors { get; set; }

		[DataMember(Name="featureColors", EmitDefaultValue=false)]
		public List<uint> FeatureColors { get; set; }

		[DataMember(Name="decalColor", EmitDefaultValue=false)]
		public uint DecalColor { get; set; }

		[DataMember(Name="wearHelmet", EmitDefaultValue=false)]
		public bool WearHelmet { get; set; }

		[DataMember(Name="hairIndex", EmitDefaultValue=false)]
		public long HairIndex { get; set; }

		[DataMember(Name="featureIndex", EmitDefaultValue=false)]
		public long FeatureIndex { get; set; }

		[DataMember(Name="decalIndex", EmitDefaultValue=false)]
		public long DecalIndex { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterCustomization);
        }

		public bool Equals(DestinyCharacterCustomization input)
		{
			if (input == null) return false;

			return
				(
                    Personality == input.Personality ||
                    (Personality != null && Personality.Equals(input.Personality))
                ) &&
				(
                    Face == input.Face ||
                    (Face != null && Face.Equals(input.Face))
                ) &&
				(
                    SkinColor == input.SkinColor ||
                    (SkinColor != null && SkinColor.Equals(input.SkinColor))
                ) &&
				(
                    LipColor == input.LipColor ||
                    (LipColor != null && LipColor.Equals(input.LipColor))
                ) &&
				(
                    EyeColor == input.EyeColor ||
                    (EyeColor != null && EyeColor.Equals(input.EyeColor))
                ) &&
				(
                    HairColors == input.HairColors ||
                    (HairColors != null && HairColors.Equals(input.HairColors))
                ) &&
				(
                    FeatureColors == input.FeatureColors ||
                    (FeatureColors != null && FeatureColors.Equals(input.FeatureColors))
                ) &&
				(
                    DecalColor == input.DecalColor ||
                    (DecalColor != null && DecalColor.Equals(input.DecalColor))
                ) &&
				(
                    WearHelmet == input.WearHelmet ||
                    (WearHelmet != null && WearHelmet.Equals(input.WearHelmet))
                ) &&
				(
                    HairIndex == input.HairIndex ||
                    (HairIndex != null && HairIndex.Equals(input.HairIndex))
                ) &&
				(
                    FeatureIndex == input.FeatureIndex ||
                    (FeatureIndex != null && FeatureIndex.Equals(input.FeatureIndex))
                ) &&
				(
                    DecalIndex == input.DecalIndex ||
                    (DecalIndex != null && DecalIndex.Equals(input.DecalIndex))
                ) ;
		}
	}
}

