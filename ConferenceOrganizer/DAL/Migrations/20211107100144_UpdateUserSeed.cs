using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UpdateUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 20, 0, "81eb0f05-77bd-40b7-bd1f-f926025b8b24", null, false, false, null, null, "USER20", "AQAAAAEAACcQAAAAEGefK8PZYR8/Tmqg85OL4i4GT8r2G/CEVafwowfS8JPxOwnCDjjZcn/CweRGVWsytg==", null, false, "5564a50f-6e09-49bb-988f-3d4e27bd0e4b", false, "user20" },
                    { 19, 0, "7120b3b0-1b2e-4866-bac0-87248571e566", null, false, false, null, null, "USER19", "AQAAAAEAACcQAAAAELeNkzchzMrPlxPTMJ+LrevIEQmyy1mnHkJckBbFY46NKlHFT0XDWR8iT5k7VpnCMQ==", null, false, "325554ca-6cbd-427e-833e-4de13a39c95a", false, "user19" },
                    { 18, 0, "06d7177a-996e-493d-a366-79adaa73bba8", null, false, false, null, null, "USER18", "AQAAAAEAACcQAAAAEA6BkmqAgJuaossWR6zEcCfGDa3m+c0iGPtrIdY74RjZhP9KvXDR++F6kl0g//yd+A==", null, false, "b90de9a0-88c2-4b60-8f31-4a6ac69f717d", false, "user18" },
                    { 17, 0, "0c2eed9a-e687-4ad7-99b5-70f636eca6c1", null, false, false, null, null, "USER17", "AQAAAAEAACcQAAAAEP3/EOE0ofUQxeH9tvpxj6cnDD7ihDj+VrOZoAvXBDHhunJXtCCrOfLF5PXdK4jWnQ==", null, false, "a64e2017-7e0e-43c3-bdd9-82eccaeb8fe6", false, "user17" },
                    { 16, 0, "c91f4e52-2eb5-4a8f-9c94-c3ddcc0fe452", null, false, false, null, null, "USER16", "AQAAAAEAACcQAAAAEEb2YlIkWnrkWItB+LOvzcEeb3BwSDLigSkR/V7719eMFkUERaxuAhA8HvbdymZiRw==", null, false, "6987523e-d4fc-4bde-9b51-10a315e3a3f8", false, "user16" },
                    { 15, 0, "a76c6e71-774f-446d-b505-692987508ca4", null, false, false, null, null, "USER15", "AQAAAAEAACcQAAAAEHIigLoYNb5lfG25hRHCxqMRKo3cDHgzGodhWEsEVuBom2tGdob9wY6l17TZ3wohZA==", null, false, "e85a6d29-34f1-46be-924b-b44f41ce1646", false, "user15" },
                    { 14, 0, "2290d90c-6a0f-4442-93c2-efce47eacc61", null, false, false, null, null, "USER14", "AQAAAAEAACcQAAAAEDFbdoQs2SMskpEQwjuROzo6zQrImDdNox8vw+n1Fc25vRW73yuTfdVs6YdAok75Bw==", null, false, "a35de423-8dd7-42f3-ab2c-38d203183c61", false, "user14" },
                    { 13, 0, "64312f0c-f590-4c27-a9d8-2f1eb642b647", null, false, false, null, null, "USER13", "AQAAAAEAACcQAAAAEPpiOlstwjYTo+Kj9nVDBkduRn+lc7NviDxRrhPC66BNdr4DY+I4T3wd6rMR3+ZXBw==", null, false, "750668fc-c113-40c8-843d-fc5b759238bd", false, "user13" },
                    { 12, 0, "9b5937a7-ff55-4a18-b131-cae1d174af3c", null, false, false, null, null, "USER12", "AQAAAAEAACcQAAAAEO7Bl8B+wDwKwECf27yp6LZPMxPNM5yi2mUOFSaZ+qbao9v1cQ/7V6odNg6a8uyRfg==", null, false, "b4280b1e-aac9-457c-ad4c-95bcda9eda38", false, "user12" },
                    { 10, 0, "845d1c55-0f8e-4e82-bb53-9947c30137a7", null, false, false, null, null, "USER10", "AQAAAAEAACcQAAAAEELiBgKHKVsBcC7OaopC2z29m2B3DRwt547SO6shCU1AhWYbP89B7B8hI4csgNzuXA==", null, false, "5d934d74-8050-4951-b267-29440ccfe77c", false, "user10" },
                    { 9, 0, "aed37935-b21d-4c1a-9188-9e829656e3ba", null, false, false, null, null, "USER9", "AQAAAAEAACcQAAAAEO94lYHexzAbgXul+cZ5V81MGBw/ZcriiVbOmFpGkB3bBhCt183UFvTkQ6WHaHI0ZQ==", null, false, "01d69c85-79f0-482e-9c0a-0e4af1a5978b", false, "user9" },
                    { 8, 0, "6dc1861a-91bb-4bcb-b4b6-237cf779e911", null, false, false, null, null, "USER8", "AQAAAAEAACcQAAAAEOuS5M1Hm6mQf9aLhE68yH9aXAyG8XpSZAtkanZU0bWpMEExgOKyAD1T+NgsbD0M7g==", null, false, "90d3a063-e94e-43da-a85b-38c5b2121a4b", false, "user8" },
                    { 7, 0, "747d1cbc-e5a2-4d9f-bbb6-93c27cba83fe", null, false, false, null, null, "USER7", "AQAAAAEAACcQAAAAENq1rBGo9vwK8Vd89AZ9GPDBhus62KtpTnL3UUEfXGkxVPl5bPG8N8oTdhOYGARxgQ==", null, false, "4cbe2be2-cd0d-4e0a-b1fe-b451732678a2", false, "user7" },
                    { 6, 0, "08419d80-39d0-48b4-ad71-751cb3c070fe", null, false, false, null, null, "USER6", "AQAAAAEAACcQAAAAEEJHcm3S/BnKf1cBBYFbCaaQm0F8/gjN9UmOY9ms46K42JJjgwZL3+aqiVlvg3y4qQ==", null, false, "e1447fc5-daab-4f5b-9ad2-ecfaf9767573", false, "user6" },
                    { 5, 0, "cedf0e63-db58-493a-a38b-47b1ac36f43d", null, false, false, null, null, "USER5", "AQAAAAEAACcQAAAAEIiB5l1J80izxGspD7/u4+MSxsMkmSLLUDxs7jsWhhE/G8RyQ5thnPjWM3g5XYp88A==", null, false, "34fc9ee8-3651-4976-80ec-6137b18a7cf7", false, "user5" },
                    { 4, 0, "14b2d2ba-6e4c-47ad-bfbd-8e3910715d23", null, false, false, null, null, "USER4", "AQAAAAEAACcQAAAAEJvI/qRuaCA2906lu5pomdYwoodUNmVlYnSdMXH5m9xdMJ7fHEXqKUAjOyJHafx5uQ==", null, false, "98a0e6e4-6f53-48e1-a7d8-ff7225e6ead7", false, "user4" },
                    { 3, 0, "0ea7005a-0c7d-4627-97ad-22fcac6c7c6e", null, false, false, null, null, "USER3", "AQAAAAEAACcQAAAAEEBKVO5nDZbB1yUuMVc8U+JVWFIYcNQj+7q9Mhgt3P/SdJSFlKeQZLBlHcQ+z4eSig==", null, false, "4bcac847-1fc9-4010-8778-78e7c6271b64", false, "user3" },
                    { 11, 0, "fc23a491-768a-4151-a883-f5c519a1ab43", null, false, false, null, null, "USER11", "AQAAAAEAACcQAAAAEOAP+i//aUob9A5zOU8p4ewbR0rWuZsi7ynrlpywjVXwXlW2isLSIsC08ErLL5/aXQ==", null, false, "c67ae985-adb3-4d93-ac5c-4ba01b4041e9", false, "user11" },
                    { 2, 0, "1e05f4ce-40f1-45ff-a97e-5182867f2586", null, false, false, null, null, "USER2", "AQAAAAEAACcQAAAAEG/dWg7pvGAibVN+yjAVcenblt/ZOAtDn89Z8JZgLKbNlP6e6jHejdaPcHP0mkRjLg==", null, false, "9ff6661e-4c01-4d05-8cd3-b57cd7bee5c3", false, "user2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "49aa847f-9cbc-4c6f-97d7-bad674ad6580");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "520c5ce2-67b4-4ab7-a4c1-903fa73bd86b", "AQAAAAEAACcQAAAAELjA9ZACBn63XuYb9ZcvJSyF9zNcdCVhkP+Ut4SeyF8zWDjqjfRLogtm83gMayQykA==", "b0dcc58f-bf59-4308-b84e-f46a7df30329" });
        }
    }
}
