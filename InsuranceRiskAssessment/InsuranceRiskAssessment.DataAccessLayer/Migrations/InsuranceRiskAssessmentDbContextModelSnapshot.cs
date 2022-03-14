﻿// <auto-generated />
using System;
using InsuranceRiskAssessment.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InsuranceRiskAssessment.DataAccessLayer.Migrations
{
    [DbContext(typeof(InsuranceRiskAssessmentDbContext))]
    partial class InsuranceRiskAssessmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities.AirTransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClimatZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistanceTraveled")
                        .HasColumnType("int");

                    b.Property<string>("Functionality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("InsuranceBrokerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ManifactureYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PreviousAccidents")
                        .HasColumnType("bit");

                    b.Property<string>("RegisteredCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredRegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecurityEquipmenPossession")
                        .HasColumnType("bit");

                    b.Property<bool>("TechnicalServiceability")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceBrokerId");

                    b.ToTable("AirTransports");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities.SeaTransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClimatZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistanceTraveled")
                        .HasColumnType("int");

                    b.Property<bool>("DoesRoutePassesPirateZones")
                        .HasColumnType("bit");

                    b.Property<string>("Functionality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("InsuranceBrokerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ManifactureYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PreviousAccidents")
                        .HasColumnType("bit");

                    b.Property<string>("RegisteredCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredRegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecurityEquipmenPossession")
                        .HasColumnType("bit");

                    b.Property<bool>("TechnicalServiceability")
                        .HasColumnType("bit");

                    b.Property<string>("TypeOfMovability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceBrokerId");

                    b.ToTable("SeaTransports");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities.VehicleByLand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistanceTraveled")
                        .HasColumnType("int");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("InsuranceBrokerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ManifactureYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("MostCommonRoutes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Parktronic")
                        .HasColumnType("bit");

                    b.Property<bool>("PreviousAccidents")
                        .HasColumnType("bit");

                    b.Property<string>("RegisterNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredRegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecurityEquipmenPossession")
                        .HasColumnType("bit");

                    b.Property<bool>("TechnicalServiceability")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceBrokerId");

                    b.ToTable("VehiclesByLand");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.BusinessEnterprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AlarmSystem")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EmergencyExit")
                        .HasColumnType("bit");

                    b.Property<bool>("FireExtinguishers")
                        .HasColumnType("bit");

                    b.Property<bool>("GasBottles")
                        .HasColumnType("bit");

                    b.Property<string>("InsuranceBrokerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PreviousAccidents")
                        .HasColumnType("bit");

                    b.Property<string>("PurposeOfTheEnterprise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SquareFeet")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceBrokerId");

                    b.ToTable("BusinessEnterprises");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.CommercialProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AlarmSystem")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EmergencyExit")
                        .HasColumnType("bit");

                    b.Property<bool>("FireExtinguishers")
                        .HasColumnType("bit");

                    b.Property<bool>("GasBottles")
                        .HasColumnType("bit");

                    b.Property<string>("InsuranceBrokerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PreviousAccidents")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SquareFeet")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceBrokerId");

                    b.ToTable("CommercialProperties");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.ResidentialBuilding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AlarmSystem")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EmergencyExit")
                        .HasColumnType("bit");

                    b.Property<bool>("FireExtinguishers")
                        .HasColumnType("bit");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GasBottles")
                        .HasColumnType("bit");

                    b.Property<string>("InsuranceBrokerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PreviousAccidents")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SquareFeet")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceBrokerId");

                    b.ToTable("ResidentialBuildings");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.VillaBuilding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AlarmSystem")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EmergencyExit")
                        .HasColumnType("bit");

                    b.Property<bool>("FireExtinguishers")
                        .HasColumnType("bit");

                    b.Property<bool>("GasBottles")
                        .HasColumnType("bit");

                    b.Property<string>("InsuranceBrokerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PreviousAccidents")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SquareFeet")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceBrokerId");

                    b.ToTable("VillaBuildings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities.AirTransport", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", "InsuranceBroker")
                        .WithMany("CheckedAirTransport")
                        .HasForeignKey("InsuranceBrokerId");

                    b.Navigation("InsuranceBroker");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities.SeaTransport", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", "InsuranceBroker")
                        .WithMany("CheckedSeaTransport")
                        .HasForeignKey("InsuranceBrokerId");

                    b.Navigation("InsuranceBroker");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities.VehicleByLand", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", "InsuranceBroker")
                        .WithMany("CheckedVehicleByLand")
                        .HasForeignKey("InsuranceBrokerId");

                    b.Navigation("InsuranceBroker");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.BusinessEnterprise", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", "InsuranceBroker")
                        .WithMany("CheckedBusinessEnterprise")
                        .HasForeignKey("InsuranceBrokerId");

                    b.Navigation("InsuranceBroker");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.CommercialProperty", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", "InsuranceBroker")
                        .WithMany("CheckedCommercialProperty")
                        .HasForeignKey("InsuranceBrokerId");

                    b.Navigation("InsuranceBroker");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.ResidentialBuilding", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", "InsuranceBroker")
                        .WithMany("CheckedResidentialBuildings")
                        .HasForeignKey("InsuranceBrokerId");

                    b.Navigation("InsuranceBroker");
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities.VillaBuilding", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", "InsuranceBroker")
                        .WithMany("CheckedVillaBuildings")
                        .HasForeignKey("InsuranceBrokerId");

                    b.Navigation("InsuranceBroker");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InsuranceRiskAssessment.DataAccessLayer.Data.InsuranceBrokerUser", b =>
                {
                    b.Navigation("CheckedAirTransport");

                    b.Navigation("CheckedBusinessEnterprise");

                    b.Navigation("CheckedCommercialProperty");

                    b.Navigation("CheckedResidentialBuildings");

                    b.Navigation("CheckedSeaTransport");

                    b.Navigation("CheckedVehicleByLand");

                    b.Navigation("CheckedVillaBuildings");
                });
#pragma warning restore 612, 618
        }
    }
}
