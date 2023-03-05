using BlogApp_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Entities.Dtos
{
    public class ArticleUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalı")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalı")]
        public string Title { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalı")]
        [MinLength(20, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalı")]
        public string Content { get; set; }
        [DisplayName("Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalı")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalı")]
        public string Thumbnail { get; set; }
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalı")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalı")]
        public string SeoAuthor { get; set; }
        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalı")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalı")]
        public string SeoDescription { get; set; }
        [DisplayName("Seo Etiketler")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalı")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalı")]
        public string SeoTags { get; set; }
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        [DisplayName("Aktiv mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public bool IssActive { get; set; }
        [DisplayName("Silinsin mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public bool IsDeleted { get; set; }
    }
}
