using AutoMapper;
using FilmesAPI.Data.Dtos.Endereco;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class EnderecoProfilie: Profile
    {
        public EnderecoProfilie()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
