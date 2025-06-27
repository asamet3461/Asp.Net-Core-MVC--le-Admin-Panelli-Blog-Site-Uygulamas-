using System.ComponentModel.DataAnnotations;

namespace MVCBlogSitesi.Entites
{
    public class Post
    {
        public int Id { get; set; }
        [Display(Name = "Gönderi Adı"), StringLength(100)]
        public string Name { get; set; }
        [Display(Name = "Gönderi Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Gönderi Resmi"), StringLength(100)]
        public string? Image { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Güncellenme Tarihi")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public Category? Category { get; set; }
    }
}
