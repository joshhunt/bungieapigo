using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class EntityActionResult
    {
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public long EntityId { get; set; }

        [DataMember(Name = "result", EmitDefaultValue = false)]
        public PlatformErrorCodes Result { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as EntityActionResult);
        }

        public bool Equals(EntityActionResult input)
        {
            if (input == null) return false;

            return
                (
                    EntityId == input.EntityId ||
                    (EntityId.Equals(input.EntityId))
                ) &&
                (
                    Result == input.Result ||
                    (Result != null && Result.Equals(input.Result))
                ) ;
        }
    }
}

