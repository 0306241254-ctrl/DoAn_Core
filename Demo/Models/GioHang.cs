using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Demo.Models
{
    public class GioHang
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("SanPham_id")]
        public int SanPham_id { get; set; }
        [ForeignKey("SanPham_id")]
        public virtual SanPham SanPham { get; set; } = null!;
        [Required]
        [Column("SanPham_TenSP")]
        public int SanPham_TenSP { get; set; }
        [ForeignKey("SanPham_TenSP")]
        public virtual SanPham TenSP { get; set; } = null!;
        [Required]
        [Column("SanPham_Gia")]
        public int SoLuong {  get; set; }
        public int SanPham_Gia { get; set; }
        [ForeignKey("SanPham_Gia")]
        public virtual SanPham Gia { get; set; } = null!;
    }
}
