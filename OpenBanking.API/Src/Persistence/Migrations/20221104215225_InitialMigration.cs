using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegalEntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryOfRegistration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyRegister = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentOrganisationReference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorisationServers",
                columns: table => new
                {
                    AuthorisationServerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoRegistrationSuported = table.Column<bool>(type: "bit", nullable: false),
                    SupportsCiba = table.Column<bool>(type: "bit", nullable: false),
                    SupportsDCR = table.Column<bool>(type: "bit", nullable: false),
                    CustomerFriendlyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerFriendlyLogoUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerFriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeveloperPortalUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermsOfServiceUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenIDDiscoveryDocument = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayloadSigningCertLocationUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorisationServers", x => x.AuthorisationServerId);
                    table.ForeignKey(
                        name: "FK_AuthorisationServers_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrgDomainClaims",
                columns: table => new
                {
                    OrgDomainClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorisationDomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgDomainClaims", x => x.OrgDomainClaimId);
                    table.ForeignKey(
                        name: "FK_OrgDomainClaims_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrgDomainRoleClaims",
                columns: table => new
                {
                    OrgDomainRoleClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorisationDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParticipantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgDomainRoleClaims", x => x.OrgDomainRoleClaimId);
                    table.ForeignKey(
                        name: "FK_OrgDomainRoleClaims_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApiResources",
                columns: table => new
                {
                    ApiResourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApiVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyComplete = table.Column<bool>(type: "bit", nullable: false),
                    ApiFamilyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorisationServerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResources", x => x.ApiResourceId);
                    table.ForeignKey(
                        name: "FK_ApiResources_AuthorisationServers_AuthorisationServerId",
                        column: x => x.AuthorisationServerId,
                        principalTable: "AuthorisationServers",
                        principalColumn: "AuthorisationServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApiDiscoveryEndpoints",
                columns: table => new
                {
                    ApiDiscoveryEndpointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApiEndpoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApiResourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiDiscoveryEndpoints", x => x.ApiDiscoveryEndpointId);
                    table.ForeignKey(
                        name: "FK_ApiDiscoveryEndpoints_ApiResources_ApiResourceId",
                        column: x => x.ApiResourceId,
                        principalTable: "ApiResources",
                        principalColumn: "ApiResourceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiDiscoveryEndpoints_ApiResourceId",
                table: "ApiDiscoveryEndpoints",
                column: "ApiResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ApiResources_AuthorisationServerId",
                table: "ApiResources",
                column: "AuthorisationServerId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorisationServers_ParticipantId",
                table: "AuthorisationServers",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgDomainClaims_ParticipantId",
                table: "OrgDomainClaims",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgDomainRoleClaims_ParticipantId",
                table: "OrgDomainRoleClaims",
                column: "ParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiDiscoveryEndpoints");

            migrationBuilder.DropTable(
                name: "OrgDomainClaims");

            migrationBuilder.DropTable(
                name: "OrgDomainRoleClaims");

            migrationBuilder.DropTable(
                name: "ApiResources");

            migrationBuilder.DropTable(
                name: "AuthorisationServers");

            migrationBuilder.DropTable(
                name: "Participants");
        }
    }
}
