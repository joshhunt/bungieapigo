using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyPresentationNodesComponent{

		[DataMember(Name="nodes", EmitDefaultValue=false)]
		public Map<String, DestinyPresentationNodeComponent> Nodes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodesComponent);
        }

		public bool Equals(DestinyPresentationNodesComponent input)
		{
			if (input == null) return false;

			return
				(
                    Nodes == input.Nodes ||
                    (Nodes != null && Nodes.Equals(input.Nodes))
                ) ;
		}
	}
}

