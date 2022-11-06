export class Info {
  participantByIdDto: ParticipantByIdDto;
  constructor() {
    this.participantByIdDto = new ParticipantByIdDto();
  }
}

export class ParticipantByIdDto {
  addressLine1: string | undefined;
  addressLine2: string | undefined;
  city: string | undefined;
  companyRegister: string | undefined;
  country: string | undefined;
  countryOfRegistration: string | undefined;
  createdOn: string | undefined;
  legalEntityName: string | undefined;
  organisationName: string | undefined;
  parentOrganisationReference: string | undefined;
  participantId: string | undefined;
  postcode: string | undefined;
  registeredName: string | undefined;
  registrationId: string | undefined;
  registrationNumber: string | undefined;
  status: string | undefined;
  authorisationServers: AuthorisationServerDto[];
  orgDomainClaims: OrgDomainClaimDto[];
  orgDomainRoleClaims: OrgDomainRoleClaimDto[];
  constructor() {
    this.authorisationServers = [];
    this.orgDomainClaims = [];
    this.orgDomainRoleClaims = [];
  }
}

export class AuthorisationServerDto {
  authorisationServerId: string | undefined;
  autoRegistrationSuported: boolean | undefined;
  supportsCiba: boolean | undefined;
  supportsDCR: boolean | undefined;
  customerFriendlyDescription: string | undefined;
  customerFriendlyLogoUri: string | undefined;
  customerFriendlyName: string | undefined;
  developerPortalUri: string | undefined;
  termsOfServiceUri: string | undefined;
  openIDDiscoveryDocument: string | undefined;
  payloadSigningCertLocationUri: string | undefined;
  apiResources: ApiResourceDto[];
  apiFamilyType: string | undefined;
  constructor(){
    this.apiResources = []
  }
}

export class OrgDomainClaimDto {
  orgDomainClaimId: string | undefined;
  authorisationDomainName: string | undefined;
  authorityName: string | undefined;
  registrationId: string | undefined;
  status: string | undefined;
  apiFamilyType: string | undefined;
}

export class OrgDomainRoleClaimDto {
  orgDomainRoleClaimId: string | undefined;
  status: string | undefined;
  authorisationDomain: string | undefined;
  role: string | undefined;
  registrationId: string | undefined;
  apiFamilyType: string | undefined;
}

export class ApiResourceDto {
  apiResourceId: string | undefined;
  apiVersion: string | undefined;
  familyComplete: boolean | undefined;
  apiFamilyType: string | undefined;
}
