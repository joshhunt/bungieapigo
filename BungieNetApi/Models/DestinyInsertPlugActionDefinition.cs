using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Data related to what happens while a plug is being inserted, mostly for UI purposes.
    /// </summary>
    [DataContract]
    public class DestinyInsertPlugActionDefinition
    {
        /// <summary>
        /// How long it takes for the Plugging of the item to be completed once it is initiated, if you care.
        /// </summary>
        [DataMember(Name = "actionExecuteSeconds", EmitDefaultValue = false)]
        public long ActionExecuteSeconds { get; set; }

        /// <summary>
        /// The type of action being performed when you act on this Socket Type. The most common value is "insert plug", but there are others as well (for instance, a "Masterwork" socket may allow for Re-initialization, and an Infusion socket allows for items to be consumed to upgrade the item)
        /// </summary>
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        public SocketTypeActionType ActionType { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyInsertPlugActionDefinition);
        }

        public bool Equals(DestinyInsertPlugActionDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ActionExecuteSeconds == input.ActionExecuteSeconds ||
                    (ActionExecuteSeconds != null && ActionExecuteSeconds.Equals(input.ActionExecuteSeconds))
                ) &&
                (
                    ActionType == input.ActionType ||
                    (ActionType != null && ActionType.Equals(input.ActionType))
                ) ;
        }
    }
}

