using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class GlobalAlert{

		[DataMember(Name="AlertKey", EmitDefaultValue=false)]
		public string AlertKey { get; set; }

		[DataMember(Name="AlertHtml", EmitDefaultValue=false)]
		public string AlertHtml { get; set; }

		[DataMember(Name="AlertTimestamp", EmitDefaultValue=false)]
		public string AlertTimestamp { get; set; }

		[DataMember(Name="AlertLink", EmitDefaultValue=false)]
		public string AlertLink { get; set; }

		[DataMember(Name="AlertLevel", EmitDefaultValue=false)]
		public GlobalAlertLevel AlertLevel { get; set; }

		[DataMember(Name="AlertType", EmitDefaultValue=false)]
		public GlobalAlertType AlertType { get; set; }

		[DataMember(Name="StreamInfo", EmitDefaultValue=false)]
		public StreamInfo StreamInfo { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GlobalAlert);
        }

		public bool Equals(GlobalAlert input)
		{
			if (input == null) return false;

			return
				(
                    AlertKey == input.AlertKey ||
                    (AlertKey != null && AlertKey.Equals(input.AlertKey))
                ) &&
				(
                    AlertHtml == input.AlertHtml ||
                    (AlertHtml != null && AlertHtml.Equals(input.AlertHtml))
                ) &&
				(
                    AlertTimestamp == input.AlertTimestamp ||
                    (AlertTimestamp != null && AlertTimestamp.Equals(input.AlertTimestamp))
                ) &&
				(
                    AlertLink == input.AlertLink ||
                    (AlertLink != null && AlertLink.Equals(input.AlertLink))
                ) &&
				(
                    AlertLevel == input.AlertLevel ||
                    (AlertLevel != null && AlertLevel.Equals(input.AlertLevel))
                ) &&
				(
                    AlertType == input.AlertType ||
                    (AlertType != null && AlertType.Equals(input.AlertType))
                ) &&
				(
                    StreamInfo == input.StreamInfo ||
                    (StreamInfo != null && StreamInfo.Equals(input.StreamInfo))
                ) ;
		}
	}
}

