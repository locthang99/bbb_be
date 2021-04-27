using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileImages_PlayList_PlayListId",
                table: "FileImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_PlayLists_PlayList_PlayListId",
                table: "Song_PlayLists");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Cmt_Playlist_PlayList_PlaylistId",
                table: "User_Cmt_Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Like_Playlist_PlayList_PlaylistId",
                table: "User_Like_Playlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayList",
                table: "PlayList");

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "PlayList",
                newName: "Playlists");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 331, DateTimeKind.Local).AddTicks(774),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 330, DateTimeKind.Local).AddTicks(9744),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 366, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 366, DateTimeKind.Local).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 384, DateTimeKind.Local).AddTicks(931),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 384, DateTimeKind.Local).AddTicks(3799),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 382, DateTimeKind.Local).AddTicks(372),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 381, DateTimeKind.Local).AddTicks(8963),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 386, DateTimeKind.Local).AddTicks(2584),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 386, DateTimeKind.Local).AddTicks(4853),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 350, DateTimeKind.Local).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 350, DateTimeKind.Local).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 394, DateTimeKind.Local).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 394, DateTimeKind.Local).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 349, DateTimeKind.Local).AddTicks(3171),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 349, DateTimeKind.Local).AddTicks(1757),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 358, DateTimeKind.Local).AddTicks(1429),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 358, DateTimeKind.Local).AddTicks(85),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 395, DateTimeKind.Local).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 395, DateTimeKind.Local).AddTicks(7104),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 361, DateTimeKind.Local).AddTicks(9931),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 361, DateTimeKind.Local).AddTicks(8513),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 354, DateTimeKind.Local).AddTicks(1621),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 354, DateTimeKind.Local).AddTicks(220),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 364, DateTimeKind.Local).AddTicks(8126),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 364, DateTimeKind.Local).AddTicks(7720),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 363, DateTimeKind.Local).AddTicks(9056),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 630, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 363, DateTimeKind.Local).AddTicks(7678),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 629, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 329, DateTimeKind.Local).AddTicks(1660),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 329, DateTimeKind.Local).AddTicks(487),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 393, DateTimeKind.Local).AddTicks(8964),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 393, DateTimeKind.Local).AddTicks(7726),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 388, DateTimeKind.Local).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 388, DateTimeKind.Local).AddTicks(1154),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 397, DateTimeKind.Local).AddTicks(5640),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 397, DateTimeKind.Local).AddTicks(4347),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 325, DateTimeKind.Local).AddTicks(3145),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 590, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 314, DateTimeKind.Local).AddTicks(6342),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 579, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 352, DateTimeKind.Local).AddTicks(2472),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 352, DateTimeKind.Local).AddTicks(1222),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "078d5d14-65df-45d6-b87a-8e60f52aa362");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "19ed5ec6-cbea-4d59-bf6e-96635af6118f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "55d789ee-a8bf-4a14-a32b-1b2ce0089acc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "54a6cae1-1cfb-4add-8003-1d801d6aa80f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "066e179c-e162-4e53-aeef-b88a41eb6173");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce2eaaaf-2da3-4ee2-98c0-e116641f3f28", "AQAAAAEAACcQAAAAEFaOGTHXuhV82DIHhNp9ytILaWt/nAINjMMdYkZrJ5aQFf6y+dsLbkUDxT6OCZE4Ug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2a49b72-c12e-477c-9b6e-ca228a3975d1", "AQAAAAEAACcQAAAAEMDAYDNoP49zaVWYwe7GRvS8YGOhOW5GAVtDeLrm7g3dotI8GmhvLc8M9dj2q5rRdQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41bf3ef2-1b87-49ba-8037-a8f740205c3b", "AQAAAAEAACcQAAAAEGVSThYc7Mf8Kz32tp6xBiaZj/bg0s0Yrq1x3H+243un6w6rx7UtDOz4v+mfPSE0Vw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "661e1bfe-2e69-41fa-9edc-ce52c013335d", "AQAAAAEAACcQAAAAEPrqfpQqVvNcibOgLv0PUq0/KfJCwRLJfPV6D/4BnWNhwAK3/gz+VVjzURt2q8+0ew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33a9baa8-ae3b-438b-96d0-78421150d840", "AQAAAAEAACcQAAAAEE0oo0AYe2wkWkFPWGvxuB473ThuFsR14UbrAVA6PHXHZSudNksrqcetT6/IlDGFmg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_FileImages_Playlists_PlayListId",
                table: "FileImages",
                column: "PlayListId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_PlayLists_Playlists_PlayListId",
                table: "Song_PlayLists",
                column: "PlayListId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cmt_Playlist_Playlists_PlaylistId",
                table: "User_Cmt_Playlist",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Like_Playlist_Playlists_PlaylistId",
                table: "User_Like_Playlist",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileImages_Playlists_PlayListId",
                table: "FileImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_PlayLists_Playlists_PlayListId",
                table: "Song_PlayLists");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Cmt_Playlist_Playlists_PlaylistId",
                table: "User_Cmt_Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Like_Playlist_Playlists_PlaylistId",
                table: "User_Like_Playlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists");

            migrationBuilder.RenameTable(
                name: "Playlists",
                newName: "PlayList");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(9480),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 331, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 330, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(6818),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 366, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(9829),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 366, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(3124),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 384, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 384, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 382, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(1843),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 381, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(5085),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 386, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(7312),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 386, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 350, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(2388),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 350, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(3504),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 394, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(2213),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 394, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(8627),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 349, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(7173),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 349, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 358, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(1693),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 358, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(5595),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 395, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(4211),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 395, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(2883),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 361, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(1562),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 361, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(6243),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 354, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(4909),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 354, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 364, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(1954),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 364, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 630, DateTimeKind.Local).AddTicks(832),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 363, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 629, DateTimeKind.Local).AddTicks(9436),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 363, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(9021),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 329, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(7785),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 329, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(5124),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 393, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(3653),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 393, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(5289),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 388, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(3989),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 388, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(3653),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 397, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(2328),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 397, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 590, DateTimeKind.Local).AddTicks(9723),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 325, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 579, DateTimeKind.Local).AddTicks(7311),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 314, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 352, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(6282),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 27, 15, 2, 53, 352, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayList",
                table: "PlayList",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0fa5abf7-36f3-4169-b688-8a78a556b798");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "326de10a-2f36-4f1f-b63c-05744c6f0a9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "79a6066b-801b-474e-a8e8-a7cc043d227b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "eb49ec3c-c383-45d6-bb91-455b3954c49b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c6e6bba4-9e62-4310-befe-5ef76461d2e2");

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "CreatedBy", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, null, null, "Nhac tre" },
                    { 2, null, null, "Nhac Remix" },
                    { 3, null, null, "Nhac Pop" },
                    { 4, null, null, "Nhac Ballad" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e11fa487-8c73-496f-ac34-e7c147ba98c7", "AQAAAAEAACcQAAAAEOFvvQEr7LrEySwAnalqVBhf/lcu/O5VCWrg+rBDOjbUxMaDRgJ5pcvprkQnMMhwqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5ee6748-f1e5-441a-862f-117da860cf2b", "AQAAAAEAACcQAAAAEBEJD0Me1MGLx/FoJiZBTHk1T+K6M1bOY2Ly1Gch1+4n0Zms/7Rvc0l0DkwQwYz1dA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a806b825-02e1-4ca9-9ed0-8b1d07cf4653", "AQAAAAEAACcQAAAAEKMT6j/DokMmJ1vi+7uG5uqebOxrF9UbOQ2yF/kZ+haqWJJA4Fm9k8zmDkBqIZxNoA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cca6af03-582b-4e67-964a-20505c8745ee", "AQAAAAEAACcQAAAAEOvvDEuefSdoCOpA8UiIFl0YKjfNp0ndWuLAv1cKun9RpGSUnrz3op14FdNvRBxkAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4cba30c-2e52-4be4-a16a-ee3f2aa15230", "AQAAAAEAACcQAAAAEG33kkX2iVOXMC/iouRTEQ+nTl2BSBGYXbPlAH8nDu5YfFibXYEV6rpdRfj+HAFwRQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_FileImages_PlayList_PlayListId",
                table: "FileImages",
                column: "PlayListId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_PlayLists_PlayList_PlayListId",
                table: "Song_PlayLists",
                column: "PlayListId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cmt_Playlist_PlayList_PlaylistId",
                table: "User_Cmt_Playlist",
                column: "PlaylistId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Like_Playlist_PlayList_PlaylistId",
                table: "User_Like_Playlist",
                column: "PlaylistId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
