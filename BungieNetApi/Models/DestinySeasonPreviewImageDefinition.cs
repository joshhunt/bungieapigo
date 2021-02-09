using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Defines the thumbnail icon, high-res image, and video link for promotional images
    /// </summary>
    [DataContract]
    public class DestinySeasonPreviewImageDefinition
    {
        /// <summary>
        /// A thumbnail icon path to preview seasonal content, probably 480x270.
        /// </summary>
        [DataMember(Name = "thumbnailImage", EmitDefaultValue = false)]
        public string ThumbnailImage { get; set; }

        /// <summary>
        /// An optional path to a high-resolution image, probably 1920x1080.
        /// </summary>
        [DataMember(Name = "highResImage", EmitDefaultValue = false)]
        public string HighResImage { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinySeasonPreviewImageDefinition);
        }

        public bool Equals(DestinySeasonPreviewImageDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ThumbnailImage == input.ThumbnailImage ||
                    (ThumbnailImage != null && ThumbnailImage.Equals(input.ThumbnailImage))
                ) &&
                (
                    HighResImage == input.HighResImage ||
                    (HighResImage != null && HighResImage.Equals(input.HighResImage))
                ) ;
        }
    }
}

