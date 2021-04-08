using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacFitGym.Dominio.Models;
using BacFitGym.FuenteDatos.Context;
using BacFitGym.Logica.AfiliafoCliente;
using BacFitGym.Logica.Login;
using BacFitGym.Logica.Login.Gimnasio;
using BacFitGym.PersistenciaDatos.Repository;
using BacFitGym.Transversal.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BacFitGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GimnasioController : ControllerBase
    {
        private readonly ILoginLogica _logica;
        private readonly IAfiliadoLogica _LogicaAf;
        private readonly IGimnasioLogica _GimnLogica;
        private readonly FitGymDb _context;

        public GimnasioController(ILoginLogica logica, IGimnasioLogica gimnasioLogica, FitGymDb context, IAfiliadoLogica logicaAf)
        {
            _logica = logica;
            _context = context;
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

        [HttpPost("CrearTipoRutina")]
        public async Task<Request<bool>> CrearARutina(TipoRutinas tipoRutinas)
        {

            return await _GimnLogica.CrearTipoRutinas(tipoRutinas);
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
        [HttpGet("GetGimnasios")]
        public async Task<ActionResult> GetGimnasios()
        {
            var gimnasios = await _context.Gimnasios.ToListAsync();
            return Ok(gimnasios);
        }
        [HttpGet("GetByGimnsasio/{id}")]
        public async Task<ActionResult> GetByGimnasios(int id)
        {
            var gimnasios = await _context.Gimnasios.Where(x => x.Id_Gimnasio == id).ToListAsync();

            var validar = gimnasios == null;
            if (validar)
            {
                return NotFound();
            }

            return Ok(gimnasios);
        }

        [HttpGet("GetByEntrenador/{id}")]
        public async Task<ActionResult> GetByEntrenadores(int id)
        {
            var entrenador = await _context.Entrenadores.Where(x => x.Id_Gimnasio == id).ToListAsync();

            var validar = entrenador == null;
            if (validar)
            {
                return NotFound();
            }

            return Ok(entrenador);
        }
 

    [HttpGet("GetInfoAfiliadoById/{id}")]
    public async Task<IEnumerable<Afiliados>> GetInfoAfiliadoById(int id)
     {           
            return await _GimnLogica.GetInfoAfiliadoById(id);
     }

    [HttpGet("GetTipoRutina/{id}")]
     public async Task<IEnumerable<TipoRutinas>> GetTipoRutina(int id)
      {
            return await _GimnLogica.GetRutina(id);
           
      }

      [HttpGet("GetDetalleRutina/{id}")]
      public async Task<IEnumerable<Rutinas>> GetDetalleRutina(int id)
       {
          return await _GimnLogica.GetDetalleRutina(id);

      }

        [HttpDelete("DeleteTipoRutina/{id}")]
     public async Task<ActionResult> DeletetTipoRutina(int id)
        {
            var rutina = _context.TipoRutinas.Where(x => x.Id_TipoRutina == id).FirstOrDefault();

            _context.TipoRutinas.Remove(rutina);
            await _context.SaveChangesAsync();

            return Ok(rutina);

        }


        [HttpPut("UpdateTipoRutina/{id}")]
     public async Task<ActionResult<TipoRutinas>> UpdateTipoRutia(int id, TipoRutinas tipoRutinas)
     {
            var item = await _context.TipoRutinas.FirstOrDefaultAsync(x => x.Id_TipoRutina == id);

            var validar = item == null;
            if (validar)
            {
                return NotFound();
            }

            item.Descripcion = tipoRutinas.Descripcion;
            item.Logo = tipoRutinas.Logo;
            item.Id_Gimnasio = tipoRutinas.Id_Gimnasio;
            item.Id_TipoRutina = id;

            await _context.SaveChangesAsync();


            return Ok(new
                {
                    Id_TipoRutina = item.Id_TipoRutina,
                    Descripcion = item.Descripcion,
                    Logo = item.Logo,
                    Id_Gimnasio = item.Id_Gimnasio
                });
       
        }


    }
}
