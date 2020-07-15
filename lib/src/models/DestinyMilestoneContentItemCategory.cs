using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Part of our dynamic, localized Milestone content is arbitrary categories of items. These are built in our content management system, and thus aren&#39;t the same as programmatically generated rewards.
	[DataContract]
	public class DestinyMilestoneContentItemCategory{

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="itemHashes", EmitDefaultValue=false)]
		public List<uint> ItemHashes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneContentItemCategory);
        }

		public bool Equals(DestinyMilestoneContentItemCategory input)
		{
			if (input == null) return false;

			return
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    ItemHashes == input.ItemHashes ||
                    (ItemHashes != null && ItemHashes.Equals(input.ItemHashes))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Title.GetHashCode();
				hashCode = hashCode * 59 + this.ItemHashes.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

