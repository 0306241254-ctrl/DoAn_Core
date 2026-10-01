using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Demo.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        public string TenSP { get; set; } = "";
        public string MoTa { get; set; } = "";
        public decimal Gia { get; set; }
        public string img { get; set; } = "";
        [Required]
        [Column("DanhMuc_id")]
        public int DanhMuc_id { get; set; }
        [ForeignKey("DanhMuc_id")]
        public virtual DanhMuc DanhMuc { get; set; } = null!;

    }
}
