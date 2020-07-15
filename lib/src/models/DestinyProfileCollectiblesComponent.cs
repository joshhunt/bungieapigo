using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyProfileCollectiblesComponent{

		/// <summary>
		/// The list of collectibles determined by the game as having been "recently" acquired.
		/// </summary>
		[DataMember(Name="recentCollectibleHashes", EmitDefaultValue=false)]
		public List<uint> RecentCollectibleHashes { get; set; }

		/// <summary>
		/// The list of collectibles determined by the game as having been "recently" acquired.
		/// </summary>
		/// <summary>
		/// The game client itself actually controls this data, so I personally question whether anyone will get much use out of this: because we can't edit this value through the API. But in case anyone finds it useful, here it is.
		/// </summary>
		[DataMember(Name="newnessFlaggedCollectibleHashes", EmitDefaultValue=false)]
		public List<uint> NewnessFlaggedCollectibleHashes { get; set; }

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
            return this.Equals(input as DestinyProfileCollectiblesComponent);
        }

		public bool Equals(DestinyProfileCollectiblesComponent input)
		{
			if (input == null) return false;

			return
				(
                    RecentCollectibleHashes == input.RecentCollectibleHashes ||
                    (RecentCollectibleHashes != null && RecentCollectibleHashes.Equals(input.RecentCollectibleHashes))
                ) &&
				(
                    NewnessFlaggedCollectibleHashes == input.NewnessFlaggedCollectibleHashes ||
                    (NewnessFlaggedCollectibleHashes != null && NewnessFlaggedCollectibleHashes.Equals(input.NewnessFlaggedCollectibleHashes))
                ) &&
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

