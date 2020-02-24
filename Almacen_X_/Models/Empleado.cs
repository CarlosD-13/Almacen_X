using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen_X_.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoID { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Codigo_Empleado { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Cedula { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Apellido { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime Fecha_Ingreso { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Ocupacion { get; set; }

    }
}
