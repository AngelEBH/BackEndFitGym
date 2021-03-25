using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacFitGym.Controllers.Classes;
using BacFitGym.Dominio.DTO;
using BacFitGym.Dominio.Models;
using BacFitGym.FuenteDatos.Context;
using BacFitGym.Logica.Login;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BacFitGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ILoginLogica _logica;
      
        private readonly IDataProtector _protector;
        private readonly FitGymDb _context;

        public UsuarioController(ILoginLogica logica, IRepository repository, IDataProtectionProvider protectionProvider, FitGymDb context)
        {
            _logica = logica;
            _context = context;
            _protector = protectionProvider.CreateProtector("Valor_unico");
        }

        [HttpPost]
         public async Task<Request<bool>> PostUsuario(Usuario user)
        {
            string cifrado = _protector.Protect(user.Password);
            user.Password = cifrado;
         
            return await _logica.PostUsuario(user);
        }

        [HttpPost("UserCliente")]
        public async Task<Request<bool>> CrearCLiente(Usuario user)
        {
            user.RolesId = 2;         
            string cifrado2 = Encrypter.Encrypt(user.Password);
            user.Password = cifrado2;
             
            return await _logica.PostUsuario(user);
        }
        [HttpPost("CrearAdministrador")]
        public async Task<Request<bool>> CrearAdministrador(Usuario user)
        {
            user.RolesId = 1;
            string cifrado2 = Encrypter.Encrypt(user.Password);
            user.Password = cifrado2;
            return await _logica.CrearAdministrador(user);
        }

        [HttpGet("GetInfoUsuarioPersona/{UserName}/{CorreoElectronico}")]
        public async Task<ActionResult> GetInfoUsuarioPersona(string UserName, string CorreoElectronico)
        {
            var user = await _context.Usuarios.Where(x => x.UserName == UserName && x.CorreoElectronico == CorreoElectronico).ToListAsync();
            return Ok(user);


        }

        [HttpPost("AuthUser")]
        public async Task<Request<bool>> PostAuthUser(UsuarioDTO user)
        {
            //string desincriptar = _protector.Unprotect(cifrado);
            return await _logica.PostAuthUser(user);
        }
        [HttpPost("UserLogin")]
        public async Task<ActionResult<Usuario>> PostLogin(UsuarioDTO user)
        {
            var passencrypted = Encrypter.Encrypt(user.Password);
           // string desincriptar = _protector.Unprotect(user.Password);
            var User = await _context.Usuarios.FirstOrDefaultAsync(x => x.CorreoElectronico == user.UserName && x.Password == passencrypted || 
            x.UserName == user.UserName && x.Password == passencrypted);

            var validar = User == null;
            if(validar)
            {
                return NotFound();
            }

            return Ok(new
            {
               Id = User.Id,
               UserName = User.UserName,
               CorreoElectronico = User.CorreoElectronico,
               Password = User.Password,
               RolesId = User.RolesId,

            });
        }
    
    }
}