using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Presentation nodes can be restricted by various requirements. This defines the rules of those requirements, and the message(s) to be shown if these requirements aren't met.
	/// </summary>
	[DataContract]
	public class DestinyPresentationNodeRequirementsBlock{

		/// <summary>
		/// If this node is not accessible due to Entitlements (for instance, you don't own the required game expansion), this is the message to show.
		/// </summary>
		[DataMember(Name="entitlementUnavailableMessage", EmitDefaultValue=false)]
		public string EntitlementUnavailableMessage { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeRequirementsBlock);
        }

		public bool Equals(DestinyPresentationNodeRequirementsBlock input)
		{
			if (input == null) return false;

			return
				(
                    EntitlementUnavailableMessage == input.EntitlementUnavailableMessage ||
                    (EntitlementUnavailableMessage != null && EntitlementUnavailableMessage.Equals(input.EntitlementUnavailableMessage))
                ) ;
		}
	}
}

