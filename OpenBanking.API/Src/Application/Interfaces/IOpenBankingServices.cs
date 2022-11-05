using Domain.Entities;

namespace Application.Interfaces;

public interface IOpenBankingServices
{
    Task<IEnumerable<Participant>> GetParticipantsAsync(CancellationToken cancellationToken);
}