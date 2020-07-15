using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// A reference to an Activity Modifier from another entity, such as an Activity (for now, just Activities).
	/// </summary>
	/// <summary>
	/// This defines some
	/// </summary>
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
	}
}

