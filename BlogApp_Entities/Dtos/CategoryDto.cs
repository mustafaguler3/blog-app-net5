using BlogApp_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Entities.Dtos
{
    public class CategoryDto : BaseDto
    {
        public Category Category { get; set; }
    }
}
