using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The response contract for GetDestinyCharacter, with components that can be returned for character and item-level data.
    /// </summary>
    [DataContract]
    public class DestinyCharacterResponse
    {
        /// <summary>
        /// The character-level non-equipped inventory items.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterInventories
        /// </summary>
        [DataMember(Name = "inventory", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyInventoryComponent Inventory { get; set; }

        /// <summary>
        /// Base information about the character in question.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Characters
        /// </summary>
        [DataMember(Name = "character", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCharacterComponent Character { get; set; }

        /// <summary>
        /// Character progression data, including Milestones.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterProgressions
        /// </summary>
        [DataMember(Name = "progressions", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCharacterProgressionComponent Progressions { get; set; }

        /// <summary>
        /// Character rendering data - a minimal set of information about equipment and dyes used for rendering.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterRenderData
        /// </summary>
        [DataMember(Name = "renderData", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCharacterRenderComponent RenderData { get; set; }

        /// <summary>
        /// Activity data - info about current activities available to the player.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterActivities
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCharacterActivitiesComponent Activities { get; set; }

        /// <summary>
        /// Equipped items on the character.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CharacterEquipment
        /// </summary>
        [DataMember(Name = "equipment", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyInventoryComponent Equipment { get; set; }

        /// <summary>
        /// Items available from Kiosks that are available to this specific character. 
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: Kiosks
        /// </summary>
        [DataMember(Name = "kiosks", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyKiosksComponent Kiosks { get; set; }

        /// <summary>
        /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are scoped to this character.
        /// </summary>
        /// <summary>
        /// This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemSockets
        /// </summary>
        [DataMember(Name = "plugSets", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyPlugSetsComponent PlugSets { get; set; }

        /// <summary>
        /// COMPONENT TYPE: PresentationNodes
        /// </summary>
        [DataMember(Name = "presentationNodes", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyPresentationNodesComponent PresentationNodes { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCharacterRecordsComponent Records { get; set; }

        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        [DataMember(Name = "collectibles", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }

        /// <summary>
        /// The set of components belonging to the player's instanced items.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        [DataMember(Name = "itemComponents", EmitDefaultValue = false)]
        public DestinyItemComponentSetOfint64 ItemComponents { get; set; }

        /// <summary>
        /// The set of components belonging to the player's UNinstanced items. Because apparently now those too can have information relevant to the character's state.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        [DataMember(Name = "uninstancedItemComponents", EmitDefaultValue = false)]
        public DestinyBaseItemComponentSetOfuint32 UninstancedItemComponents { get; set; }

        /// <summary>
        /// A "lookup" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: CurrencyLookups
        /// </summary>
        [DataMember(Name = "currencyLookups", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterResponse);
        }

        public bool Equals(DestinyCharacterResponse input)
        {
            if (input == null) return false;

            return
                (
                    Inventory == input.Inventory ||
                    (Inventory != null && Inventory.Equals(input.Inventory))
                ) &&
                (
                    Character == input.Character ||
                    (Character != null && Character.Equals(input.Character))
                ) &&
                (
                    Progressions == input.Progressions ||
                    (Progressions != null && Progressions.Equals(input.Progressions))
                ) &&
                (
                    RenderData == input.RenderData ||
                    (RenderData != null && RenderData.Equals(input.RenderData))
                ) &&
                (
                    Activities == input.Activities ||
                    (Activities != null && Activities.Equals(input.Activities))
                ) &&
                (
                    Equipment == input.Equipment ||
                    (Equipment != null && Equipment.Equals(input.Equipment))
                ) &&
                (
                    Kiosks == input.Kiosks ||
                    (Kiosks != null && Kiosks.Equals(input.Kiosks))
                ) &&
                (
                    PlugSets == input.PlugSets ||
                    (PlugSets != null && PlugSets.Equals(input.PlugSets))
                ) &&
                (
                    PresentationNodes == input.PresentationNodes ||
                    (PresentationNodes != null && PresentationNodes.Equals(input.PresentationNodes))
                ) &&
                (
                    Records == input.Records ||
                    (Records != null && Records.Equals(input.Records))
                ) &&
                (
                    Collectibles == input.Collectibles ||
                    (Collectibles != null && Collectibles.Equals(input.Collectibles))
                ) &&
                (
                    ItemComponents == input.ItemComponents ||
                    (ItemComponents != null && ItemComponents.Equals(input.ItemComponents))
                ) &&
                (
                    UninstancedItemComponents == input.UninstancedItemComponents ||
                    (UninstancedItemComponents != null && UninstancedItemComponents.Equals(input.UninstancedItemComponents))
                ) &&
                (
                    CurrencyLookups == input.CurrencyLookups ||
                    (CurrencyLookups != null && CurrencyLookups.Equals(input.CurrencyLookups))
                ) ;
        }
    }
}

