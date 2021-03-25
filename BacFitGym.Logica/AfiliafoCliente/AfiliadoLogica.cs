using BacFitGym.Dominio.Models;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BacFitGym.Logica.AfiliafoCliente
{
    public class AfiliadoLogica : IAfiliadoLogica
    {
        private readonly IRepository _repository;

        public AfiliadoLogica(IRepository repository)
        {
            _repository = repository;

        }

        public async Task<Request<bool>> CrearAfiliado(Afiliados afiliados)
        {
            var _request = new Request<bool>();
            try
            {
                await _repository.Post(afiliados);

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

        public async Task<Request<bool>> CrearRutinas(Rutinas rutinas)
        {
            var _request = new Request<bool>();
            try
            {
                await _repository.Post(rutinas);

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

        public Task<ActionResult<Usuario>> GetInfoUsuarioPersona(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Task<Request<bool>> PostUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
