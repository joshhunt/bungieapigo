using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class TrendingDetail{

		[DataMember(Name="identifier", EmitDefaultValue=false)]
		public string Identifier { get; set; }

		[DataMember(Name="entityType", EmitDefaultValue=false)]
		public TrendingEntryType EntityType { get; set; }

		[DataMember(Name="news", EmitDefaultValue=false)]
		public TrendingEntryNews News { get; set; }

		[DataMember(Name="support", EmitDefaultValue=false)]
		public TrendingEntrySupportArticle Support { get; set; }

		[DataMember(Name="destinyItem", EmitDefaultValue=false)]
		public TrendingEntryDestinyItem DestinyItem { get; set; }

		[DataMember(Name="destinyActivity", EmitDefaultValue=false)]
		public TrendingEntryDestinyActivity DestinyActivity { get; set; }

		[DataMember(Name="destinyRitual", EmitDefaultValue=false)]
		public TrendingEntryDestinyRitual DestinyRitual { get; set; }

		[DataMember(Name="creation", EmitDefaultValue=false)]
		public TrendingEntryCommunityCreation Creation { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingDetail);
        }

		public bool Equals(TrendingDetail input)
		{
			if (input == null) return false;

			return
				(
                    Identifier == input.Identifier ||
                    (Identifier != null && Identifier.Equals(input.Identifier))
                ) &&
				(
                    EntityType == input.EntityType ||
                    (EntityType != null && EntityType.Equals(input.EntityType))
                ) &&
				(
                    News == input.News ||
                    (News != null && News.Equals(input.News))
                ) &&
				(
                    Support == input.Support ||
                    (Support != null && Support.Equals(input.Support))
                ) &&
				(
                    DestinyItem == input.DestinyItem ||
                    (DestinyItem != null && DestinyItem.Equals(input.DestinyItem))
                ) &&
				(
                    DestinyActivity == input.DestinyActivity ||
                    (DestinyActivity != null && DestinyActivity.Equals(input.DestinyActivity))
                ) &&
				(
                    DestinyRitual == input.DestinyRitual ||
                    (DestinyRitual != null && DestinyRitual.Equals(input.DestinyRitual))
                ) &&
				(
                    Creation == input.Creation ||
                    (Creation != null && Creation.Equals(input.Creation))
                ) ;
		}
	}
}

