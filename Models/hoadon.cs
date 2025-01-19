namespace PH51598_Trần_Đức_Huy.Models
{
    public class hoadon
    {
        public int Id { get; set; }
        public DateTime NgayLap { get; set; }
        public int KhachHangId { get; set; }
        public khachhang KhachHang { get; set; }
        public ICollection<hoadonchitiet> ChiTietHoaDons { get; set; }
    }
}
