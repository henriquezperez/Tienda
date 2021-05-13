using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(20)]

        public string Nombre { get; set; }

        [Required]
        public decimal Precio { get; set; }

        
        [Required]
        public int  CategoryId { get; set; }

        [Required]
        public int BrandId { get; set; }



    }
}
