using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddMoreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4ddbbd1a-7b0c-4198-8425-1db1f7a32824");

            migrationBuilder.InsertData(
                table: "Conferences",
                columns: new[] { "Id", "Name", "BeginDate", "EndDate" },
                values: new object[,]
                {
                    { 1, "Conference 1", new DateTime(2021, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Conference 2", new DateTime(2022, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProfessionalFields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Physics" },
                    { 2, "Medicine" },
                    { 3, "Sociology" },
                    { 4, "Information Technology" },
                    { 5, "Economics" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "UniqueName" },
                values: new object[,]
                {
                    { 1, 100, "A1" },
                    { 10, 75, "B5" },
                    { 3, 80, "A3" },
                    { 4, 60, "A4" },
                    { 5, 75, "A5" },
                    { 6, 30, "B1" },
                    { 7, 130, "B2" },
                    { 8, 50, "B3" },
                    { 9, 100, "B4" },
                    { 2, 150, "A2" }
                });

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

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "ConferenceId", "FieldId", "RoomId", "UserId", "BeginDate", "EndDate" },
                values: new object[,]
                {
                    { 3, 2, 4, 5, 16, new DateTime(2022, 1, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, 3, 3, 2, new DateTime(2021, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 1, 1, 10, new DateTime(2022, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, 5, 1, 7, new DateTime(2022, 1, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, 3, 10, new DateTime(2021, 12, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "UserConference",
                columns: new[] { "ConferenceId", "UserId" },
                values: new object[,]
                {
                    { 2, 9 },
                    { 1, 2 },
                    { 2, 7 },
                    { 2, 6 },
                    { 1, 5 },
                    { 2, 8 },
                    { 1, 3 },
                    { 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "UserProfessionalField",
                columns: new[] { "FieldId", "UserId" },
                values: new object[,]
                {
                    { 5, 18 },
                    { 5, 15 },
                    { 5, 7 },
                    { 5, 4 },
                    { 4, 3 },
                    { 4, 16 },
                    { 4, 13 },
                    { 4, 11 },
                    { 4, 7 },
                    { 4, 5 },
                    { 4, 18 },
                    { 3, 17 },
                    { 3, 14 },
                    { 3, 13 },
                    { 3, 6 },
                    { 3, 4 },
                    { 3, 2 },
                    { 2, 20 },
                    { 2, 13 },
                    { 2, 9 },
                    { 1, 19 },
                    { 1, 16 },
                    { 1, 12 },
                    { 1, 10 },
                    { 1, 8 },
                    { 1, 5 },
                    { 3, 20 },
                    { 3, 9 }
                });

            migrationBuilder.InsertData(
                table: "Presentations",
                columns: new[] { "Id", "Presenter", "SectionId", "Title" },
                values: new object[,]
                {
                    { 3, "FehérMáté", 4, "Presentation 3" },
                    { 7, "HerczegMáté", 4, "Presentation 7" },
                    { 11, "FehérAnna", 4, "Presentation 11" },
                    { 4, "KovácsBernadett", 1, "Presentation 4" },
                    { 8, "NémethSára", 1, "Presentation 8" },
                    { 12, "KovácsLevente", 1, "Presentation 12" },
                    { 1, "HerczegMáté", 2, "Presentation 1" },
                    { 5, "KissGéza", 2, "Presentation 5" },
                    { 9, "ErőssSára", 2, "Presentation 9" },
                    { 13, "KovácsSára", 2, "Presentation 13" },
                    { 2, "KissSára", 3, "Presentation 2" },
                    { 6, "FehérBernadett", 3, "Presentation 6" },
                    { 10, "NémethMáté", 3, "Presentation 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Presentations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "UserConference",
                keyColumns: new[] { "ConferenceId", "UserId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "UserProfessionalField",
                keyColumns: new[] { "FieldId", "UserId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionalFields",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Conferences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conferences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfessionalFields",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfessionalFields",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProfessionalFields",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProfessionalFields",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4117e5cf-a5ed-4077-9ed6-b7dd43da39e2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f043ecd1-6f58-48fe-b2e8-ff013e28a154", "AQAAAAEAACcQAAAAEIzFf4ORzkdcMYhtnx00V/NZxROAOw+Mc3Rd7KF3H2JilDZDdkAWp9vcYwf+bPWk9g==", "f3b8ef41-e7fa-403f-beb1-411a528c8a72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e05f4ce-40f1-45ff-a97e-5182867f2586", "AQAAAAEAACcQAAAAEG/dWg7pvGAibVN+yjAVcenblt/ZOAtDn89Z8JZgLKbNlP6e6jHejdaPcHP0mkRjLg==", "9ff6661e-4c01-4d05-8cd3-b57cd7bee5c3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ea7005a-0c7d-4627-97ad-22fcac6c7c6e", "AQAAAAEAACcQAAAAEEBKVO5nDZbB1yUuMVc8U+JVWFIYcNQj+7q9Mhgt3P/SdJSFlKeQZLBlHcQ+z4eSig==", "4bcac847-1fc9-4010-8778-78e7c6271b64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14b2d2ba-6e4c-47ad-bfbd-8e3910715d23", "AQAAAAEAACcQAAAAEJvI/qRuaCA2906lu5pomdYwoodUNmVlYnSdMXH5m9xdMJ7fHEXqKUAjOyJHafx5uQ==", "98a0e6e4-6f53-48e1-a7d8-ff7225e6ead7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cedf0e63-db58-493a-a38b-47b1ac36f43d", "AQAAAAEAACcQAAAAEIiB5l1J80izxGspD7/u4+MSxsMkmSLLUDxs7jsWhhE/G8RyQ5thnPjWM3g5XYp88A==", "34fc9ee8-3651-4976-80ec-6137b18a7cf7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08419d80-39d0-48b4-ad71-751cb3c070fe", "AQAAAAEAACcQAAAAEEJHcm3S/BnKf1cBBYFbCaaQm0F8/gjN9UmOY9ms46K42JJjgwZL3+aqiVlvg3y4qQ==", "e1447fc5-daab-4f5b-9ad2-ecfaf9767573" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "747d1cbc-e5a2-4d9f-bbb6-93c27cba83fe", "AQAAAAEAACcQAAAAENq1rBGo9vwK8Vd89AZ9GPDBhus62KtpTnL3UUEfXGkxVPl5bPG8N8oTdhOYGARxgQ==", "4cbe2be2-cd0d-4e0a-b1fe-b451732678a2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc1861a-91bb-4bcb-b4b6-237cf779e911", "AQAAAAEAACcQAAAAEOuS5M1Hm6mQf9aLhE68yH9aXAyG8XpSZAtkanZU0bWpMEExgOKyAD1T+NgsbD0M7g==", "90d3a063-e94e-43da-a85b-38c5b2121a4b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aed37935-b21d-4c1a-9188-9e829656e3ba", "AQAAAAEAACcQAAAAEO94lYHexzAbgXul+cZ5V81MGBw/ZcriiVbOmFpGkB3bBhCt183UFvTkQ6WHaHI0ZQ==", "01d69c85-79f0-482e-9c0a-0e4af1a5978b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "845d1c55-0f8e-4e82-bb53-9947c30137a7", "AQAAAAEAACcQAAAAEELiBgKHKVsBcC7OaopC2z29m2B3DRwt547SO6shCU1AhWYbP89B7B8hI4csgNzuXA==", "5d934d74-8050-4951-b267-29440ccfe77c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc23a491-768a-4151-a883-f5c519a1ab43", "AQAAAAEAACcQAAAAEOAP+i//aUob9A5zOU8p4ewbR0rWuZsi7ynrlpywjVXwXlW2isLSIsC08ErLL5/aXQ==", "c67ae985-adb3-4d93-ac5c-4ba01b4041e9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b5937a7-ff55-4a18-b131-cae1d174af3c", "AQAAAAEAACcQAAAAEO7Bl8B+wDwKwECf27yp6LZPMxPNM5yi2mUOFSaZ+qbao9v1cQ/7V6odNg6a8uyRfg==", "b4280b1e-aac9-457c-ad4c-95bcda9eda38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64312f0c-f590-4c27-a9d8-2f1eb642b647", "AQAAAAEAACcQAAAAEPpiOlstwjYTo+Kj9nVDBkduRn+lc7NviDxRrhPC66BNdr4DY+I4T3wd6rMR3+ZXBw==", "750668fc-c113-40c8-843d-fc5b759238bd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2290d90c-6a0f-4442-93c2-efce47eacc61", "AQAAAAEAACcQAAAAEDFbdoQs2SMskpEQwjuROzo6zQrImDdNox8vw+n1Fc25vRW73yuTfdVs6YdAok75Bw==", "a35de423-8dd7-42f3-ab2c-38d203183c61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a76c6e71-774f-446d-b505-692987508ca4", "AQAAAAEAACcQAAAAEHIigLoYNb5lfG25hRHCxqMRKo3cDHgzGodhWEsEVuBom2tGdob9wY6l17TZ3wohZA==", "e85a6d29-34f1-46be-924b-b44f41ce1646" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c91f4e52-2eb5-4a8f-9c94-c3ddcc0fe452", "AQAAAAEAACcQAAAAEEb2YlIkWnrkWItB+LOvzcEeb3BwSDLigSkR/V7719eMFkUERaxuAhA8HvbdymZiRw==", "6987523e-d4fc-4bde-9b51-10a315e3a3f8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c2eed9a-e687-4ad7-99b5-70f636eca6c1", "AQAAAAEAACcQAAAAEP3/EOE0ofUQxeH9tvpxj6cnDD7ihDj+VrOZoAvXBDHhunJXtCCrOfLF5PXdK4jWnQ==", "a64e2017-7e0e-43c3-bdd9-82eccaeb8fe6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06d7177a-996e-493d-a366-79adaa73bba8", "AQAAAAEAACcQAAAAEA6BkmqAgJuaossWR6zEcCfGDa3m+c0iGPtrIdY74RjZhP9KvXDR++F6kl0g//yd+A==", "b90de9a0-88c2-4b60-8f31-4a6ac69f717d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7120b3b0-1b2e-4866-bac0-87248571e566", "AQAAAAEAACcQAAAAELeNkzchzMrPlxPTMJ+LrevIEQmyy1mnHkJckBbFY46NKlHFT0XDWR8iT5k7VpnCMQ==", "325554ca-6cbd-427e-833e-4de13a39c95a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81eb0f05-77bd-40b7-bd1f-f926025b8b24", "AQAAAAEAACcQAAAAEGefK8PZYR8/Tmqg85OL4i4GT8r2G/CEVafwowfS8JPxOwnCDjjZcn/CweRGVWsytg==", "5564a50f-6e09-49bb-988f-3d4e27bd0e4b" });
        }
    }
}
