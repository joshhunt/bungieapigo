using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class ContentTypeDescription{

		[DataMember(Name="cType", EmitDefaultValue=false)]
		public string CType { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="contentDescription", EmitDefaultValue=false)]
		public string ContentDescription { get; set; }

		[DataMember(Name="previewImage", EmitDefaultValue=false)]
		public string PreviewImage { get; set; }

		[DataMember(Name="priority", EmitDefaultValue=false)]
		public long Priority { get; set; }

		[DataMember(Name="reminder", EmitDefaultValue=false)]
		public string Reminder { get; set; }

		[DataMember(Name="properties", EmitDefaultValue=false)]
		public List<ContentTypeProperty> Properties { get; set; }

		[DataMember(Name="tagMetadata", EmitDefaultValue=false)]
		public List<TagMetadataDefinition> TagMetadata { get; set; }

		[DataMember(Name="tagMetadataItems", EmitDefaultValue=false)]
		public Map<String, TagMetadataItem> TagMetadataItems { get; set; }

		[DataMember(Name="usageExamples", EmitDefaultValue=false)]
		public List<string> UsageExamples { get; set; }

		[DataMember(Name="showInContentEditor", EmitDefaultValue=false)]
		public bool ShowInContentEditor { get; set; }

		[DataMember(Name="typeOf", EmitDefaultValue=false)]
		public string TypeOf { get; set; }

		[DataMember(Name="bindIdentifierToProperty", EmitDefaultValue=false)]
		public string BindIdentifierToProperty { get; set; }

		[DataMember(Name="boundRegex", EmitDefaultValue=false)]
		public string BoundRegex { get; set; }

		[DataMember(Name="forceIdentifierBinding", EmitDefaultValue=false)]
		public bool ForceIdentifierBinding { get; set; }

		[DataMember(Name="allowComments", EmitDefaultValue=false)]
		public bool AllowComments { get; set; }

		[DataMember(Name="autoEnglishPropertyFallback", EmitDefaultValue=false)]
		public bool AutoEnglishPropertyFallback { get; set; }

		[DataMember(Name="bulkUploadable", EmitDefaultValue=false)]
		public bool BulkUploadable { get; set; }

		[DataMember(Name="previews", EmitDefaultValue=false)]
		public List<ContentPreview> Previews { get; set; }

		[DataMember(Name="suppressCmsPath", EmitDefaultValue=false)]
		public bool SuppressCmsPath { get; set; }

		[DataMember(Name="propertySections", EmitDefaultValue=false)]
		public List<ContentTypePropertySection> PropertySections { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ContentTypeDescription);
        }

		public bool Equals(ContentTypeDescription input)
		{
			if (input == null) return false;

			return
				(
                    CType == input.CType ||
                    (CType != null && CType.Equals(input.CType))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    ContentDescription == input.ContentDescription ||
                    (ContentDescription != null && ContentDescription.Equals(input.ContentDescription))
                ) &&
				(
                    PreviewImage == input.PreviewImage ||
                    (PreviewImage != null && PreviewImage.Equals(input.PreviewImage))
                ) &&
				(
                    Priority == input.Priority ||
                    (Priority != null && Priority.Equals(input.Priority))
                ) &&
				(
                    Reminder == input.Reminder ||
                    (Reminder != null && Reminder.Equals(input.Reminder))
                ) &&
				(
                    Properties == input.Properties ||
                    (Properties != null && Properties.Equals(input.Properties))
                ) &&
				(
                    TagMetadata == input.TagMetadata ||
                    (TagMetadata != null && TagMetadata.Equals(input.TagMetadata))
                ) &&
				(
                    TagMetadataItems == input.TagMetadataItems ||
                    (TagMetadataItems != null && TagMetadataItems.Equals(input.TagMetadataItems))
                ) &&
				(
                    UsageExamples == input.UsageExamples ||
                    (UsageExamples != null && UsageExamples.Equals(input.UsageExamples))
                ) &&
				(
                    ShowInContentEditor == input.ShowInContentEditor ||
                    (ShowInContentEditor != null && ShowInContentEditor.Equals(input.ShowInContentEditor))
                ) &&
				(
                    TypeOf == input.TypeOf ||
                    (TypeOf != null && TypeOf.Equals(input.TypeOf))
                ) &&
				(
                    BindIdentifierToProperty == input.BindIdentifierToProperty ||
                    (BindIdentifierToProperty != null && BindIdentifierToProperty.Equals(input.BindIdentifierToProperty))
                ) &&
				(
                    BoundRegex == input.BoundRegex ||
                    (BoundRegex != null && BoundRegex.Equals(input.BoundRegex))
                ) &&
				(
                    ForceIdentifierBinding == input.ForceIdentifierBinding ||
                    (ForceIdentifierBinding != null && ForceIdentifierBinding.Equals(input.ForceIdentifierBinding))
                ) &&
				(
                    AllowComments == input.AllowComments ||
                    (AllowComments != null && AllowComments.Equals(input.AllowComments))
                ) &&
				(
                    AutoEnglishPropertyFallback == input.AutoEnglishPropertyFallback ||
                    (AutoEnglishPropertyFallback != null && AutoEnglishPropertyFallback.Equals(input.AutoEnglishPropertyFallback))
                ) &&
				(
                    BulkUploadable == input.BulkUploadable ||
                    (BulkUploadable != null && BulkUploadable.Equals(input.BulkUploadable))
                ) &&
				(
                    Previews == input.Previews ||
                    (Previews != null && Previews.Equals(input.Previews))
                ) &&
				(
                    SuppressCmsPath == input.SuppressCmsPath ||
                    (SuppressCmsPath != null && SuppressCmsPath.Equals(input.SuppressCmsPath))
                ) &&
				(
                    PropertySections == input.PropertySections ||
                    (PropertySections != null && PropertySections.Equals(input.PropertySections))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.CType.GetHashCode();
				hashCode = hashCode * 59 + this.Name.GetHashCode();
				hashCode = hashCode * 59 + this.ContentDescription.GetHashCode();
				hashCode = hashCode * 59 + this.PreviewImage.GetHashCode();
				hashCode = hashCode * 59 + this.Priority.GetHashCode();
				hashCode = hashCode * 59 + this.Reminder.GetHashCode();
				hashCode = hashCode * 59 + this.Properties.GetHashCode();
				hashCode = hashCode * 59 + this.TagMetadata.GetHashCode();
				hashCode = hashCode * 59 + this.TagMetadataItems.GetHashCode();
				hashCode = hashCode * 59 + this.UsageExamples.GetHashCode();
				hashCode = hashCode * 59 + this.ShowInContentEditor.GetHashCode();
				hashCode = hashCode * 59 + this.TypeOf.GetHashCode();
				hashCode = hashCode * 59 + this.BindIdentifierToProperty.GetHashCode();
				hashCode = hashCode * 59 + this.BoundRegex.GetHashCode();
				hashCode = hashCode * 59 + this.ForceIdentifierBinding.GetHashCode();
				hashCode = hashCode * 59 + this.AllowComments.GetHashCode();
				hashCode = hashCode * 59 + this.AutoEnglishPropertyFallback.GetHashCode();
				hashCode = hashCode * 59 + this.BulkUploadable.GetHashCode();
				hashCode = hashCode * 59 + this.Previews.GetHashCode();
				hashCode = hashCode * 59 + this.SuppressCmsPath.GetHashCode();
				hashCode = hashCode * 59 + this.PropertySections.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

