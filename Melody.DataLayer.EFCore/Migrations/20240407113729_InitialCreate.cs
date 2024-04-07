using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Melody.DataLayer.EFCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    RegisteredAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Verified = table.Column<bool>(type: "boolean", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creators_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AudioBookCollections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioBookCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AudioBookCollections_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true),
                    PublishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    Type = table.Column<short>(type: "smallint", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    AuthorName = table.Column<string>(type: "text", nullable: false),
                    Filename = table.Column<string>(type: "text", nullable: false),
                    DurationInMs = table.Column<long>(type: "bigint", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true),
                    ListeningsCount = table.Column<int>(type: "integer", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Podcasts_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowedAlbums",
                columns: table => new
                {
                    FollowedAlbumsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FollowersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedAlbums", x => new { x.FollowedAlbumsId, x.FollowersId });
                    table.ForeignKey(
                        name: "FK_FollowedAlbums_Albums_FollowedAlbumsId",
                        column: x => x.FollowedAlbumsId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowedAlbums_Users_FollowersId",
                        column: x => x.FollowersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AlbumId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    AuthorName = table.Column<string>(type: "text", nullable: false),
                    Filename = table.Column<string>(type: "text", nullable: false),
                    DurationInMs = table.Column<long>(type: "bigint", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true),
                    ListeningsCount = table.Column<int>(type: "integer", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tracks_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AudioBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AudioBookCollectionId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    AuthorName = table.Column<string>(type: "text", nullable: false),
                    Filename = table.Column<string>(type: "text", nullable: false),
                    DurationInMs = table.Column<long>(type: "bigint", nullable: false),
                    Coversheet = table.Column<string>(type: "text", nullable: true),
                    ListeningsCount = table.Column<int>(type: "integer", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AudioBooks_AudioBookCollections_AudioBookCollectionId",
                        column: x => x.AudioBookCollectionId,
                        principalTable: "AudioBookCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AudioBooks_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowedAudioBookCollections",
                columns: table => new
                {
                    FollowedAudioBookCollectionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FollowersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedAudioBookCollections", x => new { x.FollowedAudioBookCollectionsId, x.FollowersId });
                    table.ForeignKey(
                        name: "FK_FollowedAudioBookCollections_AudioBookCollections_FollowedA~",
                        column: x => x.FollowedAudioBookCollectionsId,
                        principalTable: "AudioBookCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowedAudioBookCollections_Users_FollowersId",
                        column: x => x.FollowersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowedPlaylists",
                columns: table => new
                {
                    FollowedPlaylistsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FollowersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedPlaylists", x => new { x.FollowedPlaylistsId, x.FollowersId });
                    table.ForeignKey(
                        name: "FK_FollowedPlaylists_Playlists_FollowedPlaylistsId",
                        column: x => x.FollowedPlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowedPlaylists_Users_FollowersId",
                        column: x => x.FollowersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaggedPlaylists",
                columns: table => new
                {
                    TaggedPlaylistsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TagsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaggedPlaylists", x => new { x.TaggedPlaylistsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_TaggedPlaylists_Playlists_TaggedPlaylistsId",
                        column: x => x.TaggedPlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaggedPlaylists_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowedPodcasts",
                columns: table => new
                {
                    FollowedPodcastsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FollowersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedPodcasts", x => new { x.FollowedPodcastsId, x.FollowersId });
                    table.ForeignKey(
                        name: "FK_FollowedPodcasts_Podcasts_FollowedPodcastsId",
                        column: x => x.FollowedPodcastsId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowedPodcasts_Users_FollowersId",
                        column: x => x.FollowersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowedTracks",
                columns: table => new
                {
                    FollowedTracksId = table.Column<Guid>(type: "uuid", nullable: false),
                    FollowersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedTracks", x => new { x.FollowedTracksId, x.FollowersId });
                    table.ForeignKey(
                        name: "FK_FollowedTracks_Tracks_FollowedTracksId",
                        column: x => x.FollowedTracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowedTracks_Users_FollowersId",
                        column: x => x.FollowersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenredTracks",
                columns: table => new
                {
                    GenredTracksId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenresId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenredTracks", x => new { x.GenredTracksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_GenredTracks_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenredTracks_Tracks_GenredTracksId",
                        column: x => x.GenredTracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistedTracks",
                columns: table => new
                {
                    PlaylistedTracksId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlaylistsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistedTracks", x => new { x.PlaylistedTracksId, x.PlaylistsId });
                    table.ForeignKey(
                        name: "FK_PlaylistedTracks_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistedTracks_Tracks_PlaylistedTracksId",
                        column: x => x.PlaylistedTracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowedAudioBooks",
                columns: table => new
                {
                    FollowedAudioBooksId = table.Column<Guid>(type: "uuid", nullable: false),
                    FollowersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedAudioBooks", x => new { x.FollowedAudioBooksId, x.FollowersId });
                    table.ForeignKey(
                        name: "FK_FollowedAudioBooks_AudioBooks_FollowedAudioBooksId",
                        column: x => x.FollowedAudioBooksId,
                        principalTable: "AudioBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowedAudioBooks_Users_FollowersId",
                        column: x => x.FollowersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_CreatorId",
                table: "Albums",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioBookCollections_CreatorId",
                table: "AudioBookCollections",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioBooks_AudioBookCollectionId",
                table: "AudioBooks",
                column: "AudioBookCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioBooks_CreatorId",
                table: "AudioBooks",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedAlbums_FollowersId",
                table: "FollowedAlbums",
                column: "FollowersId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedAudioBookCollections_FollowersId",
                table: "FollowedAudioBookCollections",
                column: "FollowersId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedAudioBooks_FollowersId",
                table: "FollowedAudioBooks",
                column: "FollowersId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedPlaylists_FollowersId",
                table: "FollowedPlaylists",
                column: "FollowersId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedPodcasts_FollowersId",
                table: "FollowedPodcasts",
                column: "FollowersId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedTracks_FollowersId",
                table: "FollowedTracks",
                column: "FollowersId");

            migrationBuilder.CreateIndex(
                name: "IX_GenredTracks_GenresId",
                table: "GenredTracks",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistedTracks_PlaylistsId",
                table: "PlaylistedTracks",
                column: "PlaylistsId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_CreatorId",
                table: "Playlists",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Podcasts_CreatorId",
                table: "Podcasts",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaggedPlaylists_TagsId",
                table: "TaggedPlaylists",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_CreatorId",
                table: "Tracks",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowedAlbums");

            migrationBuilder.DropTable(
                name: "FollowedAudioBookCollections");

            migrationBuilder.DropTable(
                name: "FollowedAudioBooks");

            migrationBuilder.DropTable(
                name: "FollowedPlaylists");

            migrationBuilder.DropTable(
                name: "FollowedPodcasts");

            migrationBuilder.DropTable(
                name: "FollowedTracks");

            migrationBuilder.DropTable(
                name: "GenredTracks");

            migrationBuilder.DropTable(
                name: "PlaylistedTracks");

            migrationBuilder.DropTable(
                name: "TaggedPlaylists");

            migrationBuilder.DropTable(
                name: "AudioBooks");

            migrationBuilder.DropTable(
                name: "Podcasts");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AudioBookCollections");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Creators");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
