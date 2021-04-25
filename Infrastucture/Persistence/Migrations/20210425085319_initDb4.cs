using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class initDb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(945),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 268, DateTimeKind.Local).AddTicks(7543),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 419, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 269, DateTimeKind.Local).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 420, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(3764),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(1981),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(9636),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(8283),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(6952),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(5412),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(3757),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(2992),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 404, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(1193),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 403, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(3717),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(1977),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 263, DateTimeKind.Local).AddTicks(8),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 262, DateTimeKind.Local).AddTicks(8412),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(6332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2790),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2283),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(5074),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(3661),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(4838),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(3386),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(139),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 279, DateTimeKind.Local).AddTicks(8686),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(7485),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 427, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(5946),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 426, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(9251),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(7601),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 218, DateTimeKind.Local).AddTicks(6265),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 341, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 207, DateTimeKind.Local).AddTicks(8553),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 323, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7a3410c0-833c-465a-ba33-f5435769d8a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "71540186-b5b2-4186-a3a1-637650286eef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9427d488-76bc-4efc-8541-0042fa8d7d11");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ae4207e1-9fc5-4f84-9a53-62516bebd378");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8e6cace9-09eb-4685-9d6e-f36b6b2fae3d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a2ae815-3b63-401c-a2a2-a94da11bc082", "AQAAAAEAACcQAAAAEKDSXlGiZsHEO8+k3iCj/SG+mG3w6bZzcCYIuY10g+t31YA7RDcj0j5pLQeqFcAM2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "391067cb-5b24-4a78-a2a4-b14be3d4028e", "AQAAAAEAACcQAAAAEHd7oHXYzuszUNHjmU3aUkky1sk1Bomh0+wwk41uQDXxMatuiyiKpZ1pjCrqpQKV5Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de20f591-547d-42a4-bdc1-2c73961ca8a9", "AQAAAAEAACcQAAAAEOql2t9GEtto2fJpkpGdmTD2YkduXbe0oaEJprQipT+ZxEr4D0xwsteGV0NIMI/PwQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9755402-0a21-47da-be5a-2cb0696549cf", "AQAAAAEAACcQAAAAEDPqpNTOfZIwp+04FzxoaCfix1I5lbfRAnC96A7S7u5+nJ76iFnvEMC2nsIc0WqgBA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17594305-0daf-41d2-943f-109ca146e885", "AQAAAAEAACcQAAAAECF/0pkBSh/vXJPHDM0RGcfUWTjI9BF+mUWrIpncl296u6lDbbZMGG9PZgntqmxNZQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(5083),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(3053),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 419, DateTimeKind.Local).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 268, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 420, DateTimeKind.Local).AddTicks(1072),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 269, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(2253),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(8974),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(6647),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(5269),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(7332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 404, DateTimeKind.Local).AddTicks(359),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 403, DateTimeKind.Local).AddTicks(7524),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(9672),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(5814),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(3299),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 263, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(868),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 262, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(9755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(7690),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(7597),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(73),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(3541),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(923),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(7844),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(6092),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(6030),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 279, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 427, DateTimeKind.Local).AddTicks(741),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 426, DateTimeKind.Local).AddTicks(7871),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(9192),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(7422),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 341, DateTimeKind.Local).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 218, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 323, DateTimeKind.Local).AddTicks(5535),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 207, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ab541c49-11e1-4bb0-a210-5e48d6f62c9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1266b337-1fb6-416b-9861-d9660691d230");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c2dc3054-6ae2-46a2-a9a3-dfa61d54661b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8e51dd6d-3649-4840-a631-8d778baa8c64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "2ad7673d-2127-403f-994e-340b036900c7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84a02dca-a2c9-4006-8306-1fdb552847f8", "AQAAAAEAACcQAAAAEG1t3rmgdMD0IjFKr1lr/i40jIYcixcYj+uqwylq9ZLhaoTWj5qdm3MsgCckDvaKVw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d16d123c-a2c6-4156-a43e-bae36e25676b", "AQAAAAEAACcQAAAAEPw/3o28l4yPYgA5QvvYyO8HZrAuEJie3r8f3UjnEGbHPVrmq1N1OSPonKRLTm9MPw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9795d425-c5a1-4e9f-8d05-d9fe9f2e1d9b", "AQAAAAEAACcQAAAAEKWuoHeU9cYeQgTW2vZDUcXceu5Osgcf92wI3W8vGnBzouYJwmK1rqSaG969Z6vw7A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "885daea3-d496-4a49-bf32-ef5080e0082a", "AQAAAAEAACcQAAAAEFdt2L/yDA9K4g7PBDbNB8lIUOUo1rhLFtG6f+UU6jCBsiDiE9yI5/Mv9CHQGuzw4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fb1f5fb-ae5e-48cc-88d6-7d85ced16449", "AQAAAAEAACcQAAAAEAgvVgLhNV1N4iXjnnPdln5XV1oV1rIeFRZcx+fzChbQc7oKpJKPUgdX9H7a4H8jSw==" });
        }
    }
}
