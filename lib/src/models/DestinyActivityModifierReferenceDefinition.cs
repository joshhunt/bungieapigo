using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// A reference to an Activity Modifier from another entity, such as an Activity (for now, just Activities).
	/// This defines some
	[DataContract]
	public class DestinyActivityModifierReferenceDefinition{

		/// <summary>
		/// The hash identifier for the DestinyActivityModifierDefinition referenced by this activity.
		/// </summary>
		[DataMember(Name="activityModifierHash", EmitDefaultValue=false)]
		public uint ActivityModifierHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityModifierReferenceDefinition);
        }

		public bool Equals(DestinyActivityModifierReferenceDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ActivityModifierHash == input.ActivityModifierHash ||
                    (ActivityModifierHash != null && ActivityModifierHash.Equals(input.ActivityModifierHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ActivityModifierHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

