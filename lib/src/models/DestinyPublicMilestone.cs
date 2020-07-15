using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Information about milestones, presented in a character state-agnostic manner. Combine this data with DestinyMilestoneDefinition to get a full picture of the milestone, which is basically a checklist of things to do in the game. Think of this as GetPublicAdvisors 3.0, for those who used the Destiny 1 API.
	[DataContract]
	public class DestinyPublicMilestone{

		/// <summary>
		/// The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone.
		/// </summary>
		[DataMember(Name="milestoneHash", EmitDefaultValue=false)]
		public uint MilestoneHash { get; set; }

		/// <summary>
		/// A milestone not need have even a single quest, but if there are active quests they will be returned here.
		/// </summary>
		[DataMember(Name="availableQuests", EmitDefaultValue=false)]
		public List<DestinyPublicMilestoneQuest> AvailableQuests { get; set; }

		[DataMember(Name="activities", EmitDefaultValue=false)]
		public List<DestinyPublicMilestoneChallengeActivity> Activities { get; set; }

		/// <summary>
		/// Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.
		/// </summary>
		/// <summary>
		/// Deprecated, already, for the sake of the new "vendors" property that has more data. What was I thinking.
		/// </summary>
		[DataMember(Name="vendorHashes", EmitDefaultValue=false)]
		public List<uint> VendorHashes { get; set; }

		/// <summary>
		/// This is why we can't have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data.
		/// </summary>
		[DataMember(Name="vendors", EmitDefaultValue=false)]
		public List<DestinyPublicMilestoneVendor> Vendors { get; set; }

		/// <summary>
		/// If known, this is the date when the Milestone started/became active.
		/// </summary>
		[DataMember(Name="startDate", EmitDefaultValue=false)]
		public string StartDate { get; set; }

		/// <summary>
		/// If known, this is the date when the Milestone will expire/recycle/end.
		/// </summary>
		[DataMember(Name="endDate", EmitDefaultValue=false)]
		public string EndDate { get; set; }

		/// <summary>
		/// Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.
		/// </summary>
		[DataMember(Name="order", EmitDefaultValue=false)]
		public long Order { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicMilestone);
        }

		public bool Equals(DestinyPublicMilestone input)
		{
			if (input == null) return false;

			return
				(
                    MilestoneHash == input.MilestoneHash ||
                    (MilestoneHash != null && MilestoneHash.Equals(input.MilestoneHash))
                ) &&
				(
                    AvailableQuests == input.AvailableQuests ||
                    (AvailableQuests != null && AvailableQuests.Equals(input.AvailableQuests))
                ) &&
				(
                    Activities == input.Activities ||
                    (Activities != null && Activities.Equals(input.Activities))
                ) &&
				(
                    VendorHashes == input.VendorHashes ||
                    (VendorHashes != null && VendorHashes.Equals(input.VendorHashes))
                ) &&
				(
                    Vendors == input.Vendors ||
                    (Vendors != null && Vendors.Equals(input.Vendors))
                ) &&
				(
                    StartDate == input.StartDate ||
                    (StartDate != null && StartDate.Equals(input.StartDate))
                ) &&
				(
                    EndDate == input.EndDate ||
                    (EndDate != null && EndDate.Equals(input.EndDate))
                ) &&
				(
                    Order == input.Order ||
                    (Order != null && Order.Equals(input.Order))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.MilestoneHash.GetHashCode();
				hashCode = hashCode * 59 + this.AvailableQuests.GetHashCode();
				hashCode = hashCode * 59 + this.Activities.GetHashCode();
				hashCode = hashCode * 59 + this.VendorHashes.GetHashCode();
				hashCode = hashCode * 59 + this.Vendors.GetHashCode();
				hashCode = hashCode * 59 + this.StartDate.GetHashCode();
				hashCode = hashCode * 59 + this.EndDate.GetHashCode();
				hashCode = hashCode * 59 + this.Order.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

