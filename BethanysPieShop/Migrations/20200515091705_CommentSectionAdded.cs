using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class CommentSectionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CComment = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 1,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 6, 7, 7, 8, 5, 6, 1, 1, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 2,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 9, 1, 6, 5, 2, 7, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 3,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 7, 4, 3, 6, 5, 1, 7, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 4,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 1, 2, 5, 9, 1, 2, 8, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 5,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 2, 7, 3, 1, 1, 4, 6, 5, 5, 9 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 6,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 8, 2, 5, 6, 9, 1, 0, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 7,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 2, 1, 8, 8, 3, 5, 9, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 8,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 5, 2, 5, 6, 5, 4, 6, 0, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 9,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 9, 9, 2, 6, 2, 2, 0, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 10,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 7, 9, 1, 2, 2, 1, 3, 1, 9, 9 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 11,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 6, 9, 0, 0, 3, 4, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 12,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 0, 9, 1, 6, 0, 3, 9, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 13,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 8, 6, 4, 1, 4, 6, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 14,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 2, 3, 1, 2, 2, 6, 7, 3, 4, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 15,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 9, 5, 2, 0, 7, 5, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 16,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 1, 5, 8, 4, 5, 1, 8, 7, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 17,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_8_stock" },
                values: new object[] { 0, 8, 7, 7, 6, 8, 9, 8, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 18,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 6, 7, 7, 8, 9, 4, 9, 3, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 19,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock" },
                values: new object[] { 9, 9, 4, 6, 4, 2, 7, 5, 7, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 20,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 6, 7, 8, 4, 6, 1, 7, 2, 9, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 21,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 3, 7, 0, 7, 6, 2, 7, 3, 8, 9 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 22,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 8, 0, 3, 0, 4, 7, 0, 8, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 23,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 3, 8, 9, 4, 1, 3, 1, 0, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 24,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 9, 8, 9, 3, 5, 0, 3, 0, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 25,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 9, 3, 1, 6, 6, 0, 1, 9, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 26,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock" },
                values: new object[] { 9, 8, 2, 6, 7, 5, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 27,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 3, 9, 4, 4, 0, 1, 2, 0, 7, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 28,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 1, 5, 6, 2, 2, 5, 6, 1, 9, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 29,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 3, 9, 1, 1, 7, 3, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 30,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 2, 2, 7, 5, 5, 7, 1, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 31,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock" },
                values: new object[] { 0, 4, 9, 7, 1, 4, 4, 9, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 32,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 8, 3, 5, 9, 9, 4, 7, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 33,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 1, 3, 9, 5, 0, 3, 7, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 34,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 2, 3, 1, 4, 6, 9, 1, 4, 6, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 35,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 9, 8, 1, 6, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 36,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 6, 0, 5, 7, 4, 8, 0, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 37,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 7, 2, 2, 7, 5, 7, 7, 9, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 38,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 2, 4, 8, 0, 3, 3, 5, 9, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 39,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 9, 8, 3, 1, 9, 8, 5, 2, 4, 3, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 40,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 2, 7, 9, 8, 0, 5, 6, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 41,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 3, 3, 6, 3, 3, 5, 8, 3, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 42,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 7, 8, 6, 6, 8, 6, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 43,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 3, 0, 2, 3, 4, 5, 3, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 44,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 0, 8, 8, 2, 5, 1, 7, 8, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 45,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 7, 9, 9, 0, 2, 3, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 46,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 7, 5, 5, 1, 0, 0, 0, 2, 9, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 47,
                columns: new[] { "Pie_id_10_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 7, 3, 2, 0, 8, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 48,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 6, 0, 2, 3, 3, 2, 1, 6, 3, 9 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 49,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 6, 1, 3, 6, 4, 1, 6, 7, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 50,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 9, 5, 2, 5, 0, 4, 4, 2, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 51,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 2, 8, 5, 8, 6, 7, 8, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 52,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 5, 8, 8, 6, 8, 1, 8, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 1,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 7, 5, 9, 9, 4, 3, 8, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 2,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 9, 2, 6, 9, 6, 8, 6, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 3,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 9, 8, 9, 7, 5, 9, 7, 1, 3, 9 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 4,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 3, 2, 1, 0, 5, 2, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 5,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 0, 6, 4, 8, 4, 7, 3, 7, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 6,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 7, 0, 1, 4, 1, 3, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 7,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 4, 3, 4, 0, 8, 3, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 8,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 8, 6, 0, 5, 6, 5, 9, 7, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 9,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 0, 1, 0, 0, 0, 1, 7, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 10,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 3, 8, 0, 3, 3, 9, 9, 4, 6, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 11,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 2, 3, 1, 8, 1, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 12,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 2, 3, 7, 2, 2, 2, 8, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 13,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 0, 2, 5, 2, 0, 7, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 14,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 7, 7, 8, 7, 9, 6, 9, 9, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 15,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 7, 4, 9, 1, 6, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 16,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 8, 0, 1, 8, 3, 2, 1, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 17,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_8_stock" },
                values: new object[] { 8, 7, 5, 6, 0, 0, 2, 0, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 18,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 3, 2, 4, 4, 0, 3, 8, 0, 9, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 19,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock" },
                values: new object[] { 0, 1, 0, 8, 5, 1, 8, 4, 4, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 20,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 8, 9, 9, 3, 3, 0, 4, 1, 7, 9 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 21,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 4, 3, 7, 3, 2, 8, 6, 2, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 22,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 7, 2, 5, 2, 5, 1, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 23,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 3, 5, 9, 5, 7, 6, 8, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 24,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 3, 2, 5, 8, 7, 6, 5, 8, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 25,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 2, 3, 4, 8, 1, 5, 2, 9, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 26,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock" },
                values: new object[] { 7, 6, 4, 1, 9, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 27,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 3, 5, 3, 6, 7, 3, 5, 6, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 28,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 3, 0, 1, 3, 1, 3, 2, 4, 8, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 29,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 5, 8, 9, 4, 9, 4, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 30,
                columns: new[] { "Pie_id_10_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 4, 1, 4, 4, 8, 8, 4, 9, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 31,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock" },
                values: new object[] { 3, 1, 3, 3, 6, 7, 7, 7, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 32,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 7, 1, 4, 7, 3, 3, 0, 9, 8, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 33,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 5, 7, 2, 7, 3, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 34,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 6, 1, 2, 6, 0, 3, 6, 9, 9, 8, 7 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 35,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 0, 2, 0, 7, 4, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 36,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 8, 3, 5, 8, 9, 5, 0, 8, 9, 7, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 37,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 0, 3, 1, 1, 2, 0, 3, 0, 8 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 38,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 9, 3, 3, 6, 1, 7, 0, 9, 4 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 39,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 2, 1, 0, 2, 3, 1, 9, 1, 9, 0 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 40,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 2, 8, 5, 8, 6, 3, 4, 9, 9, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 41,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 4, 7, 4, 4, 4, 2, 3, 1, 7, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 42,
                columns: new[] { "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 3, 0, 0, 0, 6, 1, 7, 9 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 43,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 9, 1, 5, 7, 8, 4, 6, 9, 5 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 44,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 3, 8, 9, 5, 7, 9, 9, 5, 4, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 45,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 1, 5, 0, 2, 8, 5, 2, 7, 8, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 46,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 9, 6, 4, 3, 8, 4, 4, 1, 7, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 47,
                columns: new[] { "Pie_id_10_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 5, 2, 7, 3, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 48,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 5, 7, 3, 4, 5, 0, 9, 2, 9, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 49,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 7, 9, 4, 1, 4, 0, 4, 1, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 50,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 0, 9, 4, 7, 7, 0, 9, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 51,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_3_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_6_stock", "Pie_id_7_stock", "Pie_id_9_stock" },
                values: new object[] { 2, 0, 7, 0, 3, 9, 4, 2, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Week",
                keyValue: 52,
                columns: new[] { "Pie_id_10_stock", "Pie_id_11_stock", "Pie_id_1_stock", "Pie_id_2_stock", "Pie_id_4_stock", "Pie_id_5_stock", "Pie_id_7_stock", "Pie_id_8_stock", "Pie_id_9_stock" },
                values: new object[] { 3, 9, 6, 6, 8, 6, 4, 0, 0 });
        }
    }
}
