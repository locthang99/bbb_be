using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 159, DateTimeKind.Local).AddTicks(785),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 603, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 158, DateTimeKind.Local).AddTicks(9685),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 602, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.AddColumn<string>(
                name: "ResetCode",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 187, DateTimeKind.Local).AddTicks(215),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 641, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 187, DateTimeKind.Local).AddTicks(3507),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 642, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 191, DateTimeKind.Local).AddTicks(8542),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 649, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 192, DateTimeKind.Local).AddTicks(1876),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 650, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 189, DateTimeKind.Local).AddTicks(6249),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 189, DateTimeKind.Local).AddTicks(4489),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 194, DateTimeKind.Local).AddTicks(3180),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 194, DateTimeKind.Local).AddTicks(5767),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 163, DateTimeKind.Local).AddTicks(6940),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 163, DateTimeKind.Local).AddTicks(5572),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 214, DateTimeKind.Local).AddTicks(1212),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 213, DateTimeKind.Local).AddTicks(9840),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 162, DateTimeKind.Local).AddTicks(1492),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 162, DateTimeKind.Local).AddTicks(105),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 177, DateTimeKind.Local).AddTicks(5473),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 177, DateTimeKind.Local).AddTicks(3361),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 215, DateTimeKind.Local).AddTicks(3179),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 215, DateTimeKind.Local).AddTicks(1685),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 182, DateTimeKind.Local).AddTicks(2405),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 182, DateTimeKind.Local).AddTicks(736),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 167, DateTimeKind.Local).AddTicks(8618),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 167, DateTimeKind.Local).AddTicks(6087),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 185, DateTimeKind.Local).AddTicks(4396),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 185, DateTimeKind.Local).AddTicks(3899),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 184, DateTimeKind.Local).AddTicks(3599),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 184, DateTimeKind.Local).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 157, DateTimeKind.Local).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 157, DateTimeKind.Local).AddTicks(3754),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 165, DateTimeKind.Local).AddTicks(2146),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 165, DateTimeKind.Local).AddTicks(798),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 213, DateTimeKind.Local).AddTicks(3376),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 213, DateTimeKind.Local).AddTicks(1932),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 196, DateTimeKind.Local).AddTicks(9273),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 196, DateTimeKind.Local).AddTicks(7511),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 217, DateTimeKind.Local).AddTicks(1454),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 217, DateTimeKind.Local).AddTicks(173),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 153, DateTimeKind.Local).AddTicks(5117),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 594, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 142, DateTimeKind.Local).AddTicks(987),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 582, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0fdf51a5-427c-4618-b1b9-9f33ee9ce71b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "920dfc3a-a4cc-4077-82d8-a71bc3875c33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ef6e9cdf-58d2-4ae5-b643-2a4fee29bfa7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "70fc1f74-3aea-4083-a2fa-e3fe4f5096f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "f446344e-01f1-4af6-acaa-1656d4d89595");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc2b559e-e6fd-4c13-a0b5-e7c0816447e7", "AQAAAAEAACcQAAAAED6aEkDn/tI+A81BLsFjPFF0YYFOj7Vbu+4IUrbn1esi7bRrADDRwScWa99E3cY/8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2db0008-14f2-4b10-8b1e-3dd190e3b490", "AQAAAAEAACcQAAAAEBd0kcioaH8szVaXcYvCMfsVIcpvGB9cF2gYkaSz4d31c9oI+nhicygb0AkR6BXG6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c00897a-b59e-4d8e-9630-e99c5360af5b", "AQAAAAEAACcQAAAAEDs2bfQCHcuyBW7ytJJZEKV+CnkvVA/7iO8gOtWd5F6rb2VjiiE870saV+a+7N6Lcg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "386d7205-abaf-40b1-88f9-2d821968ab58", "AQAAAAEAACcQAAAAEG+Y/SiViPg8smfAtXSb+siAqU9ydOHADLm+931ZGJgGCa/RRNSIGnabY3wq8h56Vw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aab96a01-f3b5-4ed6-8962-58f8a75f5111", "AQAAAAEAACcQAAAAEPl34kmbLydvleDA73uRkzU5CTvTum6D8YRYuViDTddgEJRPVsv3/pZhm1Gw1RY41Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResetCode",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 603, DateTimeKind.Local).AddTicks(1361),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 159, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 602, DateTimeKind.Local).AddTicks(8992),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 158, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 641, DateTimeKind.Local).AddTicks(7558),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 187, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 642, DateTimeKind.Local).AddTicks(2976),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 187, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 649, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 191, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 650, DateTimeKind.Local).AddTicks(5489),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 192, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(9896),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 189, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(7226),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 189, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 194, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(8071),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 194, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(6531),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 163, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 163, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 214, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(6445),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 213, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(3161),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 162, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(938),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 162, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(7375),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 177, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(4692),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 177, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(3221),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 215, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(1550),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 215, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(3479),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 182, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(904),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 182, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(6971),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 167, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(4193),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 167, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(9198),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 185, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 185, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(8482),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 184, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(6162),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 184, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(7134),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 157, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(5492),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 157, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(4907),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 165, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(2672),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 165, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(6718),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 213, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(4537),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 213, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(8946),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 196, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(6868),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 196, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(5408),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 217, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(2679),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 217, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 594, DateTimeKind.Local).AddTicks(3356),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 153, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 582, DateTimeKind.Local).AddTicks(1376),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 6, 12, 36, 15, 142, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "df4330b5-bb37-46f1-86b1-b61a3b8a8c1e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f48a515a-5cd5-4603-a73b-c7362c731284");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0b63400b-badc-4905-bf46-e709d84cd127");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "d5412534-af26-4e60-b56a-6ed7b052346d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "3940de8d-93ea-4bfe-83b2-7856f4b93fb3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6a152ef-3745-4b3a-a9d5-d4d15c37cd52", "AQAAAAEAACcQAAAAEOenwJMKiSdlNqrguavXkPzq6P4fLPqeEpqkUKaCfcyJ9NQD0YMQtaa1dFEjnbD+sw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b31e689-7d3b-490a-b437-dd1168aef11e", "AQAAAAEAACcQAAAAECtmK8Qad0Pol5UHq9dJe/yHASVXZWo62m2fMgbwB/uY2R/C71Y9QaoNdI6C2mzB1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0d87c6d-5bca-4556-ad47-4eef37b23203", "AQAAAAEAACcQAAAAEMGLCXyaqc8tPCH7SRyY6SVOOj3/LOjXKi4edv0mGKFsHA3d2UVjgMoH7Fy3/Nb9jQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8de7ad6f-8afb-4f30-b2c1-b8f52a9505f0", "AQAAAAEAACcQAAAAEPwdFDqXtBXL5HsNpmF9e+sHNKHCd0dSfGurwi8nkgIg0ZJ8x0uwz5hyHZn/d6rlzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5240b7d-5d54-4775-9cb8-bf0d56f42d76", "AQAAAAEAACcQAAAAEHrW20N7TKlxMX5t+2YPQ3iXacLKmUcrIcpMYFCa9HXgcrtJKOzjjWC6LUvBHXAT5g==" });
        }
    }
}
