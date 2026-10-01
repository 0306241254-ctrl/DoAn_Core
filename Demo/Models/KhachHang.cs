using System.ComponentModel.DataAnnotations;
namespace Demo.Models
{
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string SDT { get; set; } = "";
    }
}
