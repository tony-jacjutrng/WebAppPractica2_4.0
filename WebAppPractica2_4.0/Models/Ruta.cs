using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPractica2_4._0.Models
{
    public class Ruta
    {
        [Key]

        public int Id { get; set; }

        public string CodigoMenu { get; set; }
        [ForeignKey("CodigoMenu")]
        public string Nombre { get; set; }
        public virtual menu menu { get; set; }
    }
}
