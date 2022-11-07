using Application.Common.Dtos;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Participants.Queries.GetParticipantsById;

public class GetParticipantsByIdQueryHandler : IRequestHandler<GetParticipantsByIdQuery, GetParticipantsByIdResponse>
{
    private readonly IMapper _mapper;
    private readonly IOpenBankingDbContext _openBankingDbContext;

    public GetParticipantsByIdQueryHandler(IOpenBankingDbContext openBankingDbContext, IMapper mapper)
    {
        _openBankingDbContext = openBankingDbContext;
        _mapper = mapper;
    }

    public async Task<GetParticipantsByIdResponse> Handle(GetParticipantsByIdQuery request,
        CancellationToken cancellationToken)
    {
        var participant = await _openBankingDbContext.Participants
            .Include(a => a.OrgDomainRoleClaims)
            .Include(a => a.AuthorisationServers)!.ThenInclude(b => b.ApiResources)
            .Include(a => a.OrgDomainClaims)
            .Where(a => a.ParticipantId.Equals(request.id))
            .AsNoTracking()
            .ProjectTo<ParticipantByIdDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken);

        var response = new GetParticipantsByIdResponse
        {
            ParticipantByIdDto = participant ?? throw new Exception("not found")
        };
        return response;
    }
}