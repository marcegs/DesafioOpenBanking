using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class OrgDomainRoleClaim
    {
        public Guid OrgDomainRoleClaimId { get; set; }
        public string Status { get; set; }
        public string AuthorisationDomain { get; set; }
        public string Role { get; set; }
        public IEnumerable<object>? Authorisations { get; set; } //TODO: Qual tipo deve ser???
        public string RegistrationId { get; set; }

        public Guid ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}