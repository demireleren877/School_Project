using Microsoft.EntityFrameworkCore.Migrations;

namespace School_Project.Migrations
{
    public partial class sp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kategori = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParaBirimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ÜrünAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PiyasaFiyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrendyolFiyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StokAdedi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StokKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KDVOranı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GörselLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SevkiyatSüresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraçMarka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraçModel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
