using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entities
{
    public class Brand
    {
        [Key]
        public int Brandid { get; set; }

       [Required]
       [MaxLength(20)]

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
       
    }
}
