export class ParticipantByIdDto {
  participantId: String | undefined;
  status: String | undefined;
}

// export class ParticipantByIdDto2 {
//   addressLine1: string | undefined;
//   addressLine2: string | undefined;
//   city: string | undefined;
//   companyRegistrer: string | undefined;
//   country: string | undefined;
//   countryOfRegistration: string | undefined;
//   createdOn: string | undefined;
//   legalEntityName: string | undefined;
//   organizationName: string | undefined;
//   parentOrganisationReference: string | undefined;
//   participantId: string | undefined;
//   postcode: string | undefined;
//   registeredName: string | undefined;
//   registrationId: string | undefined;
//   registrationNumber: string | undefined;
//   status: string | undefined;
//   authorisationServers: AuthorisationServerDto[] | undefined;
//   orgDomainClaims: OrgDomainClaimDto[] | undefined;
//   orgDomainRoleClaims: OrgDomainRoleClaimDto[] | undefined;
// }

// export class AuthorisationServerDto {
//   authorisationServerId: string | undefined;
//   autoRegistrationSuported: boolean | undefined;
//   supportsCiba: boolean | undefined;
//   supportsDCR: boolean | undefined;
//   customerFriendlyDescription: string | undefined;
//   customerFriendlyLogoUri: string | undefined;
//   customerFriendlyName: string | undefined;
//   developerPortalUri: string | undefined;
//   termsOfServiceUri: string | undefined;
//   openIDDiscoveryDocument: string | undefined;
//   payloadSigningCertLocationUri: string | undefined;
//   apiResources: ApiResourceDto[] | undefined;
//   apiFamilyType: string | undefined;
// }

// export class OrgDomainClaimDto {
//   orgDomainClaimId: string | undefined;
//   authorisationDomainName: string | undefined;
//   authorityName: string | undefined;
//   registrationId: string | undefined;
//   status: string | undefined;
//   apiFamilyType: string | undefined;
// }

// export class OrgDomainRoleClaimDto {
//   orgDomainRoleClaimId: string | undefined;
//   status: string | undefined;
//   authorisationDomain: string | undefined;
//   role: string | undefined;
//   registrationId: string | undefined;
//   apiFamilyType: string | undefined;
// }

// export class ApiResourceDto {
//   apiResourceId: string | undefined;
//   apiVersion: string | undefined;
//   familyComplete: boolean | undefined;
//   apiFamilyType: string | undefined;
// }
