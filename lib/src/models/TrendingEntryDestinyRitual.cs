using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class TrendingEntryDestinyRitual{

		[DataMember(Name="image", EmitDefaultValue=false)]
		public string Image { get; set; }

		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="subtitle", EmitDefaultValue=false)]
		public string Subtitle { get; set; }

		[DataMember(Name="dateStart", EmitDefaultValue=false)]
		public string DateStart { get; set; }

		[DataMember(Name="dateEnd", EmitDefaultValue=false)]
		public string DateEnd { get; set; }

		/// <summary>
		/// A destiny event does not necessarily have a related Milestone, but if it does the details will be returned here.
		/// </summary>
		[DataMember(Name="milestoneDetails", EmitDefaultValue=false)]
		public DestinyPublicMilestone MilestoneDetails { get; set; }

		/// <summary>
		/// A destiny event will not necessarily have milestone "custom content", but if it does the details will be here.
		/// </summary>
		[DataMember(Name="eventContent", EmitDefaultValue=false)]
		public DestinyMilestoneContent EventContent { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingEntryDestinyRitual);
        }

		public bool Equals(TrendingEntryDestinyRitual input)
		{
			if (input == null) return false;

			return
				(
                    Image == input.Image ||
                    (Image != null && Image.Equals(input.Image))
                ) &&
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) &&
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    Subtitle == input.Subtitle ||
                    (Subtitle != null && Subtitle.Equals(input.Subtitle))
                ) &&
				(
                    DateStart == input.DateStart ||
                    (DateStart != null && DateStart.Equals(input.DateStart))
                ) &&
				(
                    DateEnd == input.DateEnd ||
                    (DateEnd != null && DateEnd.Equals(input.DateEnd))
                ) &&
				(
                    MilestoneDetails == input.MilestoneDetails ||
                    (MilestoneDetails != null && MilestoneDetails.Equals(input.MilestoneDetails))
                ) &&
				(
                    EventContent == input.EventContent ||
                    (EventContent != null && EventContent.Equals(input.EventContent))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Image.GetHashCode();
				hashCode = hashCode * 59 + this.Icon.GetHashCode();
				hashCode = hashCode * 59 + this.Title.GetHashCode();
				hashCode = hashCode * 59 + this.Subtitle.GetHashCode();
				hashCode = hashCode * 59 + this.DateStart.GetHashCode();
				hashCode = hashCode * 59 + this.DateEnd.GetHashCode();
				hashCode = hashCode * 59 + this.MilestoneDetails.GetHashCode();
				hashCode = hashCode * 59 + this.EventContent.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

