using Application.Common.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;


namespace Infra.Services;

public class OpenBankingServices : IOpenBankingServices
{
    private readonly IHttpClientFactory _httpClientFactory;
    public IEnumerable<Participant>? Participants { get; set; }

    public OpenBankingServices(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IEnumerable<Participant>> GetParticipantsAsync(CancellationToken cancellationToken)
    {
        var httpClient = _httpClientFactory.CreateClient("OpenBanking");
        var httpResponseMessage = await httpClient.GetAsync("participants", cancellationToken);

        if (!httpResponseMessage.IsSuccessStatusCode)
        {
            if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                throw new OpenBankingServicesNotFoundException(httpResponseMessage.ToString());

            throw new OpenBankingServicesBadRequestException(httpResponseMessage.ToString());
        }

        await using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync(cancellationToken);
        Participants =
            await JsonSerializer.DeserializeAsync<IEnumerable<Participant>>(contentStream,
                cancellationToken: cancellationToken);

        return Participants;
    }
}