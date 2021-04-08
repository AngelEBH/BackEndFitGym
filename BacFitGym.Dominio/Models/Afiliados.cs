using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class Afiliados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Afiliado { get; set; }
        public int Id_Gimnasio { get; set; }
        public int Id_Usuario { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string  Edad { get; set; }
        //[Required(ErrorMessage = "This field is required")]
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public int Id_Entrenador { get; set; }
        public Usuario Usuarios { get; set; }
        public Gimnasios Gimnasios { get; set; }
        public Entrenadores Entrenadores { get; set; }
        public List<Pagos> Pagos{ get; set; }
        public List<AfiliadoRutinas> AfiliadoRutinas { get; set; }
    }
}
