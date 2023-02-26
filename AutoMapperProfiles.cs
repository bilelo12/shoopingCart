using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Category,GetCategoryDto>();
            CreateMap<AddCategoryDto,Category>();

        }
        
    }
}