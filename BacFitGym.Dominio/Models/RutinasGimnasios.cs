using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class RutinasGimnasios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_RutinaGimnasio { get; set; }    

        [Required(ErrorMessage = "This field is required")]
        public int Id_Gimnasio { get; set; }
        public int Id_Rutina { get; set; }

        public Rutinas Rutinas { get; set; }
        public Gimnasios Gimnasios { get; set; }

    }
}
