using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class Application
    {
        /// <summary>
        /// Unique ID assigned to the application
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public long ApplicationId { get; set; }

        /// <summary>
        /// Name of the application
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// URL used to pass the user's authorization code to the application
        /// </summary>
        [DataMember(Name = "redirectUrl", EmitDefaultValue = false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Link to website for the application where a user can learn more about the app.
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Permissions the application needs to work
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public long Scope { get; set; }

        /// <summary>
        /// Value of the Origin header sent in requests generated by this application.
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Current status of the application.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ApplicationStatus Status { get; set; }

        /// <summary>
        /// Date the application was first added to our database.
        /// </summary>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date the application status last changed.
        /// </summary>
        [DataMember(Name = "statusChanged", EmitDefaultValue = false)]
        public DateTime StatusChanged { get; set; }

        /// <summary>
        /// Date the first time the application status entered the 'Public' status.
        /// </summary>
        [DataMember(Name = "firstPublished", EmitDefaultValue = false)]
        public DateTime FirstPublished { get; set; }

        /// <summary>
        /// List of team members who manage this application on Bungie.net. Will always consist of at least the application owner.
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        public List<ApplicationDeveloper> Team { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as Application);
        }

        public bool Equals(Application input)
        {
            if (input == null) return false;

            return
                (
                    ApplicationId == input.ApplicationId ||
                    (ApplicationId.Equals(input.ApplicationId))
                ) &&
                (
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
                (
                    RedirectUrl == input.RedirectUrl ||
                    (RedirectUrl != null && RedirectUrl.Equals(input.RedirectUrl))
                ) &&
                (
                    Link == input.Link ||
                    (Link != null && Link.Equals(input.Link))
                ) &&
                (
                    Scope == input.Scope ||
                    (Scope.Equals(input.Scope))
                ) &&
                (
                    Origin == input.Origin ||
                    (Origin != null && Origin.Equals(input.Origin))
                ) &&
                (
                    Status == input.Status ||
                    (Status != null && Status.Equals(input.Status))
                ) &&
                (
                    CreationDate == input.CreationDate ||
                    (CreationDate != null && CreationDate.Equals(input.CreationDate))
                ) &&
                (
                    StatusChanged == input.StatusChanged ||
                    (StatusChanged != null && StatusChanged.Equals(input.StatusChanged))
                ) &&
                (
                    FirstPublished == input.FirstPublished ||
                    (FirstPublished != null && FirstPublished.Equals(input.FirstPublished))
                ) &&
                (
                    Team == input.Team ||
                    (Team != null && Team.SequenceEqual(input.Team))
                ) ;
        }
    }
}

