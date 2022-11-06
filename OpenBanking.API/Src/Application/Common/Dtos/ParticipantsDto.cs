using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Dtos;

public class ParticipantsDto : IMapFrom<Participant>
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Participant, ParticipantsDto>()
            .ForMember(d => d.Id, opt => opt.MapFrom(s => s.ParticipantId))
            .ForMember(d => d.Name, opt => opt.MapFrom(s => s.LegalEntityName));
    }
}