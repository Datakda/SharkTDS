﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharkTDS.Controllers;

namespace SharkTDS.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SharkTDS.Models.Flow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionOnBots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Azerbaijan")
                        .HasColumnType("tinyint");

                    b.Property<bool>("Baidu")
                        .HasColumnType("bit");

                    b.Property<byte>("Beeline")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Belarus")
                        .HasColumnType("tinyint");

                    b.Property<bool>("Bing")
                        .HasColumnType("bit");

                    b.Property<bool>("BlackListUserAgent")
                        .HasColumnType("bit");

                    b.Property<byte>("BlankReferer")
                        .HasColumnType("tinyint");

                    b.Property<string>("BotsReplaceToCURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BotsUrlOrCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrowserLanguag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Countries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurlReplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DomainName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmptyBrowserLanguage")
                        .HasColumnType("bit");

                    b.Property<bool>("EmptyReferer")
                        .HasColumnType("bit");

                    b.Property<bool>("EmptyUserAgent")
                        .HasColumnType("bit");

                    b.Property<bool>("Google")
                        .HasColumnType("bit");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderBots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IPV6")
                        .HasColumnType("bit");

                    b.Property<int>("Identifier")
                        .HasColumnType("int");

                    b.Property<byte>("IsActiveAvailabilityInKeyword")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsActiveAvailabilityInReferer")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsActiveAvailabilityInUserAgent")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsActiveBrowserLanguage")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsActiveCity")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsActiveCountry")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsActiveDomainName")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsActiveFlow")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActiveLimit")
                        .HasColumnType("bit");

                    b.Property<byte>("IsActiveRegion")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsActiveSignsBotUserAgent")
                        .HasColumnType("bit");

                    b.Property<byte>("Kazakhstan")
                        .HasColumnType("tinyint");

                    b.Property<string>("Keyword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mailru")
                        .HasColumnType("bit");

                    b.Property<byte>("Megafon")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Mobile")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Mts")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("NonUniqueVisitors")
                        .HasColumnType("tinyint");

                    b.Property<bool>("Others")
                        .HasColumnType("bit");

                    b.Property<string>("Referer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SaveIpBot")
                        .HasColumnType("bit");

                    b.Property<byte>("Tablet")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Tele2")
                        .HasColumnType("tinyint");

                    b.Property<int>("TypeDistribution")
                        .HasColumnType("int");

                    b.Property<int>("TypeRedirect")
                        .HasColumnType("int");

                    b.Property<byte>("Ukraine")
                        .HasColumnType("tinyint");

                    b.Property<string>("UrlOrCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Visitors")
                        .HasColumnType("int");

                    b.Property<byte>("Wap_1")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Wap_2")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Wap_3")
                        .HasColumnType("tinyint");

                    b.Property<bool>("Yahoo")
                        .HasColumnType("bit");

                    b.Property<bool>("Yandex")
                        .HasColumnType("bit");

                    b.Property<byte>("Сomputer")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Flows");
                });

            modelBuilder.Entity("SharkTDS.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeoBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GroupIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActiveBanGroupToTime")
                        .HasColumnType("bit");

                    b.Property<int>("LimitQestion")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplaceToCURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SaveKeys")
                        .HasColumnType("bit");

                    b.Property<bool>("SaveKeysOfReferer")
                        .HasColumnType("bit");

                    b.Property<int>("TermUniqueness")
                        .HasColumnType("int");

                    b.Property<int>("TimePeriod")
                        .HasColumnType("int");

                    b.Property<string>("TypeRedirect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniquenessCheck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlORCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SharkTDS.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaxMindKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("SharkTDS.Models.Stat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Bot")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlowID")
                        .HasColumnType("int");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keyword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Out")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Page")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Redirect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Uniq")
                        .HasColumnType("bit");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlowID");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("SharkTDS.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SharkTDS.Models.Flow", b =>
                {
                    b.HasOne("SharkTDS.Models.Group", "Group")
                        .WithMany("Flows")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SharkTDS.Models.Stat", b =>
                {
                    b.HasOne("SharkTDS.Models.Flow", null)
                        .WithMany("Stats")
                        .HasForeignKey("FlowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharkTDS.Models.Flow", b =>
                {
                    b.Navigation("Stats");
                });

            modelBuilder.Entity("SharkTDS.Models.Group", b =>
                {
                    b.Navigation("Flows");
                });
#pragma warning restore 612, 618
        }
    }
}
