using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class Gimnasios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Gimnasio { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string NommbreGimnasio { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime HoraInicial { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime HoraFinal { get; set; }
        public string Contacto { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Descripcion { get; set; }
       //  [Required(ErrorMessage = "This field is required")]
        public string logo { get; set; }
        public string InformacionDetalle { get; set; }
        public string Dueño { get; set; }
        public string slogan { get; set; }

        public int Id_Usuario { get; set; }

        public Usuario Usuario { get; set; }
        public List<Afiliados> Afiliados { get; set; }
        public List<RutinasGimnasios> RutinasGimnasios { get; set; }
        public List<Entrenadores> Entrenadores { get; set; }
        public List<Precios> Precios{ get; set; }
        public List<Pagos> Pagos { get; set; }
        public List<TipoRutinas> tipoRutinas { get; set; }
    }
}
