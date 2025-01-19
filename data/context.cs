using Microsoft.EntityFrameworkCore;
using PH51598_Trần_Đức_Huy.Models;

namespace PH51598_Trần_Đức_Huy.data
{
    public class context: DbContext
    {
        public context(DbContextOptions<context> options) : base(options) { }
        public DbSet<sanpham> SanPhams { get; set; }
        public DbSet<sanphamchitiet> SanPhamChiTiets { get; set; }
        public DbSet<hoadon> HoaDons { get; set; }
        public DbSet<hoadonchitiet> ChiTietHoaDons { get; set; }
        public DbSet<khachhang> KhachHangs { get; set; }
        public DbSet<nhanvien> NhanViens { get; set; }

        
    }
}
