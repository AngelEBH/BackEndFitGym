using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacFitGym.Dominio.Models;
using BacFitGym.Logica.AfiliafoCliente;
using BacFitGym.Logica.Login;
using BacFitGym.Logica.Login.Gimnasio;
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
        private readonly IAfiliadoLogica _LogicaAf;
        private readonly IGimnasioLogica _GimnLogica;

        public GimnasioController(ILoginLogica logica, IAfiliadoLogica logicaAf, IGimnasioLogica gimnasioLogica )
        {
            _logica = logica;
            _LogicaAf = logicaAf;
            _GimnLogica = gimnasioLogica;
          
        }
        [HttpPost("CrearAfiliado")]
        public async Task<Request<bool>> CrearAfiliadoUsuario(Afiliados afilidado)
        {

            return await _LogicaAf.CrearAfiliado(afilidado);
        }

        [HttpPost("CrearRutina")]
        public async Task<Request<bool>> CrearRutina(Rutinas rutinas)
        {

            return await _LogicaAf.CrearRutinas(rutinas);
        }

        [HttpPost("CrearGimnasios")]
        public async Task<Request<bool>> CrearGimnasios(Gimnasios gimnasios)
        {

            return await _GimnLogica.CrearGimnasio(gimnasios);
        }
        [HttpPost("CrearPrecio")]
        public async Task<Request<bool>> CrearPrecio(Precios precios)
        {

            return await _GimnLogica.CrearPrecio(precios);
        }

        [HttpPost("CrearEntrenador")]
        public async Task<Request<bool>> CrearEntrenador(Entrenadores entrenadores)
        {

            return await _GimnLogica.CrearEntrenador(entrenadores);
        }
    }
}
