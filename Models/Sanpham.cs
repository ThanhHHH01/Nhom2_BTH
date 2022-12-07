using System.ComponentModel.DataAnnotations;
namespace Nhom02.Models;
public class Sanpham {
    [Key]
    [Display( Name = "Mã SP")]
    public string? MaSP { get; set;}
    [Display(Name = "Sản phẩm")]
    public string? TenSP { get; set;}
    [Display(Name = "Giá")]
    public decimal GiaSP { get; set;}

}