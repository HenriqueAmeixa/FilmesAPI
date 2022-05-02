﻿using FilmesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;
        [HttpPost]
        public IActionResult AdicionaFilme([FromBody]Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmePorId), new {Id = filme.Id},filme);
        }
        [HttpGet]
        public IActionResult RecuperarFilmes()
        {
                return new OkObjectResult(filmes);       

        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Filme))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RecuperaFilmePorId(int id)
        {
            Filme filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme != null)
            {
                return Ok(filme);
            }
            return  NotFound();
        }
    }
}