using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// The response for GetDestinyProfile, with components for character and item-level data.
    /// </summary>
    [DataContract]
    public class DestinyProfileResponse
    {
        /// <summary>
        /// Recent, refundable purchases you have made from vendors. When will you use it? Couldn't say...
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: VendorReceipts
        /// </summary>
        [DataMember(Name = "vendorReceipts", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; set; }

        /// <summary>
        /// The profile-level inventory of the Destiny Profile.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ProfileInventories
        /// </summary>
        [DataMember(Name = "profileInventory", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyInventoryComponent ProfileInventory { get; set; }

        /// <summary>
        /// The profile-level currencies owned by the Destiny Profile.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ProfileCurrencies
        /// </summary>
        [DataMember(Name = "profileCurrencies", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies { get; set; }

        /// <summary>
        /// The basic information about the Destiny Profile (formerly "Account").
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Profiles
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyProfileComponent Profile { get; set; }

        /// <summary>
        /// Silver quantities for any platform on which this Profile plays destiny.
        /// </summary>
        /// <summary>
        ///  COMPONENT TYPE: PlatformSilver
        /// </summary>
        [DataMember(Name = "platformSilver", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyPlatformSilverComponent PlatformSilver { get; set; }

        /// <summary>
        /// Items available from Kiosks that are available Profile-wide (i.e. across all characters)
        /// </summary>
        /// <summary>
        /// This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Kiosks
        /// </summary>
        [DataMember(Name = "profileKiosks", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks { get; set; }

        /// <summary>
        /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are profile-scoped.
        /// </summary>
        /// <summary>
        /// This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemSockets
        /// </summary>
        [DataMember(Name = "profilePlugSets", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyPlugSetsComponent ProfilePlugSets { get; set; }

        /// <summary>
        /// When we have progression information - such as Checklists - that may apply profile-wide, it will be returned here rather than in the per-character progression data.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ProfileProgression
        /// </summary>
        [DataMember(Name = "profileProgression", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyProfileProgressionComponent ProfileProgression { get; set; }

        /// <summary>
        /// COMPONENT TYPE: PresentationNodes
        /// </summary>
        [DataMember(Name = "profilePresentationNodes", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyPresentationNodesComponent ProfilePresentationNodes { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Records
        /// </summary>
        [DataMember(Name = "profileRecords", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyProfileRecordsComponent ProfileRecords { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        [DataMember(Name = "profileCollectibles", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyProfileCollectiblesComponent ProfileCollectibles { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Transitory
        /// </summary>
        [DataMember(Name = "profileTransitoryData", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyProfileTransitoryComponent ProfileTransitoryData { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Metrics
        /// </summary>
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyMetricsComponent Metrics { get; set; }

        /// <summary>
        /// Basic information about each character, keyed by the CharacterId.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Characters
        /// </summary>
        [DataMember(Name = "characters", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters { get; set; }

        /// <summary>
        /// The character-level non-equipped inventory items, keyed by the Character's Id.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterInventories
        /// </summary>
        [DataMember(Name = "characterInventories", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories { get; set; }

        /// <summary>
        /// Character-level progression data, keyed by the Character's Id.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterProgressions
        /// </summary>
        [DataMember(Name = "characterProgressions", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions { get; set; }

        /// <summary>
        /// Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character's Id.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterRenderData
        /// </summary>
        [DataMember(Name = "characterRenderData", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData { get; set; }

        /// <summary>
        /// Character activity data - the activities available to this character and its status, keyed by the Character's Id.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterActivities
        /// </summary>
        [DataMember(Name = "characterActivities", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities { get; set; }

        /// <summary>
        /// The character's equipped items, keyed by the Character's Id.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterEquipment
        /// </summary>
        [DataMember(Name = "characterEquipment", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment { get; set; }

        /// <summary>
        /// Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character's available items to check out of a kiosk.
        /// </summary>
        /// <summary>
        /// This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Kiosks
        /// </summary>
        [DataMember(Name = "characterKiosks", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks { get; set; }

        /// <summary>
        /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states, per character, that are character-scoped.
        /// </summary>
        /// <summary>
        /// This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemSockets
        /// </summary>
        [DataMember(Name = "characterPlugSets", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent CharacterPlugSets { get; set; }

        /// <summary>
        /// Do you ever get the feeling that a system was designed *too* flexibly? That it can be used in so many different ways that you end up being unable to provide an easy to use abstraction for the mess that's happening under the surface?
        /// </summary>
        /// <summary>
        /// Let's talk about character-specific data that might be related to items without instances. These two statements are totally unrelated, I promise.
        /// </summary>
        /// <summary>
        /// At some point during D2, it was decided that items - such as Bounties - could be given to characters and *not* have instance data, but that *could* display and even use relevant state information on your account and character.
        /// </summary>
        /// <summary>
        /// Up to now, any item that had meaningful dependencies on character or account state had to be instanced, and thus "itemComponents" was all that you needed: it was keyed by item's instance IDs and provided the stateful information you needed inside.
        /// </summary>
        /// <summary>
        /// Unfortunately, we don't live in such a magical world anymore. This is information held on a per-character basis about non-instanced items that the characters have in their inventory - or that reference character-specific state information even if it's in Account-level inventory - and the values related to that item's state in relation to the given character.
        /// </summary>
        /// <summary>
        /// To give a concrete example, look at a Moments of Triumph bounty. They exist in a character's inventory, and show/care about a character's progression toward completing the bounty. But the bounty itself is a non-instanced item, like a mod or a currency. This returns that data for the characters who have the bounty in their inventory.
        /// </summary>
        /// <summary>
        /// I'm not crying, you're crying Okay we're both crying but it's going to be okay I promise Actually I shouldn't promise that, I don't know if it's going to be okay
        /// </summary>
        [DataMember(Name = "characterUninstancedItemComponents", EmitDefaultValue = false)]
        public Dictionary<string, DestinyBaseItemComponentSetOfuint32> CharacterUninstancedItemComponents { get; set; }

        /// <summary>
        /// COMPONENT TYPE: PresentationNodes
        /// </summary>
        [DataMember(Name = "characterPresentationNodes", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent CharacterPresentationNodes { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Records
        /// </summary>
        [DataMember(Name = "characterRecords", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent CharacterRecords { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        [DataMember(Name = "characterCollectibles", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent CharacterCollectibles { get; set; }

        /// <summary>
        /// Information about instanced items across all returned characters, keyed by the item's instance ID.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        [DataMember(Name = "itemComponents", EmitDefaultValue = false)]
        public DestinyItemComponentSetOfint64 ItemComponents { get; set; }

        /// <summary>
        /// A "lookup" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CurrencyLookups
        /// </summary>
        [DataMember(Name = "characterCurrencyLookups", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent CharacterCurrencyLookups { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileResponse);
        }

        public bool Equals(DestinyProfileResponse input)
        {
            if (input == null) return false;

            return
                (
                    VendorReceipts == input.VendorReceipts ||
                    (VendorReceipts != null && VendorReceipts.Equals(input.VendorReceipts))
                ) &&
                (
                    ProfileInventory == input.ProfileInventory ||
                    (ProfileInventory != null && ProfileInventory.Equals(input.ProfileInventory))
                ) &&
                (
                    ProfileCurrencies == input.ProfileCurrencies ||
                    (ProfileCurrencies != null && ProfileCurrencies.Equals(input.ProfileCurrencies))
                ) &&
                (
                    Profile == input.Profile ||
                    (Profile != null && Profile.Equals(input.Profile))
                ) &&
                (
                    PlatformSilver == input.PlatformSilver ||
                    (PlatformSilver != null && PlatformSilver.Equals(input.PlatformSilver))
                ) &&
                (
                    ProfileKiosks == input.ProfileKiosks ||
                    (ProfileKiosks != null && ProfileKiosks.Equals(input.ProfileKiosks))
                ) &&
                (
                    ProfilePlugSets == input.ProfilePlugSets ||
                    (ProfilePlugSets != null && ProfilePlugSets.Equals(input.ProfilePlugSets))
                ) &&
                (
                    ProfileProgression == input.ProfileProgression ||
                    (ProfileProgression != null && ProfileProgression.Equals(input.ProfileProgression))
                ) &&
                (
                    ProfilePresentationNodes == input.ProfilePresentationNodes ||
                    (ProfilePresentationNodes != null && ProfilePresentationNodes.Equals(input.ProfilePresentationNodes))
                ) &&
                (
                    ProfileRecords == input.ProfileRecords ||
                    (ProfileRecords != null && ProfileRecords.Equals(input.ProfileRecords))
                ) &&
                (
                    ProfileCollectibles == input.ProfileCollectibles ||
                    (ProfileCollectibles != null && ProfileCollectibles.Equals(input.ProfileCollectibles))
                ) &&
                (
                    ProfileTransitoryData == input.ProfileTransitoryData ||
                    (ProfileTransitoryData != null && ProfileTransitoryData.Equals(input.ProfileTransitoryData))
                ) &&
                (
                    Metrics == input.Metrics ||
                    (Metrics != null && Metrics.Equals(input.Metrics))
                ) &&
                (
                    Characters == input.Characters ||
                    (Characters != null && Characters.Equals(input.Characters))
                ) &&
                (
                    CharacterInventories == input.CharacterInventories ||
                    (CharacterInventories != null && CharacterInventories.Equals(input.CharacterInventories))
                ) &&
                (
                    CharacterProgressions == input.CharacterProgressions ||
                    (CharacterProgressions != null && CharacterProgressions.Equals(input.CharacterProgressions))
                ) &&
                (
                    CharacterRenderData == input.CharacterRenderData ||
                    (CharacterRenderData != null && CharacterRenderData.Equals(input.CharacterRenderData))
                ) &&
                (
                    CharacterActivities == input.CharacterActivities ||
                    (CharacterActivities != null && CharacterActivities.Equals(input.CharacterActivities))
                ) &&
                (
                    CharacterEquipment == input.CharacterEquipment ||
                    (CharacterEquipment != null && CharacterEquipment.Equals(input.CharacterEquipment))
                ) &&
                (
                    CharacterKiosks == input.CharacterKiosks ||
                    (CharacterKiosks != null && CharacterKiosks.Equals(input.CharacterKiosks))
                ) &&
                (
                    CharacterPlugSets == input.CharacterPlugSets ||
                    (CharacterPlugSets != null && CharacterPlugSets.Equals(input.CharacterPlugSets))
                ) &&
                (
                    CharacterUninstancedItemComponents == input.CharacterUninstancedItemComponents ||
                    (CharacterUninstancedItemComponents != null && CharacterUninstancedItemComponents.SequenceEqual(input.CharacterUninstancedItemComponents))
                ) &&
                (
                    CharacterPresentationNodes == input.CharacterPresentationNodes ||
                    (CharacterPresentationNodes != null && CharacterPresentationNodes.Equals(input.CharacterPresentationNodes))
                ) &&
                (
                    CharacterRecords == input.CharacterRecords ||
                    (CharacterRecords != null && CharacterRecords.Equals(input.CharacterRecords))
                ) &&
                (
                    CharacterCollectibles == input.CharacterCollectibles ||
                    (CharacterCollectibles != null && CharacterCollectibles.Equals(input.CharacterCollectibles))
                ) &&
                (
                    ItemComponents == input.ItemComponents ||
                    (ItemComponents != null && ItemComponents.Equals(input.ItemComponents))
                ) &&
                (
                    CharacterCurrencyLookups == input.CharacterCurrencyLookups ||
                    (CharacterCurrencyLookups != null && CharacterCurrencyLookups.Equals(input.CharacterCurrencyLookups))
                ) ;
        }
    }
}

