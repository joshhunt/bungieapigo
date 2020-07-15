using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyInsertPlugsActionRequest{

		/// <summary>
		/// Action token provided by the AwaGetActionToken API call.
		/// </summary>
		[DataMember(Name="actionToken", EmitDefaultValue=false)]
		public string ActionToken { get; set; }

		/// <summary>
		/// The instance ID of the item having a plug inserted. Only instanced items can have sockets.
		/// </summary>
		[DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
		public long ItemInstanceId { get; set; }

		/// <summary>
		/// The plugs being inserted.
		/// </summary>
		[DataMember(Name="plug", EmitDefaultValue=false)]
		public DestinyInsertPlugsRequestEntry Plug { get; set; }

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyInsertPlugsActionRequest);
        }

		public bool Equals(DestinyInsertPlugsActionRequest input)
		{
			if (input == null) return false;

			return
				(
                    ActionToken == input.ActionToken ||
                    (ActionToken != null && ActionToken.Equals(input.ActionToken))
                ) &&
				(
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId != null && ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
				(
                    Plug == input.Plug ||
                    (Plug != null && Plug.Equals(input.Plug))
                ) &&
				(
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
				(
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) ;
		}
	}
}

