using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	[Flags]
	public enum ApplicationScopes
	{
		/// <summary>
		/// ReadBasicUserProfile = 1
		/// Read basic user profile information such as the user&#39;s handle, avatar icon, etc.
		/// </summary>
		[EnumMember(Value = "1")]
		ReadBasicUserProfile = 1,

		/// <summary>
		/// ReadGroups = 2
		/// Read Group&#x2F;Clan Forums, Wall, and Members for groups and clans that the user has joined.
		/// </summary>
		[EnumMember(Value = "2")]
		ReadGroups = 2,

		/// <summary>
		/// WriteGroups = 4
		/// Write Group&#x2F;Clan Forums, Wall, and Members for groups and clans that the user has joined.
		/// </summary>
		[EnumMember(Value = "4")]
		WriteGroups = 4,

		/// <summary>
		/// AdminGroups = 8
		/// Administer Group&#x2F;Clan Forums, Wall, and Members for groups and clans that the user is a founder or an administrator.
		/// </summary>
		[EnumMember(Value = "8")]
		AdminGroups = 8,

		/// <summary>
		/// BnetWrite = 16
		/// Create new groups, clans, and forum posts, along with other actions that are reserved for Bungie.net elevated scope: not meant to be used by third party applications.
		/// </summary>
		[EnumMember(Value = "16")]
		BnetWrite = 16,

		/// <summary>
		/// MoveEquipDestinyItems = 32
		/// Move or equip Destiny items
		/// </summary>
		[EnumMember(Value = "32")]
		MoveEquipDestinyItems = 32,

		/// <summary>
		/// ReadDestinyInventoryAndVault = 64
		/// Read Destiny 1 Inventory and Vault contents. For Destiny 2, this scope is needed to read anything regarded as private. This is the only scope a Destiny 2 app needs for read operations against Destiny 2 data such as inventory, vault, currency, vendors, milestones, progression, etc.
		/// </summary>
		[EnumMember(Value = "64")]
		ReadDestinyInventoryAndVault = 64,

		/// <summary>
		/// ReadUserData = 128
		/// Read user data such as who they are web notifications, clan&#x2F;group memberships, recent activity, muted users.
		/// </summary>
		[EnumMember(Value = "128")]
		ReadUserData = 128,

		/// <summary>
		/// EditUserData = 256
		/// Edit user data such as preferred language, status, motto, avatar selection and theme.
		/// </summary>
		[EnumMember(Value = "256")]
		EditUserData = 256,

		/// <summary>
		/// ReadDestinyVendorsAndAdvisors = 512
		/// Access vendor and advisor data specific to a user. OBSOLETE. This scope is only used on the Destiny 1 API.
		/// </summary>
		[EnumMember(Value = "512")]
		ReadDestinyVendorsAndAdvisors = 512,

		/// <summary>
		/// ReadAndApplyTokens = 1024
		/// Read offer history and claim and apply tokens for the user.
		/// </summary>
		[EnumMember(Value = "1024")]
		ReadAndApplyTokens = 1024,

		/// <summary>
		/// AdvancedWriteActions = 2048
		/// Can perform actions that will result in a prompt to the user via the Destiny app.
		/// </summary>
		[EnumMember(Value = "2048")]
		AdvancedWriteActions = 2048,

		/// <summary>
		/// PartnerOfferGrant = 4096
		/// Can user the partner offer api to claim rewards defined for a partner
		/// </summary>
		[EnumMember(Value = "4096")]
		PartnerOfferGrant = 4096,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}