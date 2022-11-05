using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Participant
    {
        public Guid ParticipantId { get; set; }
        public string Status { get; set; }
        public string OrganisationName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LegalEntityName { get; set; }
        public string CountryOfRegistration { get; set; }
        public string CompanyRegister { get; set; }
        public object? Tag { get; set; } //TODO: Qual tipo deve ser???
        public object? Size { get; set; } //TODO: Qual tipo deve ser???
        public string RegistrationNumber { get; set; }
        public string? RegistrationId { get; set; }
        public string RegisteredName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string? ParentOrganisationReference { get; set; }

        public IEnumerable<AuthorisationServer>? AuthorisationServers { get; set; }
        public IEnumerable<OrgDomainClaim>? OrgDomainClaims { get; set; }
        public IEnumerable<OrgDomainRoleClaim>? OrgDomainRoleClaims { get; set; }
    }
}