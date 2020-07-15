using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Sockets may refer to a &quot;Plug Set&quot;: a set of reusable plugs that may be shared across multiple sockets (or even, in theory, multiple sockets over multiple items).
	/// This is the set of those plugs that we came across in the users&#39; inventory, along with the values for plugs in the set. Any given set in this component may be represented in Character and Profile-level, as some plugs may be Profile-level restricted, and some character-level restricted. (note that the ones that are even more specific will remain on the actual socket component itself, as they cannot be reused)
	[DataContract]
	public class DestinyPlugSetsComponent{

		/// <summary>
		/// The shared list of plugs for each relevant PlugSet, keyed by the hash identifier of the PlugSet (DestinyPlugSetDefinition).
		/// </summary>
		[DataMember(Name="plugs", EmitDefaultValue=false)]
		public Map<String, List<DestinyItemPlug>> Plugs { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPlugSetsComponent);
        }

		public bool Equals(DestinyPlugSetsComponent input)
		{
			if (input == null) return false;

			return
				(
                    Plugs == input.Plugs ||
                    (Plugs != null && Plugs.Equals(input.Plugs))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Plugs.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

