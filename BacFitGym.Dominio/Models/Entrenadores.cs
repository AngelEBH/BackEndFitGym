using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
   public  class Entrenadores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Entrenador { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string NombreEntrenador { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Id_Gimnasio { get; set; }
        public Gimnasios gimnasios { get; set; }
        public List<Afiliados> Afiliados { get; set; }
    }
}
