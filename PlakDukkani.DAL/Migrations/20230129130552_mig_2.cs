using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakDukkani.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "ID", "CreatedDate", "KullaniciAdi", "ModifiedDate", "Sifre" },
                values: new object[,]
                {
                    { new Guid("7ba9c9d4-b354-4951-987a-e3a130d743cb"), new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(1905), "Admin123456", new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(1906), "6CDE6915D987CA57A7C808D0BF71105FF1AE67697421C55471B5ABFA303ED5B3" },
                    { new Guid("b7542ff7-f63a-401e-95fa-d4f7facd2f6f"), new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(1556), "Admin1234", new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(1567), "6CDE6915D987CA57A7C808D0BF71105FF1AE67697421C55471B5ABFA303ED5B3" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "AlbumAdi", "CikisTarihi", "CreatedDate", "Fiyat", "IndirimOrani", "ModifiedDate", "Sanatci", "SatisDurumu" },
                values: new object[,]
                {
                    { new Guid("5a4fc427-188a-46e9-8e1a-28930c8a5215"), "Melek", new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(2027), new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(2028), 100m, 10m, new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(2028), "Melek Melek", true },
                    { new Guid("7fff5d91-b6b9-4728-ba93-17a1261553d2"), "abc", new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(2020), 100m, 10m, new DateTime(2023, 1, 29, 16, 5, 52, 648, DateTimeKind.Local).AddTicks(2021), "abc", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "ID",
                keyValue: new Guid("7ba9c9d4-b354-4951-987a-e3a130d743cb"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "ID",
                keyValue: new Guid("b7542ff7-f63a-401e-95fa-d4f7facd2f6f"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: new Guid("5a4fc427-188a-46e9-8e1a-28930c8a5215"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: new Guid("7fff5d91-b6b9-4728-ba93-17a1261553d2"));
        }
    }
}
