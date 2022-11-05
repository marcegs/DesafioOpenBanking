using System;

namespace Domain.Entities
{
    public class OrgDomainClaim
    {
        public Guid OrgDomainClaimId { get; set; }
        public string AuthorisationDomainName { get; set; }
        public string AuthorityName { get; set; }
        public string RegistrationId { get; set; }
        public string Status { get; set; }

        public Guid ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}
