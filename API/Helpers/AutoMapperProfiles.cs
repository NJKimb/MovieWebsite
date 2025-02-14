using API.Entities;
using AutoMapper;
using MovieAPI.Dtos;
using MovieAPI.Entities;

namespace API.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles() {
        CreateMap<Movie, MovieDto>();       
        CreateMap<Photo, PhotoDto>();
    }
}
