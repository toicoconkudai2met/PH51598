namespace PH51598_Trần_Đức_Huy.Models
{
    public class khachhang
    {
        public int Id { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public ICollection<hoadon> HoaDons { get; set; }
    }
}
