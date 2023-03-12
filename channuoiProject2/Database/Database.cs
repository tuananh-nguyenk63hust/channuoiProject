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
        //public DbSet<tiemphong> tiemphong { set; get; }
        public DbSet<tochucvacanhan> tochucvacanhan { set; get; }
        public DbSet<trieutrung> trieutrung { set; get; }
        public DbSet<vaccin> vaccins { set; get; }
        public Database(DbContextOptions<Database> options)
        : base(options)
        { }
        
    }
}
