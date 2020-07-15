using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyPresentationChildBlock{

		[DataMember(Name="presentationNodeType", EmitDefaultValue=false)]
		public DestinyPresentationNodeType PresentationNodeType { get; set; }

		[DataMember(Name="parentPresentationNodeHashes", EmitDefaultValue=false)]
		public List<uint> ParentPresentationNodeHashes { get; set; }

		[DataMember(Name="displayStyle", EmitDefaultValue=false)]
		public DestinyPresentationDisplayStyle DisplayStyle { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationChildBlock);
        }

		public bool Equals(DestinyPresentationChildBlock input)
		{
			if (input == null) return false;

			return
				(
                    PresentationNodeType == input.PresentationNodeType ||
                    (PresentationNodeType != null && PresentationNodeType.Equals(input.PresentationNodeType))
                ) &&
				(
                    ParentPresentationNodeHashes == input.ParentPresentationNodeHashes ||
                    (ParentPresentationNodeHashes != null && ParentPresentationNodeHashes.Equals(input.ParentPresentationNodeHashes))
                ) &&
				(
                    DisplayStyle == input.DisplayStyle ||
                    (DisplayStyle != null && DisplayStyle.Equals(input.DisplayStyle))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.PresentationNodeType.GetHashCode();
				hashCode = hashCode * 59 + this.ParentPresentationNodeHashes.GetHashCode();
				hashCode = hashCode * 59 + this.DisplayStyle.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

