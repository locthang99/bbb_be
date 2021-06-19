using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileMusic",
                table: "Songs",
                newName: "FileMusic128");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(5098),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(3751),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 507, DateTimeKind.Local).AddTicks(7971),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 790, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 508, DateTimeKind.Local).AddTicks(1551),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 791, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(3617),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(7567),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(5080),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(3372),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(1961),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(4544),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(8711),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(7251),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(9491),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 821, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(7835),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 820, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(3890),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.AddColumn<string>(
                name: "FileMusic320",
                table: "Songs",
                type: "text",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileMusicLossless",
                table: "Songs",
                type: "text",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Songs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOfficial",
                table: "Songs",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(2543),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(833),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(6065),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 502, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 501, DateTimeKind.Local).AddTicks(8979),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(3444),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(898),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(553),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(19),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(9432),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(7611),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(2275),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(799),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(4801),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(5867),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(4254),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(9629),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(6537),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(9118),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(7401),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 469, DateTimeKind.Local).AddTicks(9682),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 743, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 458, DateTimeKind.Local).AddTicks(7351),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 731, DateTimeKind.Local).AddTicks(1289));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileMusic320",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "FileMusicLossless",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "IsOfficial",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "FileMusic128",
                table: "Songs",
                newName: "FileMusic");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(9322),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 477, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 790, DateTimeKind.Local).AddTicks(8456),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 507, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 791, DateTimeKind.Local).AddTicks(2237),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 508, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(7776),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 513, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(4886),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(2751),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 510, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(7439),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 516, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(9415),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(7675),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 482, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 821, DateTimeKind.Local).AddTicks(212),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 820, DateTimeKind.Local).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 534, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(7987),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(6300),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 481, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(2710),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(431),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 497, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 536, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(8578),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 502, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(6661),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 501, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(8554),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(5354),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 487, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(9536),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(8968),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 506, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(7066),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(4233),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 504, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(8038),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(6389),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 475, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(9220),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(7528),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 484, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(6318),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(4478),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 533, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(2801),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 518, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(5962),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(3933),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 538, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 743, DateTimeKind.Local).AddTicks(6939),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 469, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 731, DateTimeKind.Local).AddTicks(1289),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 17, 8, 39, 12, 458, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "be5896bb-34b3-42b5-adae-e109ba672c3d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a9cdfa8b-9b2a-494a-a4b0-95b6ed845682");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ed290b95-f84c-4c6b-97c6-4e394734adbc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9848a0f0-fe1c-46ac-9245-c87bfcd4cb8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "283fe6f3-8415-4890-9e69-8cfdeb0c06a2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee294d98-9e15-49ad-a981-444db68f3122", "AQAAAAEAACcQAAAAEAS5/pVOoiJ572pYJwcmCAQ4PxWNU8ZT07yObMujlfcz7ut0faNTde1ug9GM6K6V6g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4da11322-e12d-41e1-a06c-47b4c6d5a248", "AQAAAAEAACcQAAAAEABxYHFW3YPlu3GnpXDMRwBP9RzVqwCGpUPipJxeY741Jg+tuGvrIOu3ldauubjuDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33afc6db-7b02-438b-acb3-fdd3f399cf3c", "AQAAAAEAACcQAAAAEBPw6EtY9YLv88TMqzjmQKHV3WPTz8kPc3mIrEBFFZbjHD1agJ3vVf1jE6rhwGHJ7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f19de39c-8d68-4046-b2da-449b3f2870d8", "AQAAAAEAACcQAAAAEFxW/pkZUR4mJN0Jxjnn/ddaBNjlndO7BWx0hJP2HiB2XYxtBzLXNJOLxJhqW2Lsdw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5677b58e-0ce0-476f-863d-8b6c76e4d017", "AQAAAAEAACcQAAAAEAVL6xbDldS49TQ4n8cUV6PtRz6yyIyOb8sr+UVInPxikihfB5wnqOnRPOWkol872g==" });
        }
    }
}
