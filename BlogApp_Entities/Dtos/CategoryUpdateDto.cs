using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Entities.Dtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(70, ErrorMessage = "{0} karakterden büyük olamaz")]
        [MinLength(3, ErrorMessage = "{0} karakterden az olmamalıdır.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklama")]
        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(500, ErrorMessage = "{0} karakterden büyük olamaz")]
        [MinLength(3, ErrorMessage = "{0} karakterden az olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Not")]
        public string Note { get; set; }
        [DisplayName("Aktiv mi?")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public bool IsActive { get; set; }
        [DisplayName("Silindi mi?")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public bool IsDeleted { get; set; }
    }
}
