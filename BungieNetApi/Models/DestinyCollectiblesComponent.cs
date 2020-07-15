using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyCollectiblesComponent{

		[DataMember(Name="collectibles", EmitDefaultValue=false)]
		public Map<String, DestinyCollectibleComponent> Collectibles { get; set; }

		/// <summary>
		/// The hash for the root presentation node definition of Collection categories.
		/// </summary>
		[DataMember(Name="collectionCategoriesRootNodeHash", EmitDefaultValue=false)]
		public uint CollectionCategoriesRootNodeHash { get; set; }

		/// <summary>
		/// The hash for the root presentation node definition of Collection Badges.
		/// </summary>
		[DataMember(Name="collectionBadgesRootNodeHash", EmitDefaultValue=false)]
		public uint CollectionBadgesRootNodeHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCollectiblesComponent);
        }

		public bool Equals(DestinyCollectiblesComponent input)
		{
			if (input == null) return false;

			return
				(
                    Collectibles == input.Collectibles ||
                    (Collectibles != null && Collectibles.Equals(input.Collectibles))
                ) &&
				(
                    CollectionCategoriesRootNodeHash == input.CollectionCategoriesRootNodeHash ||
                    (CollectionCategoriesRootNodeHash != null && CollectionCategoriesRootNodeHash.Equals(input.CollectionCategoriesRootNodeHash))
                ) &&
				(
                    CollectionBadgesRootNodeHash == input.CollectionBadgesRootNodeHash ||
                    (CollectionBadgesRootNodeHash != null && CollectionBadgesRootNodeHash.Equals(input.CollectionBadgesRootNodeHash))
                ) ;
		}
	}
}

