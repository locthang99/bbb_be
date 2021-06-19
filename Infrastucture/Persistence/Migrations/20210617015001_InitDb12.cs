using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 374, DateTimeKind.Local).AddTicks(406),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 373, DateTimeKind.Local).AddTicks(9088),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 407, DateTimeKind.Local).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 507, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 408, DateTimeKind.Local).AddTicks(2972),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 508, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 415, DateTimeKind.Local).AddTicks(3335),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 415, DateTimeKind.Local).AddTicks(7979),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 412, DateTimeKind.Local).AddTicks(2599),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 412, DateTimeKind.Local).AddTicks(298),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 419, DateTimeKind.Local).AddTicks(1874),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 419, DateTimeKind.Local).AddTicks(4514),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 379, DateTimeKind.Local).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 379, DateTimeKind.Local).AddTicks(5915),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 442, DateTimeKind.Local).AddTicks(4681),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 442, DateTimeKind.Local).AddTicks(2152),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 378, DateTimeKind.Local).AddTicks(2360),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 378, DateTimeKind.Local).AddTicks(769),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Songs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 394, DateTimeKind.Local).AddTicks(3260),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 394, DateTimeKind.Local).AddTicks(1477),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 445, DateTimeKind.Local).AddTicks(1724),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 444, DateTimeKind.Local).AddTicks(8935),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 399, DateTimeKind.Local).AddTicks(1594),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 502, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 398, DateTimeKind.Local).AddTicks(9936),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 501, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 384, DateTimeKind.Local).AddTicks(1167),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 383, DateTimeKind.Local).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 404, DateTimeKind.Local).AddTicks(2645),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 404, DateTimeKind.Local).AddTicks(1982),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 402, DateTimeKind.Local).AddTicks(3671),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 402, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 371, DateTimeKind.Local).AddTicks(7284),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 371, DateTimeKind.Local).AddTicks(5590),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 381, DateTimeKind.Local).AddTicks(4841),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 381, DateTimeKind.Local).AddTicks(3349),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 440, DateTimeKind.Local).AddTicks(7003),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 440, DateTimeKind.Local).AddTicks(4236),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 422, DateTimeKind.Local).AddTicks(1833),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 422, DateTimeKind.Local).AddTicks(62),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 448, DateTimeKind.Local).AddTicks(8113),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 448, DateTimeKind.Local).AddTicks(5318),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 366, DateTimeKind.Local).AddTicks(5270),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 469, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 353, DateTimeKind.Local).AddTicks(8356),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 458, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f7fa5970-2174-4828-ad63-841281d10a8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "89f40c86-9813-4bb7-9809-53b8f560643f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ced66d52-1004-4b0f-b0cb-4ff9334a4340");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "78c7e335-1cab-471a-bc59-3f05b6ed3885");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "665ef86e-fcb4-4a0e-899d-62af7e01bb06");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5576fe6c-c163-4b87-83ac-96fef9338639", "AQAAAAEAACcQAAAAEL57/mIUmzwAc/7roenlZ0gUzRxqQ7zi0cuMhtjsbuFo6aOVoW5vdNu7nMxmYb4foA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f516facd-dec9-4853-84dc-26bcb810fe19", "AQAAAAEAACcQAAAAENpiqF7o1yNm/QzIlFQC67MeusLCfrow2zmpDWvBSB2ypp8xkzsiQE1ulEg1VD76Mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fc78630-53ee-48d5-9668-62c2bab385c3", "AQAAAAEAACcQAAAAEA4lorgJF/3PnjPIxVazNwxGET7pNyNFYxnh6k4nGNzmT+EC9aImqsodd2laYtICMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4a2a9fe-9846-4820-8a25-d8a35071d465", "AQAAAAEAACcQAAAAECtcH9E8Pc1vfMyd/06dERx1oNhu08MtGjFcc9iDcWPcyXfDc6ckWQ5SK7Fjn/f5eQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f587a9d5-0f8d-4060-a9a3-dc1423ad6710", "AQAAAAEAACcQAAAAEJ/FuDFs5TeGGhkefzGmS4Qbl4M0My7KZNZ7huoK8XcLuKgy9mLHpbjiKzlYRpeByQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Songs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(5098),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 374, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(3751),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 373, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 507, DateTimeKind.Local).AddTicks(7971),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 407, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 508, DateTimeKind.Local).AddTicks(1551),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 408, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(3617),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 415, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(7567),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 415, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(5080),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 412, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(3372),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 412, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(1961),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 419, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(4544),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 419, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(8711),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 379, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(7251),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 379, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(9491),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 442, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(7835),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 442, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(3890),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 378, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 378, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(2543),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 394, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(833),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 394, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(6065),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 445, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 444, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 502, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 399, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 501, DateTimeKind.Local).AddTicks(8979),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 398, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(3444),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 384, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(898),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 383, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(553),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 404, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(19),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 404, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(9432),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 402, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(7611),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 402, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(2275),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 371, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(799),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 371, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 381, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(4801),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 381, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(5867),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 440, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(4254),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 440, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(9629),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 422, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(6537),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 422, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(9118),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 448, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(7401),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 448, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 469, DateTimeKind.Local).AddTicks(9682),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 366, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 458, DateTimeKind.Local).AddTicks(7351),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 50, 0, 353, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f17fe56e-e651-447b-be27-532674e5f106");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a44d65a2-2540-462f-a766-b6cdd209c181");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4f032bfb-5792-47fa-bead-e72dce13fd92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "fb6d3f28-687f-401a-af0d-8b7f40c42609");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "fd73ccc8-854a-4896-aab9-29775fb5eb8a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aaff23ca-4260-4aab-99f2-bc48eda1c8ab", "AQAAAAEAACcQAAAAEEdorYrZUCm/zIY9/s1fmpwQdyfGyBEwSo7PRJwFzdDoZf59ozNm2xabACOiCFydzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aace4a35-1393-4ba4-9d1f-505a628ce636", "AQAAAAEAACcQAAAAEBcFECGAD6Iu1JToWXroTjOLu5e/v8cNwZCBeauj5Kj3XpWdZUsUTZrJ/bLWYqtJGA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab578a0a-d360-42ca-9de8-3e0b0ea5c61c", "AQAAAAEAACcQAAAAEAE/sajtTvRRzo+UZ711JToSopawCbBDLVIhZZNHP6jUhYvLNIsqxJeJCrjw02vXsA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "52e3443f-af65-4f7f-8d2a-cee236479fbc", "AQAAAAEAACcQAAAAEFL+SVAemi/vubea6USr0qLnuuY/Kn6jveBsrJvDEjUDOnqt5HCiM+/AHyJBFLG6qA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "745b061c-210e-482d-9076-5c56907a9503", "AQAAAAEAACcQAAAAEBu+T7w81euZ8ayJ4vfATDGks+nk09777fknR2Aze8BAGS1iRxx3QdbyeykoWzPsHg==" });
        }
    }
}
