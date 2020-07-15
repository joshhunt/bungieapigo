using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyItemPlugBase{

		/// <summary>
		/// The hash identifier of the DestinyInventoryItemDefinition that represents this plug.
		/// </summary>
		[DataMember(Name="plugItemHash", EmitDefaultValue=false)]
		public uint PlugItemHash { get; set; }

		/// <summary>
		/// If true, this plug has met all of its insertion requirements. Big if true.
		/// </summary>
		[DataMember(Name="canInsert", EmitDefaultValue=false)]
		public bool CanInsert { get; set; }

		/// <summary>
		/// If true, this plug will provide its benefits while inserted.
		/// </summary>
		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool Enabled { get; set; }

		/// <summary>
		/// If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition's plug.insertionRules property, so you can show the reasons why it can't be inserted.
		/// </summary>
		/// <summary>
		/// This list will be empty if the plug can be inserted.
		/// </summary>
		[DataMember(Name="insertFailIndexes", EmitDefaultValue=false)]
		public List<long> InsertFailIndexes { get; set; }

		/// <summary>
		/// If a plug is not enabled, this will be populated with indexes into the plug item definition's plug.enabledRules property, so that you can show the reasons why it is not enabled.
		/// </summary>
		/// <summary>
		/// This list will be empty if the plug is enabled.
		/// </summary>
		[DataMember(Name="enableFailIndexes", EmitDefaultValue=false)]
		public List<long> EnableFailIndexes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemPlugBase);
        }

		public bool Equals(DestinyItemPlugBase input)
		{
			if (input == null) return false;

			return
				(
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash != null && PlugItemHash.Equals(input.PlugItemHash))
                ) &&
				(
                    CanInsert == input.CanInsert ||
                    (CanInsert != null && CanInsert.Equals(input.CanInsert))
                ) &&
				(
                    Enabled == input.Enabled ||
                    (Enabled != null && Enabled.Equals(input.Enabled))
                ) &&
				(
                    InsertFailIndexes == input.InsertFailIndexes ||
                    (InsertFailIndexes != null && InsertFailIndexes.Equals(input.InsertFailIndexes))
                ) &&
				(
                    EnableFailIndexes == input.EnableFailIndexes ||
                    (EnableFailIndexes != null && EnableFailIndexes.Equals(input.EnableFailIndexes))
                ) ;
		}
	}
}

