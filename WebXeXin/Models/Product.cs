using System.ComponentModel.DataAnnotations;

namespace WebXeXin.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên xe.")]
        [StringLength(100, ErrorMessage = "Tên xe không vượt quá 100 ký tự.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá bán.")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá bán phải là số dương.")]
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public List<ProductImage>? Images { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
