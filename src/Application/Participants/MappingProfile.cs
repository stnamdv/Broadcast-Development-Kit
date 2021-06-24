using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using static Application.Participant.Commands.UpdateParticipantMeetingStatus;

namespace Application.Participants
{
    /// <summary>
    ///     Mapping Profile for AutoMapper
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ParticipantStreamModel, ParticipantStream>().ReverseMap();

            CreateMap<ParticipantStreamDetailsModel, ParticipantStreamDetails>()
                .ForPath(dest => dest.StreamKey, opts => opts.MapFrom(src => src.Passphrase)).ReverseMap();

            CreateMap<UpdateParticipantMeetingStatusCommand, ParticipantStream>();
        }
    }
}