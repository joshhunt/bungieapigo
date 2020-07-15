using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Many items can be rendered in 3D. When you request this block, you will obtain the custom data needed to render this specific instance of the item.
	/// </summary>
	[DataContract]
	public class DestinyItemRenderComponent{

		/// <summary>
		/// If you should use custom dyes on this item, it will be indicated here.
		/// </summary>
		[DataMember(Name="useCustomDyes", EmitDefaultValue=false)]
		public bool UseCustomDyes { get; set; }

		/// <summary>
		/// A dictionary for rendering gear components, with:
		/// </summary>
		/// <summary>
		/// key = Art Arrangement Region Index
		/// </summary>
		/// <summary>
		/// value = The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.
		/// </summary>
		[DataMember(Name="artRegions", EmitDefaultValue=false)]
		public Map<String, long> ArtRegions { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemRenderComponent);
        }

		public bool Equals(DestinyItemRenderComponent input)
		{
			if (input == null) return false;

			return
				(
                    UseCustomDyes == input.UseCustomDyes ||
                    (UseCustomDyes != null && UseCustomDyes.Equals(input.UseCustomDyes))
                ) &&
				(
                    ArtRegions == input.ArtRegions ||
                    (ArtRegions != null && ArtRegions.Equals(input.ArtRegions))
                ) ;
		}
	}
}

