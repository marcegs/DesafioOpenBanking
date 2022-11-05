using Application.Common.Dtos;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Participants.Queries.GetParticipants;

public class GetParticipantsHandler : IRequestHandler<GetParticipantsQuery, GetParticipantsResponse>
{
    private readonly IOpenBankingDbContext _openBankingDbContext;
    private readonly IMapper _mapper;

    public GetParticipantsHandler(IOpenBankingDbContext openBankingDbContext, IMapper mapper)
    {
        _openBankingDbContext = openBankingDbContext;
        _mapper = mapper;
    }

    public async Task<GetParticipantsResponse> Handle(GetParticipantsQuery query, CancellationToken cancellationToken)
    {
        var organisations = await _openBankingDbContext.Participants
            .AsNoTracking()
            //.Skip(10)
            //.Take(5)
            .ProjectTo<ParticipantsDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
        return new GetParticipantsResponse
        {
            count = organisations.Count,
            participants = organisations
        };
    }
}