using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// The information for how the vendor purchase should override a given socket with custom plug data.
    /// </summary>
    [DataContract]
    public class DestinyVendorItemSocketOverride
    {
        /// <summary>
        /// If this is populated, the socket will be overridden with a specific plug.
        /// </summary>
        /// <summary>
        /// If this isn't populated, it's being overridden by something more complicated that is only known by the Game Server and God, which means we can't tell you in advance what it'll be.
        /// </summary>
        [DataMember(Name = "singleItemHash", EmitDefaultValue = false)]
        public uint SingleItemHash { get; set; }

        /// <summary>
        /// If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it's set to by default.
        /// </summary>
        [DataMember(Name = "randomizedOptionsCount", EmitDefaultValue = false)]
        public long RandomizedOptionsCount { get; set; }

        /// <summary>
        /// This appears to be used to select which socket ultimately gets the override defined here.
        /// </summary>
        [DataMember(Name = "socketTypeHash", EmitDefaultValue = false)]
        public uint SocketTypeHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorItemSocketOverride);
        }

        public bool Equals(DestinyVendorItemSocketOverride input)
        {
            if (input == null) return false;

            return
                (
                    SingleItemHash == input.SingleItemHash ||
                    (SingleItemHash.Equals(input.SingleItemHash))
                ) &&
                (
                    RandomizedOptionsCount == input.RandomizedOptionsCount ||
                    (RandomizedOptionsCount.Equals(input.RandomizedOptionsCount))
                ) &&
                (
                    SocketTypeHash == input.SocketTypeHash ||
                    (SocketTypeHash.Equals(input.SocketTypeHash))
                ) ;
        }
    }
}

