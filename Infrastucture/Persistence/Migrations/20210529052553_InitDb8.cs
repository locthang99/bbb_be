using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(583),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 37, DateTimeKind.Local).AddTicks(7065),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 38, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 46, DateTimeKind.Local).AddTicks(7213),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 47, DateTimeKind.Local).AddTicks(2176),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(5314),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(5233),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(8493),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Types",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(754),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 82, DateTimeKind.Local).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Tags",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 81, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(2662),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Songs",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(433),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(7878),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(4043),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 85, DateTimeKind.Local).AddTicks(3166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 84, DateTimeKind.Local).AddTicks(9533),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(4702),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(1260),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 997, DateTimeKind.Local).AddTicks(4090),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 358, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 996, DateTimeKind.Local).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 357, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(7127),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(5706),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 32, DateTimeKind.Local).AddTicks(3070),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 31, DateTimeKind.Local).AddTicks(9016),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(6583),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(5020),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Playlists",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(2255),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 80, DateTimeKind.Local).AddTicks(1197),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Histories",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 79, DateTimeKind.Local).AddTicks(8514),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 54, DateTimeKind.Local).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 53, DateTimeKind.Local).AddTicks(8272),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(9755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "CacheDatas",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(5064),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 969, DateTimeKind.Local).AddTicks(3373),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 338, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "AppConfigs",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 953, DateTimeKind.Local).AddTicks(2871),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 327, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9ae7d6d2-b765-461b-967a-df8cea628e73");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ee2303e0-797d-4ca6-aef6-ac9576de164e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a03e4b58-6efc-495a-b75a-e8ff9bdba872");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a34541cc-a648-4498-b6ee-7ca610f7c00c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e3d48940-9b38-47ff-8b31-20dfcbc216f2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f14b23d6-487b-4fc3-b735-de43d26eb50e", "AQAAAAEAACcQAAAAECv8XYGSW1YeDWxYZBtpeQSZyiCW2ganTshquI/MeD4nm3aEmhl3J3Y7yluuydWMJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da5c045f-08d1-408a-9213-b673145c50b4", "AQAAAAEAACcQAAAAEIYyyTpL0pYakXdPh2XPqjphSAHwiu920g0nWTz6rRwYqYVmf/z3Gy9VgcZasriq7A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac174fec-aaed-4385-98e2-308609752bfc", "AQAAAAEAACcQAAAAEL/lvh7rZ8qPX/XE0Hp3H+GA9jqjD0/7Z7lKajZwFWIqAyVH/FnGKW3vGt6SYAz+Jw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0e2ea71-e210-4967-a0b1-a962210ac1b8", "AQAAAAEAACcQAAAAEGrx/8xsqwTmzpV9C8DcFtDJ0GegVIWNGd9CgqX3k1V6k1sGgHic+pX+W9v18O4bpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d01964de-8a3e-4bf0-94c0-0d8388d214d4", "AQAAAAEAACcQAAAAECMchVQzsfHkEF7LY0JLvHx5wl0kr86Tv8Ceu234GT73wRN435m5/Uak0H6d1Nu8eA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(9940),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(8821),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(2573),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 37, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(5622),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 38, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(6223),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 46, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(9377),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 47, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(5022),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(81),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(2421),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(8994),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Types",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(7419),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(8564),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 82, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Tags",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(7296),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 81, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(9787),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Songs",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(8601),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(9911),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(8451),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(1691),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 85, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(338),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 84, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(8960),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(7409),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 358, DateTimeKind.Local).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 997, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 357, DateTimeKind.Local).AddTicks(8277),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 996, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(8168),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(7481),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(8518),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 32, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(7052),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 31, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(948),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(6145),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Playlists",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(4764),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 80, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Histories",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(8258),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 79, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 54, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(449),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 53, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(9853),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "CacheDatas",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(8602),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 338, DateTimeKind.Local).AddTicks(6447),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 969, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "AppConfigs",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 327, DateTimeKind.Local).AddTicks(7309),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 953, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "61f9c8a8-0898-4730-8bc5-608d6b93b2c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2766d42a-701e-459c-a4dc-0c8927e73b3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "efc06678-6935-4c39-bb3c-6ded3306817c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f2db6724-5931-47d7-a819-66a4fd13a925");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8e1c644a-8e58-46ed-82c8-74c38a1d3dc0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f49cd7c-cce9-45c8-96ba-b84ae3ce14fa", "AQAAAAEAACcQAAAAEBV4yutvMR0JwC6CSYr2Tbwn2JFb7O3T8lG0nfLsl3GOtR/Js0kVx/uJtreV7/qAcg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61feb654-2b15-42a9-b884-35915b2ef4b8", "AQAAAAEAACcQAAAAEKMmirqF4U5DLoqh9ozxkQXynYYOFPBhCjuLWtAnfwLBAL5lokco5LHWMxHu5WPE7g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65e50844-467f-4dad-99f9-f23ec7947e89", "AQAAAAEAACcQAAAAEOHKNJb6ag/6xF60kfg2ov8cWf/oCXScHcF15porAl+VEV3JS61SDRFYCfsf89mK5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c98f64ad-882c-455e-b967-a414fe3f7f3e", "AQAAAAEAACcQAAAAEEb3eNZ7OdwTK3BPFOcgF2+2PfigGdZ0xyoLVhMlXyK8CFrZvz1qKIYtapTEyUhpPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bcced64-2aaa-4edc-ab40-2fd16f66912a", "AQAAAAEAACcQAAAAEFcxmkQZlBiMOm+7oKb41aAjQ00v/F1MOBt9fTLNrAx+SmSbNEn6GALcJpdyQPszPg==" });
        }
    }
}
