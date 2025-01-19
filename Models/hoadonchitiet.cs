namespace PH51598_Trần_Đức_Huy.Models
{
    public class hoadonchitiet
    {
        public int Id { get; set; }
        public int HoaDonId { get; set; }
        public hoadon HoaDon { get; set; }
        public int SanPhamId { get; set; }
        public sanpham SanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
    }
}
