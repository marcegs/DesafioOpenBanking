using MediatR;

namespace Application.Participants.Queries.GetParticipantsById;

public class GetParticipantsByIdQuery : IRequest<GetParticipantsByIdResponse>
{
    public Guid id { get; set; }
}