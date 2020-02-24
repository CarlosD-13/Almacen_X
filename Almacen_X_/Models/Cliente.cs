using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen_X_.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [Column(TypeName = "varchar(15)")]
        [Required]
        public string Cedula { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Apellido { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar(12)")]
        [Required]
        public string Telefono { get; set; }
        [Column(TypeName = "Varchar(1)")]
        [Required]
        public string Genero { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Correo { get; set; }
        

    }
}
