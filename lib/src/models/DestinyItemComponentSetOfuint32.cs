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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Instances.GetHashCode();
				hashCode = hashCode * 59 + this.Perks.GetHashCode();
				hashCode = hashCode * 59 + this.RenderData.GetHashCode();
				hashCode = hashCode * 59 + this.Stats.GetHashCode();
				hashCode = hashCode * 59 + this.Sockets.GetHashCode();
				hashCode = hashCode * 59 + this.ReusablePlugs.GetHashCode();
				hashCode = hashCode * 59 + this.PlugObjectives.GetHashCode();
				hashCode = hashCode * 59 + this.TalentGrids.GetHashCode();
				hashCode = hashCode * 59 + this.PlugStates.GetHashCode();
				hashCode = hashCode * 59 + this.Objectives.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

