using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class AwaUserResponse
    {
        /// <summary>
        /// Indication of the selection the user has made (Approving or rejecting the action)
        /// </summary>
        [DataMember(Name = "selection", EmitDefaultValue = false)]
        public AwaUserSelection Selection { get; set; }

        /// <summary>
        /// Correlation ID of the request
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Secret nonce received via the PUSH notification.
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public List<int> Nonce { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as AwaUserResponse);
        }

        public bool Equals(AwaUserResponse input)
        {
            if (input == null) return false;

            return
                (
                    Selection == input.Selection ||
                    (Selection != null && Selection.Equals(input.Selection))
                ) &&
                (
                    CorrelationId == input.CorrelationId ||
                    (CorrelationId != null && CorrelationId.Equals(input.CorrelationId))
                ) &&
                (
                    Nonce == input.Nonce ||
                    (Nonce != null && Nonce.Equals(input.Nonce))
                ) ;
        }
    }
}

