using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistence.Migrations
{
    public partial class InitDb0 : Migration
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 604, DateTimeKind.Local).AddTicks(2610)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 617, DateTimeKind.Local).AddTicks(6443))
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 696, DateTimeKind.Local).AddTicks(326)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 696, DateTimeKind.Local).AddTicks(2234))
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 689, DateTimeKind.Local).AddTicks(9565)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 690, DateTimeKind.Local).AddTicks(1198))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 633, DateTimeKind.Local).AddTicks(7822)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 633, DateTimeKind.Local).AddTicks(9977)),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 621, DateTimeKind.Local).AddTicks(7012)),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 621, DateTimeKind.Local).AddTicks(8541)),
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
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    Thumbnail = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    FileMusic = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 628, DateTimeKind.Local).AddTicks(1073)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 628, DateTimeKind.Local).AddTicks(3293)),
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 690, DateTimeKind.Local).AddTicks(9277)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 691, DateTimeKind.Local).AddTicks(966)),
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
                    Thumbnail = table.Column<string>(type: "text", nullable: false, defaultValue: ""),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 631, DateTimeKind.Local).AddTicks(1633)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 631, DateTimeKind.Local).AddTicks(4435)),
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 623, DateTimeKind.Local).AddTicks(5317)),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 623, DateTimeKind.Local).AddTicks(6572)),
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 637, DateTimeKind.Local).AddTicks(773)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 637, DateTimeKind.Local).AddTicks(4428))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_PlayLists", x => new { x.SongId, x.PlayListId });
                    table.ForeignKey(
                        name: "FK_Song_PlayLists_Playlists_PlayListId",
                        column: x => x.PlayListId,
                        principalTable: "Playlists",
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 692, DateTimeKind.Local).AddTicks(5234)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 692, DateTimeKind.Local).AddTicks(7166))
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 648, DateTimeKind.Local).AddTicks(5675)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 648, DateTimeKind.Local).AddTicks(7624))
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
                        name: "FK_FileImages_Playlists_PlayListId",
                        column: x => x.PlayListId,
                        principalTable: "Playlists",
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
                name: "Followers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ObserverId = table.Column<int>(type: "integer", nullable: false),
                    PublicserId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 673, DateTimeKind.Local).AddTicks(783)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 673, DateTimeKind.Local).AddTicks(2500))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Followers_Users_ObserverId",
                        column: x => x.ObserverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Followers_Users_PublicserId",
                        column: x => x.PublicserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Song_Composers",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    ComposerId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 656, DateTimeKind.Local).AddTicks(4111)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 656, DateTimeKind.Local).AddTicks(6232))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Composers", x => new { x.SongId, x.ComposerId });
                    table.ForeignKey(
                        name: "FK_Song_Composers_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_Composers_Users_ComposerId",
                        column: x => x.ComposerId,
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 657, DateTimeKind.Local).AddTicks(7844)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 657, DateTimeKind.Local).AddTicks(8379))
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
                name: "Song_Singers",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "integer", nullable: false),
                    SingerId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 653, DateTimeKind.Local).AddTicks(6284)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 653, DateTimeKind.Local).AddTicks(8039))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Singers", x => new { x.SongId, x.SingerId });
                    table.ForeignKey(
                        name: "FK_Song_Singers_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_Singers_Users_SingerId",
                        column: x => x.SingerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Cmt_Playlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PlaylistId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 670, DateTimeKind.Local).AddTicks(8162)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 670, DateTimeKind.Local).AddTicks(5543))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Cmt_Playlist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Cmt_Playlist_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Cmt_Playlist_Users_UserId",
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 664, DateTimeKind.Local).AddTicks(126)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 664, DateTimeKind.Local).AddTicks(2189))
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
                name: "User_Like_Playlist",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PlaylistId = table.Column<int>(type: "integer", nullable: false),
                    TotalLike = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 667, DateTimeKind.Local).AddTicks(7334)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 667, DateTimeKind.Local).AddTicks(3413))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Like_Playlist", x => new { x.UserId, x.PlaylistId });
                    table.ForeignKey(
                        name: "FK_User_Like_Playlist_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Like_Playlist_Users_UserId",
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
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 660, DateTimeKind.Local).AddTicks(1030)),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2021, 5, 3, 16, 53, 18, 659, DateTimeKind.Local).AddTicks(7200))
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
                    { 1, "749006b7-7a42-4f0a-9329-d8b29976207c", null, null, "SUPPERADMIN", "SUPPERADMIN" },
                    { 2, "b65868d4-7b5d-490d-90ff-c330372b15ea", null, null, "ADMIN", "ADMIN" },
                    { 3, "c3a389eb-a73b-4ae7-8911-93dc43d3c0d8", null, null, "USER", "USER" },
                    { 4, "8774ae1f-a111-4084-bcd3-f35e9141bca7", null, null, "SINGER", "SINGER" },
                    { 5, "78205cae-5983-400c-bed1-83cb6f6a525d", null, null, "AUTHOR", "AUTHOR" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Address", "ConcurrencyStamp", "CreatedBy", "Dob", "Email", "EmailConfirmed", "FirstName", "LastModifiedBy", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "SYSTEM", null, "96d5b8fe-f0d4-4de4-9a01-f6718abc2ce9", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "supperadmin@gmail.com", true, "Supper Admin", null, "BigBluebirds", false, null, "SUPPERADMIN@GMAIL.COM", "SUPPERADMIN", "AQAAAAEAACcQAAAAECIHs+uB/+uZ0TdH9zeOhG9X35DyhQ0Lx8zh2B7hpZonJn+BrWD1CszAr8nB6SwZvQ==", null, false, "", false, "supperadmin" },
                    { 2, 0, "SYSTEM", null, "0a1b04fd-7a01-468a-9533-5f561baf6030", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Admin", null, "BigBluebirds", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHOFITZ9hPM0asTGnDfsdBdvuT3cDYCPPlZdm0CRdUnJdkdDULNXfhO95UfZji+Sfw==", null, false, "", false, "admin" },
                    { 3, 0, "SYSTEM", null, "fddca26f-8e97-4403-a514-00d3f11290d8", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "User", null, "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAEBogEGmEVb8OsnSKnIjjzpf7nV7yCtKZgXEismtRMm9o3X+e/8/guSzMl5kSAoIS3Q==", null, false, "", false, "user" },
                    { 4, 0, "SYSTEM", null, "a3aca41a-f43e-4f4c-a504-0e8d0a917433", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "singer@gmail.com", true, "Singer", null, "Singer", false, null, "SINGER@GMAIL.COM", "SINGER", "AQAAAAEAACcQAAAAEC6bHrb+gPlMPjCZBtG6OWURNkWdhL4/zwbLtGn3dNZ3CKQtYuMKhYmFajdeEw4LIA==", null, false, "", false, "singer" },
                    { 5, 0, "SYSTEM", null, "8d96d15a-e2c0-4638-a1b9-df67e6d7c2f7", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "author@gmail.com", true, "Author", null, "Author", false, null, "AUTHOR@GMAIL.COM", "AUTHOR", "AQAAAAEAACcQAAAAENyN0TiYdkwo0X0oN8X5pOE3VRqsmOApbP2sKdgdIHtmlUuHp7FvM0bM9VBkM0TInw==", null, false, "", false, "author" }
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
                name: "IX_Followers_ObserverId",
                table: "Followers",
                column: "ObserverId");

            migrationBuilder.CreateIndex(
                name: "IX_Followers_PublicserId",
                table: "Followers",
                column: "PublicserId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Composers_ComposerId",
                table: "Song_Composers",
                column: "ComposerId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Owners_OwnerId",
                table: "Song_Owners",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_PlayLists_PlayListId",
                table: "Song_PlayLists",
                column: "PlayListId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Singers_SingerId",
                table: "Song_Singers",
                column: "SingerId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Tags_TagId",
                table: "Song_Tags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Types_TypeId",
                table: "Song_Types",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cmt_Playlist_PlaylistId",
                table: "User_Cmt_Playlist",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cmt_Playlist_UserId",
                table: "User_Cmt_Playlist",
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
                name: "IX_User_Like_Playlist_PlaylistId",
                table: "User_Like_Playlist",
                column: "PlaylistId");

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
                name: "Followers");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Song_Composers");

            migrationBuilder.DropTable(
                name: "Song_Owners");

            migrationBuilder.DropTable(
                name: "Song_PlayLists");

            migrationBuilder.DropTable(
                name: "Song_Singers");

            migrationBuilder.DropTable(
                name: "Song_Tags");

            migrationBuilder.DropTable(
                name: "Song_Types");

            migrationBuilder.DropTable(
                name: "User_Cmt_Playlist");

            migrationBuilder.DropTable(
                name: "User_Cmt_Song");

            migrationBuilder.DropTable(
                name: "User_Like_Playlist");

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
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
