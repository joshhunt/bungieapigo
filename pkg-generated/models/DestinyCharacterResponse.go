package bungieapigo

// The response contract for GetDestinyCharacter, with components that can be returned for
// character and item-level data.
type DestinyCharacterResponse struct {

    // The character-level non-equipped inventory items.
    // COMPONENT TYPE: CharacterInventories
    Inventory SingleComponentResponseOfDestinyInventoryComponent `json:"inventory"`


    // Base information about the character in question.
    // COMPONENT TYPE: Characters
    Character SingleComponentResponseOfDestinyCharacterComponent `json:"character"`


    // Character progression data, including Milestones.
    // COMPONENT TYPE: CharacterProgressions
    Progressions SingleComponentResponseOfDestinyCharacterProgressionComponent `json:"progressions"`


    // Character rendering data - a minimal set of information about equipment and dyes used for
    // rendering.
    // COMPONENT TYPE: CharacterRenderData
    RenderData SingleComponentResponseOfDestinyCharacterRenderComponent `json:"renderData"`


    // Activity data - info about current activities available to the player.
    // COMPONENT TYPE: CharacterActivities
    Activities SingleComponentResponseOfDestinyCharacterActivitiesComponent `json:"activities"`


    // Equipped items on the character.
    // COMPONENT TYPE: CharacterEquipment
    Equipment SingleComponentResponseOfDestinyInventoryComponent `json:"equipment"`


    // Items available from Kiosks that are available to this specific character. 
    // COMPONENT TYPE: Kiosks
    Kiosks SingleComponentResponseOfDestinyKiosksComponent `json:"kiosks"`


    // When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this
    // is the set of plugs and their states that are scoped to this character.
    // This comes back with ItemSockets, as it is needed for a complete picture of the sockets on
    // requested items.
    // COMPONENT TYPE: ItemSockets
    PlugSets SingleComponentResponseOfDestinyPlugSetsComponent `json:"plugSets"`


    // COMPONENT TYPE: PresentationNodes
    PresentationNodes SingleComponentResponseOfDestinyPresentationNodesComponent `json:"presentationNodes"`


    // COMPONENT TYPE: Records
    Records SingleComponentResponseOfDestinyCharacterRecordsComponent `json:"records"`


    // COMPONENT TYPE: Collectibles
    Collectibles SingleComponentResponseOfDestinyCollectiblesComponent `json:"collectibles"`


    // The set of components belonging to the player's instanced items.
    // COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
    ItemComponents DestinyItemComponentSetOfint64 `json:"itemComponents"`


    // The set of components belonging to the player's UNinstanced items. Because apparently now
    // those too can have information relevant to the character's state.
    // COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
    UninstancedItemComponents DestinyBaseItemComponentSetOfuint32 `json:"uninstancedItemComponents"`


    // A "lookup" convenience component that can be used to quickly check if the character has access
    // to items that can be used for purchasing.
    // COMPONENT TYPE: CurrencyLookups
    CurrencyLookups SingleComponentResponseOfDestinyCurrenciesComponent `json:"currencyLookups"`

}

