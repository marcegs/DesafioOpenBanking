using Application.Common.Dtos;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Participants.Queries.GetParticipants;

public class GetParticipantsHandler : IRequestHandler<GetParticipantsQuery, GetParticipantsResponse>
{
    private readonly IMapper _mapper;
    private readonly IOpenBankingDbContext _openBankingDbContext;

    public GetParticipantsHandler(IOpenBankingDbContext openBankingDbContext, IMapper mapper)
    {
        _openBankingDbContext = openBankingDbContext;
        _mapper = mapper;
    }

    public async Task<GetParticipantsResponse> Handle(GetParticipantsQuery query, CancellationToken cancellationToken)
    {
        var participants = await _openBankingDbContext.Participants
            .AsNoTracking()
            //.Skip(10)
            //.Take(5)
            .ProjectTo<ParticipantsDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
        return new GetParticipantsResponse
        {
            count = participants.Count,
            participants = participants
        };
    }
}