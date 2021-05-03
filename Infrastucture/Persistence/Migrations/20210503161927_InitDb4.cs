using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_ObserverId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_PublicserId",
                table: "Followers");

            migrationBuilder.RenameColumn(
                name: "PublicserId",
                table: "Followers",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "ObserverId",
                table: "Followers",
                newName: "SubscriberId");

            migrationBuilder.RenameIndex(
                name: "IX_Followers_PublicserId",
                table: "Followers",
                newName: "IX_Followers_PublisherId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 603, DateTimeKind.Local).AddTicks(1361),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 602, DateTimeKind.Local).AddTicks(8992),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 641, DateTimeKind.Local).AddTicks(7558),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 565, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 642, DateTimeKind.Local).AddTicks(2976),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 566, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 649, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 572, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 650, DateTimeKind.Local).AddTicks(5489),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 573, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(9896),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(7226),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(8071),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(6531),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(6445),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(3161),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(938),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(7375),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(4692),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(3221),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(1550),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(3479),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(904),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(6971),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(4193),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(9198),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 563, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 562, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(8482),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(6162),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(7134),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(5492),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(4907),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(2672),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(6718),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(4537),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(8946),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(6868),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(5408),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(2679),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 594, DateTimeKind.Local).AddTicks(3356),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 517, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 582, DateTimeKind.Local).AddTicks(1376),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 504, DateTimeKind.Local).AddTicks(4253));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_PublisherId",
                table: "Followers",
                column: "PublisherId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_SubscriberId",
                table: "Followers",
                column: "SubscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_PublisherId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_SubscriberId",
                table: "Followers");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Followers",
                newName: "PublicserId");

            migrationBuilder.RenameColumn(
                name: "SubscriberId",
                table: "Followers",
                newName: "ObserverId");

            migrationBuilder.RenameIndex(
                name: "IX_Followers_PublisherId",
                table: "Followers",
                newName: "IX_Followers_PublicserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(2674),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 603, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(738),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 602, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 565, DateTimeKind.Local).AddTicks(6792),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 641, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 566, DateTimeKind.Local).AddTicks(2436),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 642, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 572, DateTimeKind.Local).AddTicks(7680),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 649, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 573, DateTimeKind.Local).AddTicks(7420),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 650, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(5363),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(3308),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 645, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(486),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(3172),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 654, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(7636),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(5220),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 610, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(9696),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(7396),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 677, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(7634),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(5631),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 608, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(7330),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(4640),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 627, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(5409),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 679, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(7341),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 634, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(7912),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 616, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 563, DateTimeKind.Local).AddTicks(159),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 562, DateTimeKind.Local).AddTicks(9148),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 638, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(1042),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 637, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(9760),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(7664),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 599, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(8357),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(6810),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 613, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(4025),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(1066),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 676, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(8631),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(6284),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 657, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(9450),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(6332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 682, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 517, DateTimeKind.Local).AddTicks(3356),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 594, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 504, DateTimeKind.Local).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 23, 19, 26, 582, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8dbc9912-4b18-4072-a024-a657da4acbe4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3249e67d-055c-4d28-b330-92d95868e7fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "01078747-79f5-4f93-a319-e9b8082a2cfb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a87830ec-af48-4136-bac3-d98502c2976f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c9019efd-cd0e-47f1-b186-7896b77f3ad4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3292ef9-9527-4ff3-97a7-6d3da7efecdf", "AQAAAAEAACcQAAAAEKC+No3Pqpt+c/Y/0wTF3VPsv+HTROnnOp5QfMbmjWTkM5FBGUwHBXBWlLx2rDxOjw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f752a11c-6747-41fa-88f8-b9f86788644f", "AQAAAAEAACcQAAAAEH46wS3EohQ9yqOsW3JQkbVDKtBDymxUSDods9YbNgzhrkQAqdjLUQ7o7vepxK7oog==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77d8f9eb-8287-4b14-864a-1e6d19597d65", "AQAAAAEAACcQAAAAEKqiNZmXdv13CqlsxgajXzirHYz9dXyppRWLNzfN7/pZaPjw26vpeQE9wcfQFXYkxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a642f7a4-e90c-4025-a92a-a7ca7ceac6ae", "AQAAAAEAACcQAAAAEC69kJK4fpRURQQIXZgjJDajSJ9equQOZpfwpXp2H45oXvtKDjaP6VnHFZUFcHmj8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "679611bc-511d-489f-b78c-33286652b90c", "AQAAAAEAACcQAAAAELGOa04DMr97hmxN653dmU7vKHTjzxTM1liK7DAxrqPV//b8zJ/EEzMGW1VRHBHrFg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_ObserverId",
                table: "Followers",
                column: "ObserverId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_PublicserId",
                table: "Followers",
                column: "PublicserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
