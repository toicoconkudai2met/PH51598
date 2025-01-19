namespace PH51598_Trần_Đức_Huy.Models
{
    public class sanphamchitiet
    {
        public int Id { get; set; }
        public string MoTa { get; set; }
        public int SanPhamId { get; set; }
        public sanpham SanPham { get; set; }
    }
}
