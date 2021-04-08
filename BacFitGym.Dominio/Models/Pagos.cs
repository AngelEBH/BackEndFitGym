using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class Pagos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Pago{ get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Descripcion { get; set; }

        public string Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Gimnasio { get; set; }
        public int Id_Afiliado { get; set; }
        public Gimnasios gimnasios { get; set; }
        public Afiliados afiliados { get; set; }
    }
}
