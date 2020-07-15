using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// A point of entry into an activity, gated by an unlock flag and with some more-or-less useless (for our purposes) phase information. I&#39;m including it in case we end up being able to bolt more useful information onto it in the future.
	/// UPDATE: Turns out this information isn&#39;t actually useless, and is in fact actually useful for people. Who would have thought? We still don&#39;t have localized info for it, but at least this will help people when they&#39;re looking at phase indexes in stats data, or when they want to know what phases have been completed on a weekly achievement.
	[DataContract]
	public class DestinyActivityInsertionPointDefinition{

		/// <summary>
		/// A unique hash value representing the phase. This can be useful for, for example, comparing how different instances of Raids have phases in different orders!
		/// </summary>
		[DataMember(Name="phaseHash", EmitDefaultValue=false)]
		public uint PhaseHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityInsertionPointDefinition);
        }

		public bool Equals(DestinyActivityInsertionPointDefinition input)
		{
			if (input == null) return false;

			return
				(
                    PhaseHash == input.PhaseHash ||
                    (PhaseHash != null && PhaseHash.Equals(input.PhaseHash))
                ) ;
		}
	}
}

