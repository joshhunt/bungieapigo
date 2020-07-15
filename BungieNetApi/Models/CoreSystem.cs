using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class CoreSystem{

		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool Enabled { get; set; }

		[DataMember(Name="parameters", EmitDefaultValue=false)]
		public Dictionary<string, string> Parameters { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as CoreSystem);
        }

		public bool Equals(CoreSystem input)
		{
			if (input == null) return false;

			return
				(
                    Enabled == input.Enabled ||
                    (Enabled != null && Enabled.Equals(input.Enabled))
                ) &&
				(
                    Parameters == input.Parameters ||
                    (Parameters != null && Parameters.Equals(input.Parameters))
                ) ;
		}
	}
}

