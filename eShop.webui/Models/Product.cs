using System.ComponentModel.DataAnnotations;

namespace eShop.webui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [StringLength(60,MinimumLength =10,ErrorMessage ="Product name is must contains between 10-60chars")]
        public string Name { get; set; }
        [Required(ErrorMessage = "between 1-100000")]
        [Range(1,100000)]
        public double? Price { get; set; }
        public string? Description { get; set; }
        public bool IsApproved { get; set; }
        [Required(ErrorMessage ="You can`t pass the image url")]
        [StringLength(100)]
        public string? ImageUrl { get; set; }
    }
}
