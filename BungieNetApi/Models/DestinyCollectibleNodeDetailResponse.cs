using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Returns the detailed information about a Collectible Presentation Node and any Collectibles that are direct descendants.
	/// </summary>
	[DataContract]
	public class DestinyCollectibleNodeDetailResponse{

		/// <summary>
		/// COMPONENT TYPE: Collectibles
		/// </summary>
		[DataMember(Name="collectibles", EmitDefaultValue=false)]
		public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }

		/// <summary>
		/// Item components, keyed by the item hash of the items pointed at collectibles found under the requested Presentation Node.
		/// </summary>
		/// <summary>
		/// NOTE: I had a lot of hemming and hawing about whether these should be keyed by collectible hash or item hash... but ultimately having it be keyed by item hash meant that UI that already uses DestinyItemComponentSet data wouldn't have to have a special override to do the collectible -> item lookup once you delve into an item's details, and it also meant that you didn't have to remember that the Hash being used as the key for plugSets was different from the Hash being used for the other Dictionaries. As a result, using the Item Hash felt like the least crappy solution.
		/// </summary>
		/// <summary>
		/// We may all come to regret this decision. We will see.
		/// </summary>
		/// <summary>
		/// COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
		/// </summary>
		[DataMember(Name="collectibleItemComponents", EmitDefaultValue=false)]
		public DestinyItemComponentSetOfuint32 CollectibleItemComponents { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCollectibleNodeDetailResponse);
        }

		public bool Equals(DestinyCollectibleNodeDetailResponse input)
		{
			if (input == null) return false;

			return
				(
                    Collectibles == input.Collectibles ||
                    (Collectibles != null && Collectibles.Equals(input.Collectibles))
                ) &&
				(
                    CollectibleItemComponents == input.CollectibleItemComponents ||
                    (CollectibleItemComponents != null && CollectibleItemComponents.Equals(input.CollectibleItemComponents))
                ) ;
		}
	}
}

