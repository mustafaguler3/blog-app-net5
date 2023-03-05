using BlogApp_Entities.Concrete;
using BlogApp_Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Entities.Dtos
{
    public class ArticleDto : BaseDto
    {
        public Article Article { get; set; }
    }
}
