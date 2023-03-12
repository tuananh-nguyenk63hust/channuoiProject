using Microsoft.EntityFrameworkCore;
namespace channuoiProject2
{
    public class Database: DbContext
    {
        public DbSet<coso> cosos { set; get; }
        public DbSet<daily> daily { set; get; }
        public DbSet<dichbenh> dichbenh { set; get; }
        public DbSet<luatphap> luatphap { set; get; }
        public DbSet<odich> odich { set; get; }
        public DbSet<tiemphong> tiemphong { set; get; }
        public DbSet<tochucvacanhan> tochucvacanhan { set; get; }
        public DbSet<trieutrung> trieutrung { set; get; }
        // Chuỗi kết nối tới CSDL (MS SQL Server)
        private const string connectionString = @"
                Data Source=localhost,1433;
                Initial Catalog=channuoi;
                User ID=SA;Password=123";

        // Phương thức OnConfiguring gọi mỗi khi một đối tượng DbContext được tạo
        // Nạp chồng nó để thiết lập các cấu hình, như thiết lập chuỗi kết nối
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        
        public Database(DbContextOptions<Database> options)
        : base(options)
        { }
    }
}
