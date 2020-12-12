using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyRecordsComponent
    {
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public Dictionary<string, DestinyRecordComponent> Records { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph categories.
        /// </summary>
        [DataMember(Name = "recordCategoriesRootNodeHash", EmitDefaultValue = false)]
        public uint RecordCategoriesRootNodeHash { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph Seals.
        /// </summary>
        [DataMember(Name = "recordSealsRootNodeHash", EmitDefaultValue = false)]
        public uint RecordSealsRootNodeHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyRecordsComponent);
        }

        public bool Equals(DestinyRecordsComponent input)
        {
            if (input == null) return false;

            return
                (
                    Records == input.Records ||
                    (Records != null && Records.SequenceEqual(input.Records))
                ) &&
                (
                    RecordCategoriesRootNodeHash == input.RecordCategoriesRootNodeHash ||
                    (RecordCategoriesRootNodeHash.Equals(input.RecordCategoriesRootNodeHash))
                ) &&
                (
                    RecordSealsRootNodeHash == input.RecordSealsRootNodeHash ||
                    (RecordSealsRootNodeHash.Equals(input.RecordSealsRootNodeHash))
                ) ;
        }
    }
}

