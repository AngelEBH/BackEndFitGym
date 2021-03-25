using BacFitGym.Dominio.DTO;
using BacFitGym.Dominio.Models;
using BacFitGym.Transversal.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BacFitGym.Logica.AfiliafoCliente
{
    public interface IAfiliadoLogica
    {
        Task<Request<bool>> PostUsuario(Usuario usuario);
        Task<Request<bool>> CrearAfiliado(Afiliados afiliados);
        Task<Request<bool>> CrearRutinas(Rutinas rutinas);
        Task<ActionResult<Usuario>> GetInfoUsuarioPersona(Usuario user);
    }
}