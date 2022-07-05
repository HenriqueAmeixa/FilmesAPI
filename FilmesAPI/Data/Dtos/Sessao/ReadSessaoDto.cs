using FilmesAPI.Models;
using System;

namespace FilmesAPI.Data.Dtos
{
    public class ReadSessaoDto
    {
        public int Id { get; set; }
        public  Cinema Cinema { get; set; }
        public  Filme Filme { get; set; }
        public DateTime HoraDeEncerramento { get; set; }
        public DateTime HoraDeInicio { get; set; }
    }
}
