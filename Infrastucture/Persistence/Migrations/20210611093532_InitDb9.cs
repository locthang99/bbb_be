using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(4938),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 37, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(8987),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 38, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 212, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 46, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 213, DateTimeKind.Local).AddTicks(4922),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 47, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(7961),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(4724),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 218, DateTimeKind.Local).AddTicks(8660),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 219, DateTimeKind.Local).AddTicks(4088),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(6660),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(3966),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(5816),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 82, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(2230),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 81, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 142, DateTimeKind.Local).AddTicks(6243),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 141, DateTimeKind.Local).AddTicks(1769),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(9075),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(4953),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Song_Types",
                type: "integer",
                nullable: false,
                defaultValue: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(9204),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 85, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(5166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 84, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(3612),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(699),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 154, DateTimeKind.Local).AddTicks(4160),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 997, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 153, DateTimeKind.Local).AddTicks(8547),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 996, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(8755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(7395),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(4516),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 32, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(1204),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 31, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 128, DateTimeKind.Local).AddTicks(1128),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 127, DateTimeKind.Local).AddTicks(7870),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 149, DateTimeKind.Local).AddTicks(2325),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 148, DateTimeKind.Local).AddTicks(9166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 251, DateTimeKind.Local).AddTicks(1849),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 80, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 250, DateTimeKind.Local).AddTicks(8492),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 79, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(7408),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 54, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 53, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(7721),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(4181),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 117, DateTimeKind.Local).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 969, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 96, DateTimeKind.Local).AddTicks(5791),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 953, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0fbacd2c-0016-43f6-9890-6d5c96016199");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "dfb6b3a4-d324-42a4-830c-d3c22338fba3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "68384183-b877-4c10-b240-e782d2d98e11");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "2f1cb733-dd4e-43e4-90f5-eafb5a5e6de0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "9d3e3f94-15c3-4096-88e1-484d2d0f30ab");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ecea07b-0ab5-4fe8-9113-8e99db75728f", "AQAAAAEAACcQAAAAEGiCJzpGvYG9uwlYx3l5X5a5d6Si7z+aALtKUWjLUX9H2Imnr0RJ5YavyXaulusjGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb2ebe4d-677b-4bbb-863f-6e6ace4365ea", "AQAAAAEAACcQAAAAEB77vw1fSwt/XWwb67zAilpdMb5XVL9/RWh4qIE/de1gH5Ap+i6zr9At+UcQYWn6pg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b6a4435-0c8a-45ff-a687-7892aec160ad", "AQAAAAEAACcQAAAAEOWhOYSL2CXMA3PQb1CYDQQpnvUOgUFN0S27nKtWIZyDG/VpQhZFxyhSiq/F72OUnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec190554-61e7-47b5-b5fb-48ca9f83050b", "AQAAAAEAACcQAAAAENMEm/ebmGY5lEWpoJicl2hSdhIBnI7xOEWcQhf5H3A87anBCBMLu7AoR59osliybA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36cd976f-a963-44b1-a46e-6cd2ccb768c0", "AQAAAAEAACcQAAAAEOYzEgKcuCfAc/yWHUj3RzZZY25QdSjcIiNpzyAn4Z8/eeYjBfiW5CZa8rfGUbVFfA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Song_Types");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 981, DateTimeKind.Local).AddTicks(583),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 37, DateTimeKind.Local).AddTicks(7065),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 38, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 46, DateTimeKind.Local).AddTicks(7213),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 212, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 47, DateTimeKind.Local).AddTicks(2176),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 213, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(5314),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 42, DateTimeKind.Local).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(5233),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 218, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 50, DateTimeKind.Local).AddTicks(8493),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 219, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 989, DateTimeKind.Local).AddTicks(754),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 82, DateTimeKind.Local).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 81, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(2662),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 142, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 987, DateTimeKind.Local).AddTicks(433),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 141, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(7878),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 16, DateTimeKind.Local).AddTicks(4043),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 85, DateTimeKind.Local).AddTicks(3166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 84, DateTimeKind.Local).AddTicks(9533),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(4702),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 27, DateTimeKind.Local).AddTicks(1260),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 997, DateTimeKind.Local).AddTicks(4090),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 154, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 996, DateTimeKind.Local).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 153, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(7127),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 34, DateTimeKind.Local).AddTicks(5706),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 32, DateTimeKind.Local).AddTicks(3070),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 31, DateTimeKind.Local).AddTicks(9016),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 128, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 977, DateTimeKind.Local).AddTicks(6583),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 127, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(5020),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 149, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 992, DateTimeKind.Local).AddTicks(2255),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 148, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 80, DateTimeKind.Local).AddTicks(1197),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 251, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 79, DateTimeKind.Local).AddTicks(8514),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 250, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 54, DateTimeKind.Local).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 53, DateTimeKind.Local).AddTicks(8272),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(9755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 52, 91, DateTimeKind.Local).AddTicks(5064),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 969, DateTimeKind.Local).AddTicks(3373),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 117, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 12, 25, 51, 953, DateTimeKind.Local).AddTicks(2871),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 96, DateTimeKind.Local).AddTicks(5791));

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
    }
}
