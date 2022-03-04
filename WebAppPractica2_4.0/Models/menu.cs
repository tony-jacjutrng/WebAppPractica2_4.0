using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPractica2_4._0.Models
{
    public class menu
    {
        [Key]

        public int Id { get; set; }
        public string CodigoMenu { get; set; }
    }
}
