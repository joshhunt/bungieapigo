using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// The time has unfortunately come to talk about Talent Grids.
	/// </summary>
	/// <summary>
	/// Talent Grids are the most complex and unintuitive part of the Destiny Definition data. Grab a cup of coffee before we begin, I can wait.
	/// </summary>
	/// <summary>
	/// Talent Grids were the primary way that items could be customized in Destiny 1. In Destiny 2, for now, talent grids have become exclusively used by Subclass/Build items: but the system is still in place for it to be used by items should the direction change back toward talent grids.
	/// </summary>
	/// <summary>
	/// Talent Grids have Nodes: the visual circles on the talent grid detail screen that have icons and can be activated if you meet certain requirements and pay costs. The actual visual data and effects, however, are driven by the "Steps" on Talent Nodes. Any given node will have 1:M of these steps, and the specific step that will be considered the "current" step (and thus the dictator of all benefits, visual state, and activation requirements on the Node) will almost always not be determined until an instance of the item is created. This is how, in Destiny 1, items were able to have such a wide variety of what users saw as "Perks": they were actually Talent Grids with nodes that had a wide variety of Steps, randomly chosen at the time of item creation.
	/// </summary>
	/// <summary>
	/// Now that Talent Grids are used exclusively by subclasses and builds, all of the properties within still apply: but there are additional visual elements on the Subclass/Build screens that are superimposed on top of the talent nodes. Unfortunately, BNet doesn't have this data: if you want to build a subclass screen, you will have to provide your own "decorative" assets, such as the visual connectors between nodes and the fancy colored-fire-bathed character standing behind the nodes.
	/// </summary>
	/// <summary>
	/// DestinyInventoryItem.talentGrid.talentGridHash defines an item's linked Talent Grid, which brings you to this definition that contains enough satic data about talent grids to make your head spin. These *must* be combined with instanced data - found when live data returns DestinyItemTalentGridComponent - in order to derive meaning. The instanced data will reference nodes and steps within these definitions, which you will then have to look up in the definition and combine with the instanced data to give the user the visual representation of their item's talent grid.
	/// </summary>
	[DataContract]
	public class DestinyTalentGridDefinition{

		/// <summary>
		/// The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated.
		/// </summary>
		[DataMember(Name="maxGridLevel", EmitDefaultValue=false)]
		public long MaxGridLevel { get; set; }

		/// <summary>
		/// The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual "column" of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it's just a bit of interesting history.
		/// </summary>
		[DataMember(Name="gridLevelPerColumn", EmitDefaultValue=false)]
		public long GridLevelPerColumn { get; set; }

		/// <summary>
		/// The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid's level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition's activation requirements for more information.
		/// </summary>
		[DataMember(Name="progressionHash", EmitDefaultValue=false)]
		public uint ProgressionHash { get; set; }

		/// <summary>
		/// The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent).
		/// </summary>
		[DataMember(Name="nodes", EmitDefaultValue=false)]
		public List<DestinyTalentNodeDefinition> Nodes { get; set; }

		/// <summary>
		/// Talent Nodes can exist in "exclusive sets": these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a "Swap").
		/// </summary>
		/// <summary>
		/// If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.
		/// </summary>
		/// <summary>
		/// Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept.
		/// </summary>
		[DataMember(Name="exclusiveSets", EmitDefaultValue=false)]
		public List<DestinyTalentNodeExclusiveSetDefinition> ExclusiveSets { get; set; }

		/// <summary>
		/// This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping.
		/// </summary>
		[DataMember(Name="independentNodeIndexes", EmitDefaultValue=false)]
		public List<long> IndependentNodeIndexes { get; set; }

		/// <summary>
		/// Talent Nodes can have "Exclusive Groups". These are not to be confused with Exclusive Sets (see exclusiveSets property).
		/// </summary>
		/// <summary>
		/// Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the "groupHash" from DestinyTalentExclusiveGroup.
		/// </summary>
		[DataMember(Name="groups", EmitDefaultValue=false)]
		public Map<String, DestinyTalentExclusiveGroup> Groups { get; set; }

		/// <summary>
		/// BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.
		/// </summary>
		/// <summary>
		/// Note that this is different from Exclusive Groups or Sets, because these categories also incorporate "Independent" nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping.
		/// </summary>
		[DataMember(Name="nodeCategories", EmitDefaultValue=false)]
		public List<DestinyTalentNodeCategory> NodeCategories { get; set; }

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
            return this.Equals(input as DestinyTalentGridDefinition);
        }

		public bool Equals(DestinyTalentGridDefinition input)
		{
			if (input == null) return false;

			return
				(
                    MaxGridLevel == input.MaxGridLevel ||
                    (MaxGridLevel != null && MaxGridLevel.Equals(input.MaxGridLevel))
                ) &&
				(
                    GridLevelPerColumn == input.GridLevelPerColumn ||
                    (GridLevelPerColumn != null && GridLevelPerColumn.Equals(input.GridLevelPerColumn))
                ) &&
				(
                    ProgressionHash == input.ProgressionHash ||
                    (ProgressionHash != null && ProgressionHash.Equals(input.ProgressionHash))
                ) &&
				(
                    Nodes == input.Nodes ||
                    (Nodes != null && Nodes.Equals(input.Nodes))
                ) &&
				(
                    ExclusiveSets == input.ExclusiveSets ||
                    (ExclusiveSets != null && ExclusiveSets.Equals(input.ExclusiveSets))
                ) &&
				(
                    IndependentNodeIndexes == input.IndependentNodeIndexes ||
                    (IndependentNodeIndexes != null && IndependentNodeIndexes.Equals(input.IndependentNodeIndexes))
                ) &&
				(
                    Groups == input.Groups ||
                    (Groups != null && Groups.Equals(input.Groups))
                ) &&
				(
                    NodeCategories == input.NodeCategories ||
                    (NodeCategories != null && NodeCategories.Equals(input.NodeCategories))
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

