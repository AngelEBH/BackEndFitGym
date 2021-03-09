using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacFitGym.Dominio.DTO;
using BacFitGym.Dominio.Models;
using BacFitGym.Logica.Login;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using Microsoft.AspNetCore.DataProtection;
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
        private readonly IDataProtector _protector;

        public UsuarioController(ILoginLogica logica, IRepository repository, IDataProtectionProvider protectionProvider)
        {
            _logica = logica;
            _repository = repository;
            _protector = protectionProvider.CreateProtector("Valor_unico");
        }

        [HttpPost]
         public async Task<Request<bool>> PostUsuario(Usuario user)
        {
            //string cifrado = _protector.Protect(user.Password);
            //user.Password = cifrado;
            //string desincriptar = _protector.Unprotect(cifrado);
            return await _logica.PostUsuario(user);
        }

        [HttpPost("AuthUser")]
        public async Task<Request<bool>> PostAuthUser(UsuarioDTO user)
        {
            
            return await _logica.PostAuthUser(user);
        }
        [HttpPost("CrearAfiliado")]
        public async Task<Request<bool>> CrearAfiliadoUsuario(Usuario user)
        {
           
            return await _logica.PostUsuario(user);
        }

        [HttpPost("CrearAdministrador")]
        public async Task<Request<bool>> CrearAdministrador(Usuario user)
        {

            return await _logica.CrearAdministrador(user);
        }
    }
}