using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(9322),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 790, DateTimeKind.Local).AddTicks(8456),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 791, DateTimeKind.Local).AddTicks(2237),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 212, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(7776),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 213, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(4886),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(2751),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 218, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(7439),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 219, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(9415),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(7675),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 821, DateTimeKind.Local).AddTicks(212),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 820, DateTimeKind.Local).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(7987),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 142, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(6300),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 141, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(2710),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(431),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(8578),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(6661),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(8554),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 154, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(5354),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 153, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(9536),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(8968),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(7066),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(4233),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(8038),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 128, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(6389),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 127, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(9220),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 149, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(7528),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 148, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(6318),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 251, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(4478),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 250, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(2801),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(5962),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(3933),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 743, DateTimeKind.Local).AddTicks(6939),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 117, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 731, DateTimeKind.Local).AddTicks(1289),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 96, DateTimeKind.Local).AddTicks(5791));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 132, DateTimeKind.Local).AddTicks(4938),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 755, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 790, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 201, DateTimeKind.Local).AddTicks(8987),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 791, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 212, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 213, DateTimeKind.Local).AddTicks(4922),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 797, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(7961),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 206, DateTimeKind.Local).AddTicks(4724),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 794, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 218, DateTimeKind.Local).AddTicks(8660),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 219, DateTimeKind.Local).AddTicks(4088),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 800, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(6660),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 145, DateTimeKind.Local).AddTicks(3966),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 761, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(5816),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 821, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 253, DateTimeKind.Local).AddTicks(2230),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 820, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 142, DateTimeKind.Local).AddTicks(6243),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 141, DateTimeKind.Local).AddTicks(1769),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 759, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(9075),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 180, DateTimeKind.Local).AddTicks(4953),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 779, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(9204),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 256, DateTimeKind.Local).AddTicks(5166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 822, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(3612),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 190, DateTimeKind.Local).AddTicks(699),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 784, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 154, DateTimeKind.Local).AddTicks(4160),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 153, DateTimeKind.Local).AddTicks(8547),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 766, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(8755),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 197, DateTimeKind.Local).AddTicks(7395),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 788, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(4516),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 195, DateTimeKind.Local).AddTicks(1204),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 787, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 128, DateTimeKind.Local).AddTicks(1128),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 127, DateTimeKind.Local).AddTicks(7870),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 752, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 149, DateTimeKind.Local).AddTicks(2325),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 148, DateTimeKind.Local).AddTicks(9166),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 763, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 251, DateTimeKind.Local).AddTicks(1849),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 250, DateTimeKind.Local).AddTicks(8492),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 819, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(7408),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 223, DateTimeKind.Local).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 803, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(7721),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 261, DateTimeKind.Local).AddTicks(4181),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 825, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 117, DateTimeKind.Local).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 743, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 16, 35, 30, 96, DateTimeKind.Local).AddTicks(5791),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 6, 11, 17, 14, 39, 731, DateTimeKind.Local).AddTicks(1289));

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
    }
}
