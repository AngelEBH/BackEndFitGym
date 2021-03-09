using BacFitGym.Dominio.DTO;
using BacFitGym.Dominio.Models;
using BacFitGym.Transversal.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BacFitGym.Logica.Login
{
    public interface ILoginLogica
    {
        Task<Request<bool>> PostUsuario(Usuario usuario);
        Task<Request<bool>> CrearAdministrador(Usuario usuario);
        Task<Request<bool>> PostAuthUser(UsuarioDTO usuario);
    }
}
