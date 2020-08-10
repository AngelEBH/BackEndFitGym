using BacFitGym.Dominio.DTO;
using BacFitGym.Dominio.Models;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BacFitGym.Logica.Login
{
    public class LoginLogica : ILoginLogica
    {
        private readonly IRepository _repository;
        public LoginLogica(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<Request<bool>> PostUsuario(Usuario usuario)
        {
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
    }
}
