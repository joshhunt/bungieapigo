using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class SingleComponentResponseOfDestinyItemStatsComponent
    {
        /// <summary>
        /// If you want the stats on an item's instanced data, get this component.
        /// </summary>
        /// <summary>
        /// These are stats like Attack, Defense etc... and *not* historical stats.
        /// </summary>
        /// <summary>
        /// Note that some stats have additional computation in-game at runtime - for instance, Magazine Size - and thus these stats might not be 100% accurate compared to what you see in-game for some stats. I know, it sucks. I hate it too.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DestinyItemStatsComponent Data { get; set; }

        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public ComponentPrivacySetting Privacy { get; set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
        public bool Disabled { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyItemStatsComponent);
        }

        public bool Equals(SingleComponentResponseOfDestinyItemStatsComponent input)
        {
            if (input == null) return false;

            return
                (
                    Data == input.Data ||
                    (Data != null && Data.Equals(input.Data))
                ) &&
                (
                    Privacy == input.Privacy ||
                    (Privacy != null && Privacy.Equals(input.Privacy))
                ) &&
                (
                    Disabled == input.Disabled ||
                    (Disabled != null && Disabled.Equals(input.Disabled))
                ) ;
        }
    }
}

