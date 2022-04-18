using AutoMapper;
using FilmeAPI.Models;
using FilmesAPI.Data.Dtos;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile: Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}
