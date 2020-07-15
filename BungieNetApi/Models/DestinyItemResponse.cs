using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn't have an "itemInstanceId": for those, get your information from the DestinyInventoryDefinition.
    /// </summary>
    [DataContract]
    public class DestinyItemResponse
    {
        /// <summary>
        /// If the item is on a character, this will return the ID of the character that is holding the item.
        /// </summary>
        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        /// <summary>
        /// Common data for the item relevant to its non-instanced properties.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemCommonData
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemComponent Item { get; set; }

        /// <summary>
        /// Basic instance data for the item.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemInstances
        /// </summary>
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemInstanceComponent Instance { get; set; }

        /// <summary>
        /// Information specifically about the item's objectives.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemObjectives
        /// </summary>
        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemObjectivesComponent Objectives { get; set; }

        /// <summary>
        /// Information specifically about the perks currently active on the item.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemPerks
        /// </summary>
        [DataMember(Name = "perks", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemPerksComponent Perks { get; set; }

        /// <summary>
        /// Information about how to render the item in 3D.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemRenderData
        /// </summary>
        [DataMember(Name = "renderData", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemRenderComponent RenderData { get; set; }

        /// <summary>
        /// Information about the computed stats of the item: power, defense, etc...
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemStats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemStatsComponent Stats { get; set; }

        /// <summary>
        /// Information about the talent grid attached to the item. Talent nodes can provide a variety of benefits and abilities, and in Destiny 2 are used almost exclusively for the character's "Builds".
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemTalentGrids
        /// </summary>
        [DataMember(Name = "talentGrid", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemTalentGridComponent TalentGrid { get; set; }

        /// <summary>
        /// Information about the sockets of the item: which are currently active, what potential sockets you could have and the stats/abilities/perks you can gain from them.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemSockets
        /// </summary>
        [DataMember(Name = "sockets", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemSocketsComponent Sockets { get; set; }

        /// <summary>
        /// Information about the Reusable Plugs for sockets on an item. These are plugs that you can insert into the given socket regardless of if you actually own an instance of that plug: they are logic-driven plugs rather than inventory-driven.
        /// </summary>
        /// <summary>
        ///  These may need to be combined with Plug Set component data to get a full picture of available plugs on a given socket.
        /// </summary>
        /// <summary>
        ///  COMPONENT TYPE: ItemReusablePlugs
        /// </summary>
        [DataMember(Name = "reusablePlugs", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

        /// <summary>
        /// Information about objectives on Plugs for a given item. See the component's documentation for more info.
        /// </summary>
        /// <summary>
        /// COMPONENT TYPE: ItemPlugObjectives
        /// </summary>
        [DataMember(Name = "plugObjectives", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemResponse);
        }

        public bool Equals(DestinyItemResponse input)
        {
            if (input == null) return false;

            return
                (
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
                (
                    Item == input.Item ||
                    (Item != null && Item.Equals(input.Item))
                ) &&
                (
                    Instance == input.Instance ||
                    (Instance != null && Instance.Equals(input.Instance))
                ) &&
                (
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.Equals(input.Objectives))
                ) &&
                (
                    Perks == input.Perks ||
                    (Perks != null && Perks.Equals(input.Perks))
                ) &&
                (
                    RenderData == input.RenderData ||
                    (RenderData != null && RenderData.Equals(input.RenderData))
                ) &&
                (
                    Stats == input.Stats ||
                    (Stats != null && Stats.Equals(input.Stats))
                ) &&
                (
                    TalentGrid == input.TalentGrid ||
                    (TalentGrid != null && TalentGrid.Equals(input.TalentGrid))
                ) &&
                (
                    Sockets == input.Sockets ||
                    (Sockets != null && Sockets.Equals(input.Sockets))
                ) &&
                (
                    ReusablePlugs == input.ReusablePlugs ||
                    (ReusablePlugs != null && ReusablePlugs.Equals(input.ReusablePlugs))
                ) &&
                (
                    PlugObjectives == input.PlugObjectives ||
                    (PlugObjectives != null && PlugObjectives.Equals(input.PlugObjectives))
                ) ;
        }
    }
}

