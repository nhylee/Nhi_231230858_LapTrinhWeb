using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTapDay09_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LtynKHACH_HANG",
                columns: table => new
                {
                    ltynID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ltynMaKhachHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ltynHoTenKhachHang = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynMatKhau = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ltynDiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynNgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ltynTrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LtynKHACH_HANG", x => x.ltynID);
                });

            migrationBuilder.CreateTable(
                name: "LtynLOAI_SAN_PHAM",
                columns: table => new
                {
                    ltynID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ltynMaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ltynTenLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ltynTrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LtynLOAI_SAN_PHAM", x => x.ltynID);
                });

            migrationBuilder.CreateTable(
                name: "LtynQUAN_TRI",
                columns: table => new
                {
                    ltynID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ltynTenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ltynMatKhau = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ltynHoTen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynTrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LtynQUAN_TRI", x => x.ltynID);
                });

            migrationBuilder.CreateTable(
                name: "LtynHOA_DON",
                columns: table => new
                {
                    ltynID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ltynMaHoaDon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ltynMaKhachHang = table.Column<int>(type: "int", nullable: true),
                    ltynNgayHoaDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ltynNgayNhan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ltynHoTenKhachHang = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ltynDiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynTongTriGia = table.Column<double>(type: "float", nullable: true),
                    ltynTrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LtynHOA_DON", x => x.ltynID);
                    table.ForeignKey(
                        name: "FK_LtynHOA_DON_LtynKHACH_HANG_ltynMaKhachHang",
                        column: x => x.ltynMaKhachHang,
                        principalTable: "LtynKHACH_HANG",
                        principalColumn: "ltynID");
                });

            migrationBuilder.CreateTable(
                name: "LtynSAN_PHAM",
                columns: table => new
                {
                    ltynID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ltynMaSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ltynTenSanPham = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ltynHinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ltynSoLuong = table.Column<int>(type: "int", nullable: true),
                    ltynDonGia = table.Column<double>(type: "float", nullable: true),
                    ltynMaLoai = table.Column<int>(type: "int", nullable: true),
                    ltynTrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LtynSAN_PHAM", x => x.ltynID);
                    table.ForeignKey(
                        name: "FK_LtynSAN_PHAM_LtynLOAI_SAN_PHAM_ltynMaLoai",
                        column: x => x.ltynMaLoai,
                        principalTable: "LtynLOAI_SAN_PHAM",
                        principalColumn: "ltynID");
                });

            migrationBuilder.CreateTable(
                name: "LtynCT_HOA_DON",
                columns: table => new
                {
                    ltynID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ltynHoaDonID = table.Column<int>(type: "int", nullable: true),
                    ltynSanPhamID = table.Column<int>(type: "int", nullable: true),
                    ltynSoLuongMua = table.Column<int>(type: "int", nullable: true),
                    ltynDonGiaMua = table.Column<double>(type: "float", nullable: true),
                    ltynThanhTien = table.Column<double>(type: "float", nullable: true),
                    ltynTrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LtynCT_HOA_DON", x => x.ltynID);
                    table.ForeignKey(
                        name: "FK_LtynCT_HOA_DON_LtynHOA_DON_ltynHoaDonID",
                        column: x => x.ltynHoaDonID,
                        principalTable: "LtynHOA_DON",
                        principalColumn: "ltynID");
                    table.ForeignKey(
                        name: "FK_LtynCT_HOA_DON_LtynSAN_PHAM_ltynSanPhamID",
                        column: x => x.ltynSanPhamID,
                        principalTable: "LtynSAN_PHAM",
                        principalColumn: "ltynID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LtynCT_HOA_DON_ltynHoaDonID",
                table: "LtynCT_HOA_DON",
                column: "ltynHoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_LtynCT_HOA_DON_ltynSanPhamID",
                table: "LtynCT_HOA_DON",
                column: "ltynSanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_LtynHOA_DON_ltynMaKhachHang",
                table: "LtynHOA_DON",
                column: "ltynMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_LtynSAN_PHAM_ltynMaLoai",
                table: "LtynSAN_PHAM",
                column: "ltynMaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LtynCT_HOA_DON");

            migrationBuilder.DropTable(
                name: "LtynQUAN_TRI");

            migrationBuilder.DropTable(
                name: "LtynHOA_DON");

            migrationBuilder.DropTable(
                name: "LtynSAN_PHAM");

            migrationBuilder.DropTable(
                name: "LtynKHACH_HANG");

            migrationBuilder.DropTable(
                name: "LtynLOAI_SAN_PHAM");
        }
    }
}
