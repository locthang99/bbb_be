using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IntiDb7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(9940),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 960, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(8821),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 959, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.AddColumn<bool>(
                name: "UserVip",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(2573),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 13, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(5622),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 13, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "User_Like_Song",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "User_Like_Song",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(6223),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 18, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(9377),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 18, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "User_Like_Playlist",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "User_Like_Playlist",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(5022),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 15, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 15, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "User_Cmt_Song",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "User_Cmt_Song",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(81),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 21, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(2421),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 22, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "User_Cmt_Playlist",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "User_Cmt_Playlist",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(8994),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 970, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(7419),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 969, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Types",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Types",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(8564),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 41, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(7296),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 40, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Tags",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Tags",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(9787),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 966, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(8601),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 966, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Songs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Songs",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "SongVip",
                table: "Songs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(9911),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 999, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(8451),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 999, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Song_Types",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Song_Types",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(1691),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 42, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(338),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 42, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Song_Tags",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Song_Tags",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(8960),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 7, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(7409),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 7, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Song_Singers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Song_Singers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 358, DateTimeKind.Local).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 979, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 357, DateTimeKind.Local).AddTicks(8277),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 978, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Song_PlayLists",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Song_PlayLists",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(8168),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 11, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(7481),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 11, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Song_Owners",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Song_Owners",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(8518),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 9, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(7052),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 9, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Song_Composers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Song_Composers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 956, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(948),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 955, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(6145),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 973, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(4764),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 973, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Playlists",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Playlists",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 40, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(8258),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 39, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Histories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Histories",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 24, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(449),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 24, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "Followers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Followers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(9853),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 45, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(8602),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 44, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "CacheDatas",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "CacheDatas",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 338, DateTimeKind.Local).AddTicks(6447),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 949, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 327, DateTimeKind.Local).AddTicks(7309),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 934, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.AddColumn<bool>(
                name: "Disable",
                table: "AppConfigs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "AppConfigs",
                type: "boolean",
                nullable: false,
                defaultValue: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserVip",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "User_Like_Song");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "User_Like_Song");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "User_Like_Playlist");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "User_Like_Playlist");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "User_Cmt_Song");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "User_Cmt_Song");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "User_Cmt_Playlist");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "User_Cmt_Playlist");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "SongVip",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Song_Types");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Song_Types");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Song_Tags");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Song_Tags");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Song_Singers");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Song_Singers");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Song_PlayLists");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Song_PlayLists");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Song_Owners");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Song_Owners");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Song_Composers");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Song_Composers");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "Followers");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Followers");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "CacheDatas");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "CacheDatas");

            migrationBuilder.DropColumn(
                name: "Disable",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "AppConfigs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 960, DateTimeKind.Local).AddTicks(1634),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 959, DateTimeKind.Local).AddTicks(9451),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 344, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 13, DateTimeKind.Local).AddTicks(382),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 13, DateTimeKind.Local).AddTicks(4224),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 375, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 18, DateTimeKind.Local).AddTicks(5604),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 18, DateTimeKind.Local).AddTicks(9424),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 379, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 15, DateTimeKind.Local).AddTicks(8643),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 15, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 377, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 21, DateTimeKind.Local).AddTicks(9077),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 22, DateTimeKind.Local).AddTicks(1909),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 382, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 970, DateTimeKind.Local).AddTicks(1683),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 969, DateTimeKind.Local).AddTicks(8271),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 353, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 41, DateTimeKind.Local).AddTicks(759),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 40, DateTimeKind.Local).AddTicks(9212),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 396, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 966, DateTimeKind.Local).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 966, DateTimeKind.Local).AddTicks(3001),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 347, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 999, DateTimeKind.Local).AddTicks(8397),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 999, DateTimeKind.Local).AddTicks(4756),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 366, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 42, DateTimeKind.Local).AddTicks(6035),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 42, DateTimeKind.Local).AddTicks(4235),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 398, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 7, DateTimeKind.Local).AddTicks(3778),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 7, DateTimeKind.Local).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 370, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 979, DateTimeKind.Local).AddTicks(2583),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 358, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 978, DateTimeKind.Local).AddTicks(6716),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 357, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 11, DateTimeKind.Local).AddTicks(2063),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 11, DateTimeKind.Local).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 373, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 9, DateTimeKind.Local).AddTicks(8472),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 9, DateTimeKind.Local).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 372, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 956, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 955, DateTimeKind.Local).AddTicks(9004),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 343, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 973, DateTimeKind.Local).AddTicks(6382),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 973, DateTimeKind.Local).AddTicks(3460),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 355, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 40, DateTimeKind.Local).AddTicks(1022),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 39, DateTimeKind.Local).AddTicks(9402),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 395, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 24, DateTimeKind.Local).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 24, DateTimeKind.Local).AddTicks(4671),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 384, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 45, DateTimeKind.Local).AddTicks(399),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 31, 44, DateTimeKind.Local).AddTicks(8611),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 399, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 949, DateTimeKind.Local).AddTicks(15),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 338, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 9, 8, 23, 30, 934, DateTimeKind.Local).AddTicks(3409),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 19, 10, 29, 25, 327, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1a1468fd-065a-497f-9352-108f73e09e82");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f23fd5c1-4c50-4340-8332-0eb72a4c38ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d8cdc89e-caa7-4f8f-bff3-5f223c3419a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0333fd54-8e24-4020-824a-37d90063961c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4ddd9682-9c23-4cce-bc94-723d03bab149");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f03df367-73bf-484c-a32f-00104bac6e96", "AQAAAAEAACcQAAAAEHfb+mNwRjufrKP5vJd1CBaY+AvDiJt3E+1ljyFou/LCHIoOqFWLxILZSUiH79i/Gg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4f148d5-f00e-4671-b660-33675df6469f", "AQAAAAEAACcQAAAAENI7CjjKQQ2lN40eVjLbH+V0WSqzgbDtu7DhMCB6RjcDvOVElGQ7F+uYGctGUlgv5Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6289403-b19b-423c-806f-4973c085853c", "AQAAAAEAACcQAAAAEBBTlFMQLQRZgxHxZQTS2nYrakvkGN6P1BvwYwHESyOAL2mmYqXnvjutRmzW9xPXsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5b3a38a-a5b0-4fde-811e-4f64138e3935", "AQAAAAEAACcQAAAAEJpSBI2D3KdIck0lTMbOJJjYV8UBqlO3XDKnGtkorsw08H/ShxKxLsLbPq8iBe+HKA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b47754e-bf0c-49b4-90ea-e7e31af8b699", "AQAAAAEAACcQAAAAEOfQ7kp1rEzNLc12hkKI2g109eloB1oHowSfOZGk4zwPZ1xIouVhznGtWiJfhclaxQ==" });
        }
    }
}
