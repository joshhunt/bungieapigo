using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyPositionDefinition{

		[DataMember(Name="x", EmitDefaultValue=false)]
		public long X { get; set; }

		[DataMember(Name="y", EmitDefaultValue=false)]
		public long Y { get; set; }

		[DataMember(Name="z", EmitDefaultValue=false)]
		public long Z { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPositionDefinition);
        }

		public bool Equals(DestinyPositionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    X == input.X ||
                    (X != null && X.Equals(input.X))
                ) &&
				(
                    Y == input.Y ||
                    (Y != null && Y.Equals(input.Y))
                ) &&
				(
                    Z == input.Z ||
                    (Z != null && Z.Equals(input.Z))
                ) ;
		}
	}
}

