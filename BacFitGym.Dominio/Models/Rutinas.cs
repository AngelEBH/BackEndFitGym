using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class Rutinas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Rutina { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Instruccion  { get; set; }
        public int Id_TipoRutina { get; set; }
        public TipoRutinas TipoRutinas { get; set; }
        public List<RutinasGimnasios> rutinasGimnasios { get; set; }
        public List<AfiliadoRutinas> AfiliadoRutinas { get; set; }
    }
}
