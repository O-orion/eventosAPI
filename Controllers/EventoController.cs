using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventosAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace eventosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController: ControllerBase
    {
        private static int id = 1;
        private static List<Evento> eventosList = new List<Evento>();
        Evento vento = new Evento{
            NomeEvento = "Culto Jovem",
            LocalEvento = "Igreja Universal",
            DataEvento = "04/09/2021"
        };
    
        [HttpGet]
        public IEnumerable<Evento> RecuperarEventos(){
            eventosList.Add(vento);
            return eventosList;
        }

        [HttpPost]
        public IActionResult AdicionarEvento([FromBody]Evento evento){
            Evento novoEvento = new Evento{
                Id = id++,
                NomeEvento = evento.NomeEvento,
                DataEvento = evento.DataEvento,
                LocalEvento = evento.LocalEvento
            };

            eventosList.Add(novoEvento);
            return Ok();
        }
    }
}