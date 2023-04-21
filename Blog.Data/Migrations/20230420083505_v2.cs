using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("23821f95-f558-4c5c-aeac-a06e5a524cd3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f7821456-3127-4f65-b42a-d0455046c5b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66dc5149-6b91-462c-8ebc-2cd2c18c7d35"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3c2b29e1-7821-427f-8ce3-2f8009a55ae8"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("f7821456-3127-4f65-b42a-d0455046c5b9"), new Guid("6720dcdc-6ac5-4f19-8bc4-4fdb812aea89"), "Asp.net Core Deneme Makalesi1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam vitae facilisis lacus. Phasellus ornare lorem elit, id venenatis ligula tempus sit amet. Proin libero justo, sodales ac blandit nec, malesuada quis sapien. Mauris ornare mauris sit amet risus pulvinar bibendum quis vitae ex. Nam dignissim odio eu velit dictum porta. Nullam mattis a diam vitae suscipit. Fusce consequat lectus metus, in interdum magna iaculis eget. Vestibulum id nulla ac orci tincidunt sodales rhoncus nec odio. In enim quam, fringilla eget ligula nec, egestas maximus purus. Fusce lorem ante, mattis ac metus non, porta convallis neque. Curabitur suscipit, metus vitae bibendum congue, augue lacus maximus turpis, at blandit odio massa vitae magna. Pellentesque hendrerit, augue a efficitur porta, ligula orci ornare quam, quis feugiat dui massa et libero. Quisque aliquam est vitae libero aliquam, in tincidunt enim condimentum.", "Admin Test", new DateTime(2023, 4, 20, 10, 33, 0, 401, DateTimeKind.Local).AddTicks(1816), null, null, new Guid("d491f90b-90ac-468a-a076-0ed56ac15e6e"), false, null, null, "Asp.net Core Deneme Makalesi1", new Guid("45cb1797-8868-4c0d-846d-d7e5c3e4bb26"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("71c68485-8f30-4f24-83e9-a39136b9666c"),
                column: "ConcurrencyStamp",
                value: "89c0146d-17e5-467f-ae58-c547e2f9d844");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ba4d4699-25c1-48da-8cef-69e6a1942723"),
                column: "ConcurrencyStamp",
                value: "15248da5-0c06-49ff-8768-117e7eb61cc5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f1ab3d99-e78a-4538-9719-551f9a8c4678"),
                column: "ConcurrencyStamp",
                value: "091abc56-46f5-4e2f-8b40-aa5b7e57a5fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("45cb1797-8868-4c0d-846d-d7e5c3e4bb26"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0420ac75-88cf-4682-b007-c048309f68e7", "AQAAAAEAACcQAAAAEE17e9VFd8yWYPpPMRAs0fqYUTF4LfI/P7Dr4CV9JVcmDTnMuWdAkKjS12yApwNS5Q==", "c136f093-eb36-4d9a-b3be-1f49572d32ee" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("66dc5149-6b91-462c-8ebc-2cd2c18c7d35"), 0, "7c2bbbbe-aaad-4352-8cbf-d4193a083558", "admin@gmail.com", false, "Admin", new Guid("d491f90b-90ac-468a-a076-0ed56ac15e6e"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", null, "+05519999988", false, "59c6e986-f708-480e-a758-8bc393ea4c8d", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6720dcdc-6ac5-4f19-8bc4-4fdb812aea89"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 10, 33, 0, 401, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d58c7491-ba0f-46af-acc2-53968a7c3648"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 10, 33, 0, 401, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8e6b041c-edd8-40b5-bdde-147c079ecbf8"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 10, 33, 0, 401, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d491f90b-90ac-468a-a076-0ed56ac15e6e"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 20, 10, 33, 0, 401, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("23821f95-f558-4c5c-aeac-a06e5a524cd3"), new Guid("d58c7491-ba0f-46af-acc2-53968a7c3648"), "Visual Studio Deneme Makalesi1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam vitae facilisis lacus. Phasellus ornare lorem elit, id venenatis ligula tempus sit amet. Proin libero justo, sodales ac blandit nec, malesuada quis sapien. Mauris ornare mauris sit amet risus pulvinar bibendum quis vitae ex. Nam dignissim odio eu velit dictum porta. Nullam mattis a diam vitae suscipit. Fusce consequat lectus metus, in interdum magna iaculis eget. Vestibulum id nulla ac orci tincidunt sodales rhoncus nec odio. In enim quam, fringilla eget ligula nec, egestas maximus purus. Fusce lorem ante, mattis ac metus non, porta convallis neque. Curabitur suscipit, metus vitae bibendum congue, augue lacus maximus turpis, at blandit odio massa vitae magna. Pellentesque hendrerit, augue a efficitur porta, ligula orci ornare quam, quis feugiat dui massa et libero. Quisque aliquam est vitae libero aliquam, in tincidunt enim condimentum.", "Admin Test", new DateTime(2023, 4, 20, 10, 33, 0, 401, DateTimeKind.Local).AddTicks(1826), null, null, new Guid("8e6b041c-edd8-40b5-bdde-147c079ecbf8"), false, null, null, "Visual Studio Deneme Makalesi1", new Guid("66dc5149-6b91-462c-8ebc-2cd2c18c7d35"), 15 });
        }
    }
}
