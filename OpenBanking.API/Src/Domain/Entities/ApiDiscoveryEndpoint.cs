using System;

namespace Domain.Entities
{
    public class ApiDiscoveryEndpoint
    {
        public Guid ApiDiscoveryEndpointId { get; set; }
        public string ApiEndpoint { get; set; }

        public Guid ApiResourceId { get; set; }
        public ApiResource ApiResource { get; set; }
    }
}