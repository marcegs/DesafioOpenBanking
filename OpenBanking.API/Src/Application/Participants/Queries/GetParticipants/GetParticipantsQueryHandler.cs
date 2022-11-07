using Application.Common.Dtos;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Participants.Queries.GetParticipants;

public class GetParticipantsQueryHandler : IRequestHandler<GetParticipantsQuery, GetParticipantsResponse>
{
    private readonly IMapper _mapper;
    private readonly IOpenBankingDbContext _openBankingDbContext;

    public GetParticipantsQueryHandler(IOpenBankingDbContext openBankingDbContext, IMapper mapper)
    {
        _openBankingDbContext = openBankingDbContext;
        _mapper = mapper;
    }

    public async Task<GetParticipantsResponse> Handle(GetParticipantsQuery query, CancellationToken cancellationToken)
    {
        var participants = await _openBankingDbContext.Participants
            .AsNoTracking()
            .OrderBy(a=>a.LegalEntityName)
            .ProjectTo<ParticipantsDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
        return new GetParticipantsResponse
        {
            count = participants.Count,
            participants = participants
        };
    }
}