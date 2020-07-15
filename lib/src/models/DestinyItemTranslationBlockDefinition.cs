using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// This Block defines the rendering data associated with the item, if any.
	[DataContract]
	public class DestinyItemTranslationBlockDefinition{

		[DataMember(Name="weaponPatternIdentifier", EmitDefaultValue=false)]
		public string WeaponPatternIdentifier { get; set; }

		[DataMember(Name="weaponPatternHash", EmitDefaultValue=false)]
		public uint WeaponPatternHash { get; set; }

		[DataMember(Name="defaultDyes", EmitDefaultValue=false)]
		public List<DyeReference> DefaultDyes { get; set; }

		[DataMember(Name="lockedDyes", EmitDefaultValue=false)]
		public List<DyeReference> LockedDyes { get; set; }

		[DataMember(Name="customDyes", EmitDefaultValue=false)]
		public List<DyeReference> CustomDyes { get; set; }

		[DataMember(Name="arrangements", EmitDefaultValue=false)]
		public List<DestinyGearArtArrangementReference> Arrangements { get; set; }

		[DataMember(Name="hasGeometry", EmitDefaultValue=false)]
		public bool HasGeometry { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemTranslationBlockDefinition);
        }

		public bool Equals(DestinyItemTranslationBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    WeaponPatternIdentifier == input.WeaponPatternIdentifier ||
                    (WeaponPatternIdentifier != null && WeaponPatternIdentifier.Equals(input.WeaponPatternIdentifier))
                ) &&
				(
                    WeaponPatternHash == input.WeaponPatternHash ||
                    (WeaponPatternHash != null && WeaponPatternHash.Equals(input.WeaponPatternHash))
                ) &&
				(
                    DefaultDyes == input.DefaultDyes ||
                    (DefaultDyes != null && DefaultDyes.Equals(input.DefaultDyes))
                ) &&
				(
                    LockedDyes == input.LockedDyes ||
                    (LockedDyes != null && LockedDyes.Equals(input.LockedDyes))
                ) &&
				(
                    CustomDyes == input.CustomDyes ||
                    (CustomDyes != null && CustomDyes.Equals(input.CustomDyes))
                ) &&
				(
                    Arrangements == input.Arrangements ||
                    (Arrangements != null && Arrangements.Equals(input.Arrangements))
                ) &&
				(
                    HasGeometry == input.HasGeometry ||
                    (HasGeometry != null && HasGeometry.Equals(input.HasGeometry))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.WeaponPatternIdentifier.GetHashCode();
				hashCode = hashCode * 59 + this.WeaponPatternHash.GetHashCode();
				hashCode = hashCode * 59 + this.DefaultDyes.GetHashCode();
				hashCode = hashCode * 59 + this.LockedDyes.GetHashCode();
				hashCode = hashCode * 59 + this.CustomDyes.GetHashCode();
				hashCode = hashCode * 59 + this.Arrangements.GetHashCode();
				hashCode = hashCode * 59 + this.HasGeometry.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

