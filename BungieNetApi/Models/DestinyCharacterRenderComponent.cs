using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Only really useful if you're attempting to render the character's current appearance in 3D, this returns a bare minimum of information, pre-aggregated, that you'll need to perform that rendering. Note that you need to combine this with other 3D assets and data from our servers.
    /// </summary>
    /// <summary>
    /// Examine the Javascript returned by https://bungie.net/sharedbundle/spasm to see how we use this data, but be warned: the rabbit hole goes pretty deep.
    /// </summary>
    [DataContract]
    public class DestinyCharacterRenderComponent
    {
        /// <summary>
        /// Custom dyes, calculated by iterating over the character's equipped items. Useful for pre-fetching all of the dye data needed from our server.
        /// </summary>
        [DataMember(Name = "customDyes", EmitDefaultValue = false)]
        public List<DyeReference> CustomDyes { get; set; }

        /// <summary>
        /// This is actually something that Spasm.js *doesn't* do right now, and that we don't return assets for yet. This is the data about what character customization options you picked. You can combine this with DestinyCharacterCustomizationOptionDefinition to show some cool info, and hopefully someday to actually render a user's face in 3D. We'll see if we ever end up with time for that.
        /// </summary>
        [DataMember(Name = "customization", EmitDefaultValue = false)]
        public DestinyCharacterCustomization Customization { get; set; }

        /// <summary>
        /// A minimal view of:
        /// </summary>
        /// <summary>
        /// - Equipped items
        /// </summary>
        /// <summary>
        /// - The rendering-related custom options on those equipped items
        /// </summary>
        /// <summary>
        /// Combined, that should be enough to render all of the items on the equipped character.
        /// </summary>
        [DataMember(Name = "peerView", EmitDefaultValue = false)]
        public DestinyCharacterPeerView PeerView { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterRenderComponent);
        }

        public bool Equals(DestinyCharacterRenderComponent input)
        {
            if (input == null) return false;

            return
                (
                    CustomDyes == input.CustomDyes ||
                    (CustomDyes != null && CustomDyes.SequenceEqual(input.CustomDyes))
                ) &&
                (
                    Customization == input.Customization ||
                    (Customization != null && Customization.Equals(input.Customization))
                ) &&
                (
                    PeerView == input.PeerView ||
                    (PeerView != null && PeerView.Equals(input.PeerView))
                ) ;
        }
    }
}

