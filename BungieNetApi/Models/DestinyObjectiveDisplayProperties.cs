using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyObjectiveDisplayProperties
    {
        /// <summary>
        /// The activity associated with this objective in the context of this item, if any.
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        /// <summary>
        /// If true, the game shows this objective on item preview screens.
        /// </summary>
        [DataMember(Name = "displayOnItemPreviewScreen", EmitDefaultValue = false)]
        public bool DisplayOnItemPreviewScreen { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyObjectiveDisplayProperties);
        }

        public bool Equals(DestinyObjectiveDisplayProperties input)
        {
            if (input == null) return false;

            return
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    DisplayOnItemPreviewScreen == input.DisplayOnItemPreviewScreen ||
                    (DisplayOnItemPreviewScreen != null && DisplayOnItemPreviewScreen.Equals(input.DisplayOnItemPreviewScreen))
                ) ;
        }
    }
}

