using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class Visitors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3c2b29e1-7821-427f-8ce3-2f8009a55ae8"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    ArticleVisitorArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ArticleVisitorVisitorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_ArticleVisitors_ArticleVisitorArticleId_ArticleVisitorVisitorId",
                        columns: x => new { x.ArticleVisitorArticleId, x.ArticleVisitorVisitorId },
                        principalTable: "ArticleVisitors",
                        principalColumns: new[] { "ArticleId", "VisitorId" });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("f0444d0b-0f0c-4647-9314-2eb2c9ca6518"), new Guid("6720dcdc-6ac5-4f19-8bc4-4fdb812aea89"), "Asp.net Core Deneme Makalesi1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam vitae facilisis lacus. Phasellus ornare lorem elit, id venenatis ligula tempus sit amet. Proin libero justo, sodales ac blandit nec, malesuada quis sapien. Mauris ornare mauris sit amet risus pulvinar bibendum quis vitae ex. Nam dignissim odio eu velit dictum porta. Nullam mattis a diam vitae suscipit. Fusce consequat lectus metus, in interdum magna iaculis eget. Vestibulum id nulla ac orci tincidunt sodales rhoncus nec odio. In enim quam, fringilla eget ligula nec, egestas maximus purus. Fusce lorem ante, mattis ac metus non, porta convallis neque. Curabitur suscipit, metus vitae bibendum congue, augue lacus maximus turpis, at blandit odio massa vitae magna. Pellentesque hendrerit, augue a efficitur porta, ligula orci ornare quam, quis feugiat dui massa et libero. Quisque aliquam est vitae libero aliquam, in tincidunt enim condimentum.", "Admin Test", new DateTime(2023, 4, 20, 12, 11, 6, 364, DateTimeKind.Local).AddTicks(1831), null, null, new Guid("d491f90b-90ac-468a-a076-0ed56ac15e6e"), false, null, null, "Asp.net Core Deneme Makalesi1", new Guid("45cb1797-8868-4c0d-846d-d7e5c3e4bb26"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("71c68485-8f30-4f24-83e9-a39136b9666c"),
                column: "ConcurrencyStamp",
                value: "0ef401a2-1a18-48cd-b429-a5eeca4a83da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ba4d4699-25c1-48da-8cef-69e6a1942723"),
                column: "ConcurrencyStamp",
                value: "f9b35ef0-8315-4751-b3ca-c861a47a50c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f1ab3d99-e78a-4538-9719-551f9a8c4678"),
                column: "ConcurrencyStamp",
                value: "e3972c9c-adce-4003-b228-fccf55b1628d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("45cb1797-8868-4c0d-846d-d7e5c3e4bb26"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a39c86c-de7b-43ba-831f-f402324d1ab4", "AQAAAAEAACcQAAAAEAuaD915ny40VBY1LgYAhAjN4LiCrJsyV1fRABbPSujZTUdxdLNo5xc9zBU0v6dR6Q==", "7a22dee7-757f-4950-a4c0-1c3c878047be" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6720dcdc-6ac5-4f19-8bc4-4fdb812aea89"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 12, 11, 6, 364, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d58c7491-ba0f-46af-acc2-53968a7c3648"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 12, 11, 6, 364, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8e6b041c-edd8-40b5-bdde-147c079ecbf8"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 12, 11, 6, 364, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d491f90b-90ac-468a-a076-0ed56ac15e6e"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 12, 11, 6, 364, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_ArticleVisitorArticleId_ArticleVisitorVisitorId",
                table: "ArticleVisitors",
                columns: new[] { "ArticleVisitorArticleId", "ArticleVisitorVisitorId" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f0444d0b-0f0c-4647-9314-2eb2c9ca6518"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("3c2b29e1-7821-427f-8ce3-2f8009a55ae8"), new Guid("6720dcdc-6ac5-4f19-8bc4-4fdb812aea89"), "Asp.net Core Deneme Makalesi1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam vitae facilisis lacus. Phasellus ornare lorem elit, id venenatis ligula tempus sit amet. Proin libero justo, sodales ac blandit nec, malesuada quis sapien. Mauris ornare mauris sit amet risus pulvinar bibendum quis vitae ex. Nam dignissim odio eu velit dictum porta. Nullam mattis a diam vitae suscipit. Fusce consequat lectus metus, in interdum magna iaculis eget. Vestibulum id nulla ac orci tincidunt sodales rhoncus nec odio. In enim quam, fringilla eget ligula nec, egestas maximus purus. Fusce lorem ante, mattis ac metus non, porta convallis neque. Curabitur suscipit, metus vitae bibendum congue, augue lacus maximus turpis, at blandit odio massa vitae magna. Pellentesque hendrerit, augue a efficitur porta, ligula orci ornare quam, quis feugiat dui massa et libero. Quisque aliquam est vitae libero aliquam, in tincidunt enim condimentum.", "Admin Test", new DateTime(2023, 4, 20, 11, 35, 4, 948, DateTimeKind.Local).AddTicks(7907), null, null, new Guid("d491f90b-90ac-468a-a076-0ed56ac15e6e"), false, null, null, "Asp.net Core Deneme Makalesi1", new Guid("45cb1797-8868-4c0d-846d-d7e5c3e4bb26"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("71c68485-8f30-4f24-83e9-a39136b9666c"),
                column: "ConcurrencyStamp",
                value: "f4115a09-ef6d-45d6-9802-5af0dd079534");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ba4d4699-25c1-48da-8cef-69e6a1942723"),
                column: "ConcurrencyStamp",
                value: "a7220329-46ff-4fe1-b09d-7cf384631ce0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f1ab3d99-e78a-4538-9719-551f9a8c4678"),
                column: "ConcurrencyStamp",
                value: "6cd8f23a-507c-4cdb-ac20-9293c47fe4ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("45cb1797-8868-4c0d-846d-d7e5c3e4bb26"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4cb3957-0ca7-4989-a0c0-4a2a38b6344b", "AQAAAAEAACcQAAAAEDvS8EYHI/1VjI9V2MSzWPrDhpaKj8W42WYilZAFbPxCEQ5+ywygZAtEiHc+q+5Wqw==", "0afe49a1-0a53-4391-8017-68ed5ee3cd5f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6720dcdc-6ac5-4f19-8bc4-4fdb812aea89"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 11, 35, 4, 948, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d58c7491-ba0f-46af-acc2-53968a7c3648"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 11, 35, 4, 948, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8e6b041c-edd8-40b5-bdde-147c079ecbf8"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 11, 35, 4, 948, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d491f90b-90ac-468a-a076-0ed56ac15e6e"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 11, 35, 4, 948, DateTimeKind.Local).AddTicks(8381));
        }
    }
}
