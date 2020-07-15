using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Represents localized, extended content related to Milestones. This is intentionally returned by a separate endpoint and not with Character-level Milestone data because we do not put localized data into standard Destiny responses, both for brevity of response and for caching purposes. If you really need this data, hit the Milestone Content endpoint.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneContent{

		/// <summary>
		/// The "About this Milestone" text from the Firehose.
		/// </summary>
		[DataMember(Name="about", EmitDefaultValue=false)]
		public string About { get; set; }

		/// <summary>
		/// The Current Status of the Milestone, as driven by the Firehose.
		/// </summary>
		[DataMember(Name="status", EmitDefaultValue=false)]
		public string Status { get; set; }

		/// <summary>
		/// A list of tips, provided by the Firehose.
		/// </summary>
		[DataMember(Name="tips", EmitDefaultValue=false)]
		public List<string> Tips { get; set; }

		/// <summary>
		/// If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here.
		/// </summary>
		[DataMember(Name="itemCategories", EmitDefaultValue=false)]
		public List<DestinyMilestoneContentItemCategory> ItemCategories { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneContent);
        }

		public bool Equals(DestinyMilestoneContent input)
		{
			if (input == null) return false;

			return
				(
                    About == input.About ||
                    (About != null && About.Equals(input.About))
                ) &&
				(
                    Status == input.Status ||
                    (Status != null && Status.Equals(input.Status))
                ) &&
				(
                    Tips == input.Tips ||
                    (Tips != null && Tips.Equals(input.Tips))
                ) &&
				(
                    ItemCategories == input.ItemCategories ||
                    (ItemCategories != null && ItemCategories.Equals(input.ItemCategories))
                ) ;
		}
	}
}

