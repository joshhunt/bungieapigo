using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// The list entry view for trending items. Returns just enough to show the item on the trending page.
	[DataContract]
	public class TrendingEntry{

		/// <summary>
		/// The weighted score of this trending item.
		/// </summary>
		[DataMember(Name="weight", EmitDefaultValue=false)]
		public double Weight { get; set; }

		[DataMember(Name="isFeatured", EmitDefaultValue=false)]
		public bool IsFeatured { get; set; }

		/// <summary>
		/// We don't know whether the identifier will be a string, a uint, or a long... so we're going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type.
		/// </summary>
		[DataMember(Name="identifier", EmitDefaultValue=false)]
		public string Identifier { get; set; }

		/// <summary>
		/// An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item.
		/// </summary>
		[DataMember(Name="entityType", EmitDefaultValue=false)]
		public TrendingEntryType EntityType { get; set; }

		/// <summary>
		/// The localized "display name/article title/'primary localized identifier'" of the entity.
		/// </summary>
		[DataMember(Name="displayName", EmitDefaultValue=false)]
		public string DisplayName { get; set; }

		/// <summary>
		/// If the entity has a localized tagline/subtitle/motto/whatever, that is found here.
		/// </summary>
		[DataMember(Name="tagline", EmitDefaultValue=false)]
		public string Tagline { get; set; }

		[DataMember(Name="image", EmitDefaultValue=false)]
		public string Image { get; set; }

		[DataMember(Name="startDate", EmitDefaultValue=false)]
		public string StartDate { get; set; }

		[DataMember(Name="endDate", EmitDefaultValue=false)]
		public string EndDate { get; set; }

		[DataMember(Name="link", EmitDefaultValue=false)]
		public string Link { get; set; }

		/// <summary>
		/// If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
		/// </summary>
		[DataMember(Name="webmVideo", EmitDefaultValue=false)]
		public string WebmVideo { get; set; }

		/// <summary>
		/// If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
		/// </summary>
		[DataMember(Name="mp4Video", EmitDefaultValue=false)]
		public string Mp4Video { get; set; }

		/// <summary>
		/// If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don't use it all the time.
		/// </summary>
		[DataMember(Name="featureImage", EmitDefaultValue=false)]
		public string FeatureImage { get; set; }

		/// <summary>
		/// If the item is of entityType TrendingEntryType.Container, it may have items - also Trending Entries - contained within it. This is the ordered list of those to display under the Container's header.
		/// </summary>
		[DataMember(Name="items", EmitDefaultValue=false)]
		public List<TrendingEntry> Items { get; set; }

		/// <summary>
		/// If the entry has a date at which it was created, this is that date.
		/// </summary>
		[DataMember(Name="creationDate", EmitDefaultValue=false)]
		public string CreationDate { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingEntry);
        }

		public bool Equals(TrendingEntry input)
		{
			if (input == null) return false;

			return
				(
                    Weight == input.Weight ||
                    (Weight != null && Weight.Equals(input.Weight))
                ) &&
				(
                    IsFeatured == input.IsFeatured ||
                    (IsFeatured != null && IsFeatured.Equals(input.IsFeatured))
                ) &&
				(
                    Identifier == input.Identifier ||
                    (Identifier != null && Identifier.Equals(input.Identifier))
                ) &&
				(
                    EntityType == input.EntityType ||
                    (EntityType != null && EntityType.Equals(input.EntityType))
                ) &&
				(
                    DisplayName == input.DisplayName ||
                    (DisplayName != null && DisplayName.Equals(input.DisplayName))
                ) &&
				(
                    Tagline == input.Tagline ||
                    (Tagline != null && Tagline.Equals(input.Tagline))
                ) &&
				(
                    Image == input.Image ||
                    (Image != null && Image.Equals(input.Image))
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
                    Link == input.Link ||
                    (Link != null && Link.Equals(input.Link))
                ) &&
				(
                    WebmVideo == input.WebmVideo ||
                    (WebmVideo != null && WebmVideo.Equals(input.WebmVideo))
                ) &&
				(
                    Mp4Video == input.Mp4Video ||
                    (Mp4Video != null && Mp4Video.Equals(input.Mp4Video))
                ) &&
				(
                    FeatureImage == input.FeatureImage ||
                    (FeatureImage != null && FeatureImage.Equals(input.FeatureImage))
                ) &&
				(
                    Items == input.Items ||
                    (Items != null && Items.Equals(input.Items))
                ) &&
				(
                    CreationDate == input.CreationDate ||
                    (CreationDate != null && CreationDate.Equals(input.CreationDate))
                ) ;
		}
	}
}

