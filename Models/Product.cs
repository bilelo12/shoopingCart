using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Models
{
    public class Product
    {
    public long Id { get; set; }
    public string Name { get; set; }=string.Empty ;
    public string Description { get; set; }=string.Empty ;
    public decimal Price { get; set; }


    }
}