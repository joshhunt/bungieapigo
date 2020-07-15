using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Where the sausage gets made. Unlock Expressions are the foundation of the game's gating mechanics and investment-related restrictions. They can test Unlock Flags and Unlock Values for certain states, using a sufficient amount of logical operators such that unlock expressions are effectively Turing complete.
	/// </summary>
	/// <summary>
	/// Use UnlockExpressionParser to evaluate expressions using an IUnlockContext parsed from Babel.
	/// </summary>
	[DataContract]
	public class DestinyUnlockExpressionDefinition{

		/// <summary>
		/// A shortcut for determining the most restrictive gating that this expression performs. See the DestinyGatingScope enum's documentation for more details.
		/// </summary>
		[DataMember(Name="scope", EmitDefaultValue=false)]
		public DestinyGatingScope Scope { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyUnlockExpressionDefinition);
        }

		public bool Equals(DestinyUnlockExpressionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) ;
		}
	}
}

