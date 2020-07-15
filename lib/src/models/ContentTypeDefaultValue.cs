using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class ContentTypeDefaultValue{

		[DataMember(Name="whenClause", EmitDefaultValue=false)]
		public string WhenClause { get; set; }

		[DataMember(Name="whenValue", EmitDefaultValue=false)]
		public string WhenValue { get; set; }

		[DataMember(Name="defaultValue", EmitDefaultValue=false)]
		public string DefaultValue { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ContentTypeDefaultValue);
        }

		public bool Equals(ContentTypeDefaultValue input)
		{
			if (input == null) return false;

			return
				(
                    WhenClause == input.WhenClause ||
                    (WhenClause != null && WhenClause.Equals(input.WhenClause))
                ) &&
				(
                    WhenValue == input.WhenValue ||
                    (WhenValue != null && WhenValue.Equals(input.WhenValue))
                ) &&
				(
                    DefaultValue == input.DefaultValue ||
                    (DefaultValue != null && DefaultValue.Equals(input.DefaultValue))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.WhenClause.GetHashCode();
				hashCode = hashCode * 59 + this.WhenValue.GetHashCode();
				hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

