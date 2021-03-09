using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class Precios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Precio { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public int IdGimnasio { get; set; }

        public Gimnasios Gimnasios { get; set; }
    }
}
