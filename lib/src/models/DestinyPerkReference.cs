using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The list of perks to display in an item tooltip - and whether or not they have been activated.
	/// Perks apply a variety of effects to a character, and are generally either intrinsic to the item or provided in activated talent nodes or sockets.
	[DataContract]
	public class DestinyPerkReference{

		/// <summary>
		/// The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk's definition before you show it to the user.
		/// </summary>
		[DataMember(Name="perkHash", EmitDefaultValue=false)]
		public uint PerkHash { get; set; }

		/// <summary>
		/// The icon for the perk.
		/// </summary>
		[DataMember(Name="iconPath", EmitDefaultValue=false)]
		public string IconPath { get; set; }

		/// <summary>
		/// Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item's tooltip, but that the user has not yet activated.)
		/// </summary>
		[DataMember(Name="isActive", EmitDefaultValue=false)]
		public bool IsActive { get; set; }

		/// <summary>
		/// Some perks provide benefits, but aren't visible in the UI. This value will let you know if this is perk should be shown in your UI.
		/// </summary>
		[DataMember(Name="visible", EmitDefaultValue=false)]
		public bool Visible { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPerkReference);
        }

		public bool Equals(DestinyPerkReference input)
		{
			if (input == null) return false;

			return
				(
                    PerkHash == input.PerkHash ||
                    (PerkHash != null && PerkHash.Equals(input.PerkHash))
                ) &&
				(
                    IconPath == input.IconPath ||
                    (IconPath != null && IconPath.Equals(input.IconPath))
                ) &&
				(
                    IsActive == input.IsActive ||
                    (IsActive != null && IsActive.Equals(input.IsActive))
                ) &&
				(
                    Visible == input.Visible ||
                    (Visible != null && Visible.Equals(input.Visible))
                ) ;
		}
	}
}

