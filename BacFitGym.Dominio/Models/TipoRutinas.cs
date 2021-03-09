using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class TipoRutinas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_TipoRutina { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Descripcion { get; set; }
        public List<Rutinas> Rutinas { get; set; }
    }
}
