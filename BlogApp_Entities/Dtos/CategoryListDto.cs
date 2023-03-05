using BlogApp_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Entities.Dtos
{
    public class CategoryListDto : BaseDto
    {
        public IList<Category> Categories { get; set; }
    }
}
