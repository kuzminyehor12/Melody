using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Melody.DataLayer.EFCore.Migrations
{
    public partial class GenresSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Coversheet", "DisplayName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0247861c-eb66-4167-886d-daabf549c62f"), null, "Drill", false },
                    { new Guid("02e1574c-9e9e-48d5-8a3d-d9aacb7fcc11"), null, "Ambient", false },
                    { new Guid("03454e6a-2de1-49ce-b1a6-3fef1b9c689d"), null, "Smooth Jazz", false },
                    { new Guid("03725cc6-6e38-4177-b378-6d63300d1cf8"), null, "Post-punk", false },
                    { new Guid("0474bc93-daaf-41b6-90ca-2480eccad521"), null, "Hip-hop", false },
                    { new Guid("064c5939-7357-4d33-8dcb-56f7e59fef67"), null, "Trap", false },
                    { new Guid("0d3d181b-ac05-43e7-bd23-9efe3b2e0ddc"), null, "House", false },
                    { new Guid("11a1fbe3-0efd-4f68-8ccb-1e87930f88c6"), null, "Bossa Nova", false },
                    { new Guid("12614b21-e0be-41e8-937b-fa84ca02b941"), null, "Trip-hop", false },
                    { new Guid("1626b78f-c817-463c-a1f6-e8c189c0b1e8"), null, "Ambient House", false },
                    { new Guid("1a51fae4-bbf5-4b1a-8464-bf0522806f25"), null, "Hard Rock", false },
                    { new Guid("1ce0408f-2063-4a85-bb43-800ca9ae3b8b"), null, "Blues", false },
                    { new Guid("204f0daa-deee-4f58-8b1e-6f5cde8c38b1"), null, "Dub", false },
                    { new Guid("21dbcff0-9302-4b93-88f1-145343c48f4d"), null, "Latin", false },
                    { new Guid("22e636c3-7a30-4f91-b98f-159cd43ed377"), null, "Folk", false },
                    { new Guid("260db6f1-ebca-4db8-843e-484f266a7a1f"), null, "Dubstep", false },
                    { new Guid("27b0d1f8-cc4b-4148-9b35-4a5e11aa33a1"), null, "Reggae", false },
                    { new Guid("28dc3819-7304-4400-9067-13a423b688ee"), null, "Trance", false },
                    { new Guid("292be485-ef15-4359-89a5-16002c3b5e46"), null, "Breakbeat", false },
                    { new Guid("29db448c-b137-4b84-afca-aded28c2b05e"), null, "House", false },
                    { new Guid("2c5a4dcb-0598-422f-90e4-0b56f1119970"), null, "Grime", false },
                    { new Guid("2f6cc1fe-0b68-4832-9786-59eebf05dd59"), null, "Electropop", false },
                    { new Guid("31628369-3460-4ee1-94fe-eac3525a98cb"), null, "Orchestral", false },
                    { new Guid("34e23834-aff6-47e8-9a27-2200eb69fb21"), null, "Synthpop", false },
                    { new Guid("379b7d12-d8b8-4626-858a-30d4cbb29734"), null, "Soul", false },
                    { new Guid("3cd458ad-c89a-4071-a056-61be59102f8b"), null, "Punk", false },
                    { new Guid("3ef801f2-cc55-47dc-b45c-dc4ac92990b9"), null, "Samba", false },
                    { new Guid("42e84f9c-dfbb-481a-8218-b975d5625c16"), null, "Psychedelic Rock", false },
                    { new Guid("53028b6a-a883-4fe0-a09a-ecc40e739a68"), null, "Grunge", false },
                    { new Guid("533397ab-56b6-40db-944b-6469aab1e450"), null, "Salsa", false },
                    { new Guid("53504abd-dc18-419c-a7c1-e6517582d727"), null, "Indie", false },
                    { new Guid("59f3984b-e16f-493c-be92-821d75a48bd3"), null, "Bebop", false },
                    { new Guid("5a2942f9-be8a-4fcf-a8bb-8ed3a72eff82"), null, "Disco", false },
                    { new Guid("5bd8b1d8-a0a8-4474-b797-aff73bf9f4f5"), null, "Downtempo", false },
                    { new Guid("5db12421-d7e4-46ce-99ed-eba428f3e5a2"), null, "Celtic", false },
                    { new Guid("649bbd4b-4270-4aaf-8331-d72301cbad92"), null, "Experimental", false },
                    { new Guid("6c5907e4-2558-4ed4-9d20-57da9bf421bc"), null, "World Music", false },
                    { new Guid("702d6cf6-a53b-44fc-b26e-04d7f6a830c3"), null, "Fusion", false },
                    { new Guid("7306c521-26de-42b1-a4c9-c30355d855fa"), null, "Big Band", false },
                    { new Guid("762e6c38-d446-4add-b37a-0b971bddaf47"), null, "Bluegrass", false },
                    { new Guid("783309ce-6311-4e0b-925f-9ec1893c5b12"), null, "Pop", false },
                    { new Guid("7e8947fe-04bb-47fb-b7bc-7c1c31325cd0"), null, "Alternative", false },
                    { new Guid("8a7c7f94-3986-4ca3-b0b4-fe9b39565fcc"), null, "Post-rock", false },
                    { new Guid("8b0e8b40-eece-478e-becb-7e0df087acd8"), null, "Post-hardcore", false },
                    { new Guid("8b8ee08f-f1e3-4b94-a937-fd17a94bec2e"), null, "Choral", false },
                    { new Guid("8cb890e7-08ec-4218-afab-ffdc7c37207d"), null, "IDM(Intelligent Dance Music)", false },
                    { new Guid("90977a44-ab70-49bf-a3bc-f2820483f0d0"), null, "Shoegaze", false },
                    { new Guid("92b4f5f0-f11a-4561-b845-72be2c7fb78f"), null, "Rap", false },
                    { new Guid("9c6551e5-0f18-4ff3-85c0-0e3055e88d69"), null, "Swing", false },
                    { new Guid("9d386abe-9c55-4cc1-8bb8-ab200be82937"), null, "Alternative Metal", false },
                    { new Guid("9ee621bb-c05f-4f30-971c-34710827065f"), null, "Nu Jazz", false },
                    { new Guid("a3264121-28a1-4c23-b678-339d8791359f"), null, "Soft Rock", false },
                    { new Guid("bd8f5900-a469-44c6-b67e-61de36d5608b"), null, "Future Bass", false },
                    { new Guid("bdb77530-a951-4270-b094-efbc6fbb36a1"), null, "Classical", false },
                    { new Guid("bec0e5fb-5084-40c7-9bce-badffddc5afb"), null, "Garage Rock", false },
                    { new Guid("c7d4ca63-9d2b-4c45-a2c6-4d322c56f99a"), null, "Phonk", false },
                    { new Guid("c85eb736-33ea-45e3-b4ee-825321af452d"), null, "Electronic", false },
                    { new Guid("cd489609-55df-4c68-876b-139633aa83e6"), null, "Ska", false },
                    { new Guid("d2057ac3-cbfa-4e07-99a0-57ee0b127139"), null, "Dance", false },
                    { new Guid("d6ef4670-9197-45b9-b486-4c774cf42cd3"), null, "Afrobeat", false },
                    { new Guid("da1382ff-51b3-4a5b-818d-28d52680753a"), null, "Funk", false },
                    { new Guid("dce8cf1d-eb63-4518-98db-059badd609d3"), null, "Flamenco", false },
                    { new Guid("df27f395-3893-4571-85e1-8faa63d4bbfa"), null, "Techno", false },
                    { new Guid("e728725b-b421-48fd-9005-fce048b372fb"), null, "Jazz", false },
                    { new Guid("e94e4d38-3077-48d8-a476-035683b1cbde"), null, "Eurobeat", false },
                    { new Guid("e988ae59-4a88-479e-aea4-25b0e3adf330"), null, "Glam Rock", false },
                    { new Guid("e99924df-bd33-4efe-99f6-92b2feeedaa4"), null, "Country", false },
                    { new Guid("ea1d1d90-83f2-470c-9936-efeb89e49b54"), null, "Rock", false },
                    { new Guid("eb0d219e-b273-443a-8466-a571139d923a"), null, "Funk Rock", false },
                    { new Guid("ebf1cbf0-43c8-47d1-a007-ec57f15cf644"), null, "R&B(Rhythm and Blues)", false },
                    { new Guid("f0879bf8-93a2-4453-a2f7-e4233e019572"), null, "New Wave", false },
                    { new Guid("f0e6017e-66f1-41f3-997f-3520f56d861c"), null, "Gospel", false },
                    { new Guid("f26109ce-4c5a-4b63-a019-f498c043dae3"), null, "Reggaeton", false },
                    { new Guid("f772e26b-cc33-4381-a5b3-581c5c5b0a33"), null, "Metal", false },
                    { new Guid("f89364a6-3526-475e-adde-aca84a4d204f"), null, "Progressive Rock", false },
                    { new Guid("ff88df15-df30-4a58-81e8-0e0eccb45408"), null, "Synthwave", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0247861c-eb66-4167-886d-daabf549c62f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("02e1574c-9e9e-48d5-8a3d-d9aacb7fcc11"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("03454e6a-2de1-49ce-b1a6-3fef1b9c689d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("03725cc6-6e38-4177-b378-6d63300d1cf8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0474bc93-daaf-41b6-90ca-2480eccad521"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("064c5939-7357-4d33-8dcb-56f7e59fef67"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0d3d181b-ac05-43e7-bd23-9efe3b2e0ddc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("11a1fbe3-0efd-4f68-8ccb-1e87930f88c6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("12614b21-e0be-41e8-937b-fa84ca02b941"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1626b78f-c817-463c-a1f6-e8c189c0b1e8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1a51fae4-bbf5-4b1a-8464-bf0522806f25"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1ce0408f-2063-4a85-bb43-800ca9ae3b8b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("204f0daa-deee-4f58-8b1e-6f5cde8c38b1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("21dbcff0-9302-4b93-88f1-145343c48f4d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("22e636c3-7a30-4f91-b98f-159cd43ed377"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("260db6f1-ebca-4db8-843e-484f266a7a1f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("27b0d1f8-cc4b-4148-9b35-4a5e11aa33a1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("28dc3819-7304-4400-9067-13a423b688ee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("292be485-ef15-4359-89a5-16002c3b5e46"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("29db448c-b137-4b84-afca-aded28c2b05e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2c5a4dcb-0598-422f-90e4-0b56f1119970"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2f6cc1fe-0b68-4832-9786-59eebf05dd59"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("31628369-3460-4ee1-94fe-eac3525a98cb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("34e23834-aff6-47e8-9a27-2200eb69fb21"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("379b7d12-d8b8-4626-858a-30d4cbb29734"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3cd458ad-c89a-4071-a056-61be59102f8b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3ef801f2-cc55-47dc-b45c-dc4ac92990b9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("42e84f9c-dfbb-481a-8218-b975d5625c16"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("53028b6a-a883-4fe0-a09a-ecc40e739a68"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("533397ab-56b6-40db-944b-6469aab1e450"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("53504abd-dc18-419c-a7c1-e6517582d727"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("59f3984b-e16f-493c-be92-821d75a48bd3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5a2942f9-be8a-4fcf-a8bb-8ed3a72eff82"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5bd8b1d8-a0a8-4474-b797-aff73bf9f4f5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5db12421-d7e4-46ce-99ed-eba428f3e5a2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("649bbd4b-4270-4aaf-8331-d72301cbad92"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6c5907e4-2558-4ed4-9d20-57da9bf421bc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("702d6cf6-a53b-44fc-b26e-04d7f6a830c3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7306c521-26de-42b1-a4c9-c30355d855fa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("762e6c38-d446-4add-b37a-0b971bddaf47"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("783309ce-6311-4e0b-925f-9ec1893c5b12"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7e8947fe-04bb-47fb-b7bc-7c1c31325cd0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8a7c7f94-3986-4ca3-b0b4-fe9b39565fcc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8b0e8b40-eece-478e-becb-7e0df087acd8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8b8ee08f-f1e3-4b94-a937-fd17a94bec2e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8cb890e7-08ec-4218-afab-ffdc7c37207d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("90977a44-ab70-49bf-a3bc-f2820483f0d0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("92b4f5f0-f11a-4561-b845-72be2c7fb78f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9c6551e5-0f18-4ff3-85c0-0e3055e88d69"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9d386abe-9c55-4cc1-8bb8-ab200be82937"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9ee621bb-c05f-4f30-971c-34710827065f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a3264121-28a1-4c23-b678-339d8791359f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bd8f5900-a469-44c6-b67e-61de36d5608b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bdb77530-a951-4270-b094-efbc6fbb36a1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bec0e5fb-5084-40c7-9bce-badffddc5afb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c7d4ca63-9d2b-4c45-a2c6-4d322c56f99a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c85eb736-33ea-45e3-b4ee-825321af452d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cd489609-55df-4c68-876b-139633aa83e6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d2057ac3-cbfa-4e07-99a0-57ee0b127139"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d6ef4670-9197-45b9-b486-4c774cf42cd3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("da1382ff-51b3-4a5b-818d-28d52680753a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dce8cf1d-eb63-4518-98db-059badd609d3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("df27f395-3893-4571-85e1-8faa63d4bbfa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e728725b-b421-48fd-9005-fce048b372fb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e94e4d38-3077-48d8-a476-035683b1cbde"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e988ae59-4a88-479e-aea4-25b0e3adf330"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e99924df-bd33-4efe-99f6-92b2feeedaa4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ea1d1d90-83f2-470c-9936-efeb89e49b54"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eb0d219e-b273-443a-8466-a571139d923a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ebf1cbf0-43c8-47d1-a007-ec57f15cf644"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f0879bf8-93a2-4453-a2f7-e4233e019572"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f0e6017e-66f1-41f3-997f-3520f56d861c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f26109ce-4c5a-4b63-a019-f498c043dae3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f772e26b-cc33-4381-a5b3-581c5c5b0a33"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f89364a6-3526-475e-adde-aca84a4d204f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ff88df15-df30-4a58-81e8-0e0eccb45408"));
        }
    }
}
