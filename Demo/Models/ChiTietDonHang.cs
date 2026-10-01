using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Demo.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column("DonHang_id")]
        public int DonHang_id { get; set; }
        [ForeignKey("DonHang_id")]
        public virtual DonHang DonHang { get; set; } = null!;

        [Required]
        [Column("SanPham_id")]
        public int SanPham_id { get; set; }
        [ForeignKey("SanPham_id")]
        public virtual SanPham SanPham { get; set; } = null!;
        public int SoLuong {  get; set; }
        public decimal Gia { get; set; }

    }
}
