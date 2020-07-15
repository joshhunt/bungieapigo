using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Represents a status string that could be conditionally displayed about an activity. Note that externally, you can only see the strings themselves. Internally we combine this information with server state to determine which strings should be shown.
	/// </summary>
	[DataContract]
	public class DestinyActivityUnlockStringDefinition{

		/// <summary>
		/// The string to be displayed if the conditions are met.
		/// </summary>
		[DataMember(Name="displayString", EmitDefaultValue=false)]
		public string DisplayString { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityUnlockStringDefinition);
        }

		public bool Equals(DestinyActivityUnlockStringDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayString == input.DisplayString ||
                    (DisplayString != null && DisplayString.Equals(input.DisplayString))
                ) ;
		}
	}
}

