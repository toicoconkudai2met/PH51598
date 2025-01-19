namespace PH51598_Trần_Đức_Huy.Models
{
    public class sanpham
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public decimal Gia { get; set; }
        public ICollection<sanphamchitiet> SanPhamChiTiets { get; set; }
    }
}
