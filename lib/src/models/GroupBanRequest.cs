using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupBanRequest{

		[DataMember(Name="comment", EmitDefaultValue=false)]
		public string Comment { get; set; }

		[DataMember(Name="length", EmitDefaultValue=false)]
		public IgnoreLength Length { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupBanRequest);
        }

		public bool Equals(GroupBanRequest input)
		{
			if (input == null) return false;

			return
				(
                    Comment == input.Comment ||
                    (Comment != null && Comment.Equals(input.Comment))
                ) &&
				(
                    Length == input.Length ||
                    (Length != null && Length.Equals(input.Length))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Comment.GetHashCode();
				hashCode = hashCode * 59 + this.Length.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

