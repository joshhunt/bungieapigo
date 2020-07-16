using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// When a vendor provides services, this is the localized name of those services.
    /// </summary>
    [DataContract]
    public class DestinyVendorServiceDefinition
    {
        /// <summary>
        /// The localized name of a service provided.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorServiceDefinition);
        }

        public bool Equals(DestinyVendorServiceDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) ;
        }
    }
}

