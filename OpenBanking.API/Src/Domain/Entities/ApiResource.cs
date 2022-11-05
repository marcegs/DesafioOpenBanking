using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ApiResource
    {
        public Guid ApiResourceId { get; set; }
        public string ApiVersion { get; set; }
        public bool FamilyComplete { get; set; }
        public object ApiCertificationUri { get; set; } //TODO: Qual tipo deve ser???
        public object CertificationStatus { get; set; } //TODO: Qual tipo deve ser???
        public object CertificationStartDate { get; set; } //TODO: Qual tipo deve ser???
        public object CertificationExpirationDate { get; set; } //TODO: Qual tipo deve ser???
        public string ApiFamilyType { get; set; }

        public IEnumerable<ApiDiscoveryEndpoint>? ApiDiscoveryEndpoints { get; set; }

        public Guid AuthorisationServerId { get; set; }
        public AuthorisationServer AuthorisationServer { get; set; }
    }
}