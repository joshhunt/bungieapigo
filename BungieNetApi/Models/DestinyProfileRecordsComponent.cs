using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyProfileRecordsComponent{

		/// <summary>
		/// Your "Triumphs" score.
		/// </summary>
		[DataMember(Name="score", EmitDefaultValue=false)]
		public long Score { get; set; }

		/// <summary>
		/// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
		/// </summary>
		[DataMember(Name="trackedRecordHash", EmitDefaultValue=false)]
		public uint TrackedRecordHash { get; set; }

		[DataMember(Name="records", EmitDefaultValue=false)]
		public Map<String, DestinyRecordComponent> Records { get; set; }

		/// <summary>
		/// The hash for the root presentation node definition of Triumph categories.
		/// </summary>
		[DataMember(Name="recordCategoriesRootNodeHash", EmitDefaultValue=false)]
		public uint RecordCategoriesRootNodeHash { get; set; }

		/// <summary>
		/// The hash for the root presentation node definition of Triumph Seals.
		/// </summary>
		[DataMember(Name="recordSealsRootNodeHash", EmitDefaultValue=false)]
		public uint RecordSealsRootNodeHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileRecordsComponent);
        }

		public bool Equals(DestinyProfileRecordsComponent input)
		{
			if (input == null) return false;

			return
				(
                    Score == input.Score ||
                    (Score != null && Score.Equals(input.Score))
                ) &&
				(
                    TrackedRecordHash == input.TrackedRecordHash ||
                    (TrackedRecordHash != null && TrackedRecordHash.Equals(input.TrackedRecordHash))
                ) &&
				(
                    Records == input.Records ||
                    (Records != null && Records.Equals(input.Records))
                ) &&
				(
                    RecordCategoriesRootNodeHash == input.RecordCategoriesRootNodeHash ||
                    (RecordCategoriesRootNodeHash != null && RecordCategoriesRootNodeHash.Equals(input.RecordCategoriesRootNodeHash))
                ) &&
				(
                    RecordSealsRootNodeHash == input.RecordSealsRootNodeHash ||
                    (RecordSealsRootNodeHash != null && RecordSealsRootNodeHash.Equals(input.RecordSealsRootNodeHash))
                ) ;
		}
	}
}

