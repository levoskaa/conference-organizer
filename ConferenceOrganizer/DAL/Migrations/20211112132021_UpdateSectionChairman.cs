using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UpdateSectionChairman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Users_UserId",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Sections",
                newName: "ChairmanId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_UserId",
                table: "Sections",
                newName: "IX_Sections_ChairmanId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3c17c47a-c4f9-4df5-9658-364a5682754c");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Presenter",
                value: "ErőssLevente");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Presenter",
                value: "HerczegLevente");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Presenter",
                value: "NémethBernadett");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Presenter",
                value: "FehérBernadett");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Presenter",
                value: "KovácsSára");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Presenter",
                value: "FehérLevente");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Presenter",
                value: "KovácsBernadett");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Presenter",
                value: "FehérLevente");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Presenter",
                value: "NémethSára");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Presenter",
                value: "ErőssLevente");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 11,
                column: "Presenter",
                value: "KovácsSára");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 12,
                column: "Presenter",
                value: "KissMáté");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 13,
                column: "Presenter",
                value: "ErőssAnna");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d79bba5-18e6-4748-978b-86d33c1898e7", "AQAAAAEAACcQAAAAEJWqJLVszbistyJ52Eda1acBsqQlf4eXq3ZOy5MFKTKuGM+ih1Sun3aEQqBYjyHwdw==", "3b13b5d0-d756-4c2a-b969-4620b258e5c4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac78a329-105e-428e-b1d6-4a23cd5d0fe6", "AQAAAAEAACcQAAAAENfnSsTN6IY/dpHqEw65RKbw1FpOCMNqPmuxQhsEENJhc0ewNipAx7B7CQ5ewUCGNQ==", "fc7b456c-2f2c-4909-b980-d37ad593ef3f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c9d485f-f6c4-4394-83e3-e6d5991f564e", "AQAAAAEAACcQAAAAEHdw/6ypcseL0+I1mjxEGY9aTQ3inAv23OgYAr8xG8X/0zhII9Kjy8iec+OqYw5iTQ==", "2ef67851-ae4a-4916-b76c-f95d34b08028" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85aa145b-8b0f-4635-baf6-dd71411650ac", "AQAAAAEAACcQAAAAEMw7NxQiPfMqnHytLupXP8O1BMJ+6vj9T9gsq+Qs0bhGx+rLjG8qECwcLhPPIS9pEw==", "5f3b58eb-c386-4597-b102-46561d45e0c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87d6592d-7995-4592-ac03-e752fd8cbc55", "AQAAAAEAACcQAAAAELBAYbBmiqZFF7zAQqPf8Q3YGLhB6mfdOQ1fXCLanyeMLQPJohYaBclSbcMZSkSTKg==", "7db0a03b-324e-4cba-bd76-f842fe204679" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb0461c8-befd-496c-ab1e-f298d85e9851", "AQAAAAEAACcQAAAAEELrAIs6HyEm75Vt1mZpA4EoTXcM1mXILgo1wyz66K0NqGiidWpWIYP+b/i9Jap27Q==", "6525a1be-cd1c-4b78-acef-6e91be3f8ab5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ab85a74-cc11-4982-8c5f-3c939bc40168", "AQAAAAEAACcQAAAAEELmCg+abXF+JIzjXU+f3lVLTtGkNCb2weyutIK+Sj21RhZ36NU7S2I/x0FYWZauHQ==", "ce9af71a-8040-4439-b44e-1b627cc4ce70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e26cda02-4c88-491a-831b-39f089a5337c", "AQAAAAEAACcQAAAAEP1YR4fHfkNOQiykz+ZBRtJhduxhSjQ91rgY24V6dH6XlQgGdDmuimL+Bs2msmonMQ==", "6a88ac40-5703-451a-9f8e-fedf88b0fe4c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26d940dd-fdb8-4def-9c9a-c0e60a8b060d", "AQAAAAEAACcQAAAAEC6zpfz7UT+1hI4iU1h3Y5s8qsg+VVf/iB9zAm91iX/msiHG98b4VszFNWn9c7Enew==", "09b9bade-5aa6-4bf0-827f-98aa636c5ead" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9685bbf4-7ba1-4932-a402-3365e2d9c913", "AQAAAAEAACcQAAAAEHn5lX3spJzCelqI9s06kJzFmxT+IffkcNzsPN/NqK86O1xjlT7yAlsZsRtgs/AWBw==", "724eadc8-8a98-40ad-9688-3b2505f9f2f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5a4afc9-e2f2-41b4-8c32-6fca77aa0956", "AQAAAAEAACcQAAAAEHg3NkbAdxP8PN6Np9KyXZ2ZXKHXhsZeY2PyhfPUkp9xpEUuruWxA5GNpepp+krEXA==", "352d012a-5a3c-47bf-810b-5f62cc125b5d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aad9b611-604e-4b23-89c5-afd17d832b4d", "AQAAAAEAACcQAAAAEKPON4PS0iTsEXh915PqUt/wQERmNocZio72Jwn6ZmANj2uvBnm6n2hLNlLdnnKNRw==", "bba43937-2662-44e3-b020-29309f78514a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d9331a-0cf8-402f-a83d-f332a8c6c8f4", "AQAAAAEAACcQAAAAEPdKCfzdcCukt1YL7Hp0wVaWXL9GW/nLUlah6yeqTY7slyzYUQRmGnVnBYKYDpOPZQ==", "494a28c6-174d-498d-b070-fbe36aaf3a8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d4e7479-0100-42d7-b5e8-0f97f46a2fcd", "AQAAAAEAACcQAAAAEINdJwttCKTRbxc/cyphOuTl21h9M3xC0VTzF0JIqChGWhk1/OOqwLxmiGRkI+Oxdw==", "1ae4b3a3-3c45-4e6d-94b1-ea26ab4d0527" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efc68686-343a-4fc4-8b8d-e949dc9ebaaa", "AQAAAAEAACcQAAAAEF5h0Y/CWkNx1KFEoshRwZrXeT48AlPr1qEJhGsB61V/Q1SZ0SdhWcWbp/dL0juzlA==", "ce285c45-4fad-451e-b245-848270edc867" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a256c94-4900-4a4d-bfdc-7d41d88f0e3d", "AQAAAAEAACcQAAAAEJzlWI8n18LAxUWiYOyiWA8YTTjqhUVZyD5mR80zDkBy0HvXSkl2jvg9vNLzZfFnog==", "3f9c9f4c-aa41-4149-a990-e5be6b369f3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d64d5f-d8a7-45a4-bda6-561a22b8027a", "AQAAAAEAACcQAAAAEBbVZohgqPmun+vgaBBK2biTR8j4AjtjfnuYDDjI72auaAf2i++R3rNJ9KbHxm1TxQ==", "d44587ad-6001-4061-8714-e37bcf29b032" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a379216-ba03-45fb-9d27-964736e75a58", "AQAAAAEAACcQAAAAENGvgVxNFFBD8WpmpMsvKIJ/xwVz73M+j3wIUsdEg7LObzDdCgSeWbd8mTT6u15yug==", "5d459fcf-fbcc-4297-ad4d-ea1bd8335f5d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48a3235c-0145-4817-b431-4aa11e296169", "AQAAAAEAACcQAAAAEEHwl8kytJl9Jrl3JGOC5udqZGWcVDcYW2qrCh7su+AD/BD8Ggu4BUYpL3ynGuRykw==", "3b7e7591-4d96-43af-b262-9756d7a02df3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7b65fba-106f-4d6c-a008-34a55853f6c2", "AQAAAAEAACcQAAAAEE9t2gA5GrqvKYgH5aAaO8SghJALySAQah3CZ9hnE4bAJ/Bcv2UBhfDGxk903BHvUg==", "72635844-422d-46a6-99fa-4fc3d7d79c30" });

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Users_ChairmanId",
                table: "Sections",
                column: "ChairmanId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Users_ChairmanId",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "ChairmanId",
                table: "Sections",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_ChairmanId",
                table: "Sections",
                newName: "IX_Sections_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4ddbbd1a-7b0c-4198-8425-1db1f7a32824");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Presenter",
                value: "HerczegMáté");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Presenter",
                value: "KissSára");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Presenter",
                value: "FehérMáté");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Presenter",
                value: "KovácsBernadett");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Presenter",
                value: "KissGéza");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Presenter",
                value: "FehérBernadett");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Presenter",
                value: "HerczegMáté");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Presenter",
                value: "NémethSára");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Presenter",
                value: "ErőssSára");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Presenter",
                value: "NémethMáté");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 11,
                column: "Presenter",
                value: "FehérAnna");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 12,
                column: "Presenter",
                value: "KovácsLevente");

            migrationBuilder.UpdateData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 13,
                column: "Presenter",
                value: "KovácsSára");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2cff473-9a9c-4efe-9a65-db0d9dfd02ff", "AQAAAAEAACcQAAAAEHKDSXxxP0vXF2JKmY2YXCQBN17k9IInOfb6MeN2mbopu9quy0DeBaArunpmiOZcDw==", "953acac8-43d9-4cb4-8b33-0ef89426dfa4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1148cfe5-31a5-46f2-a1c3-5279216e16c9", "AQAAAAEAACcQAAAAEP3bZI9MDV3Gmxk3uk7JmfQSbUJWMY1BdiAAu1IllaOSCNLraeYxr2NFICsflLMcPQ==", "6ffc068f-487a-4ab1-a7e8-a49eaaf7c4f3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81f1bbd0-d3b8-447b-8077-ed2640806f4b", "AQAAAAEAACcQAAAAEEg0MtjkyrJtwEYktkKc7zZ8y5AAPZA2nrZzrGcYvgdQ9MmKMUPIu+9hsiWSAghQzw==", "88ccd836-5711-421c-b7e3-bc67ea52d390" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1dcb582-a7d7-4bbb-8434-f12119f32c63", "AQAAAAEAACcQAAAAEOI/FkFOWakwYLx5mcG2AJqMT7TTeeNozIDWDoX5+UmsGkgBAEdabo8oyVuxhPoC0A==", "f72f7e22-5006-4182-b9df-e5fcca6e6de3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94969a43-f21f-4221-8bb0-9d9c9489af50", "AQAAAAEAACcQAAAAEN0tPx+8AM2YaZx5sxyN/MXV0yLo6DZbRlGxn9Bj9C8lzJGqepjq3vL8OkhMaWttbg==", "04d4c17c-7ec9-4fb9-a7cb-170600a1ce30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2f4e186-39bb-488a-b2ce-f77c2f47ca40", "AQAAAAEAACcQAAAAEC3jrpg8W58An4qRUVMJRhzMFDfrLHF3eyHipEQ5udbpfljHmtiKBq9VAXuOfTMetw==", "d7d53f30-3004-428b-9ee5-da9cf22beaa2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a96f0c5-fae6-4409-b0e6-e1188f44af5f", "AQAAAAEAACcQAAAAEGUe+II9ZNImeydHog60s4OXOkoLCAU39eB7ZjDKsjbq1kyBQPk3fw08Cv1nFE8drQ==", "edeb099d-af26-4ede-841e-7e2b92178e98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd2b0810-f010-4bf1-ae90-a582650c552d", "AQAAAAEAACcQAAAAEGcdTEKiFBv+OWyvVBqaTXXpPIz33JM0bnkodJx0YGl2dv0NgJoz+gveMVz3uQ8rYw==", "15b1eb02-a491-4ebb-bbb4-1ee2ac77ba8a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f949dea0-b6e4-4ab1-9e94-2a9e1c852b11", "AQAAAAEAACcQAAAAEBZelmkmXDnA5ZTsYiaEIslXe7spp3WDFJp4QymcLzd5uJ0VefapZOdXZl4hL/CuJA==", "6ad24e12-842d-41df-9e81-1e8d90baba20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a30cd718-4382-49b7-a12a-fef5d92796ac", "AQAAAAEAACcQAAAAEJ5Tw+KoBd7aGWyOGKDHc8u8hrgHGs/KUyQLZ+O6a8w+8LU15tcICYoRKcDvgsD3pA==", "fcbb913d-f328-4784-8830-9c5e5bb38b05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fff36774-3b30-4e4b-94a8-94e356959220", "AQAAAAEAACcQAAAAEE94O+obHxKyBCusEYSOZzQLvE0LIfbpXtzbUJ8bBfgcFrJgH0a/ABIvMMnReeiNrg==", "a70bf153-b9ab-4efb-a111-31e2cb81ed39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7f353b1-60d6-41e0-a4b7-404d6ff04cd1", "AQAAAAEAACcQAAAAEMaXEfrCYPXVQ0jKokhfNPbdE/UyPzABeKbDnNGR0aOaWwP/wICseo/RyKnBP3uQLQ==", "61795743-8a46-49cc-b5f2-4ae972812e32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f04d9410-9fbd-45c4-aa48-45a69f20b0b8", "AQAAAAEAACcQAAAAELQ4sMQ6u/0ZPkTNkYpcSxO+27H14kBiBNWB9nOAnNxu9YPK39/fZ/7Mf02hx5OLIA==", "6fb4cb70-950f-476d-b035-f12b2894f535" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea2eccc5-7251-4e58-9ec5-d3f1ed97670c", "AQAAAAEAACcQAAAAEKaEFpj5MRDgLy/C63rBYADqmzJEssyZvyZMZN9bN2Q0cGjWTG8htkw41KJVK60/AQ==", "b3aae4c0-22ac-4577-8861-62e14281b9dd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23466021-e016-4688-80c1-a40bea2b806c", "AQAAAAEAACcQAAAAEINCd8MZcknpJVqTe2WP9zAAXSnZVZlSWuNH4EbEO5vHZIs+CZD0hXdwOVTBwCmFFg==", "15bfb0c3-06cc-4f4d-92a1-7615698e3463" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ac68869-1203-4f21-924e-cb997f5e8563", "AQAAAAEAACcQAAAAEKN2+d+9SGy0NEvOuQiU0NOgCJBjfSPy5IJjhGzLiiX6UqMRhLqxKj19tgFIS6pPOA==", "957be00d-146f-4585-b008-e06580bd09e2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf9c347-67f9-46cf-91b0-b2866eac504e", "AQAAAAEAACcQAAAAEAvW04g5VmdFDfkWmIS1UKqx3tSxmsLu7xP3yo/ZFqNp2tFOqBCm3qFblqAPiEJE8A==", "e575ba67-030f-43c2-8c6a-3cd160df756e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee25d22c-8cba-4aa7-98a6-f86f412143e0", "AQAAAAEAACcQAAAAEF8e6QmrA9YfDeJ1QrNSl3q1zFb1rN9+AdUBBZEpQ46nO52OPC3XAfZVmxrC0Mds4g==", "fda7b75b-ca77-4039-aa0a-0382be59e7ab" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b196f287-c0d8-447e-989c-4b1480fd78f4", "AQAAAAEAACcQAAAAEMG2JsKUcc1GBiKZZfKHDa2xYDIGerA1tgF1+cs1p2brRyUkCg212NuKutezWzEvWw==", "9946c9ca-31b2-43c7-b07f-fc7da1da76a6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f2a340-e1e4-420b-b23f-666754dd3e42", "AQAAAAEAACcQAAAAEJtl3PYQ+oK+nLi8BB6NYCwJGCaCvQOIcxzvr4TIGq36ENk/M2NQCtGBJBEBrh+gNw==", "3c83f0c3-7b9c-46e7-b09c-33126ed5a849" });

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Users_UserId",
                table: "Sections",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
