using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace channuoiProject2.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Loaicoso = table.Column<int>(type: "int", nullable: false),
                    Thoigianvanhanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "daily",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Loaidaily = table.Column<int>(type: "int", nullable: false),
                    Thoigianvanhanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_daily", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dichbenh",
                columns: table => new
                {
                    DichbenhId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DichbenhName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaSuc = table.Column<int>(type: "int", nullable: false),
                    VaccinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dichbenh", x => x.DichbenhId);
                });

            migrationBuilder.CreateTable(
                name: "luatphap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Loaigiayto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_luatphap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "odich",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdichName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Vitri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Giasuc = table.Column<int>(type: "int", nullable: false),
                    Soluowng = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_odich", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tiemphong",
                columns: table => new
                {
                    VaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdichId = table.Column<int>(type: "int", nullable: false),
                    VaccinName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Thoigiantiem = table.Column<int>(type: "int", nullable: false),
                    Soluongdatiem = table.Column<int>(type: "int", nullable: false),
                    Soluongchuatien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiemphong", x => x.VaccinId);
                });

            migrationBuilder.CreateTable(
                name: "tochucvacanhan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Loaisanxuat = table.Column<int>(type: "int", nullable: false),
                    Thoigianvanhanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tochucvacanhan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trieutrung",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Loaisanxuat = table.Column<int>(type: "int", nullable: false),
                    Thoigianvanhanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trieutrung", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coso");

            migrationBuilder.DropTable(
                name: "daily");

            migrationBuilder.DropTable(
                name: "dichbenh");

            migrationBuilder.DropTable(
                name: "luatphap");

            migrationBuilder.DropTable(
                name: "odich");

            migrationBuilder.DropTable(
                name: "tiemphong");

            migrationBuilder.DropTable(
                name: "tochucvacanhan");

            migrationBuilder.DropTable(
                name: "trieutrung");
        }
    }
}
