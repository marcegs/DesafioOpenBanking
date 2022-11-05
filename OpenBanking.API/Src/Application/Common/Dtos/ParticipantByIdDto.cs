using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Dtos;

public class ParticipantByIdDto : IMapFrom<Participant>
{
    public Guid ParticipantId { get; set; }
    public string Status { get; set; }
    // public string OrganisationName { get; set; }
    // public DateTime CreatedOn { get; set; }
    // public string LegalEntityName { get; set; }
    // public string CountryOfRegistration { get; set; }
    // public string CompanyRegister { get; set; }
    // public string RegistrationNumber { get; set; }
    // public string? RegistrationId { get; set; }
    // public string RegisteredName { get; set; }
    // public string AddressLine1 { get; set; }
    // public string AddressLine2 { get; set; }
    // public string City { get; set; }
    // public string Postcode { get; set; }
    // public string Country { get; set; }
    // public string? ParentOrganisationReference { get; set; }
    //
    // public IEnumerable<AuthorisationServerDto>? AuthorisationServers { get; set; }
    // public IEnumerable<OrgDomainClaimDto>? OrgDomainClaims { get; set; }
    // public IEnumerable<OrgDomainRoleClaimDto>? OrgDomainRoleClaims { get; set; }

    public class AuthorisationServerDto : IMapFrom<AuthorisationServer>
    {
        public Guid AuthorisationServerId { get; set; }
        public bool AutoRegistrationSuported { get; set; }
        public bool SupportsCiba { get; set; }
        public bool SupportsDCR { get; set; }
        public string CustomerFriendlyDescription { get; set; }
        public string CustomerFriendlyLogoUri { get; set; }
        public string CustomerFriendlyName { get; set; }
        public string? DeveloperPortalUri { get; set; }
        public string? TermsOfServiceUri { get; set; }
        public string OpenIDDiscoveryDocument { get; set; }
        public string PayloadSigningCertLocationUri { get; set; }

        public IEnumerable<ApiResourceDto>? ApiResources { get; set; }
        public string ApiFamilyType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AuthorisationServer, AuthorisationServerDto>();
        }
    }

    public class OrgDomainClaimDto : IMapFrom<OrgDomainClaim>
    {
        public Guid OrgDomainClaimId { get; set; }
        public string AuthorisationDomainName { get; set; }
        public string AuthorityName { get; set; }
        public string RegistrationId { get; set; }
        public string Status { get; set; }
        public string ApiFamilyType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrgDomainClaim, OrgDomainClaimDto>();
        }
    }

    public class OrgDomainRoleClaimDto : IMapFrom<OrgDomainRoleClaim>
    {
        public Guid OrgDomainRoleClaimId { get; set; }
        public string Status { get; set; }
        public string AuthorisationDomain { get; set; }
        public string Role { get; set; }
        public string RegistrationId { get; set; }
        public string ApiFamilyType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrgDomainRoleClaim, OrgDomainRoleClaimDto>();
        }
    }

    public class ApiResourceDto : IMapFrom<ApiResource>
    {
        public Guid ApiResourceId { get; set; }
        public string ApiVersion { get; set; }
        public bool FamilyComplete { get; set; }
        public string ApiFamilyType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ApiResource, ApiResourceDto>();
        }
    }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Participant, ParticipantByIdDto>();
    }
}