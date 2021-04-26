using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(9480),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(6818),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 158, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(9829),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 159, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(3124),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 163, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(1843),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 162, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(5085),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(7312),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 134, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(2388),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 133, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Types",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(3504),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(2213),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(8627),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(7173),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(1693),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(5595),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(4211),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(2883),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 152, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(1562),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 151, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(6243),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(4909),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(1954),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 630, DateTimeKind.Local).AddTicks(832),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 629, DateTimeKind.Local).AddTicks(9436),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(9021),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(7785),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 136, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(6282),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 135, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(5124),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(3653),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(5289),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(3989),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(3653),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(2328),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 590, DateTimeKind.Local).AddTicks(9723),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 97, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 579, DateTimeKind.Local).AddTicks(7311),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 82, DateTimeKind.Local).AddTicks(2343));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Types");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(6694),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 104, DateTimeKind.Local).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 596, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 158, DateTimeKind.Local).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 159, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 632, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 167, DateTimeKind.Local).AddTicks(6070),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 641, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 163, DateTimeKind.Local).AddTicks(911),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 162, DateTimeKind.Local).AddTicks(8163),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 639, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(4231),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 171, DateTimeKind.Local).AddTicks(8053),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 643, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 134, DateTimeKind.Local).AddTicks(565),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 133, DateTimeKind.Local).AddTicks(9157),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 617, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(2318),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 184, DateTimeKind.Local).AddTicks(721),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 652, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(4978),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 132, DateTimeKind.Local).AddTicks(2745),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 615, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 146, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 624, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(8831),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 185, DateTimeKind.Local).AddTicks(6869),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 653, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 152, DateTimeKind.Local).AddTicks(1667),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 151, DateTimeKind.Local).AddTicks(9845),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 628, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(6841),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 139, DateTimeKind.Local).AddTicks(4305),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 620, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(9503),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 155, DateTimeKind.Local).AddTicks(8954),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 631, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(7465),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 630, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 154, DateTimeKind.Local).AddTicks(5579),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 629, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(2029),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 102, DateTimeKind.Local).AddTicks(556),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 594, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 136, DateTimeKind.Local).AddTicks(1490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "PlayList",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 135, DateTimeKind.Local).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 618, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(2598),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 183, DateTimeKind.Local).AddTicks(880),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 651, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Friends",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 175, DateTimeKind.Local).AddTicks(7789),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 645, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(2995),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 188, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 655, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 97, DateTimeKind.Local).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 590, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 25, 16, 23, 16, 82, DateTimeKind.Local).AddTicks(2343),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 4, 26, 12, 36, 47, 579, DateTimeKind.Local).AddTicks(7311));

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
        }
    }
}
