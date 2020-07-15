using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class EntityActionResult{

		[DataMember(Name="entityId", EmitDefaultValue=false)]
		public long EntityId { get; set; }

		[DataMember(Name="result", EmitDefaultValue=false)]
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
                    (EntityId != null && EntityId.Equals(input.EntityId))
                ) &&
				(
                    Result == input.Result ||
                    (Result != null && Result.Equals(input.Result))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.EntityId.GetHashCode();
				hashCode = hashCode * 59 + this.Result.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

