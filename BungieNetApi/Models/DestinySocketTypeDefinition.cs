using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// All Sockets have a "Type": a set of common properties that determine when the socket allows Plugs to be inserted, what Categories of Plugs can be inserted, and whether the socket is even visible at all given the current game/character/account state.
	/// </summary>
	/// <summary>
	/// See DestinyInventoryItemDefinition for more information about Socketed items and Plugs.
	/// </summary>
	[DataContract]
	public class DestinySocketTypeDefinition{

		/// <summary>
		/// There are fields for this display data, but they appear to be unpopulated as of now. I am not sure where in the UI these would show if they even were populated, but I will continue to return this data in case it becomes useful.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// Defines what happens when a plug is inserted into sockets of this type.
		/// </summary>
		[DataMember(Name="insertAction", EmitDefaultValue=false)]
		public DestinyInsertPlugActionDefinition InsertAction { get; set; }

		/// <summary>
		/// A list of Plug "Categories" that are allowed to be plugged into sockets of this type.
		/// </summary>
		/// <summary>
		/// These should be compared against a given plug item's DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item's category.
		/// </summary>
		/// <summary>
		/// If the plug's category matches any whitelisted plug, or if the whitelist is empty, it is allowed to be inserted.
		/// </summary>
		[DataMember(Name="plugWhitelist", EmitDefaultValue=false)]
		public List<DestinyPlugWhitelistEntryDefinition> PlugWhitelist { get; set; }

		[DataMember(Name="socketCategoryHash", EmitDefaultValue=false)]
		public uint SocketCategoryHash { get; set; }

		/// <summary>
		/// Sometimes a socket isn't visible. These are some of the conditions under which sockets of this type are not visible. Unfortunately, the truth of visibility is much, much more complex. Best to rely on the live data for whether the socket is visible and enabled.
		/// </summary>
		[DataMember(Name="visibility", EmitDefaultValue=false)]
		public DestinySocketVisibility Visibility { get; set; }

		[DataMember(Name="alwaysRandomizeSockets", EmitDefaultValue=false)]
		public bool AlwaysRandomizeSockets { get; set; }

		[DataMember(Name="isPreviewEnabled", EmitDefaultValue=false)]
		public bool IsPreviewEnabled { get; set; }

		[DataMember(Name="hideDuplicateReusablePlugs", EmitDefaultValue=false)]
		public bool HideDuplicateReusablePlugs { get; set; }

		/// <summary>
		/// This property indicates if the socket type determines whether Emblem icons and nameplates should be overridden by the inserted plug item's icon and nameplate.
		/// </summary>
		[DataMember(Name="overridesUiAppearance", EmitDefaultValue=false)]
		public bool OverridesUiAppearance { get; set; }

		[DataMember(Name="avoidDuplicatesOnInitialization", EmitDefaultValue=false)]
		public bool AvoidDuplicatesOnInitialization { get; set; }

		[DataMember(Name="currencyScalars", EmitDefaultValue=false)]
		public List<DestinySocketTypeScalarMaterialRequirementEntry> CurrencyScalars { get; set; }

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
            return this.Equals(input as DestinySocketTypeDefinition);
        }

		public bool Equals(DestinySocketTypeDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    InsertAction == input.InsertAction ||
                    (InsertAction != null && InsertAction.Equals(input.InsertAction))
                ) &&
				(
                    PlugWhitelist == input.PlugWhitelist ||
                    (PlugWhitelist != null && PlugWhitelist.Equals(input.PlugWhitelist))
                ) &&
				(
                    SocketCategoryHash == input.SocketCategoryHash ||
                    (SocketCategoryHash != null && SocketCategoryHash.Equals(input.SocketCategoryHash))
                ) &&
				(
                    Visibility == input.Visibility ||
                    (Visibility != null && Visibility.Equals(input.Visibility))
                ) &&
				(
                    AlwaysRandomizeSockets == input.AlwaysRandomizeSockets ||
                    (AlwaysRandomizeSockets != null && AlwaysRandomizeSockets.Equals(input.AlwaysRandomizeSockets))
                ) &&
				(
                    IsPreviewEnabled == input.IsPreviewEnabled ||
                    (IsPreviewEnabled != null && IsPreviewEnabled.Equals(input.IsPreviewEnabled))
                ) &&
				(
                    HideDuplicateReusablePlugs == input.HideDuplicateReusablePlugs ||
                    (HideDuplicateReusablePlugs != null && HideDuplicateReusablePlugs.Equals(input.HideDuplicateReusablePlugs))
                ) &&
				(
                    OverridesUiAppearance == input.OverridesUiAppearance ||
                    (OverridesUiAppearance != null && OverridesUiAppearance.Equals(input.OverridesUiAppearance))
                ) &&
				(
                    AvoidDuplicatesOnInitialization == input.AvoidDuplicatesOnInitialization ||
                    (AvoidDuplicatesOnInitialization != null && AvoidDuplicatesOnInitialization.Equals(input.AvoidDuplicatesOnInitialization))
                ) &&
				(
                    CurrencyScalars == input.CurrencyScalars ||
                    (CurrencyScalars != null && CurrencyScalars.Equals(input.CurrencyScalars))
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

