using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class AfiliadoRutinas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_RutinaAfiliafo { get; set; }
        public int Id_Afiliado { get; set; }
        public int Id_Rutina { get; set; }

        public Afiliados afiliados { get; set; }
        public Rutinas Rutinas { get; set; }

    }
}
