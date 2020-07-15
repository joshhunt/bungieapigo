using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyItemComponentSetOfuint32{

		[DataMember(Name="instances", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent Instances { get; set; }

		[DataMember(Name="perks", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent Perks { get; set; }

		[DataMember(Name="renderData", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent RenderData { get; set; }

		[DataMember(Name="stats", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent Stats { get; set; }

		[DataMember(Name="sockets", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent Sockets { get; set; }

		[DataMember(Name="reusablePlugs", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

		[DataMember(Name="plugObjectives", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }

		[DataMember(Name="talentGrids", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent TalentGrids { get; set; }

		[DataMember(Name="plugStates", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }

		[DataMember(Name="objectives", EmitDefaultValue=false)]
		public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemComponentSetOfuint32);
        }

		public bool Equals(DestinyItemComponentSetOfuint32 input)
		{
			if (input == null) return false;

			return
				(
                    Instances == input.Instances ||
                    (Instances != null && Instances.Equals(input.Instances))
                ) &&
				(
                    Perks == input.Perks ||
                    (Perks != null && Perks.Equals(input.Perks))
                ) &&
				(
                    RenderData == input.RenderData ||
                    (RenderData != null && RenderData.Equals(input.RenderData))
                ) &&
				(
                    Stats == input.Stats ||
                    (Stats != null && Stats.Equals(input.Stats))
                ) &&
				(
                    Sockets == input.Sockets ||
                    (Sockets != null && Sockets.Equals(input.Sockets))
                ) &&
				(
                    ReusablePlugs == input.ReusablePlugs ||
                    (ReusablePlugs != null && ReusablePlugs.Equals(input.ReusablePlugs))
                ) &&
				(
                    PlugObjectives == input.PlugObjectives ||
                    (PlugObjectives != null && PlugObjectives.Equals(input.PlugObjectives))
                ) &&
				(
                    TalentGrids == input.TalentGrids ||
                    (TalentGrids != null && TalentGrids.Equals(input.TalentGrids))
                ) &&
				(
                    PlugStates == input.PlugStates ||
                    (PlugStates != null && PlugStates.Equals(input.PlugStates))
                ) &&
				(
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.Equals(input.Objectives))
                ) ;
		}
	}
}

