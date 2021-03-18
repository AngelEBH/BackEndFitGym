using BacFitGym.Dominio.DTO;
using BacFitGym.Dominio.Models;
using BacFitGym.FuenteDatos.Context;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.DataProtection;
using System.Net;
using System.Linq.Expressions;

namespace BacFitGym.Logica.Login
{
    public class LoginLogica : ILoginLogica
    {
        private readonly IDataProtector _protector;
        private readonly IRepository _repository;
        private readonly FitGymDb _context;
       
        public LoginLogica(IRepository repository, IDataProtectionProvider protectionProvider, FitGymDb context)
        {
            _context = context;
            _repository = repository;
            _protector = protectionProvider.CreateProtector("Valor_unico");
        }

      
        public async Task<Request<bool>> PostUsuario(Usuario usuario)
        {
            //Encriptar(usuario.Password);

            var _request = new Request<bool>();
            try
            {
                await _repository.Post(usuario);

                _request.Codigo = HttpStatusCode.OK;
                _request.Entity = true;
                _request.Mensaje = "Se envio la información con éxito.";

                return _request;
            }
            catch (Exception ex)
            {
                _request.Codigo = HttpStatusCode.InternalServerError;
                _request.Entity = false;
                _request.Mensaje = "Hay un error en el servidor o la red.";
                _request.Exception = ex.Message;

                return _request;
            }
        }

        public async Task<Request<bool>> CrearAdministrador(Usuario usuario)
        {
            //Encriptar(usuario.Password);

            var _request = new Request<bool>();
            try
            {
                await _repository.Post(usuario);

                _request.Codigo = HttpStatusCode.OK;
                _request.Entity = true;
                _request.Mensaje = "Se envio la información con éxito.";

                return _request;
            }
            catch (Exception ex)
            {
                _request.Codigo = HttpStatusCode.InternalServerError;
                _request.Entity = false;
                _request.Mensaje = "Hay un error en el servidor o la red.";
                _request.Exception = ex.Message;

                return _request;
            }
        }

        public async Task<Request<bool>> PostAuthUser(UsuarioDTO user)
        {
            
            var _request = new Request<bool>();

            try
            {
                Expression<Func<Usuario, bool>> expresionUser = u => u.UserName == user.UserName && u.Password == user.Password;

                
                var r = await _repository.GetById<Usuario>(expresionUser);
                
               
                if (r == null)
                {
                    _request.Codigo = HttpStatusCode.OK;
                    _request.Entity = true;
                    _request.Mensaje = "Las credenciales son incorrectas.";
                }
                else
                {
                    _request.Codigo = HttpStatusCode.OK;
                    _request.Entity = true;
                    _request.Mensaje = "Las credenciales son correctas.";
                }

                return _request;
            }
            catch (Exception ex)
            {
                _request.Codigo = HttpStatusCode.InternalServerError;
                _request.Entity = false;
                _request.Mensaje = "Hay un error en el servidor o la red.";
                _request.Exception = ex.Message;

                return _request;
            }


        }

        public async Task<ActionResult<Usuario>> GetInfoUsuarioPersona(Usuario user)
        {

            var user1 = await _context.Usuarios.Where(x => x.UserName == user.UserName && x.CorreoElectronico == user.CorreoElectronico).ToListAsync();
            return user;
            
        }

       
    }
}
