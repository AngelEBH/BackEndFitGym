using BacFitGym.Dominio.Models;
using BacFitGym.FuenteDatos.Context;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BacFitGym.Logica.Login.Gimnasio
{
    public  class GimnasioLogica : IGimnasioLogica
    {
        private readonly IRepository _repository;
        private readonly FitGymDb _context;

        public GimnasioLogica(IRepository repository, FitGymDb context)
        {
            _repository = repository;
            _context = context;

        }

   
        public async Task<Request<bool>> CrearGimnasio(Gimnasios gimnasio)
        {


            var _request = new Request<bool>();
            try
            {
                await _repository.Post(gimnasio);

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

        public async Task<Request<bool>> CrearEntrenador(Entrenadores entrenadores)
        {


            var _request = new Request<bool>();
            try
            {
                await _repository.Post(entrenadores);

                _request.Codigo = HttpStatusCode.OK;
                _request.Entity = true;
                _request.Mensaje = "Se envio la información con éxito.";

                return _request;
            }
            catch (Exception ex)
            {
                _request.Codigo = HttpStatusCode.InternalServerError;
                _request.Entity = false;
                _request.Mensaje = "Hay un error en el servidor o la re.";
                _request.Exception = ex.Message;

                return _request;
            }
        }

        public async Task<Request<bool>> CrearPrecio(Precios precios)
        {


            var _request = new Request<bool>();
            try
            {
                await _repository.Post(precios);

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
        public async Task<Request<bool>> GetGimnasio(Gimnasios gimnasio)
        {


            var _request = new Request<bool>();
            try
            {
                await _repository.Post(gimnasio);

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
     
        public async Task<IEnumerable<Afiliados>> GetInfoAfiliadoById(int id)
        {
            var _request = new Request<bool>();
            
            var afiliado = await _context.Afiliados.Where(x => x.Id_Usuario == id).ToListAsync();
            if (afiliado.Count() == 0)
            {
                return null;
            }

            return afiliado;
        }
    }
}
