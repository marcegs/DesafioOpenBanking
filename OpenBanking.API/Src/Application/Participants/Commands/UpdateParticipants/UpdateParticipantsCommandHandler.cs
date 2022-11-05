using Application.Interfaces;
using MediatR;

namespace Application.Participants.Commands.UpdateParticipants;

public class UpdateParticipantsCommandHandler : IRequestHandler<UpdateParticipantsCommand, bool>
{
    private readonly IOpenBankingDbContext _openBankingDbContext;
    private readonly IOpenBankingServices _openBankingServices;

    public UpdateParticipantsCommandHandler(IOpenBankingServices openBankingServices,
        IOpenBankingDbContext openBankingDbContext)
    {
        _openBankingServices = openBankingServices;
        _openBankingDbContext = openBankingDbContext;
    }

    public async Task<bool> Handle(UpdateParticipantsCommand request, CancellationToken cancellationToken)
    {
        var organisations = await _openBankingServices.GetParticipantsAsync(cancellationToken);
        _openBankingDbContext.DropDb();
        _openBankingDbContext.CreateDb();
        await _openBankingDbContext.Participants.AddRangeAsync(organisations, cancellationToken);
        await _openBankingDbContext.SaveChangesAsync(cancellationToken);
        return true;
    }
}