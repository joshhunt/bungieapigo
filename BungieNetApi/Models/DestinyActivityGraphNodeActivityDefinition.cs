using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// The actual activity to be redirected to when you click on the node. Note that a node can have many Activities attached to it: but only one will be active at any given time. The list of Node Activities will be traversed, and the first one found to be active will be displayed. This way, a node can layer multiple variants of an activity on top of each other. For instance, one node can control the weekly Crucible Playlist. There are multiple possible playlists, but only one is active for the week.
    /// </summary>
    [DataContract]
    public class DestinyActivityGraphNodeActivityDefinition
    {
        /// <summary>
        /// An identifier for this node activity. It is only guaranteed to be unique within the Activity Graph.
        /// </summary>
        [DataMember(Name = "nodeActivityId", EmitDefaultValue = false)]
        public uint NodeActivityId { get; set; }

        /// <summary>
        /// The activity that will be activated if the user clicks on this node. Controls all activity-related information displayed on the node if it is active (the text shown in the tooltip etc)
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphNodeActivityDefinition);
        }

        public bool Equals(DestinyActivityGraphNodeActivityDefinition input)
        {
            if (input == null) return false;

            return
                (
                    NodeActivityId == input.NodeActivityId ||
                    (NodeActivityId != null && NodeActivityId.Equals(input.NodeActivityId))
                ) &&
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) ;
        }
    }
}

