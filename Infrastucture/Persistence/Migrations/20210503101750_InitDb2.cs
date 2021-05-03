using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistence.Migrations
{
    public partial class InitDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Followers",
                table: "Followers");

            migrationBuilder.DropIndex(
                name: "IX_Followers_ObserverId",
                table: "Followers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(3584),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 623, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(690),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 623, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 45, DateTimeKind.Local).AddTicks(9852),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 659, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 46, DateTimeKind.Local).AddTicks(3839),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 660, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(1137),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 667, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(7429),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 667, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(7002),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 664, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(4861),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 664, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(2598),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 670, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 670, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 13, DateTimeKind.Local).AddTicks(585),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 631, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 12, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 631, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(5775),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 691, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(4129),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 690, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 628, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(2411),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 628, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 30, DateTimeKind.Local).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 648, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 29, DateTimeKind.Local).AddTicks(9173),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 648, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(3569),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 692, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(1498),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 692, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 38, DateTimeKind.Local).AddTicks(2444),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 653, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 37, DateTimeKind.Local).AddTicks(9646),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 653, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 637, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(7034),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 637, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 43, DateTimeKind.Local).AddTicks(76),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 657, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 42, DateTimeKind.Local).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 657, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(5706),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 656, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(3350),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 656, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 3, DateTimeKind.Local).AddTicks(693),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 621, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 2, DateTimeKind.Local).AddTicks(9015),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 621, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(7168),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 633, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(5664),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 633, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 82, DateTimeKind.Local).AddTicks(1229),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 690, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 81, DateTimeKind.Local).AddTicks(7045),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 689, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 673, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 673, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Followers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(8296),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 696, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(6658),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 696, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 998, DateTimeKind.Local).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 617, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 987, DateTimeKind.Local).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 604, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followers",
                table: "Followers",
                columns: new[] { "ObserverId", "PublicserId" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7e21f254-c743-4927-9bd3-826a214f54b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fddf5238-3bf7-447d-af5a-4dce808eb386");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1f4a1e7e-496b-41d2-9f4e-54c5dddda023");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "5244ce62-1c25-40a0-a1a7-1593799b26ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "80c8848c-f478-488a-b640-a3acfeceed31");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "881bb6c9-35d4-4a89-82da-a86762d2cf1e", "AQAAAAEAACcQAAAAEFd1NtuTbONwdWTE6GacKxLU0QRqOiAGrA2c5zJcpI4gak6eWZ1dCTbZabpBIXCWaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60bf8859-f36e-4bad-8235-cff77cbdec94", "AQAAAAEAACcQAAAAEPRRVj1v7QUwRGzF5MNhSEKR97BTV53Vzas5DicWieXt6XrCV37ho6T85IzAPD/0PQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01198707-7546-4713-9990-eb11523966af", "AQAAAAEAACcQAAAAEPP13E1w/oDv101f1GAeC68cBs/4twaR49FUwuGDYSBcA+l/nDtEdXg+csAMUt8x5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "942fa2d5-0afc-4899-b698-ac5b8a860461", "AQAAAAEAACcQAAAAEOClEGhaAjH9RcNOI5p5V4SCAj20M/KuzMyhSvLOKALop73uxJRsOk/3+l8QF9wVPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec4eea67-6b97-41db-949c-9936ba5371d6", "AQAAAAEAACcQAAAAEJAL5vAAStUiCJqqFIA1NP5KhgezAkoCgWAhdJRQzmM4LAlsHNuDWxM43QP3Kgbnmw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Followers",
                table: "Followers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 623, DateTimeKind.Local).AddTicks(6572),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 623, DateTimeKind.Local).AddTicks(5317),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 659, DateTimeKind.Local).AddTicks(7200),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 45, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 660, DateTimeKind.Local).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 46, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 667, DateTimeKind.Local).AddTicks(3413),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 667, DateTimeKind.Local).AddTicks(7334),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 664, DateTimeKind.Local).AddTicks(2189),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 664, DateTimeKind.Local).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 670, DateTimeKind.Local).AddTicks(5543),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 670, DateTimeKind.Local).AddTicks(8162),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 631, DateTimeKind.Local).AddTicks(4435),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 13, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 631, DateTimeKind.Local).AddTicks(1633),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 12, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 691, DateTimeKind.Local).AddTicks(966),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 690, DateTimeKind.Local).AddTicks(9277),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 628, DateTimeKind.Local).AddTicks(3293),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 628, DateTimeKind.Local).AddTicks(1073),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 648, DateTimeKind.Local).AddTicks(7624),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 30, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 648, DateTimeKind.Local).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 29, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 692, DateTimeKind.Local).AddTicks(7166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 692, DateTimeKind.Local).AddTicks(5234),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 653, DateTimeKind.Local).AddTicks(8039),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 38, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 653, DateTimeKind.Local).AddTicks(6284),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 37, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 637, DateTimeKind.Local).AddTicks(4428),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 637, DateTimeKind.Local).AddTicks(773),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 657, DateTimeKind.Local).AddTicks(8379),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 43, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 657, DateTimeKind.Local).AddTicks(7844),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 42, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 656, DateTimeKind.Local).AddTicks(6232),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 656, DateTimeKind.Local).AddTicks(4111),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 621, DateTimeKind.Local).AddTicks(8541),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 3, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 621, DateTimeKind.Local).AddTicks(7012),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 2, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 633, DateTimeKind.Local).AddTicks(9977),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 633, DateTimeKind.Local).AddTicks(7822),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 690, DateTimeKind.Local).AddTicks(1198),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 82, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 689, DateTimeKind.Local).AddTicks(9565),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 81, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 673, DateTimeKind.Local).AddTicks(2500),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Followers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 673, DateTimeKind.Local).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 696, DateTimeKind.Local).AddTicks(2234),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 696, DateTimeKind.Local).AddTicks(326),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 617, DateTimeKind.Local).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 998, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 604, DateTimeKind.Local).AddTicks(2610),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 987, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followers",
                table: "Followers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "749006b7-7a42-4f0a-9329-d8b29976207c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b65868d4-7b5d-490d-90ff-c330372b15ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c3a389eb-a73b-4ae7-8911-93dc43d3c0d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8774ae1f-a111-4084-bcd3-f35e9141bca7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "78205cae-5983-400c-bed1-83cb6f6a525d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96d5b8fe-f0d4-4de4-9a01-f6718abc2ce9", "AQAAAAEAACcQAAAAECIHs+uB/+uZ0TdH9zeOhG9X35DyhQ0Lx8zh2B7hpZonJn+BrWD1CszAr8nB6SwZvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a1b04fd-7a01-468a-9533-5f561baf6030", "AQAAAAEAACcQAAAAEHOFITZ9hPM0asTGnDfsdBdvuT3cDYCPPlZdm0CRdUnJdkdDULNXfhO95UfZji+Sfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fddca26f-8e97-4403-a514-00d3f11290d8", "AQAAAAEAACcQAAAAEBogEGmEVb8OsnSKnIjjzpf7nV7yCtKZgXEismtRMm9o3X+e/8/guSzMl5kSAoIS3Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3aca41a-f43e-4f4c-a504-0e8d0a917433", "AQAAAAEAACcQAAAAEC6bHrb+gPlMPjCZBtG6OWURNkWdhL4/zwbLtGn3dNZ3CKQtYuMKhYmFajdeEw4LIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d96d15a-e2c0-4638-a1b9-df67e6d7c2f7", "AQAAAAEAACcQAAAAENyN0TiYdkwo0X0oN8X5pOE3VRqsmOApbP2sKdgdIHtmlUuHp7FvM0bM9VBkM0TInw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Followers_ObserverId",
                table: "Followers",
                column: "ObserverId");
        }
    }
}
