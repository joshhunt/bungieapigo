using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Represents a color whose RGBA values are all represented as values between 0 and 255.
	/// </summary>
	[DataContract]
	public class DestinyColor{

		[DataMember(Name="red", EmitDefaultValue=false)]
		public int Red { get; set; }

		[DataMember(Name="green", EmitDefaultValue=false)]
		public int Green { get; set; }

		[DataMember(Name="blue", EmitDefaultValue=false)]
		public int Blue { get; set; }

		[DataMember(Name="alpha", EmitDefaultValue=false)]
		public int Alpha { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyColor);
        }

		public bool Equals(DestinyColor input)
		{
			if (input == null) return false;

			return
				(
                    Red == input.Red ||
                    (Red != null && Red.Equals(input.Red))
                ) &&
				(
                    Green == input.Green ||
                    (Green != null && Green.Equals(input.Green))
                ) &&
				(
                    Blue == input.Blue ||
                    (Blue != null && Blue.Equals(input.Blue))
                ) &&
				(
                    Alpha == input.Alpha ||
                    (Alpha != null && Alpha.Equals(input.Alpha))
                ) ;
		}
	}
}

