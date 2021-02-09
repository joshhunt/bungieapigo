using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Defines the promotional text, images, and links to preview this season.
    /// </summary>
    [DataContract]
    public class DestinySeasonPreviewDefinition
    {
        /// <summary>
        /// A localized description of the season.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A relative path to learn more about the season. Web browsers should be automatically redirected to the user's Bungie.net locale. For example: "/SeasonOfTheChosen" will redirect to "/7/en/Seasons/SeasonOfTheChosen" for English users.
        /// </summary>
        [DataMember(Name = "linkPath", EmitDefaultValue = false)]
        public string LinkPath { get; set; }

        /// <summary>
        /// An optional link to a localized video, probably YouTube.
        /// </summary>
        [DataMember(Name = "videoLink", EmitDefaultValue = false)]
        public string VideoLink { get; set; }

        /// <summary>
        /// A list of images to preview the seasonal content. Should have at least three to show.
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<DestinySeasonPreviewImageDefinition> Images { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinySeasonPreviewDefinition);
        }

        public bool Equals(DestinySeasonPreviewDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
                (
                    LinkPath == input.LinkPath ||
                    (LinkPath != null && LinkPath.Equals(input.LinkPath))
                ) &&
                (
                    VideoLink == input.VideoLink ||
                    (VideoLink != null && VideoLink.Equals(input.VideoLink))
                ) &&
                (
                    Images == input.Images ||
                    (Images != null && Images.SequenceEqual(input.Images))
                ) ;
        }
    }
}

