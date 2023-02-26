using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.DTOS
{
    public class AddProductDto
    {
    public string Name { get; set; }=string.Empty ;
    public string Description { get; set; }=string.Empty ;
    public decimal Price { get; set; }
    }
}