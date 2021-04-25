using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistence.Migrations
{
    public partial class initDb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Cmt_Playlists_PlayList_PlaylistId",
                table: "User_Cmt_Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Cmt_Playlists_Users_UserId",
                table: "User_Cmt_Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Like_Playlists_PlayList_PlaylistId",
                table: "User_Like_Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Like_Playlists_Users_UserId",
                table: "User_Like_Playlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Like_Playlists",
                table: "User_Like_Playlists");

            migrationBuilder.DropIndex(
                name: "IX_User_Like_Playlists_UserId",
                table: "User_Like_Playlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Cmt_Playlists",
                table: "User_Cmt_Playlists");

            migrationBuilder.RenameTable(
                name: "User_Like_Playlists",
                newName: "User_Like_Playlist");

            migrationBuilder.RenameTable(
                name: "User_Cmt_Playlists",
                newName: "User_Cmt_Playlist");

            migrationBuilder.RenameIndex(
                name: "IX_User_Like_Playlists_PlaylistId",
                table: "User_Like_Playlist",
                newName: "IX_User_Like_Playlist_PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Cmt_Playlists_UserId",
                table: "User_Cmt_Playlist",
                newName: "IX_User_Cmt_Playlist_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Cmt_Playlists_PlaylistId",
                table: "User_Cmt_Playlist",
                newName: "IX_User_Cmt_Playlist_PlaylistId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(6694),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 158, DateTimeKind.Local).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 268, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 159, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 269, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 163, DateTimeKind.Local).AddTicks(911),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 162, DateTimeKind.Local).AddTicks(8163),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 134, DateTimeKind.Local).AddTicks(565),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 133, DateTimeKind.Local).AddTicks(9157),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(2318),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(721),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(4978),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(2745),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(8831),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(6869),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 152, DateTimeKind.Local).AddTicks(1667),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 263, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 151, DateTimeKind.Local).AddTicks(9845),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 262, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(6841),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(4305),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(9503),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(8954),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(7465),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(5579),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(2029),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(556),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 136, DateTimeKind.Local).AddTicks(1490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 135, DateTimeKind.Local).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(2598),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(880),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 279, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(7789),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(2995),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 97, DateTimeKind.Local).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 218, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 82, DateTimeKind.Local).AddTicks(2343),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 207, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.AlterColumn<int>(
                name: "TotalLike",
                table: "User_Like_Playlist",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(6070),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User_Like_Playlist",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(4231),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(8053),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "User_Cmt_Playlist",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Like_Playlist",
                table: "User_Like_Playlist",
                columns: new[] { "UserId", "PlaylistId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Cmt_Playlist",
                table: "User_Cmt_Playlist",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "021951c1-cea9-401d-80f0-7212619177ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0951b41b-ba80-4f89-8387-6a24df711cbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "db0f6930-9485-4100-86eb-01999c5522f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "fbf7e8de-3906-49cc-a197-d126f929c228");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c8fd8432-ed61-4318-a783-9d9bb3ed7a54");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d705372a-0888-4d3c-9489-2296cd927843", "AQAAAAEAACcQAAAAEIzA6AbntAwyUw3EqgkFq8RSzEQLMa/HR7T4j5EeOoN0JdmKyb4mOarXIQQXmn2ygw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e45f033-26e2-4383-8e18-4c1a24887b79", "AQAAAAEAACcQAAAAEFxovsegKIFVL8sy1st2j0W3+S3BXfoz1k2GulLH1qiAJtJjJCUbQU5DNb9K3wGvnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a070df7-0a43-484b-ad19-aeede9fd6d15", "AQAAAAEAACcQAAAAELCwr8RQxVq1o5xQUzfKp5D4WgDY2kPDY1eWzkdumrWURly8J3DRM6zd+eFPH5ggCw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11f03e68-9c9f-4f6f-bb22-d5774e9be9a4", "AQAAAAEAACcQAAAAEH3t3zpnzUB1QhrKDEa/JoG6wRauf2/QgOJwmi+zNlst2o9Bbj2otuw/fEBbPapV0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9f6af85-c3e7-45fe-91af-b6d44e6e2f4c", "AQAAAAEAACcQAAAAEPS0WrIqbXlUUl3xQqs1oWTV/QJ4Oiy4yTp9IOndSEElat4n2SLdwfsqpF8LsKGLRg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cmt_Playlist_PlayList_PlaylistId",
                table: "User_Cmt_Playlist",
                column: "PlaylistId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cmt_Playlist_Users_UserId",
                table: "User_Cmt_Playlist",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Like_Playlist_PlayList_PlaylistId",
                table: "User_Like_Playlist",
                column: "PlaylistId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Like_Playlist_Users_UserId",
                table: "User_Like_Playlist",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Cmt_Playlist_PlayList_PlaylistId",
                table: "User_Cmt_Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Cmt_Playlist_Users_UserId",
                table: "User_Cmt_Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Like_Playlist_PlayList_PlaylistId",
                table: "User_Like_Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Like_Playlist_Users_UserId",
                table: "User_Like_Playlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Like_Playlist",
                table: "User_Like_Playlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Cmt_Playlist",
                table: "User_Cmt_Playlist");

            migrationBuilder.RenameTable(
                name: "User_Like_Playlist",
                newName: "User_Like_Playlists");

            migrationBuilder.RenameTable(
                name: "User_Cmt_Playlist",
                newName: "User_Cmt_Playlists");

            migrationBuilder.RenameIndex(
                name: "IX_User_Like_Playlist_PlaylistId",
                table: "User_Like_Playlists",
                newName: "IX_User_Like_Playlists_PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Cmt_Playlist_UserId",
                table: "User_Cmt_Playlists",
                newName: "IX_User_Cmt_Playlists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Cmt_Playlist_PlaylistId",
                table: "User_Cmt_Playlists",
                newName: "IX_User_Cmt_Playlists_PlaylistId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 226, DateTimeKind.Local).AddTicks(945),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 268, DateTimeKind.Local).AddTicks(7543),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 158, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 269, DateTimeKind.Local).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 159, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(3764),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 163, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 271, DateTimeKind.Local).AddTicks(1981),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 162, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(9636),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 134, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 248, DateTimeKind.Local).AddTicks(8283),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 133, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(6952),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(5412),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 247, DateTimeKind.Local).AddTicks(3757),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(2992),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 258, DateTimeKind.Local).AddTicks(1193),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(3717),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 282, DateTimeKind.Local).AddTicks(1977),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 263, DateTimeKind.Local).AddTicks(8),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 152, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 262, DateTimeKind.Local).AddTicks(8412),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 151, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(6332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 253, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2790),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 266, DateTimeKind.Local).AddTicks(2283),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 265, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(5074),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 223, DateTimeKind.Local).AddTicks(3661),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(4838),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 136, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 250, DateTimeKind.Local).AddTicks(3386),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 135, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 280, DateTimeKind.Local).AddTicks(139),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 279, DateTimeKind.Local).AddTicks(8686),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(7485),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 273, DateTimeKind.Local).AddTicks(5946),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(9251),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 285, DateTimeKind.Local).AddTicks(7601),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 218, DateTimeKind.Local).AddTicks(6265),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 97, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 15, 53, 18, 207, DateTimeKind.Local).AddTicks(8553),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 82, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.AlterColumn<int>(
                name: "TotalLike",
                table: "User_Like_Playlists",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlists",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User_Like_Playlists",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlists",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlists",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlists",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "User_Cmt_Playlists",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Like_Playlists",
                table: "User_Like_Playlists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Cmt_Playlists",
                table: "User_Cmt_Playlists",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_User_Like_Playlists_UserId",
                table: "User_Like_Playlists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cmt_Playlists_PlayList_PlaylistId",
                table: "User_Cmt_Playlists",
                column: "PlaylistId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cmt_Playlists_Users_UserId",
                table: "User_Cmt_Playlists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Like_Playlists_PlayList_PlaylistId",
                table: "User_Like_Playlists",
                column: "PlaylistId",
                principalTable: "PlayList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Like_Playlists_Users_UserId",
                table: "User_Like_Playlists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
