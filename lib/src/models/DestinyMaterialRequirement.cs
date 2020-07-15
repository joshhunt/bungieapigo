using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Many actions relating to items require you to expend materials: - Activating a talent node - Inserting a plug into a socket The items will refer to material requirements by a materialRequirementsHash in these cases, and this is the definition for those requirements in terms of the item required, how much of it is required and other interesting info. This is one of the rare&#x2F;strange times where a single contract class is used both in definitions *and* in live data response contracts. I&#39;m not sure yet whether I regret that.
	[DataContract]
	public class DestinyMaterialRequirement{

		/// <summary>
		/// The hash identifier of the material required. Use it to look up the material's DestinyInventoryItemDefinition.
		/// </summary>
		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }

		/// <summary>
		/// If True, the material will be removed from the character's inventory when the action is performed.
		/// </summary>
		[DataMember(Name="deleteOnAction", EmitDefaultValue=false)]
		public bool DeleteOnAction { get; set; }

		/// <summary>
		/// The amount of the material required.
		/// </summary>
		[DataMember(Name="count", EmitDefaultValue=false)]
		public long Count { get; set; }

		/// <summary>
		/// If True, this requirement is "silent": don't bother showing it in a material requirements display. I mean, I'm not your mom: I'm not going to tell you you *can't* show it. But we won't show it in our UI.
		/// </summary>
		[DataMember(Name="omitFromRequirements", EmitDefaultValue=false)]
		public bool OmitFromRequirements { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMaterialRequirement);
        }

		public bool Equals(DestinyMaterialRequirement input)
		{
			if (input == null) return false;

			return
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
				(
                    DeleteOnAction == input.DeleteOnAction ||
                    (DeleteOnAction != null && DeleteOnAction.Equals(input.DeleteOnAction))
                ) &&
				(
                    Count == input.Count ||
                    (Count != null && Count.Equals(input.Count))
                ) &&
				(
                    OmitFromRequirements == input.OmitFromRequirements ||
                    (OmitFromRequirements != null && OmitFromRequirements.Equals(input.OmitFromRequirements))
                ) ;
		}
	}
}

