using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// If an item is a Plug, its DestinyInventoryItemDefinition.plug property will be populated with an instance of one of these bad boys.
	/// </summary>
	/// <summary>
	/// This gives information about when it can be inserted, what the plug's category is (and thus whether it is compatible with a socket... see DestinySocketTypeDefinition for information about Plug Categories and socket compatibility), whether it is enabled and other Plug info.
	/// </summary>
	[DataContract]
	public class DestinyItemPlugDefinition{

		/// <summary>
		/// The rules around when this plug can be inserted into a socket, aside from the socket's individual restrictions.
		/// </summary>
		/// <summary>
		/// The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
		/// </summary>
		[DataMember(Name="insertionRules", EmitDefaultValue=false)]
		public List<DestinyPlugRuleDefinition> InsertionRules { get; set; }

		/// <summary>
		/// The string identifier for the plug's category. Use the socket's DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket.
		/// </summary>
		[DataMember(Name="plugCategoryIdentifier", EmitDefaultValue=false)]
		public string PlugCategoryIdentifier { get; set; }

		/// <summary>
		/// The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes.
		/// </summary>
		[DataMember(Name="plugCategoryHash", EmitDefaultValue=false)]
		public uint PlugCategoryHash { get; set; }

		/// <summary>
		/// If you successfully socket the item, this will determine whether or not you get "refunded" on the plug.
		/// </summary>
		[DataMember(Name="onActionRecreateSelf", EmitDefaultValue=false)]
		public bool OnActionRecreateSelf { get; set; }

		/// <summary>
		/// If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.
		/// </summary>
		[DataMember(Name="insertionMaterialRequirementHash", EmitDefaultValue=false)]
		public uint InsertionMaterialRequirementHash { get; set; }

		/// <summary>
		/// In the game, if you're inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.
		/// </summary>
		[DataMember(Name="previewItemOverrideHash", EmitDefaultValue=false)]
		public uint PreviewItemOverrideHash { get; set; }

		/// <summary>
		/// It's not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.
		/// </summary>
		[DataMember(Name="enabledMaterialRequirementHash", EmitDefaultValue=false)]
		public uint EnabledMaterialRequirementHash { get; set; }

		/// <summary>
		/// The rules around whether the plug, once inserted, is enabled and providing its benefits.
		/// </summary>
		/// <summary>
		/// The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
		/// </summary>
		[DataMember(Name="enabledRules", EmitDefaultValue=false)]
		public List<DestinyPlugRuleDefinition> EnabledRules { get; set; }

		/// <summary>
		/// Plugs can have arbitrary, UI-defined identifiers that the UI designers use to determine the style applied to plugs. Unfortunately, we have neither a definitive list of these labels nor advance warning of when new labels might be applied or how that relates to how they get rendered. If you want to, you can refer to known labels to change your own styles: but know that new ones can be created arbitrarily, and we have no way of associating the labels with any specific UI style guidance... you'll have to piece that together on your end. Or do what we do, and just show plugs more generically, without specialized styles.
		/// </summary>
		[DataMember(Name="uiPlugLabel", EmitDefaultValue=false)]
		public string UiPlugLabel { get; set; }

		[DataMember(Name="plugStyle", EmitDefaultValue=false)]
		public PlugUiStyles PlugStyle { get; set; }

		/// <summary>
		/// Indicates the rules about when this plug can be used. See the PlugAvailabilityMode enumeration for more information!
		/// </summary>
		[DataMember(Name="plugAvailability", EmitDefaultValue=false)]
		public PlugAvailabilityMode PlugAvailability { get; set; }

		/// <summary>
		/// If the plug meets certain state requirements, it may have an alternative label applied to it. This is the alternative label that will be applied in such a situation.
		/// </summary>
		[DataMember(Name="alternateUiPlugLabel", EmitDefaultValue=false)]
		public string AlternateUiPlugLabel { get; set; }

		/// <summary>
		/// The alternate plug of the plug: only applies when the item is in states that only the server can know about and control, unfortunately. See AlternateUiPlugLabel for the related label info.
		/// </summary>
		[DataMember(Name="alternatePlugStyle", EmitDefaultValue=false)]
		public PlugUiStyles AlternatePlugStyle { get; set; }

		/// <summary>
		/// If TRUE, this plug is used for UI display purposes only, and doesn't have any interesting effects of its own.
		/// </summary>
		[DataMember(Name="isDummyPlug", EmitDefaultValue=false)]
		public bool IsDummyPlug { get; set; }

		/// <summary>
		/// Do you ever get the feeling that a system has become so overburdened by edge cases that it probably should have become some other system entirely? So do I!
		/// </summary>
		/// <summary>
		/// In totally unrelated news, Plugs can now override properties of their parent items. This is some of the relevant definition data for those overrides.
		/// </summary>
		/// <summary>
		/// If this is populated, it will have the override data to be applied when this plug is applied to an item.
		/// </summary>
		[DataMember(Name="parentItemOverride", EmitDefaultValue=false)]
		public DestinyParentItemOverride ParentItemOverride { get; set; }

		/// <summary>
		/// IF not null, this plug provides Energy capacity to the item in which it is socketed. In Armor 2.0 for example, is implemented in a similar way to Masterworks, where visually it's a single area of the UI being clicked on to "Upgrade" to higher energy levels, but it's actually socketing new plugs.
		/// </summary>
		[DataMember(Name="energyCapacity", EmitDefaultValue=false)]
		public DestinyEnergyCapacityEntry EnergyCapacity { get; set; }

		/// <summary>
		/// IF not null, this plug has an energy cost. This contains the details of that cost.
		/// </summary>
		[DataMember(Name="energyCost", EmitDefaultValue=false)]
		public DestinyEnergyCostEntry EnergyCost { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemPlugDefinition);
        }

		public bool Equals(DestinyItemPlugDefinition input)
		{
			if (input == null) return false;

			return
				(
                    InsertionRules == input.InsertionRules ||
                    (InsertionRules != null && InsertionRules.Equals(input.InsertionRules))
                ) &&
				(
                    PlugCategoryIdentifier == input.PlugCategoryIdentifier ||
                    (PlugCategoryIdentifier != null && PlugCategoryIdentifier.Equals(input.PlugCategoryIdentifier))
                ) &&
				(
                    PlugCategoryHash == input.PlugCategoryHash ||
                    (PlugCategoryHash != null && PlugCategoryHash.Equals(input.PlugCategoryHash))
                ) &&
				(
                    OnActionRecreateSelf == input.OnActionRecreateSelf ||
                    (OnActionRecreateSelf != null && OnActionRecreateSelf.Equals(input.OnActionRecreateSelf))
                ) &&
				(
                    InsertionMaterialRequirementHash == input.InsertionMaterialRequirementHash ||
                    (InsertionMaterialRequirementHash != null && InsertionMaterialRequirementHash.Equals(input.InsertionMaterialRequirementHash))
                ) &&
				(
                    PreviewItemOverrideHash == input.PreviewItemOverrideHash ||
                    (PreviewItemOverrideHash != null && PreviewItemOverrideHash.Equals(input.PreviewItemOverrideHash))
                ) &&
				(
                    EnabledMaterialRequirementHash == input.EnabledMaterialRequirementHash ||
                    (EnabledMaterialRequirementHash != null && EnabledMaterialRequirementHash.Equals(input.EnabledMaterialRequirementHash))
                ) &&
				(
                    EnabledRules == input.EnabledRules ||
                    (EnabledRules != null && EnabledRules.Equals(input.EnabledRules))
                ) &&
				(
                    UiPlugLabel == input.UiPlugLabel ||
                    (UiPlugLabel != null && UiPlugLabel.Equals(input.UiPlugLabel))
                ) &&
				(
                    PlugStyle == input.PlugStyle ||
                    (PlugStyle != null && PlugStyle.Equals(input.PlugStyle))
                ) &&
				(
                    PlugAvailability == input.PlugAvailability ||
                    (PlugAvailability != null && PlugAvailability.Equals(input.PlugAvailability))
                ) &&
				(
                    AlternateUiPlugLabel == input.AlternateUiPlugLabel ||
                    (AlternateUiPlugLabel != null && AlternateUiPlugLabel.Equals(input.AlternateUiPlugLabel))
                ) &&
				(
                    AlternatePlugStyle == input.AlternatePlugStyle ||
                    (AlternatePlugStyle != null && AlternatePlugStyle.Equals(input.AlternatePlugStyle))
                ) &&
				(
                    IsDummyPlug == input.IsDummyPlug ||
                    (IsDummyPlug != null && IsDummyPlug.Equals(input.IsDummyPlug))
                ) &&
				(
                    ParentItemOverride == input.ParentItemOverride ||
                    (ParentItemOverride != null && ParentItemOverride.Equals(input.ParentItemOverride))
                ) &&
				(
                    EnergyCapacity == input.EnergyCapacity ||
                    (EnergyCapacity != null && EnergyCapacity.Equals(input.EnergyCapacity))
                ) &&
				(
                    EnergyCost == input.EnergyCost ||
                    (EnergyCost != null && EnergyCost.Equals(input.EnergyCost))
                ) ;
		}
	}
}

