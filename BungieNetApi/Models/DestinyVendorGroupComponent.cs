using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// This component returns references to all of the Vendors in the response, grouped by categorizations that Bungie has deemed to be interesting, in the order in which both the groups and the vendors within that group should be rendered.
    /// </summary>
    [DataContract]
    public class DestinyVendorGroupComponent
    {
        /// <summary>
        /// The ordered list of groups being returned.
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<DestinyVendorGroup> Groups { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorGroupComponent);
        }

        public bool Equals(DestinyVendorGroupComponent input)
        {
            if (input == null) return false;

            return
                (
                    Groups == input.Groups ||
                    (Groups != null && Groups.Equals(input.Groups))
                ) ;
        }
    }
}

