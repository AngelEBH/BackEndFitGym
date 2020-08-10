using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacFitGym.Dominio.DTO;
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
    public class UsuarioController : ControllerBase
    {
        private readonly ILoginLogica _logica;
        private readonly IRepository _repository;

        public UsuarioController(ILoginLogica logica, IRepository repository)
        {
            _logica = logica;
            _repository = repository;
        }

        [HttpPost]
         public async Task<Request<bool>> PostUsuario(Usuario user)
        {
             return await _logica.PostUsuario(user);
        }

        [HttpPost("AuthUser")]
        public async Task<Request<bool>> PostAuthUser(UsuarioDTO user)
        {
            return await _logica.PostAuthUser(user);
        }

    }
}