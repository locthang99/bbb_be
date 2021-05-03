using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(2674),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(738),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.AddColumn<int>(
                name: "TotalFollower",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 565, DateTimeKind.Local).AddTicks(6792),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 45, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 566, DateTimeKind.Local).AddTicks(2436),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 46, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 572, DateTimeKind.Local).AddTicks(7680),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 573, DateTimeKind.Local).AddTicks(7420),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(5363),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(3308),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(486),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(3172),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(7636),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 13, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(5220),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 12, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(9696),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(7396),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(7634),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(5631),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(7330),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 30, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(4640),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 29, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(5409),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 38, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(7341),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 37, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(7912),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 563, DateTimeKind.Local).AddTicks(159),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 43, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 562, DateTimeKind.Local).AddTicks(9148),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 42, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(1042),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(9760),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 3, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(7664),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 2, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(8357),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(6810),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(4025),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 82, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(1066),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 81, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(8631),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(6284),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(9450),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(6332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 517, DateTimeKind.Local).AddTicks(3356),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 998, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 504, DateTimeKind.Local).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 987, DateTimeKind.Local).AddTicks(4455));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalFollower",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(3584),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 5, DateTimeKind.Local).AddTicks(690),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 526, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 45, DateTimeKind.Local).AddTicks(9852),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 565, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 46, DateTimeKind.Local).AddTicks(3839),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 566, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(1137),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 572, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Like_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 54, DateTimeKind.Local).AddTicks(7429),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 573, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(7002),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Song",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 50, DateTimeKind.Local).AddTicks(4861),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 569, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(2598),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "User_Cmt_Playlist",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 58, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 577, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 13, DateTimeKind.Local).AddTicks(585),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 12, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 532, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(5775),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 83, DateTimeKind.Local).AddTicks(4129),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 601, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Songs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 10, DateTimeKind.Local).AddTicks(2411),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 530, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 30, DateTimeKind.Local).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Types",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 29, DateTimeKind.Local).AddTicks(9173),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 550, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(3569),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Tags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 85, DateTimeKind.Local).AddTicks(1498),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 604, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 38, DateTimeKind.Local).AddTicks(2444),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Singers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 37, DateTimeKind.Local).AddTicks(9646),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 557, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_PlayLists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 18, DateTimeKind.Local).AddTicks(7034),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 537, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 43, DateTimeKind.Local).AddTicks(76),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 563, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Owners",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 42, DateTimeKind.Local).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 562, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(5706),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Song_Composers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 41, DateTimeKind.Local).AddTicks(3350),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 561, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 3, DateTimeKind.Local).AddTicks(693),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Roles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 2, DateTimeKind.Local).AddTicks(9015),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 522, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(7168),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Playlists",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 15, DateTimeKind.Local).AddTicks(5664),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 534, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 82, DateTimeKind.Local).AddTicks(1229),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Histories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 81, DateTimeKind.Local).AddTicks(7045),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 600, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Followers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 61, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 581, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(8296),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "CacheDatas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 49, 87, DateTimeKind.Local).AddTicks(6658),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 608, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 998, DateTimeKind.Local).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 517, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "AppConfigs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 3, 17, 17, 48, 987, DateTimeKind.Local).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 5, 3, 22, 55, 19, 504, DateTimeKind.Local).AddTicks(4253));

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
    }
}
