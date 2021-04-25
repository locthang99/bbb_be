using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class initDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(5083),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 404, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(3053),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 404, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 419, DateTimeKind.Local).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 525, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 420, DateTimeKind.Local).AddTicks(1072),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 526, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(2253),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 534, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 534, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(8974),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 469, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(6647),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 469, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 567, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(5269),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 566, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(7332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 459, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 458, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 404, DateTimeKind.Local).AddTicks(359),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 488, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 403, DateTimeKind.Local).AddTicks(7524),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 488, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(9672),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 571, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(5814),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 570, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(3299),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 506, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(868),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 506, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(9755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 478, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(7690),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 477, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 521, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(7597),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 521, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 518, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(73),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 518, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(3541),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 398, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(923),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 398, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(7844),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 472, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(6092),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 472, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(6030),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 564, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 564, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 427, DateTimeKind.Local).AddTicks(741),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 540, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 426, DateTimeKind.Local).AddTicks(7871),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 540, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(9192),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 575, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(7422),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 575, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 341, DateTimeKind.Local).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 385, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 323, DateTimeKind.Local).AddTicks(5535),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 354, DateTimeKind.Local).AddTicks(9043));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 404, DateTimeKind.Local).AddTicks(6215),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 404, DateTimeKind.Local).AddTicks(3176),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 353, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 525, DateTimeKind.Local).AddTicks(5169),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 419, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 526, DateTimeKind.Local).AddTicks(4906),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 420, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 534, DateTimeKind.Local).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 534, DateTimeKind.Local).AddTicks(1678),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 423, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 469, DateTimeKind.Local).AddTicks(3720),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 469, DateTimeKind.Local).AddTicks(676),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 390, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 567, DateTimeKind.Local).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 566, DateTimeKind.Local).AddTicks(8125),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 438, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 459, DateTimeKind.Local).AddTicks(1676),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 458, DateTimeKind.Local).AddTicks(7841),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 388, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 488, DateTimeKind.Local).AddTicks(8375),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 404, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 488, DateTimeKind.Local).AddTicks(4821),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 403, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 571, DateTimeKind.Local).AddTicks(3985),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 570, DateTimeKind.Local).AddTicks(9408),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 440, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 506, DateTimeKind.Local).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 506, DateTimeKind.Local).AddTicks(5509),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 411, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 478, DateTimeKind.Local).AddTicks(2505),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 477, DateTimeKind.Local).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 396, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 521, DateTimeKind.Local).AddTicks(3573),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 521, DateTimeKind.Local).AddTicks(2365),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 415, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 518, DateTimeKind.Local).AddTicks(6365),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 518, DateTimeKind.Local).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 414, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 398, DateTimeKind.Local).AddTicks(6287),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 398, DateTimeKind.Local).AddTicks(2777),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 349, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 472, DateTimeKind.Local).AddTicks(4514),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 472, DateTimeKind.Local).AddTicks(1858),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 392, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 564, DateTimeKind.Local).AddTicks(5631),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 564, DateTimeKind.Local).AddTicks(1368),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 437, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 540, DateTimeKind.Local).AddTicks(7832),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 427, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 540, DateTimeKind.Local).AddTicks(3948),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 426, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 575, DateTimeKind.Local).AddTicks(9068),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 575, DateTimeKind.Local).AddTicks(5953),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 443, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 385, DateTimeKind.Local).AddTicks(6998),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 341, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 22, 23, 15, 25, 354, DateTimeKind.Local).AddTicks(9043),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 24, 22, 48, 7, 323, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f4729ab8-4a0b-440f-b9f7-2769fc70cd07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3e93052e-2edf-426d-b1c2-a6ee246a8f53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1595ffaf-ac05-4fcc-a550-0594d4baf9a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "117af258-46cc-4ba0-a06f-b746bd7452ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "69da1bd9-1878-4196-a9ba-8ef993c5cae1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29ddfa34-40a0-4419-8446-5a1e215032ea", "AQAAAAEAACcQAAAAEAMkRqdXri4ZZz37qlWTh+YieplPK87jWZXqmeOQ1RiLzHae8NMULqug9pj3JSWuKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "755bf919-187d-4d37-8758-cd30260718cd", "AQAAAAEAACcQAAAAEKj9QhM4f5UsDWr+L66bkMEvuKZNx/Rz25NTiC0eqLtWV1BsW4ZpXtFf9HFPQEBegQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10a9f49b-8111-4596-b73d-fe393735ead4", "AQAAAAEAACcQAAAAECB/WNPqn++gwePLejvLSApQWh6dkrA17ErN3+KkZstpLsZO+nNUPwbbzrT0WEShzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1438f122-4d14-40cd-aacb-d0abf9f5f4e5", "AQAAAAEAACcQAAAAEDWgHlGQPtMMSFPcqxaQCqMb96I/cnUGtlVBxcuI8GpKndESh5mK3NZQh9UlSUl9fg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "113c43be-8080-4d92-82d6-5d4b55d33e50", "AQAAAAEAACcQAAAAEMIGMwuTm0DcC2Wuyw8AMKpKcFDVjrLOwsiaU8M3KtvVQ658YlRz3aWQ07brnbLcIQ==" });
        }
    }
}
