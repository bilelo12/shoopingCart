using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.DTOS
{
    public class AddCostumerDto
    {
    public string Name { get; set; }=string.Empty ;
    public string Adress { get; set; }=string.Empty ;
    public string Email { get; set; }=string.Empty ;
    public string Number { get; set; }=string.Empty ;   
    }
}