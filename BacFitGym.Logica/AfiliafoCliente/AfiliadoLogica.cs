using BacFitGym.PersistenciaDatos.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BacFitGym.Logica.AfiliafoCliente
{
    public class AfiliadoLogica : IAfiliadoLogica
    {
        private readonly IRepository _repository;

        public AfiliadoLogica(IRepository repository)
        {
            _repository = repository;

        }
    }
}
