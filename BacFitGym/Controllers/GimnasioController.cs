using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacFitGym.Dominio.Models;
using BacFitGym.Logica.Login;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BacFitGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GimnasioController : ControllerBase
    {
        private readonly ILoginLogica _logica;

        public GimnasioController(ILoginLogica logica)
        {
            _logica = logica;
          
        }
        [HttpPost("CrearGimnasio")]
        public async Task<Request<bool>> CrearAfiliadoUsuario(Usuario user)
        {

            return await _logica.PostUsuario(user);
        }
    }
}
