using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class ContentItemPublicContract{

		[DataMember(Name="contentId", EmitDefaultValue=false)]
		public long ContentId { get; set; }

		[DataMember(Name="cType", EmitDefaultValue=false)]
		public string CType { get; set; }

		[DataMember(Name="cmsPath", EmitDefaultValue=false)]
		public string CmsPath { get; set; }

		[DataMember(Name="creationDate", EmitDefaultValue=false)]
		public string CreationDate { get; set; }

		[DataMember(Name="modifyDate", EmitDefaultValue=false)]
		public string ModifyDate { get; set; }

		[DataMember(Name="allowComments", EmitDefaultValue=false)]
		public bool AllowComments { get; set; }

		[DataMember(Name="hasAgeGate", EmitDefaultValue=false)]
		public bool HasAgeGate { get; set; }

		[DataMember(Name="minimumAge", EmitDefaultValue=false)]
		public long MinimumAge { get; set; }

		[DataMember(Name="ratingImagePath", EmitDefaultValue=false)]
		public string RatingImagePath { get; set; }

		[DataMember(Name="author", EmitDefaultValue=false)]
		public GeneralUser Author { get; set; }

		[DataMember(Name="autoEnglishPropertyFallback", EmitDefaultValue=false)]
		public bool AutoEnglishPropertyFallback { get; set; }

		/// <summary>
		/// Firehose content is really a collection of metadata and "properties", which are the potentially-but-not-strictly localizable data that comprises the meat of whatever content is being shown.
		/// </summary>
		/// <summary>
		/// As Cole Porter would have crooned, "Anything Goes" with Firehose properties. They are most often strings, but they can theoretically be anything. They are JSON encoded, and could be JSON structures, simple strings, numbers etc... The Content Type of the item (cType) will describe the properties, and thus how they ought to be deserialized.
		/// </summary>
		[DataMember(Name="properties", EmitDefaultValue=false)]
		public Map<String, Map<String, String>> Properties { get; set; }

		[DataMember(Name="representations", EmitDefaultValue=false)]
		public List<ContentRepresentation> Representations { get; set; }

		/// <summary>
		/// NOTE: Tags will always be lower case.
		/// </summary>
		[DataMember(Name="tags", EmitDefaultValue=false)]
		public List<string> Tags { get; set; }

		[DataMember(Name="commentSummary", EmitDefaultValue=false)]
		public CommentSummary CommentSummary { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ContentItemPublicContract);
        }

		public bool Equals(ContentItemPublicContract input)
		{
			if (input == null) return false;

			return
				(
                    ContentId == input.ContentId ||
                    (ContentId != null && ContentId.Equals(input.ContentId))
                ) &&
				(
                    CType == input.CType ||
                    (CType != null && CType.Equals(input.CType))
                ) &&
				(
                    CmsPath == input.CmsPath ||
                    (CmsPath != null && CmsPath.Equals(input.CmsPath))
                ) &&
				(
                    CreationDate == input.CreationDate ||
                    (CreationDate != null && CreationDate.Equals(input.CreationDate))
                ) &&
				(
                    ModifyDate == input.ModifyDate ||
                    (ModifyDate != null && ModifyDate.Equals(input.ModifyDate))
                ) &&
				(
                    AllowComments == input.AllowComments ||
                    (AllowComments != null && AllowComments.Equals(input.AllowComments))
                ) &&
				(
                    HasAgeGate == input.HasAgeGate ||
                    (HasAgeGate != null && HasAgeGate.Equals(input.HasAgeGate))
                ) &&
				(
                    MinimumAge == input.MinimumAge ||
                    (MinimumAge != null && MinimumAge.Equals(input.MinimumAge))
                ) &&
				(
                    RatingImagePath == input.RatingImagePath ||
                    (RatingImagePath != null && RatingImagePath.Equals(input.RatingImagePath))
                ) &&
				(
                    Author == input.Author ||
                    (Author != null && Author.Equals(input.Author))
                ) &&
				(
                    AutoEnglishPropertyFallback == input.AutoEnglishPropertyFallback ||
                    (AutoEnglishPropertyFallback != null && AutoEnglishPropertyFallback.Equals(input.AutoEnglishPropertyFallback))
                ) &&
				(
                    Properties == input.Properties ||
                    (Properties != null && Properties.Equals(input.Properties))
                ) &&
				(
                    Representations == input.Representations ||
                    (Representations != null && Representations.Equals(input.Representations))
                ) &&
				(
                    Tags == input.Tags ||
                    (Tags != null && Tags.Equals(input.Tags))
                ) &&
				(
                    CommentSummary == input.CommentSummary ||
                    (CommentSummary != null && CommentSummary.Equals(input.CommentSummary))
                ) ;
		}
	}
}

