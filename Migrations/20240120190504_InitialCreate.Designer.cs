﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proiect3.Data;

#nullable disable

namespace proiect3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240120190504_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComandaProdus", b =>
                {
                    b.Property<int>("ComenziComandaID")
                        .HasColumnType("int");

                    b.Property<int>("ProduseProdusID")
                        .HasColumnType("int");

                    b.HasKey("ComenziComandaID", "ProduseProdusID");

                    b.HasIndex("ProduseProdusID");

                    b.ToTable("ComandaProdus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("proiect3.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategorieID");

                    b.ToTable("Categorii");
                });

            modelBuilder.Entity("proiect3.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClientID");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("proiect3.Models.Comanda", b =>
                {
                    b.Property<int>("ComandaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPlasare")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ComandaID");

                    b.HasIndex("ClientID");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("proiect3.Models.DetaliuComanda", b =>
                {
                    b.Property<int>("DetaliuComandaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<int>("ComandaID")
                        .HasColumnType("int");

                    b.Property<decimal>("PretUnitar")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProdusID")
                        .HasColumnType("int");

                    b.HasKey("DetaliuComandaID");

                    b.HasIndex("ComandaID");

                    b.HasIndex("ProdusID");

                    b.ToTable("DetaliiComanda");
                });

            modelBuilder.Entity("proiect3.Models.Livrare", b =>
                {
                    b.Property<int>("LivrareID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ComandaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLivrare")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Stare")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LivrareID");

                    b.HasIndex("ComandaID")
                        .IsUnique();

                    b.ToTable("Livrari");
                });

            modelBuilder.Entity("proiect3.Models.Produs", b =>
                {
                    b.Property<int>("ProdusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ReviewID")
                        .HasColumnType("int");

                    b.Property<int>("Stoc")
                        .HasColumnType("int");

                    b.HasKey("ProdusID");

                    b.HasIndex("CategorieId");

                    b.HasIndex("ReviewID");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("proiect3.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Comentariu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataReview")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewID");

                    b.HasIndex("ClientID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ComandaProdus", b =>
                {
                    b.HasOne("proiect3.Models.Comanda", null)
                        .WithMany()
                        .HasForeignKey("ComenziComandaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiect3.Models.Produs", null)
                        .WithMany()
                        .HasForeignKey("ProduseProdusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("proiect3.Models.Comanda", b =>
                {
                    b.HasOne("proiect3.Models.Client", "Client")
                        .WithMany("Comenzi")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("proiect3.Models.DetaliuComanda", b =>
                {
                    b.HasOne("proiect3.Models.Comanda", "Comanda")
                        .WithMany("DetaliiComanda")
                        .HasForeignKey("ComandaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiect3.Models.Produs", "Produs")
                        .WithMany("DetaliiComanda")
                        .HasForeignKey("ProdusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("proiect3.Models.Livrare", b =>
                {
                    b.HasOne("proiect3.Models.Comanda", "Comanda")
                        .WithOne("Livrare")
                        .HasForeignKey("proiect3.Models.Livrare", "ComandaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("proiect3.Models.Produs", b =>
                {
                    b.HasOne("proiect3.Models.Categorie", "Categorii")
                        .WithMany("Produse")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiect3.Models.Review", "Review")
                        .WithMany("Produse")
                        .HasForeignKey("ReviewID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorii");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("proiect3.Models.Review", b =>
                {
                    b.HasOne("proiect3.Models.Client", "Client")
                        .WithMany("Reviews")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("proiect3.Models.Categorie", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("proiect3.Models.Client", b =>
                {
                    b.Navigation("Comenzi");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("proiect3.Models.Comanda", b =>
                {
                    b.Navigation("DetaliiComanda");

                    b.Navigation("Livrare")
                        .IsRequired();
                });

            modelBuilder.Entity("proiect3.Models.Produs", b =>
                {
                    b.Navigation("DetaliiComanda");
                });

            modelBuilder.Entity("proiect3.Models.Review", b =>
                {
                    b.Navigation("Produse");
                });
#pragma warning restore 612, 618
        }
    }
}
