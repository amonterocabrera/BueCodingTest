using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmpleados.Models
{
    public class Empleados
    {
        [Key]
        public int CodEmpleado { get; set; }

        [Required]
        [Column(TypeName ="varchar (150)")]
        public string primerNombre { get; set; }


        [Required]
        [Column(TypeName = "varchar (150)")]
        public string segundoNomre { get; set; }


        [Required]
        [Column(TypeName = "varchar (150)")]
        public string primerApellido { get; set; }


        [Required]
        [Column(TypeName = "varchar (150)")]
        public string segundoApellido { get; set; }


        [Required]
        [Column(TypeName = "varchar (12)")]
        public string Cedula { get; set; }


    }
}
