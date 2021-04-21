using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistence.Migrations
{
    public partial class intiDB0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 296, DateTimeKind.Local).AddTicks(8074)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 313, DateTimeKind.Local).AddTicks(3890))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CacheDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OwnerId = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    TimeExpire = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 399, DateTimeKind.Local).AddTicks(7576)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 399, DateTimeKind.Local).AddTicks(9804))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CacheDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ActionType = table.Column<string>(type: "text", nullable: false),
                    ObjectType = table.Column<string>(type: "text", nullable: false),
                    ObjectId = table.Column<string>(type: "text", nullable: true),
                    ObjectName = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 391, DateTimeKind.Local).AddTicks(8460)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 392, DateTimeKind.Local).AddTicks(755))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Thumbnail = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    TotalSong = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    TotalListen = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    TotalLike = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    TotalCmt = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    PlaylistType = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 355, DateTimeKind.Local).AddTicks(6335)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 355, DateTimeKind.Local).AddTicks(8351)),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 318, DateTimeKind.Local).AddTicks(5972)),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 318, DateTimeKind.Local).AddTicks(8280)),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalListen = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    TotalLike = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    TotalCmt = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    TotalDownload = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    Lyric = table.Column<string>(type: "text", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Thumbnail = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    FileMusic = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 349, DateTimeKind.Local).AddTicks(1840)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 349, DateTimeKind.Local).AddTicks(4450)),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 393, DateTimeKind.Local).AddTicks(1881)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 393, DateTimeKind.Local).AddTicks(4088)),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 351, DateTimeKind.Local).AddTicks(2843)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 351, DateTimeKind.Local).AddTicks(5093)),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    ProviderKey = table.Column<string>(type: "text", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    AccountType = table.Column<string>(type: "text", nullable: false),
                    Thumbnail = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 322, DateTimeKind.Local).AddTicks(7540)),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 322, DateTimeKind.Local).AddTicks(8877)),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "FileMusics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdSong = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    SongId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileMusics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileMusics_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Song_PlayLists",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    PlayListId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 358, DateTimeKind.Local).AddTicks(4560)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 358, DateTimeKind.Local).AddTicks(6379))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_PlayLists", x => new { x.SongId, x.PlayListId });
                    table.ForeignKey(
                        name: "FK_Song_PlayLists_PlayList_PlayListId",
                        column: x => x.PlayListId,
                        principalTable: "PlayList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_PlayLists_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song_Tags",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 395, DateTimeKind.Local).AddTicks(4663)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 396, DateTimeKind.Local).AddTicks(2689))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Tags", x => new { x.SongId, x.TagId });
                    table.ForeignKey(
                        name: "FK_Song_Tags_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_Tags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song_Types",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 364, DateTimeKind.Local).AddTicks(3967)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 364, DateTimeKind.Local).AddTicks(5780))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Types", x => new { x.SongId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_Song_Types_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_Types_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdSong = table.Column<int>(type: "integer", nullable: true),
                    IdPlayList = table.Column<int>(type: "integer", nullable: true),
                    IdUser = table.Column<Guid>(type: "uuid", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    SongId = table.Column<int>(type: "integer", nullable: true),
                    PlayListId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileImages_PlayList_PlayListId",
                        column: x => x.PlayListId,
                        principalTable: "PlayList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileImages_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileImages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SenderId = table.Column<int>(type: "integer", nullable: false),
                    ReceiverId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 380, DateTimeKind.Local).AddTicks(7158)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 380, DateTimeKind.Local).AddTicks(9466))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friends_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Friends_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song_Owners",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 367, DateTimeKind.Local).AddTicks(183)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 367, DateTimeKind.Local).AddTicks(2126))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Owners", x => new { x.SongId, x.OwnerId });
                    table.ForeignKey(
                        name: "FK_Song_Owners_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_Owners_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Cmt_Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PlaylistId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Cmt_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Cmt_Playlists_PlayList_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "PlayList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Cmt_Playlists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Cmt_Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 376, DateTimeKind.Local).AddTicks(6820)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 376, DateTimeKind.Local).AddTicks(9741))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Cmt_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Cmt_Song_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Cmt_Song_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Like_Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PlaylistId = table.Column<int>(type: "integer", nullable: false),
                    TotalLike = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Like_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Like_Playlists_PlayList_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "PlayList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Like_Playlists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Like_Song",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    TotalLike = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 373, DateTimeKind.Local).AddTicks(1137)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 4, 21, 15, 4, 10, 372, DateTimeKind.Local).AddTicks(3595))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Like_Song", x => new { x.UserId, x.SongId });
                    table.ForeignKey(
                        name: "FK_User_Like_Song_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Like_Song_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "LastModifiedBy", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "57e4f186-de32-4be8-9831-e37ea69a9b66", null, null, "SUPPERADMIN", "SUPPERADMIN" },
                    { 2, "a3d7f00d-4c64-42da-ae52-1bd99347a4dc", null, null, "ADMIN", "ADMIN" },
                    { 3, "a82b25fe-b9c8-488a-a5a0-e20317f667d9", null, null, "USER", "USER" },
                    { 4, "ac521a3b-949f-4a62-9fde-6089b0eb74c9", null, null, "SINGER", "SINGER" },
                    { 5, "a846497f-b16c-4d4b-9e87-5324402a58c7", null, null, "AUTHOR", "AUTHOR" }
                });

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

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 2, 2 },
                    { 1, 1 },
                    { 5, 5 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Address", "ConcurrencyStamp", "CreatedBy", "Dob", "Email", "EmailConfirmed", "FirstName", "LastModifiedBy", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 5, 0, "SYSTEM", null, "12f4d53b-6b78-4484-853a-eb4d5632c674", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "author@gmail.com", true, "Author", null, "Author", false, null, "AUTHOR@GMAIL.COM", "AUTHOR", "AQAAAAEAACcQAAAAEPknHgnQ2NpnFS0jGq09pHJSMXqeF1XS0Y11bZp+zfwNmk1heoXlZMGp6KkGhIyhVw==", null, false, "", false, "author" },
                    { 3, 0, "SYSTEM", null, "88ad2e2a-c7c6-4590-bb48-8d5bf915be9f", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "User", null, "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAEDhA1hGOjbDGZV+75UnkRmusOMHrzde5Nc72u0wLBUp9pS8SYmbQC6SZ5zAfj2nm3Q==", null, false, "", false, "user" },
                    { 2, 0, "SYSTEM", null, "85a6ece4-5144-47f7-807e-504aff0852ec", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Admin", null, "BigBluebirds", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJ7hzWb4SOp4F2pNUIDmIBVbQerOJ9hQ5qhlrrxZ1GPOVa3oxIv67Cn0uwPrY4gQXw==", null, false, "", false, "admin" },
                    { 4, 0, "SYSTEM", null, "464b5d5c-ce44-4989-bc8a-f8fd56850a31", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "singer@gmail.com", true, "Singer", null, "Singer", false, null, "SINGER@GMAIL.COM", "SINGER", "AQAAAAEAACcQAAAAEIpMIJ6p7d+VAWJg7kW5UKd7WQQ7n0KPde2m+T15ZqrngnUyHf0a3SI83TZdKmKovg==", null, false, "", false, "singer" },
                    { 1, 0, "SYSTEM", null, "3bdcca1f-2979-4b97-b636-0ae35cb3692b", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "supperadmin@gmail.com", true, "Supper Admin", null, "BigBluebirds", false, null, "SUPPERADMIN@GMAIL.COM", "SUPPERADMIN", "AQAAAAEAACcQAAAAEBWHOVs3680XnxKJ0rMsxJxzLquW7KlFrmNg/YjB75i+UcdPOarzISShRAifSs+O0A==", null, false, "", false, "supperadmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileImages_PlayListId",
                table: "FileImages",
                column: "PlayListId");

            migrationBuilder.CreateIndex(
                name: "IX_FileImages_SongId",
                table: "FileImages",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_FileImages_UserId",
                table: "FileImages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileMusics_SongId",
                table: "FileMusics",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_ReceiverId",
                table: "Friends",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_SenderId",
                table: "Friends",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Owners_OwnerId",
                table: "Song_Owners",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_PlayLists_PlayListId",
                table: "Song_PlayLists",
                column: "PlayListId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Tags_TagId",
                table: "Song_Tags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Types_TypeId",
                table: "Song_Types",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cmt_Playlists_PlaylistId",
                table: "User_Cmt_Playlists",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cmt_Playlists_UserId",
                table: "User_Cmt_Playlists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cmt_Song_SongId",
                table: "User_Cmt_Song",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cmt_Song_UserId",
                table: "User_Cmt_Song",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Like_Playlists_PlaylistId",
                table: "User_Like_Playlists",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Like_Playlists_UserId",
                table: "User_Like_Playlists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Like_Song_SongId",
                table: "User_Like_Song",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "CacheDatas");

            migrationBuilder.DropTable(
                name: "FileImages");

            migrationBuilder.DropTable(
                name: "FileMusics");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Song_Owners");

            migrationBuilder.DropTable(
                name: "Song_PlayLists");

            migrationBuilder.DropTable(
                name: "Song_Tags");

            migrationBuilder.DropTable(
                name: "Song_Types");

            migrationBuilder.DropTable(
                name: "User_Cmt_Playlists");

            migrationBuilder.DropTable(
                name: "User_Cmt_Song");

            migrationBuilder.DropTable(
                name: "User_Like_Playlists");

            migrationBuilder.DropTable(
                name: "User_Like_Song");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoleClaims");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "PlayList");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
