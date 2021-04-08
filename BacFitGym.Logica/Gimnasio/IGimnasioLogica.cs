using BacFitGym.Dominio.Models;
using BacFitGym.Transversal.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BacFitGym.Logica.Login.Gimnasio
{
    public interface IGimnasioLogica
    {
        Task<Request<bool>> CrearGimnasio(Gimnasios gimnasio);
        Task<Request<bool>> CrearRutinas(Rutinas rutinas);

        Task<Request<bool>> CrearTipoRutinas(TipoRutinas tipoRutinas);
        Task<Request<bool>> CrearEntrenador(Entrenadores entrenadores);
        Task<Request<bool>> CrearPrecio(Precios precios);
        Task<IEnumerable<Afiliados>> GetInfoAfiliadoById(int id);
        Task<IEnumerable<TipoRutinas>> GetRutina(int id);
        Task<IEnumerable<Rutinas>> GetDetalleRutina(int id);
        Task<IEnumerable<TipoRutinas>> DeleteRutina(int id);
    }
}