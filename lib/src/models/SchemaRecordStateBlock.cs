using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class SchemaRecordStateBlock{

		[DataMember(Name="featuredPriority", EmitDefaultValue=false)]
		public long FeaturedPriority { get; set; }

		[DataMember(Name="obscuredString", EmitDefaultValue=false)]
		public string ObscuredString { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SchemaRecordStateBlock);
        }

		public bool Equals(SchemaRecordStateBlock input)
		{
			if (input == null) return false;

			return
				(
                    FeaturedPriority == input.FeaturedPriority ||
                    (FeaturedPriority != null && FeaturedPriority.Equals(input.FeaturedPriority))
                ) &&
				(
                    ObscuredString == input.ObscuredString ||
                    (ObscuredString != null && ObscuredString.Equals(input.ObscuredString))
                ) ;
		}
	}
}

