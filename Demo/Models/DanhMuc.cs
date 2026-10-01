using System.ComponentModel.DataAnnotations;
namespace Demo.Models
{
    public class DanhMuc
    {
        [Key]
        public int Id { get; set; }
        public string TenDM { get; set; } = "";
        public bool TrangThai { get; set; } = true;
    }
}
