using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class Series{

		/// <summary>
		/// Collection of samples with time and value.
		/// </summary>
		[DataMember(Name="datapoints", EmitDefaultValue=false)]
		public List<Datapoint> Datapoints { get; set; }

		/// <summary>
		/// Target to which to datapoints apply.
		/// </summary>
		[DataMember(Name="target", EmitDefaultValue=false)]
		public string Target { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as Series);
        }

		public bool Equals(Series input)
		{
			if (input == null) return false;

			return
				(
                    Datapoints == input.Datapoints ||
                    (Datapoints != null && Datapoints.Equals(input.Datapoints))
                ) &&
				(
                    Target == input.Target ||
                    (Target != null && Target.Equals(input.Target))
                ) ;
		}
	}
}

