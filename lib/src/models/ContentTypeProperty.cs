using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class ContentTypeProperty{

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="rootPropertyName", EmitDefaultValue=false)]
		public string RootPropertyName { get; set; }

		[DataMember(Name="readableName", EmitDefaultValue=false)]
		public string ReadableName { get; set; }

		[DataMember(Name="value", EmitDefaultValue=false)]
		public string Value { get; set; }

		[DataMember(Name="propertyDescription", EmitDefaultValue=false)]
		public string PropertyDescription { get; set; }

		[DataMember(Name="localizable", EmitDefaultValue=false)]
		public bool Localizable { get; set; }

		[DataMember(Name="fallback", EmitDefaultValue=false)]
		public bool Fallback { get; set; }

		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool Enabled { get; set; }

		[DataMember(Name="order", EmitDefaultValue=false)]
		public long Order { get; set; }

		[DataMember(Name="visible", EmitDefaultValue=false)]
		public bool Visible { get; set; }

		[DataMember(Name="isTitle", EmitDefaultValue=false)]
		public bool IsTitle { get; set; }

		[DataMember(Name="required", EmitDefaultValue=false)]
		public bool Required { get; set; }

		[DataMember(Name="maxLength", EmitDefaultValue=false)]
		public long MaxLength { get; set; }

		[DataMember(Name="maxByteLength", EmitDefaultValue=false)]
		public long MaxByteLength { get; set; }

		[DataMember(Name="maxFileSize", EmitDefaultValue=false)]
		public long MaxFileSize { get; set; }

		[DataMember(Name="regexp", EmitDefaultValue=false)]
		public string Regexp { get; set; }

		[DataMember(Name="validateAs", EmitDefaultValue=false)]
		public string ValidateAs { get; set; }

		[DataMember(Name="rssAttribute", EmitDefaultValue=false)]
		public string RssAttribute { get; set; }

		[DataMember(Name="visibleDependency", EmitDefaultValue=false)]
		public string VisibleDependency { get; set; }

		[DataMember(Name="visibleOn", EmitDefaultValue=false)]
		public string VisibleOn { get; set; }

		[DataMember(Name="datatype", EmitDefaultValue=false)]
		public ContentPropertyDataTypeEnum Datatype { get; set; }

		[DataMember(Name="attributes", EmitDefaultValue=false)]
		public Map<String, string> Attributes { get; set; }

		[DataMember(Name="childProperties", EmitDefaultValue=false)]
		public List<ContentTypeProperty> ChildProperties { get; set; }

		[DataMember(Name="contentTypeAllowed", EmitDefaultValue=false)]
		public string ContentTypeAllowed { get; set; }

		[DataMember(Name="bindToProperty", EmitDefaultValue=false)]
		public string BindToProperty { get; set; }

		[DataMember(Name="boundRegex", EmitDefaultValue=false)]
		public string BoundRegex { get; set; }

		[DataMember(Name="representationSelection", EmitDefaultValue=false)]
		public Map<String, string> RepresentationSelection { get; set; }

		[DataMember(Name="defaultValues", EmitDefaultValue=false)]
		public List<ContentTypeDefaultValue> DefaultValues { get; set; }

		[DataMember(Name="isExternalAllowed", EmitDefaultValue=false)]
		public bool IsExternalAllowed { get; set; }

		[DataMember(Name="propertySection", EmitDefaultValue=false)]
		public string PropertySection { get; set; }

		[DataMember(Name="weight", EmitDefaultValue=false)]
		public long Weight { get; set; }

		[DataMember(Name="entitytype", EmitDefaultValue=false)]
		public string Entitytype { get; set; }

		[DataMember(Name="isCombo", EmitDefaultValue=false)]
		public bool IsCombo { get; set; }

		[DataMember(Name="suppressProperty", EmitDefaultValue=false)]
		public bool SuppressProperty { get; set; }

		[DataMember(Name="legalContentTypes", EmitDefaultValue=false)]
		public List<string> LegalContentTypes { get; set; }

		[DataMember(Name="representationValidationString", EmitDefaultValue=false)]
		public string RepresentationValidationString { get; set; }

		[DataMember(Name="minWidth", EmitDefaultValue=false)]
		public long MinWidth { get; set; }

		[DataMember(Name="maxWidth", EmitDefaultValue=false)]
		public long MaxWidth { get; set; }

		[DataMember(Name="minHeight", EmitDefaultValue=false)]
		public long MinHeight { get; set; }

		[DataMember(Name="maxHeight", EmitDefaultValue=false)]
		public long MaxHeight { get; set; }

		[DataMember(Name="isVideo", EmitDefaultValue=false)]
		public bool IsVideo { get; set; }

		[DataMember(Name="isImage", EmitDefaultValue=false)]
		public bool IsImage { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ContentTypeProperty);
        }

		public bool Equals(ContentTypeProperty input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    RootPropertyName == input.RootPropertyName ||
                    (RootPropertyName != null && RootPropertyName.Equals(input.RootPropertyName))
                ) &&
				(
                    ReadableName == input.ReadableName ||
                    (ReadableName != null && ReadableName.Equals(input.ReadableName))
                ) &&
				(
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) &&
				(
                    PropertyDescription == input.PropertyDescription ||
                    (PropertyDescription != null && PropertyDescription.Equals(input.PropertyDescription))
                ) &&
				(
                    Localizable == input.Localizable ||
                    (Localizable != null && Localizable.Equals(input.Localizable))
                ) &&
				(
                    Fallback == input.Fallback ||
                    (Fallback != null && Fallback.Equals(input.Fallback))
                ) &&
				(
                    Enabled == input.Enabled ||
                    (Enabled != null && Enabled.Equals(input.Enabled))
                ) &&
				(
                    Order == input.Order ||
                    (Order != null && Order.Equals(input.Order))
                ) &&
				(
                    Visible == input.Visible ||
                    (Visible != null && Visible.Equals(input.Visible))
                ) &&
				(
                    IsTitle == input.IsTitle ||
                    (IsTitle != null && IsTitle.Equals(input.IsTitle))
                ) &&
				(
                    Required == input.Required ||
                    (Required != null && Required.Equals(input.Required))
                ) &&
				(
                    MaxLength == input.MaxLength ||
                    (MaxLength != null && MaxLength.Equals(input.MaxLength))
                ) &&
				(
                    MaxByteLength == input.MaxByteLength ||
                    (MaxByteLength != null && MaxByteLength.Equals(input.MaxByteLength))
                ) &&
				(
                    MaxFileSize == input.MaxFileSize ||
                    (MaxFileSize != null && MaxFileSize.Equals(input.MaxFileSize))
                ) &&
				(
                    Regexp == input.Regexp ||
                    (Regexp != null && Regexp.Equals(input.Regexp))
                ) &&
				(
                    ValidateAs == input.ValidateAs ||
                    (ValidateAs != null && ValidateAs.Equals(input.ValidateAs))
                ) &&
				(
                    RssAttribute == input.RssAttribute ||
                    (RssAttribute != null && RssAttribute.Equals(input.RssAttribute))
                ) &&
				(
                    VisibleDependency == input.VisibleDependency ||
                    (VisibleDependency != null && VisibleDependency.Equals(input.VisibleDependency))
                ) &&
				(
                    VisibleOn == input.VisibleOn ||
                    (VisibleOn != null && VisibleOn.Equals(input.VisibleOn))
                ) &&
				(
                    Datatype == input.Datatype ||
                    (Datatype != null && Datatype.Equals(input.Datatype))
                ) &&
				(
                    Attributes == input.Attributes ||
                    (Attributes != null && Attributes.Equals(input.Attributes))
                ) &&
				(
                    ChildProperties == input.ChildProperties ||
                    (ChildProperties != null && ChildProperties.Equals(input.ChildProperties))
                ) &&
				(
                    ContentTypeAllowed == input.ContentTypeAllowed ||
                    (ContentTypeAllowed != null && ContentTypeAllowed.Equals(input.ContentTypeAllowed))
                ) &&
				(
                    BindToProperty == input.BindToProperty ||
                    (BindToProperty != null && BindToProperty.Equals(input.BindToProperty))
                ) &&
				(
                    BoundRegex == input.BoundRegex ||
                    (BoundRegex != null && BoundRegex.Equals(input.BoundRegex))
                ) &&
				(
                    RepresentationSelection == input.RepresentationSelection ||
                    (RepresentationSelection != null && RepresentationSelection.Equals(input.RepresentationSelection))
                ) &&
				(
                    DefaultValues == input.DefaultValues ||
                    (DefaultValues != null && DefaultValues.Equals(input.DefaultValues))
                ) &&
				(
                    IsExternalAllowed == input.IsExternalAllowed ||
                    (IsExternalAllowed != null && IsExternalAllowed.Equals(input.IsExternalAllowed))
                ) &&
				(
                    PropertySection == input.PropertySection ||
                    (PropertySection != null && PropertySection.Equals(input.PropertySection))
                ) &&
				(
                    Weight == input.Weight ||
                    (Weight != null && Weight.Equals(input.Weight))
                ) &&
				(
                    Entitytype == input.Entitytype ||
                    (Entitytype != null && Entitytype.Equals(input.Entitytype))
                ) &&
				(
                    IsCombo == input.IsCombo ||
                    (IsCombo != null && IsCombo.Equals(input.IsCombo))
                ) &&
				(
                    SuppressProperty == input.SuppressProperty ||
                    (SuppressProperty != null && SuppressProperty.Equals(input.SuppressProperty))
                ) &&
				(
                    LegalContentTypes == input.LegalContentTypes ||
                    (LegalContentTypes != null && LegalContentTypes.Equals(input.LegalContentTypes))
                ) &&
				(
                    RepresentationValidationString == input.RepresentationValidationString ||
                    (RepresentationValidationString != null && RepresentationValidationString.Equals(input.RepresentationValidationString))
                ) &&
				(
                    MinWidth == input.MinWidth ||
                    (MinWidth != null && MinWidth.Equals(input.MinWidth))
                ) &&
				(
                    MaxWidth == input.MaxWidth ||
                    (MaxWidth != null && MaxWidth.Equals(input.MaxWidth))
                ) &&
				(
                    MinHeight == input.MinHeight ||
                    (MinHeight != null && MinHeight.Equals(input.MinHeight))
                ) &&
				(
                    MaxHeight == input.MaxHeight ||
                    (MaxHeight != null && MaxHeight.Equals(input.MaxHeight))
                ) &&
				(
                    IsVideo == input.IsVideo ||
                    (IsVideo != null && IsVideo.Equals(input.IsVideo))
                ) &&
				(
                    IsImage == input.IsImage ||
                    (IsImage != null && IsImage.Equals(input.IsImage))
                ) ;
		}
	}
}

