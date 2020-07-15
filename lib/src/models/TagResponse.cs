using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class TagResponse{

		[DataMember(Name="tagText", EmitDefaultValue=false)]
		public string TagText { get; set; }

		[DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
		public IgnoreResponse IgnoreStatus { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TagResponse);
        }

		public bool Equals(TagResponse input)
		{
			if (input == null) return false;

			return
				(
                    TagText == input.TagText ||
                    (TagText != null && TagText.Equals(input.TagText))
                ) &&
				(
                    IgnoreStatus == input.IgnoreStatus ||
                    (IgnoreStatus != null && IgnoreStatus.Equals(input.IgnoreStatus))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.TagText.GetHashCode();
				hashCode = hashCode * 59 + this.IgnoreStatus.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

