using Domain.Entities;

namespace Application.Interfaces;

public interface IOpenBankingServices
{
    Task<IEnumerable<Domain.Entities.Participant>> GetParticipantsAsync(CancellationToken cancellationToken);
}