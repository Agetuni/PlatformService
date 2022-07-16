using AutoMapper;
using PlatformService.Dtos;
using platfromServices.Models;

namespace platfromServices.Profiles
{
    public class PlatformsProfile:Profile
    {
        public PlatformsProfile()
        {
            CreateMap<Platform, platformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}