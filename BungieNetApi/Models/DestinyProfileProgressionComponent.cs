using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// The set of progression-related information that applies at a Profile-wide level for your Destiny experience. This differs from the Jimi Hendrix Experience because there's less guitars on fire. Yet. #spoileralert?
	/// </summary>
	/// <summary>
	/// This will include information such as Checklist info.
	/// </summary>
	[DataContract]
	public class DestinyProfileProgressionComponent{

		/// <summary>
		/// The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)
		/// </summary>
		/// <summary>
		/// For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.
		/// </summary>
		[DataMember(Name="checklists", EmitDefaultValue=false)]
		public Dictionary<string, Dictionary<string, bool>> Checklists { get; set; }

		/// <summary>
		/// Data related to your progress on the current season's artifact that is the same across characters.
		/// </summary>
		[DataMember(Name="seasonalArtifact", EmitDefaultValue=false)]
		public DestinyArtifactProfileScoped SeasonalArtifact { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileProgressionComponent);
        }

		public bool Equals(DestinyProfileProgressionComponent input)
		{
			if (input == null) return false;

			return
				(
                    Checklists == input.Checklists ||
                    (Checklists != null && Checklists.Equals(input.Checklists))
                ) &&
				(
                    SeasonalArtifact == input.SeasonalArtifact ||
                    (SeasonalArtifact != null && SeasonalArtifact.Equals(input.SeasonalArtifact))
                ) ;
		}
	}
}

