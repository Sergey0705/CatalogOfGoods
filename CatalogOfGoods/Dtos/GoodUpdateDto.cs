using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogOfGoods.Dtos
{
    public class GoodUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(1, 10_000_000)]
        public int Price { get; set; }
        [Required]
        [MaxLength(100)]
        public string Brand { get; set; }
    }
}
