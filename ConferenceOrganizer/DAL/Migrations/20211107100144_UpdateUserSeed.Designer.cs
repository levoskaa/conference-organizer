﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211107100144_UpdateUserSeed")]
    partial class UpdateUserSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.HasSequence("conferenceseq")
                .IncrementsBy(10);

            modelBuilder.HasSequence("presentationseq")
                .IncrementsBy(10);

            modelBuilder.HasSequence("professionalfieldseq")
                .IncrementsBy(10);

            modelBuilder.HasSequence("roomseq")
                .IncrementsBy(10);

            modelBuilder.HasSequence("sectionseq")
                .IncrementsBy(10);

            modelBuilder.Entity("Domain.Entitites.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "4117e5cf-a5ed-4077-9ed6-b7dd43da39e2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Domain.Entitites.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f043ecd1-6f58-48fe-b2e8-ff013e28a154",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEIzFf4ORzkdcMYhtnx00V/NZxROAOw+Mc3Rd7KF3H2JilDZDdkAWp9vcYwf+bPWk9g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f3b8ef41-e7fa-403f-beb1-411a528c8a72",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1e05f4ce-40f1-45ff-a97e-5182867f2586",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER2",
                            PasswordHash = "AQAAAAEAACcQAAAAEG/dWg7pvGAibVN+yjAVcenblt/ZOAtDn89Z8JZgLKbNlP6e6jHejdaPcHP0mkRjLg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9ff6661e-4c01-4d05-8cd3-b57cd7bee5c3",
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0ea7005a-0c7d-4627-97ad-22fcac6c7c6e",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER3",
                            PasswordHash = "AQAAAAEAACcQAAAAEEBKVO5nDZbB1yUuMVc8U+JVWFIYcNQj+7q9Mhgt3P/SdJSFlKeQZLBlHcQ+z4eSig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4bcac847-1fc9-4010-8778-78e7c6271b64",
                            TwoFactorEnabled = false,
                            UserName = "user3"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "14b2d2ba-6e4c-47ad-bfbd-8e3910715d23",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER4",
                            PasswordHash = "AQAAAAEAACcQAAAAEJvI/qRuaCA2906lu5pomdYwoodUNmVlYnSdMXH5m9xdMJ7fHEXqKUAjOyJHafx5uQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "98a0e6e4-6f53-48e1-a7d8-ff7225e6ead7",
                            TwoFactorEnabled = false,
                            UserName = "user4"
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cedf0e63-db58-493a-a38b-47b1ac36f43d",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER5",
                            PasswordHash = "AQAAAAEAACcQAAAAEIiB5l1J80izxGspD7/u4+MSxsMkmSLLUDxs7jsWhhE/G8RyQ5thnPjWM3g5XYp88A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "34fc9ee8-3651-4976-80ec-6137b18a7cf7",
                            TwoFactorEnabled = false,
                            UserName = "user5"
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "08419d80-39d0-48b4-ad71-751cb3c070fe",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER6",
                            PasswordHash = "AQAAAAEAACcQAAAAEEJHcm3S/BnKf1cBBYFbCaaQm0F8/gjN9UmOY9ms46K42JJjgwZL3+aqiVlvg3y4qQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e1447fc5-daab-4f5b-9ad2-ecfaf9767573",
                            TwoFactorEnabled = false,
                            UserName = "user6"
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "747d1cbc-e5a2-4d9f-bbb6-93c27cba83fe",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER7",
                            PasswordHash = "AQAAAAEAACcQAAAAENq1rBGo9vwK8Vd89AZ9GPDBhus62KtpTnL3UUEfXGkxVPl5bPG8N8oTdhOYGARxgQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4cbe2be2-cd0d-4e0a-b1fe-b451732678a2",
                            TwoFactorEnabled = false,
                            UserName = "user7"
                        },
                        new
                        {
                            Id = 8,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6dc1861a-91bb-4bcb-b4b6-237cf779e911",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER8",
                            PasswordHash = "AQAAAAEAACcQAAAAEOuS5M1Hm6mQf9aLhE68yH9aXAyG8XpSZAtkanZU0bWpMEExgOKyAD1T+NgsbD0M7g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "90d3a063-e94e-43da-a85b-38c5b2121a4b",
                            TwoFactorEnabled = false,
                            UserName = "user8"
                        },
                        new
                        {
                            Id = 9,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aed37935-b21d-4c1a-9188-9e829656e3ba",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER9",
                            PasswordHash = "AQAAAAEAACcQAAAAEO94lYHexzAbgXul+cZ5V81MGBw/ZcriiVbOmFpGkB3bBhCt183UFvTkQ6WHaHI0ZQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "01d69c85-79f0-482e-9c0a-0e4af1a5978b",
                            TwoFactorEnabled = false,
                            UserName = "user9"
                        },
                        new
                        {
                            Id = 10,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "845d1c55-0f8e-4e82-bb53-9947c30137a7",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER10",
                            PasswordHash = "AQAAAAEAACcQAAAAEELiBgKHKVsBcC7OaopC2z29m2B3DRwt547SO6shCU1AhWYbP89B7B8hI4csgNzuXA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5d934d74-8050-4951-b267-29440ccfe77c",
                            TwoFactorEnabled = false,
                            UserName = "user10"
                        },
                        new
                        {
                            Id = 11,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc23a491-768a-4151-a883-f5c519a1ab43",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER11",
                            PasswordHash = "AQAAAAEAACcQAAAAEOAP+i//aUob9A5zOU8p4ewbR0rWuZsi7ynrlpywjVXwXlW2isLSIsC08ErLL5/aXQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c67ae985-adb3-4d93-ac5c-4ba01b4041e9",
                            TwoFactorEnabled = false,
                            UserName = "user11"
                        },
                        new
                        {
                            Id = 12,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9b5937a7-ff55-4a18-b131-cae1d174af3c",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER12",
                            PasswordHash = "AQAAAAEAACcQAAAAEO7Bl8B+wDwKwECf27yp6LZPMxPNM5yi2mUOFSaZ+qbao9v1cQ/7V6odNg6a8uyRfg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b4280b1e-aac9-457c-ad4c-95bcda9eda38",
                            TwoFactorEnabled = false,
                            UserName = "user12"
                        },
                        new
                        {
                            Id = 13,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "64312f0c-f590-4c27-a9d8-2f1eb642b647",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER13",
                            PasswordHash = "AQAAAAEAACcQAAAAEPpiOlstwjYTo+Kj9nVDBkduRn+lc7NviDxRrhPC66BNdr4DY+I4T3wd6rMR3+ZXBw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "750668fc-c113-40c8-843d-fc5b759238bd",
                            TwoFactorEnabled = false,
                            UserName = "user13"
                        },
                        new
                        {
                            Id = 14,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2290d90c-6a0f-4442-93c2-efce47eacc61",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER14",
                            PasswordHash = "AQAAAAEAACcQAAAAEDFbdoQs2SMskpEQwjuROzo6zQrImDdNox8vw+n1Fc25vRW73yuTfdVs6YdAok75Bw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a35de423-8dd7-42f3-ab2c-38d203183c61",
                            TwoFactorEnabled = false,
                            UserName = "user14"
                        },
                        new
                        {
                            Id = 15,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a76c6e71-774f-446d-b505-692987508ca4",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER15",
                            PasswordHash = "AQAAAAEAACcQAAAAEHIigLoYNb5lfG25hRHCxqMRKo3cDHgzGodhWEsEVuBom2tGdob9wY6l17TZ3wohZA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e85a6d29-34f1-46be-924b-b44f41ce1646",
                            TwoFactorEnabled = false,
                            UserName = "user15"
                        },
                        new
                        {
                            Id = 16,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c91f4e52-2eb5-4a8f-9c94-c3ddcc0fe452",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER16",
                            PasswordHash = "AQAAAAEAACcQAAAAEEb2YlIkWnrkWItB+LOvzcEeb3BwSDLigSkR/V7719eMFkUERaxuAhA8HvbdymZiRw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6987523e-d4fc-4bde-9b51-10a315e3a3f8",
                            TwoFactorEnabled = false,
                            UserName = "user16"
                        },
                        new
                        {
                            Id = 17,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c2eed9a-e687-4ad7-99b5-70f636eca6c1",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER17",
                            PasswordHash = "AQAAAAEAACcQAAAAEP3/EOE0ofUQxeH9tvpxj6cnDD7ihDj+VrOZoAvXBDHhunJXtCCrOfLF5PXdK4jWnQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a64e2017-7e0e-43c3-bdd9-82eccaeb8fe6",
                            TwoFactorEnabled = false,
                            UserName = "user17"
                        },
                        new
                        {
                            Id = 18,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06d7177a-996e-493d-a366-79adaa73bba8",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER18",
                            PasswordHash = "AQAAAAEAACcQAAAAEA6BkmqAgJuaossWR6zEcCfGDa3m+c0iGPtrIdY74RjZhP9KvXDR++F6kl0g//yd+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b90de9a0-88c2-4b60-8f31-4a6ac69f717d",
                            TwoFactorEnabled = false,
                            UserName = "user18"
                        },
                        new
                        {
                            Id = 19,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7120b3b0-1b2e-4866-bac0-87248571e566",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER19",
                            PasswordHash = "AQAAAAEAACcQAAAAELeNkzchzMrPlxPTMJ+LrevIEQmyy1mnHkJckBbFY46NKlHFT0XDWR8iT5k7VpnCMQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "325554ca-6cbd-427e-833e-4de13a39c95a",
                            TwoFactorEnabled = false,
                            UserName = "user19"
                        },
                        new
                        {
                            Id = 20,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "81eb0f05-77bd-40b7-bd1f-f926025b8b24",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER20",
                            PasswordHash = "AQAAAAEAACcQAAAAEGefK8PZYR8/Tmqg85OL4i4GT8r2G/CEVafwowfS8JPxOwnCDjjZcn/CweRGVWsytg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5564a50f-6e09-49bb-988f-3d4e27bd0e4b",
                            TwoFactorEnabled = false,
                            UserName = "user20"
                        });
                });

            modelBuilder.Entity("Domain.Entitites.ApplicationUserConference", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ConferenceId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ConferenceId");

                    b.HasIndex("ConferenceId");

                    b.ToTable("UserConference");
                });

            modelBuilder.Entity("Domain.Entitites.ApplicationUserProfessionalField", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("UserProfessionalField");
                });

            modelBuilder.Entity("Domain.Entitites.Conference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "conferenceseq")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conferences");
                });

            modelBuilder.Entity("Domain.Entitites.Presentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "presentationseq")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Presenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Presentations");
                });

            modelBuilder.Entity("Domain.Entitites.ProfessionalField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "professionalfieldseq")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProfessionalFields");
                });

            modelBuilder.Entity("Domain.Entitites.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "roomseq")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("UniqueName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Domain.Entitites.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "sectionseq")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("ConferenceId")
                        .HasColumnType("int");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.HasIndex("FieldId");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entitites.ApplicationUserConference", b =>
                {
                    b.HasOne("Domain.Entitites.Conference", "Conference")
                        .WithMany("UserConferences")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entitites.ApplicationUser", "User")
                        .WithMany("UserConferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conference");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entitites.ApplicationUserProfessionalField", b =>
                {
                    b.HasOne("Domain.Entitites.ProfessionalField", "Field")
                        .WithMany("UserFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entitites.ApplicationUser", "User")
                        .WithMany("UserFields")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entitites.Conference", b =>
                {
                    b.OwnsOne("Domain.Entitites.TimeFrame", "TimeFrame", b1 =>
                        {
                            b1.Property<int>("ConferenceId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:HiLoSequenceName", "conferenceseq")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                            b1.Property<DateTime>("BeginDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("BeginDate");

                            b1.Property<DateTime>("EndDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("EndDate");

                            b1.HasKey("ConferenceId");

                            b1.ToTable("Conferences");

                            b1.WithOwner()
                                .HasForeignKey("ConferenceId");
                        });

                    b.Navigation("TimeFrame");
                });

            modelBuilder.Entity("Domain.Entitites.Presentation", b =>
                {
                    b.HasOne("Domain.Entitites.Section", "Section")
                        .WithMany("Presentations")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("Domain.Entitites.Section", b =>
                {
                    b.HasOne("Domain.Entitites.Conference", "Conference")
                        .WithMany("Sections")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entitites.ProfessionalField", "Field")
                        .WithMany("SectionsAboutField")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entitites.Room", "Room")
                        .WithMany("Sections")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entitites.ApplicationUser", "User")
                        .WithMany("ModeratedSections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Domain.Entitites.TimeFrame", "TimeFrame", b1 =>
                        {
                            b1.Property<int>("SectionId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:HiLoSequenceName", "sectionseq")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                            b1.Property<DateTime>("BeginDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("BeginDate");

                            b1.Property<DateTime>("EndDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("EndDate");

                            b1.HasKey("SectionId");

                            b1.ToTable("Sections");

                            b1.WithOwner()
                                .HasForeignKey("SectionId");
                        });

                    b.Navigation("Conference");

                    b.Navigation("Field");

                    b.Navigation("Room");

                    b.Navigation("TimeFrame");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Domain.Entitites.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Domain.Entitites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Domain.Entitites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Domain.Entitites.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entitites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Domain.Entitites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entitites.ApplicationUser", b =>
                {
                    b.Navigation("ModeratedSections");

                    b.Navigation("UserConferences");

                    b.Navigation("UserFields");
                });

            modelBuilder.Entity("Domain.Entitites.Conference", b =>
                {
                    b.Navigation("Sections");

                    b.Navigation("UserConferences");
                });

            modelBuilder.Entity("Domain.Entitites.ProfessionalField", b =>
                {
                    b.Navigation("SectionsAboutField");

                    b.Navigation("UserFields");
                });

            modelBuilder.Entity("Domain.Entitites.Room", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Domain.Entitites.Section", b =>
                {
                    b.Navigation("Presentations");
                });
#pragma warning restore 612, 618
        }
    }
}