using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// This describes links between the current graph and others, as well as when that link is relevant.
	/// </summary>
	[DataContract]
	public class DestinyLinkedGraphDefinition{

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// Where the sausage gets made. Unlock Expressions are the foundation of the game's gating mechanics and investment-related restrictions. They can test Unlock Flags and Unlock Values for certain states, using a sufficient amount of logical operators such that unlock expressions are effectively Turing complete.
		/// </summary>
		/// <summary>
		/// Use UnlockExpressionParser to evaluate expressions using an IUnlockContext parsed from Babel.
		/// </summary>
		[DataMember(Name="unlockExpression", EmitDefaultValue=false)]
		public DestinyUnlockExpressionDefinition UnlockExpression { get; set; }

		[DataMember(Name="linkedGraphId", EmitDefaultValue=false)]
		public uint LinkedGraphId { get; set; }

		[DataMember(Name="linkedGraphs", EmitDefaultValue=false)]
		public List<DestinyLinkedGraphEntryDefinition> LinkedGraphs { get; set; }

		[DataMember(Name="overview", EmitDefaultValue=false)]
		public string Overview { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyLinkedGraphDefinition);
        }

		public bool Equals(DestinyLinkedGraphDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    UnlockExpression == input.UnlockExpression ||
                    (UnlockExpression != null && UnlockExpression.Equals(input.UnlockExpression))
                ) &&
				(
                    LinkedGraphId == input.LinkedGraphId ||
                    (LinkedGraphId != null && LinkedGraphId.Equals(input.LinkedGraphId))
                ) &&
				(
                    LinkedGraphs == input.LinkedGraphs ||
                    (LinkedGraphs != null && LinkedGraphs.Equals(input.LinkedGraphs))
                ) &&
				(
                    Overview == input.Overview ||
                    (Overview != null && Overview.Equals(input.Overview))
                ) ;
		}
	}
}

