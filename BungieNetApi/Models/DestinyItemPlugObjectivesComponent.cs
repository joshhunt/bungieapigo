using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyItemPlugObjectivesComponent
    {
        /// <summary>
        /// This set of data is keyed by the Item Hash (DestinyInventoryItemDefinition) of the plug whose objectives are being returned, with the value being the list of those objectives.
        /// </summary>
        /// <summary>
        ///  What if two plugs with the same hash are returned for an item, you ask?
        /// </summary>
        /// <summary>
        ///  Good question! They share the same item-scoped state, and as such would have identical objective state as a result. How's that for convenient.
        /// </summary>
        /// <summary>
        ///  Sometimes, Plugs may have objectives: generally, these are used for flavor and display purposes. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item's data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition's progressDescription property. Refer to the plug's itemHash and objective property for more information if you would like to display even more data.
        /// </summary>
        [DataMember(Name = "objectivesPerPlug", EmitDefaultValue = false)]
        public Dictionary<string, List<DestinyObjectiveProgress>> ObjectivesPerPlug { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemPlugObjectivesComponent);
        }

        public bool Equals(DestinyItemPlugObjectivesComponent input)
        {
            if (input == null) return false;

            return
                (
                    ObjectivesPerPlug == input.ObjectivesPerPlug ||
                    (ObjectivesPerPlug != null && ObjectivesPerPlug.SequenceEqual(input.ObjectivesPerPlug))
                ) ;
        }
    }
}

