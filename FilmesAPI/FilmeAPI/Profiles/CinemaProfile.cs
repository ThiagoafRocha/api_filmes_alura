using AutoMapper;
using FilmeAPI.Models;
using FilmesAPI.Data.Dtos;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile: Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<UpdateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
        }
    }
}
