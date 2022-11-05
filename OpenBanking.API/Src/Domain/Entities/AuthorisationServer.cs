using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class AuthorisationServer
    {
        public Guid AuthorisationServerId { get; set; }
        public bool AutoRegistrationSuported { get; set; }
        public object AutoRegistrationNotificationWebhook { get; set; } //TODO: Qual tipo deve ser???
        public bool SupportsCiba { get; set; }
        public bool SupportsDCR { get; set; }
        public string CustomerFriendlyDescription { get; set; }
        public string CustomerFriendlyLogoUri { get; set; }
        public string CustomerFriendlyName { get; set; }
        public string? DeveloperPortalUri { get; set; }
        public string? TermsOfServiceUri { get; set; }
        public object NotificationWebhookAddedDate { get; set; } //TODO: Qual tipo deve ser???
        public string OpenIDDiscoveryDocument { get; set; }
        public object Issuer { get; set; } //TODO: Qual tipo deve ser???
        public string PayloadSigningCertLocationUri { get; set; }
        public object ParentAuthorisationServerId { get; set; } //TODO: Qual tipo deve ser???
        public object DeprecatedDate { get; set; } //TODO: Qual tipo deve ser???
        public object RetirementDate { get; set; } //TODO: Qual tipo deve ser???
        public object SupersededByAuthorisationServerId { get; set; } //TODO: Qual tipo deve ser???

        public IEnumerable<ApiResource>? ApiResources { get; set; }
        // public IEnumerable<AuthorisationServerCertification> AuthorisationServerCertifications { get; set; }

        public Guid ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}