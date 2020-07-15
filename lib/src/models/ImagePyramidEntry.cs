using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class ImagePyramidEntry{

		/// <summary>
		/// The name of the subfolder where these images are located.
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// The factor by which the original image size has been reduced.
		/// </summary>
		[DataMember(Name="factor", EmitDefaultValue=false)]
		public double Factor { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ImagePyramidEntry);
        }

		public bool Equals(ImagePyramidEntry input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Factor == input.Factor ||
                    (Factor != null && Factor.Equals(input.Factor))
                ) ;
		}
	}
}

