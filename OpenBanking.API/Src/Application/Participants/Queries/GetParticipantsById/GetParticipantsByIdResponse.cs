using Application.Common.Dtos;
using Domain.Entities;

namespace Application.Participants.Queries.GetParticipantsById;

public class GetParticipantsByIdResponse
{
    public ParticipantByIdDto ParticipantByIdDto { get; set; }
}