using Application.Common.Dtos;

namespace Application.Participants.Queries.GetParticipants;

public class GetParticipantsResponse
{
    public int count { get; set; }
    public IEnumerable<ParticipantsDto> participants { get; set; }
}