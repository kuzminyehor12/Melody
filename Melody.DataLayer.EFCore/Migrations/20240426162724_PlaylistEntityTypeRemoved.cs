using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Melody.DataLayer.EFCore.Migrations
{
    public partial class PlaylistEntityTypeRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("016b5a4b-a67c-472d-b36b-73c4c62491e3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("07e5bc0e-5c01-4ab5-9b2b-c13e74e37e18"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0b6d6e4d-ca7b-429e-ab44-a12a5c550f2e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0ffbf458-aa0c-463a-ab0f-32ad6c322bb0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1436a40d-dec8-40db-b665-cb6c40913669"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("14ebc21f-6fb3-474c-b7c1-87e382cd4bd5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("159f5867-d19d-4751-8b73-f12834f93b35"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2206a270-43cd-405a-b609-03f49d95bfb9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2733b259-36ff-48b8-923e-8633f819b1ca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("278f78d9-f6bd-43b1-9002-a0013f6799c2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2e82dc74-b175-4c26-a70d-f210657dfd4b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3081a092-0c06-45c6-aa37-9f1b8852e2cc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("381c9d20-f79c-435a-b335-a029d863a3bf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3b0fd9fd-1281-49a0-85f7-2fc93dba0e5c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3fbedb1f-ed0d-481e-81dc-ca72f2da198b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("419b8b6d-c5d7-4559-87c3-2ed4090e25b9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("47a9c936-02d7-40b8-8948-5c0d9c9d4f26"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4a2b69a5-e7a6-4911-b38f-dd56a862fe36"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4eb5ce91-8187-4b18-95ca-b143037a2a65"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5052cfcc-a75c-46d0-919b-54e10822eddb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5159f4db-0ad4-4e43-891b-f28eebc3616b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("55392c28-7592-46c4-898c-f1eb684a08f7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5b145c00-bbf5-4eb0-9cb9-6acfabdf4937"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5c7208e6-a5ef-48a5-b9e5-b8f5c6d5d249"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("63faac96-9553-4ab7-acbc-f9708915d26e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("64c7e7e4-b865-421f-a3bc-2799c25bfe6f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("67c8dd56-e048-47f0-8b01-d4630cdb34d4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6ce4f27b-4693-49b1-b1bb-91f559800f55"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("721352b8-63fd-4cfe-b912-cc02c1c54b58"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("72bf9336-a014-4503-a8bf-0a46b09c2832"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("73150765-b68b-4b7c-b283-3b1c5dd2ead3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8b8c5a1b-f644-423d-8718-9b3a6cb09ee8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8cf9ec17-96fc-4aa6-8079-68cde50cc90b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8eeee62b-d76e-424d-8820-09782d638825"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("901843b5-f362-41e3-befc-759e68b39f57"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9136e492-620e-4137-b962-24ed684693cd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9380b40b-ed38-4e4d-ab91-28e1ddc6d5e0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9950d4c8-28ab-49f1-9eb5-55996ca992f6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("996683fd-2b43-47af-80a7-f4b68d97009a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9ce9c252-ff3c-4760-a8de-ae3f88598429"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9cfc51db-51db-428b-ada2-86ce16477069"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a75a6f5d-b2a0-4cbc-beea-c5794c320c25"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a8226a35-aaca-4443-bd40-e82e06a86084"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a8996433-3ae2-470a-84cb-8edf191a1686"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("aa56f411-c5ab-4490-8757-9bb719907e64"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("aaf3cec6-4274-4cb5-9415-6f64ba91ca56"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("aeb8e094-945e-46db-9181-636b35c85c8e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b1cfb7fa-7ae4-44ba-ab7a-cddf29970bd8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b27b25be-9a5d-48c8-abf6-ea20d18fef7b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b347b9c3-4751-44b4-a1d9-6e5eedc3a39e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b423e9fa-9a40-4eb1-bfad-f0de8a1cfd47"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b4487d46-8f1e-4047-975a-a347c0e6ed76"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b589084b-dafb-471e-82e6-5508a02e73ed"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b7c16569-3a0e-4e1c-a395-b649e91e4727"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b88e94ee-cd14-478a-bb42-8ebae7fefda0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1e659da-bc6c-416c-a65f-bd18a4b9527c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c4f131f3-ad80-40a8-82ac-2da18fa82a46"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c5d795ff-11da-4c0e-b7c6-fe6314abfdaa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c6877381-3634-41fb-923f-9e7ae8a997c6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ca3ec2df-c8aa-46f0-af7e-801f8f83c5c4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cb1a6360-a84e-46b0-9250-840223296733"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cc92a862-d6a8-4b4b-832c-a3c905d01864"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cce623ba-2d05-42f9-890a-f268e7d76d44"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cdcf534a-57db-426e-b041-d09aca90b5ac"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cf393e36-c61a-45e3-b8e7-30f519e384db"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cf7edf14-1a2a-4638-9c57-f2edcf073c44"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d0e0f8e7-c4ef-4c8d-9c8d-a3199751eb7e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d8a0b4af-30be-4763-b4db-bf616824baf9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dc87d280-3a99-47ba-a370-fa8d6459993e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e4f38c15-4481-4ffd-9adf-a30da0a60748"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eaf5bd1b-cb38-489a-b4af-64dd351f102c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f44b43f6-0d3b-401d-a44a-978025894f87"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f86163dd-adeb-4eae-969d-d3f5f17473c1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fdc2796e-ebf1-4c7b-90d0-1852a9ad52cc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fe74fe56-b342-4fad-bcc3-002d79b19e4a"));

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Playlists");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Coversheet", "DisplayName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0248a2f9-c0d6-41d0-becc-27314fd84225"), null, "Rock", false },
                    { new Guid("062f2830-391f-400f-be59-8fa17d3272b2"), null, "Synthwave", false },
                    { new Guid("0684c575-bba7-4eb6-bb41-e6081b469ec5"), null, "Electropop", false },
                    { new Guid("0d0f120d-27b5-4285-a20a-9bb454c20a56"), null, "Bossa Nova", false },
                    { new Guid("1097a6ab-a73e-400d-97bb-4320a7348424"), null, "Shoegaze", false },
                    { new Guid("11cbb0e4-895c-4458-8be5-6f91b08a196a"), null, "Electronic", false },
                    { new Guid("1f130467-da59-4159-a1eb-8ced7958da9e"), null, "Nu Jazz", false },
                    { new Guid("26c90a4c-4643-4b05-92b7-7dcf03761a32"), null, "Alternative", false },
                    { new Guid("299e4e41-c3d3-4926-89e0-25e9ac670d4f"), null, "Eurobeat", false },
                    { new Guid("2ae69212-e295-4beb-a609-65bde72d9a87"), null, "Alternative Metal", false },
                    { new Guid("2b909260-1ebc-4840-8ed1-c4afcbfcbc47"), null, "New Wave", false },
                    { new Guid("32f76aae-d08f-4688-b0ec-c9dd2ee3073c"), null, "Swing", false },
                    { new Guid("3d985cbf-d1ad-400f-89b1-6685d261edbd"), null, "Bluegrass", false },
                    { new Guid("3e89398c-afbf-4ebe-8a94-8b11ae32626c"), null, "Country", false },
                    { new Guid("42d300a5-6f8d-42cb-82ba-c972b313115a"), null, "Ambient House", false },
                    { new Guid("499a2fe2-e735-4718-943c-42966ed42ecc"), null, "Indie", false },
                    { new Guid("49ce2b1d-4326-457f-aa1d-e35a694501c5"), null, "Blues", false },
                    { new Guid("4c9367dd-56da-4a3b-aae3-5888adb4e623"), null, "Reggaeton", false },
                    { new Guid("4dc00c84-bacd-4219-aa8f-70a1a1def2e7"), null, "Rap", false },
                    { new Guid("4e18940f-b2c7-45cf-843a-6b275f97ea39"), null, "R&B(Rhythm and Blues)", false },
                    { new Guid("4f480b0e-bf80-403c-ae4e-dbf9c960af52"), null, "Metal", false },
                    { new Guid("4f889cd4-a44b-4403-ba00-3de39bdb6040"), null, "Trance", false },
                    { new Guid("4fb14079-2c68-4362-b197-79c233dd8f77"), null, "Glam Rock", false },
                    { new Guid("503ab304-a725-4e0a-bb3e-b94651bc0c32"), null, "Hip-hop", false },
                    { new Guid("5863ff0c-056a-4819-a558-8a906473c1ea"), null, "Grunge", false },
                    { new Guid("595b5dc0-f2f8-40d6-ae6b-ccb7510f5d60"), null, "Ska", false },
                    { new Guid("5bc36b03-41ff-4209-bdfb-7b05a350fa61"), null, "Bebop", false },
                    { new Guid("5c8226d9-1f22-4bee-90ee-3df1a6b934e9"), null, "Pop", false },
                    { new Guid("5d3bead7-8adc-4a26-900b-688109449a39"), null, "Progressive Rock", false },
                    { new Guid("5db5350b-123a-4295-9a3d-f0b09978d9f6"), null, "Soul", false },
                    { new Guid("5e1d1f4c-1bd6-4a59-9794-5159fd2cef5b"), null, "Post-punk", false },
                    { new Guid("6089fb70-5812-4d0f-b580-3dd267f07639"), null, "World Music", false },
                    { new Guid("618d4584-622f-40ff-a4d7-9dca069d3d90"), null, "Smooth Jazz", false },
                    { new Guid("65421d41-748b-400b-9fbe-2dce9ed90fdb"), null, "Future Bass", false },
                    { new Guid("69529f5e-d678-4e9c-b807-0ca01b95cf06"), null, "Ambient", false },
                    { new Guid("7504627f-f3f9-4cb1-a64e-ae17fd9abc47"), null, "Gospel", false },
                    { new Guid("7bb3169d-cb0f-4f5a-8911-0e99f58cbb22"), null, "Experimental", false },
                    { new Guid("7ec970f1-3af3-4849-b21d-bb121d918736"), null, "Grime", false },
                    { new Guid("7f3d1073-5e4b-4168-a18c-7c6554494f67"), null, "Post-hardcore", false },
                    { new Guid("7f5c3b7e-7ce4-4a90-a54c-7fc69c4dd966"), null, "IDM(Intelligent Dance Music)", false },
                    { new Guid("804632c7-fd5e-4439-8814-4ef28e8f3279"), null, "Techno", false },
                    { new Guid("8048fae4-6185-4adb-ae4c-0b487429a773"), null, "Synthpop", false },
                    { new Guid("80a0f8bf-41c0-4dff-8d08-6f37ffe3d1f2"), null, "Funk Rock", false },
                    { new Guid("815e417f-1cfb-4801-a82c-f85edc357cb9"), null, "Orchestral", false },
                    { new Guid("8ef9a2da-e4c0-4d2e-94b4-fef9e15d6f74"), null, "Punk", false },
                    { new Guid("8f5defd0-4704-47b6-a977-890fae5f5726"), null, "Fusion", false },
                    { new Guid("949062ef-f6a5-4c53-8e84-2154a866ef19"), null, "Dub", false },
                    { new Guid("95dbd49d-9688-41d7-8f50-1a14266a0490"), null, "Downtempo", false },
                    { new Guid("977023e0-76c3-4545-9987-5e2cad3129d6"), null, "Samba", false },
                    { new Guid("97cb58a5-b045-43a5-8240-50c007ae26bc"), null, "Funk", false },
                    { new Guid("9cd0d485-231b-4e23-8f6f-7078480f7215"), null, "Trip-hop", false },
                    { new Guid("9ee92828-edc8-4734-a5bc-dc4b0d11d000"), null, "Flamenco", false },
                    { new Guid("a613f4a4-ae2d-4b88-9dae-3b57e1650545"), null, "Drill", false },
                    { new Guid("a7686963-1f4d-40ca-ae12-1711e8ab794b"), null, "Choral", false },
                    { new Guid("a8cce862-7713-4bfa-baa0-d76afb61c704"), null, "Garage Rock", false },
                    { new Guid("a90e5bbc-e35c-4d61-b558-5b1b740ce179"), null, "Soft Rock", false },
                    { new Guid("abc55085-c2e3-46bb-bb5a-cb3bfe2e2b20"), null, "Hard Rock", false },
                    { new Guid("bccd93e7-2a2b-4c83-ab36-37ddd093d5b0"), null, "Folk", false },
                    { new Guid("bf0fbe27-f8f9-4cef-b84a-e9756f63338b"), null, "Classical", false },
                    { new Guid("c090a9b4-1787-4ff2-8e0e-7144a26e5501"), null, "Dance", false },
                    { new Guid("c5a86ff7-bfea-43e1-84dd-5bb425b516c4"), null, "Reggae", false },
                    { new Guid("ce996dd5-ebac-4720-ab99-545fd6102259"), null, "Big Band", false },
                    { new Guid("d9e8fa31-bdfe-447c-9d9e-cfd8073a39c6"), null, "Afrobeat", false },
                    { new Guid("da02ca4c-eb25-42e7-9269-bc8087a4a736"), null, "Post-rock", false },
                    { new Guid("db23252a-7bfe-44bf-b15e-e9945595a26b"), null, "Latin", false },
                    { new Guid("dc6e4370-597f-4bb8-8c81-c190855955c8"), null, "Phonk", false },
                    { new Guid("dcc0eaa9-9ec9-42d0-b06a-3fdf7ee2ed09"), null, "Jazz", false },
                    { new Guid("dda06cbc-835d-48cc-9d20-95d4b8cba627"), null, "Celtic", false },
                    { new Guid("e2e34612-90e2-4df7-a2f7-6bc740d11722"), null, "Trap", false },
                    { new Guid("ecdc1f83-3b95-44ed-921e-5f3847043f4c"), null, "House", false },
                    { new Guid("ef3fc19c-b6c9-45dc-a273-4462d8bbcbb9"), null, "Disco", false },
                    { new Guid("f4594998-5d2a-4baf-92e0-0d431990fe10"), null, "Psychedelic Rock", false },
                    { new Guid("f52fd39a-0a41-44b5-b20e-a75011eb543e"), null, "Salsa", false },
                    { new Guid("f5c87805-3851-4ce0-b19c-2db33be43fef"), null, "Dubstep", false },
                    { new Guid("fc3050a7-a3b2-41a8-97f5-7789de10000f"), null, "Breakbeat", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0248a2f9-c0d6-41d0-becc-27314fd84225"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("062f2830-391f-400f-be59-8fa17d3272b2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0684c575-bba7-4eb6-bb41-e6081b469ec5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0d0f120d-27b5-4285-a20a-9bb454c20a56"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1097a6ab-a73e-400d-97bb-4320a7348424"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("11cbb0e4-895c-4458-8be5-6f91b08a196a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1f130467-da59-4159-a1eb-8ced7958da9e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("26c90a4c-4643-4b05-92b7-7dcf03761a32"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("299e4e41-c3d3-4926-89e0-25e9ac670d4f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2ae69212-e295-4beb-a609-65bde72d9a87"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2b909260-1ebc-4840-8ed1-c4afcbfcbc47"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("32f76aae-d08f-4688-b0ec-c9dd2ee3073c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3d985cbf-d1ad-400f-89b1-6685d261edbd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3e89398c-afbf-4ebe-8a94-8b11ae32626c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("42d300a5-6f8d-42cb-82ba-c972b313115a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("499a2fe2-e735-4718-943c-42966ed42ecc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("49ce2b1d-4326-457f-aa1d-e35a694501c5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4c9367dd-56da-4a3b-aae3-5888adb4e623"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4dc00c84-bacd-4219-aa8f-70a1a1def2e7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4e18940f-b2c7-45cf-843a-6b275f97ea39"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f480b0e-bf80-403c-ae4e-dbf9c960af52"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f889cd4-a44b-4403-ba00-3de39bdb6040"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4fb14079-2c68-4362-b197-79c233dd8f77"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("503ab304-a725-4e0a-bb3e-b94651bc0c32"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5863ff0c-056a-4819-a558-8a906473c1ea"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("595b5dc0-f2f8-40d6-ae6b-ccb7510f5d60"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5bc36b03-41ff-4209-bdfb-7b05a350fa61"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5c8226d9-1f22-4bee-90ee-3df1a6b934e9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5d3bead7-8adc-4a26-900b-688109449a39"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5db5350b-123a-4295-9a3d-f0b09978d9f6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5e1d1f4c-1bd6-4a59-9794-5159fd2cef5b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6089fb70-5812-4d0f-b580-3dd267f07639"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("618d4584-622f-40ff-a4d7-9dca069d3d90"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("65421d41-748b-400b-9fbe-2dce9ed90fdb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("69529f5e-d678-4e9c-b807-0ca01b95cf06"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7504627f-f3f9-4cb1-a64e-ae17fd9abc47"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7bb3169d-cb0f-4f5a-8911-0e99f58cbb22"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7ec970f1-3af3-4849-b21d-bb121d918736"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7f3d1073-5e4b-4168-a18c-7c6554494f67"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7f5c3b7e-7ce4-4a90-a54c-7fc69c4dd966"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("804632c7-fd5e-4439-8814-4ef28e8f3279"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8048fae4-6185-4adb-ae4c-0b487429a773"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("80a0f8bf-41c0-4dff-8d08-6f37ffe3d1f2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("815e417f-1cfb-4801-a82c-f85edc357cb9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8ef9a2da-e4c0-4d2e-94b4-fef9e15d6f74"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8f5defd0-4704-47b6-a977-890fae5f5726"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("949062ef-f6a5-4c53-8e84-2154a866ef19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("95dbd49d-9688-41d7-8f50-1a14266a0490"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("977023e0-76c3-4545-9987-5e2cad3129d6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("97cb58a5-b045-43a5-8240-50c007ae26bc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9cd0d485-231b-4e23-8f6f-7078480f7215"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9ee92828-edc8-4734-a5bc-dc4b0d11d000"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a613f4a4-ae2d-4b88-9dae-3b57e1650545"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a7686963-1f4d-40ca-ae12-1711e8ab794b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a8cce862-7713-4bfa-baa0-d76afb61c704"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a90e5bbc-e35c-4d61-b558-5b1b740ce179"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("abc55085-c2e3-46bb-bb5a-cb3bfe2e2b20"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bccd93e7-2a2b-4c83-ab36-37ddd093d5b0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bf0fbe27-f8f9-4cef-b84a-e9756f63338b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c090a9b4-1787-4ff2-8e0e-7144a26e5501"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c5a86ff7-bfea-43e1-84dd-5bb425b516c4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ce996dd5-ebac-4720-ab99-545fd6102259"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d9e8fa31-bdfe-447c-9d9e-cfd8073a39c6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("da02ca4c-eb25-42e7-9269-bc8087a4a736"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("db23252a-7bfe-44bf-b15e-e9945595a26b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dc6e4370-597f-4bb8-8c81-c190855955c8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dcc0eaa9-9ec9-42d0-b06a-3fdf7ee2ed09"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dda06cbc-835d-48cc-9d20-95d4b8cba627"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e2e34612-90e2-4df7-a2f7-6bc740d11722"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ecdc1f83-3b95-44ed-921e-5f3847043f4c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ef3fc19c-b6c9-45dc-a273-4462d8bbcbb9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f4594998-5d2a-4baf-92e0-0d431990fe10"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f52fd39a-0a41-44b5-b20e-a75011eb543e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f5c87805-3851-4ce0-b19c-2db33be43fef"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fc3050a7-a3b2-41a8-97f5-7789de10000f"));

            migrationBuilder.AddColumn<short>(
                name: "Type",
                table: "Playlists",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Coversheet", "DisplayName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("016b5a4b-a67c-472d-b36b-73c4c62491e3"), null, "Synthwave", false },
                    { new Guid("07e5bc0e-5c01-4ab5-9b2b-c13e74e37e18"), null, "Ska", false },
                    { new Guid("0b6d6e4d-ca7b-429e-ab44-a12a5c550f2e"), null, "Jazz", false },
                    { new Guid("0ffbf458-aa0c-463a-ab0f-32ad6c322bb0"), null, "Electropop", false },
                    { new Guid("1436a40d-dec8-40db-b665-cb6c40913669"), null, "Drill", false },
                    { new Guid("14ebc21f-6fb3-474c-b7c1-87e382cd4bd5"), null, "Indie", false },
                    { new Guid("159f5867-d19d-4751-8b73-f12834f93b35"), null, "Bebop", false },
                    { new Guid("2206a270-43cd-405a-b609-03f49d95bfb9"), null, "New Wave", false },
                    { new Guid("2733b259-36ff-48b8-923e-8633f819b1ca"), null, "Trap", false },
                    { new Guid("278f78d9-f6bd-43b1-9002-a0013f6799c2"), null, "Future Bass", false },
                    { new Guid("2e82dc74-b175-4c26-a70d-f210657dfd4b"), null, "Alternative", false },
                    { new Guid("3081a092-0c06-45c6-aa37-9f1b8852e2cc"), null, "Trip-hop", false },
                    { new Guid("381c9d20-f79c-435a-b335-a029d863a3bf"), null, "Flamenco", false },
                    { new Guid("3b0fd9fd-1281-49a0-85f7-2fc93dba0e5c"), null, "Hip-hop", false },
                    { new Guid("3fbedb1f-ed0d-481e-81dc-ca72f2da198b"), null, "Swing", false },
                    { new Guid("419b8b6d-c5d7-4559-87c3-2ed4090e25b9"), null, "Reggaeton", false },
                    { new Guid("47a9c936-02d7-40b8-8948-5c0d9c9d4f26"), null, "Bluegrass", false },
                    { new Guid("4a2b69a5-e7a6-4911-b38f-dd56a862fe36"), null, "Choral", false },
                    { new Guid("4eb5ce91-8187-4b18-95ca-b143037a2a65"), null, "Gospel", false },
                    { new Guid("5052cfcc-a75c-46d0-919b-54e10822eddb"), null, "Funk Rock", false },
                    { new Guid("5159f4db-0ad4-4e43-891b-f28eebc3616b"), null, "Trance", false },
                    { new Guid("55392c28-7592-46c4-898c-f1eb684a08f7"), null, "Folk", false },
                    { new Guid("5b145c00-bbf5-4eb0-9cb9-6acfabdf4937"), null, "Alternative Metal", false },
                    { new Guid("5c7208e6-a5ef-48a5-b9e5-b8f5c6d5d249"), null, "Salsa", false },
                    { new Guid("63faac96-9553-4ab7-acbc-f9708915d26e"), null, "Ambient House", false },
                    { new Guid("64c7e7e4-b865-421f-a3bc-2799c25bfe6f"), null, "Nu Jazz", false },
                    { new Guid("67c8dd56-e048-47f0-8b01-d4630cdb34d4"), null, "Synthpop", false },
                    { new Guid("6ce4f27b-4693-49b1-b1bb-91f559800f55"), null, "Punk", false },
                    { new Guid("721352b8-63fd-4cfe-b912-cc02c1c54b58"), null, "Hard Rock", false },
                    { new Guid("72bf9336-a014-4503-a8bf-0a46b09c2832"), null, "Bossa Nova", false },
                    { new Guid("73150765-b68b-4b7c-b283-3b1c5dd2ead3"), null, "Techno", false },
                    { new Guid("8b8c5a1b-f644-423d-8718-9b3a6cb09ee8"), null, "Post-punk", false },
                    { new Guid("8cf9ec17-96fc-4aa6-8079-68cde50cc90b"), null, "Grime", false },
                    { new Guid("8eeee62b-d76e-424d-8820-09782d638825"), null, "Grunge", false },
                    { new Guid("901843b5-f362-41e3-befc-759e68b39f57"), null, "Progressive Rock", false },
                    { new Guid("9136e492-620e-4137-b962-24ed684693cd"), null, "Electronic", false },
                    { new Guid("9380b40b-ed38-4e4d-ab91-28e1ddc6d5e0"), null, "Eurobeat", false },
                    { new Guid("9950d4c8-28ab-49f1-9eb5-55996ca992f6"), null, "Afrobeat", false },
                    { new Guid("996683fd-2b43-47af-80a7-f4b68d97009a"), null, "Downtempo", false },
                    { new Guid("9ce9c252-ff3c-4760-a8de-ae3f88598429"), null, "Post-rock", false },
                    { new Guid("9cfc51db-51db-428b-ada2-86ce16477069"), null, "Reggae", false },
                    { new Guid("a75a6f5d-b2a0-4cbc-beea-c5794c320c25"), null, "Classical", false },
                    { new Guid("a8226a35-aaca-4443-bd40-e82e06a86084"), null, "Fusion", false },
                    { new Guid("a8996433-3ae2-470a-84cb-8edf191a1686"), null, "Samba", false },
                    { new Guid("aa56f411-c5ab-4490-8757-9bb719907e64"), null, "Metal", false },
                    { new Guid("aaf3cec6-4274-4cb5-9415-6f64ba91ca56"), null, "Disco", false },
                    { new Guid("aeb8e094-945e-46db-9181-636b35c85c8e"), null, "Blues", false },
                    { new Guid("b1cfb7fa-7ae4-44ba-ab7a-cddf29970bd8"), null, "World Music", false },
                    { new Guid("b27b25be-9a5d-48c8-abf6-ea20d18fef7b"), null, "Dance", false },
                    { new Guid("b347b9c3-4751-44b4-a1d9-6e5eedc3a39e"), null, "Post-hardcore", false },
                    { new Guid("b423e9fa-9a40-4eb1-bfad-f0de8a1cfd47"), null, "Latin", false },
                    { new Guid("b4487d46-8f1e-4047-975a-a347c0e6ed76"), null, "IDM(Intelligent Dance Music)", false },
                    { new Guid("b589084b-dafb-471e-82e6-5508a02e73ed"), null, "House", false },
                    { new Guid("b7c16569-3a0e-4e1c-a395-b649e91e4727"), null, "Celtic", false },
                    { new Guid("b88e94ee-cd14-478a-bb42-8ebae7fefda0"), null, "Big Band", false },
                    { new Guid("c1e659da-bc6c-416c-a65f-bd18a4b9527c"), null, "Orchestral", false },
                    { new Guid("c4f131f3-ad80-40a8-82ac-2da18fa82a46"), null, "Garage Rock", false },
                    { new Guid("c5d795ff-11da-4c0e-b7c6-fe6314abfdaa"), null, "Shoegaze", false },
                    { new Guid("c6877381-3634-41fb-923f-9e7ae8a997c6"), null, "Soul", false },
                    { new Guid("ca3ec2df-c8aa-46f0-af7e-801f8f83c5c4"), null, "Dubstep", false },
                    { new Guid("cb1a6360-a84e-46b0-9250-840223296733"), null, "Pop", false },
                    { new Guid("cc92a862-d6a8-4b4b-832c-a3c905d01864"), null, "Funk", false },
                    { new Guid("cce623ba-2d05-42f9-890a-f268e7d76d44"), null, "Ambient", false },
                    { new Guid("cdcf534a-57db-426e-b041-d09aca90b5ac"), null, "Soft Rock", false },
                    { new Guid("cf393e36-c61a-45e3-b8e7-30f519e384db"), null, "Psychedelic Rock", false },
                    { new Guid("cf7edf14-1a2a-4638-9c57-f2edcf073c44"), null, "Rock", false },
                    { new Guid("d0e0f8e7-c4ef-4c8d-9c8d-a3199751eb7e"), null, "Rap", false },
                    { new Guid("d8a0b4af-30be-4763-b4db-bf616824baf9"), null, "Glam Rock", false },
                    { new Guid("dc87d280-3a99-47ba-a370-fa8d6459993e"), null, "Smooth Jazz", false },
                    { new Guid("e4f38c15-4481-4ffd-9adf-a30da0a60748"), null, "R&B(Rhythm and Blues)", false },
                    { new Guid("eaf5bd1b-cb38-489a-b4af-64dd351f102c"), null, "Experimental", false },
                    { new Guid("f44b43f6-0d3b-401d-a44a-978025894f87"), null, "Country", false },
                    { new Guid("f86163dd-adeb-4eae-969d-d3f5f17473c1"), null, "Breakbeat", false },
                    { new Guid("fdc2796e-ebf1-4c7b-90d0-1852a9ad52cc"), null, "Dub", false },
                    { new Guid("fe74fe56-b342-4fad-bcc3-002d79b19e4a"), null, "Phonk", false }
                });
        }
    }
}
