using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// BNet attempts to group vendors into similar collections. These groups aren't technically game canonical, but they are helpful for filtering vendors or showing them organized into a clean view on a webpage or app.
	/// </summary>
	/// <summary>
	/// These definitions represent the groups we've built. Unlike in Destiny 1, a Vendors' group may change dynamically as the game state changes: thus, you will want to check DestinyVendorComponent responses to find a vendor's currently active Group (if you care).
	/// </summary>
	/// <summary>
	/// Using this will let you group your vendors in your UI in a similar manner to how we will do grouping in the Companion.
	/// </summary>
	[DataContract]
	public class DestinyVendorGroupDefinition{

		/// <summary>
		/// The recommended order in which to render the groups, Ascending order.
		/// </summary>
		[DataMember(Name="order", EmitDefaultValue=false)]
		public long Order { get; set; }

		/// <summary>
		/// For now, a group just has a name.
		/// </summary>
		[DataMember(Name="categoryName", EmitDefaultValue=false)]
		public string CategoryName { get; set; }

		/// <summary>
		/// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
		/// </summary>
		/// <summary>
		/// When entities refer to each other in Destiny content, it is this hash that they are referring to.
		/// </summary>
		[DataMember(Name="hash", EmitDefaultValue=false)]
		public uint Hash { get; set; }

		/// <summary>
		/// The index of the entity as it was found in the investment tables.
		/// </summary>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public long Index { get; set; }

		/// <summary>
		/// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
		/// </summary>
		[DataMember(Name="redacted", EmitDefaultValue=false)]
		public bool Redacted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorGroupDefinition);
        }

		public bool Equals(DestinyVendorGroupDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Order == input.Order ||
                    (Order != null && Order.Equals(input.Order))
                ) &&
				(
                    CategoryName == input.CategoryName ||
                    (CategoryName != null && CategoryName.Equals(input.CategoryName))
                ) &&
				(
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
				(
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
				(
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
		}
	}
}

