using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Not terribly useful, some basic cooldown interaction info.
    /// </summary>
    [DataContract]
    public class DestinyVendorSaleItemActionBlockDefinition
    {
        [DataMember(Name = "executeSeconds", EmitDefaultValue = false)]
        public double ExecuteSeconds { get; set; }

        [DataMember(Name = "isPositive", EmitDefaultValue = false)]
        public bool IsPositive { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorSaleItemActionBlockDefinition);
        }

        public bool Equals(DestinyVendorSaleItemActionBlockDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ExecuteSeconds == input.ExecuteSeconds ||
                    (ExecuteSeconds != null && ExecuteSeconds.Equals(input.ExecuteSeconds))
                ) &&
                (
                    IsPositive == input.IsPositive ||
                    (IsPositive != null && IsPositive.Equals(input.IsPositive))
                ) ;
        }
    }
}

