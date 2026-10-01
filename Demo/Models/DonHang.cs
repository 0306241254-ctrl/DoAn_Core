using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Demo.Models
{
    public class DonHang
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("KhachHang_id")]
        public int KhachHang_id { get; set; }
        [ForeignKey("KhachHang_id")]
        public virtual KhachHang KhachHang { get; set; } = null!;

        public decimal TongTien { get; set; }
        public DateTime NgayDatHang { get; set; }

    }
}
