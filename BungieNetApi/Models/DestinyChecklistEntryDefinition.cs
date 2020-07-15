using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The properties of an individual checklist item. Note that almost everything is optional: it is *highly* variable what kind of data we'll actually be able to return: at times we may have no other relationships to entities at all.
    /// </summary>
    /// <summary>
    /// Whatever UI you build, do it with the knowledge that any given entry might not actually be able to be associated with some other Destiny entity.
    /// </summary>
    [DataContract]
    public class DestinyChecklistEntryDefinition
    {
        /// <summary>
        /// The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// Even if no other associations exist, we will give you *something* for display properties. In cases where we have no associated entities, it may be as simple as a numerical identifier.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        [DataMember(Name = "destinationHash", EmitDefaultValue = false)]
        public uint DestinationHash { get; set; }

        [DataMember(Name = "locationHash", EmitDefaultValue = false)]
        public uint LocationHash { get; set; }

        /// <summary>
        /// Note that a Bubble's hash doesn't uniquely identify a "top level" entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.
        /// </summary>
        /// <summary>
        /// You can use this property if it is populated to look up the DestinyLocationDefinition's associated .locationReleases[].activityBubbleName property.
        /// </summary>
        [DataMember(Name = "bubbleHash", EmitDefaultValue = false)]
        public uint BubbleHash { get; set; }

        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public uint VendorHash { get; set; }

        [DataMember(Name = "vendorInteractionIndex", EmitDefaultValue = false)]
        public long VendorInteractionIndex { get; set; }

        /// <summary>
        /// The scope at which this specific entry can be computed.
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public DestinyScope Scope { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyChecklistEntryDefinition);
        }

        public bool Equals(DestinyChecklistEntryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    DestinationHash == input.DestinationHash ||
                    (DestinationHash != null && DestinationHash.Equals(input.DestinationHash))
                ) &&
                (
                    LocationHash == input.LocationHash ||
                    (LocationHash != null && LocationHash.Equals(input.LocationHash))
                ) &&
                (
                    BubbleHash == input.BubbleHash ||
                    (BubbleHash != null && BubbleHash.Equals(input.BubbleHash))
                ) &&
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    VendorHash == input.VendorHash ||
                    (VendorHash != null && VendorHash.Equals(input.VendorHash))
                ) &&
                (
                    VendorInteractionIndex == input.VendorInteractionIndex ||
                    (VendorInteractionIndex != null && VendorInteractionIndex.Equals(input.VendorInteractionIndex))
                ) &&
                (
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) ;
        }
    }
}

