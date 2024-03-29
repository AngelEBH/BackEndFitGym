﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BacFitGym.Dominio.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Only accepts one or 50 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string CorreoElectronico { get; set; } 

        [Required(ErrorMessage = "This field is required")]
        [StringLength(200 ,MinimumLength = 8, ErrorMessage = "Only accepts 8 or 25 characters")]
        public string Password { get; set; }
        // public int Id_Gimnasio { get; set; }
        public int RolesId { get; set; }
        public Roles Roles { get; set; }
        public List<Gimnasios> gimnasios { get; set; }
        public List<Afiliados> afiliados { get; set; } 



    }
}
