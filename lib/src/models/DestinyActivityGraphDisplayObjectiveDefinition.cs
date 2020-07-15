using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// When a Graph needs to show active Objectives, this defines those objectives as well as an identifier.
	[DataContract]
	public class DestinyActivityGraphDisplayObjectiveDefinition{

		/// <summary>
		/// $NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works.
		/// </summary>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public uint Id { get; set; }

		/// <summary>
		/// The objective being shown on the map.
		/// </summary>
		[DataMember(Name="objectiveHash", EmitDefaultValue=false)]
		public uint ObjectiveHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphDisplayObjectiveDefinition);
        }

		public bool Equals(DestinyActivityGraphDisplayObjectiveDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Id == input.Id ||
                    (Id != null && Id.Equals(input.Id))
                ) &&
				(
                    ObjectiveHash == input.ObjectiveHash ||
                    (ObjectiveHash != null && ObjectiveHash.Equals(input.ObjectiveHash))
                ) ;
		}
	}
}

