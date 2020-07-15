using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupApplicationResponse{

		[DataMember(Name="resolution", EmitDefaultValue=false)]
		public GroupApplicationResolveState Resolution { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupApplicationResponse);
        }

		public bool Equals(GroupApplicationResponse input)
		{
			if (input == null) return false;

			return
				(
                    Resolution == input.Resolution ||
                    (Resolution != null && Resolution.Equals(input.Resolution))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Resolution.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

