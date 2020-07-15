using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class HyperlinkReference{

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="url", EmitDefaultValue=false)]
		public string Url { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as HyperlinkReference);
        }

		public bool Equals(HyperlinkReference input)
		{
			if (input == null) return false;

			return
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    Url == input.Url ||
                    (Url != null && Url.Equals(input.Url))
                ) ;
		}
	}
}

