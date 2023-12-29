﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UcakBiletiSitesi.Models;

#nullable disable

namespace UcakBiletiSitesi.Migrations
{
    [DbContext(typeof(HavayoluContext))]
    partial class HavayoluContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UcakBiletiSitesi.Models.Bilet", b =>
                {
                    b.Property<int>("BiletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BiletId"));

                    b.Property<int>("UcusId")
                        .HasColumnType("int");

                    b.Property<int>("YolcuId")
                        .HasColumnType("int");

                    b.HasKey("BiletId");

                    b.HasIndex("UcusId");

                    b.HasIndex("YolcuId");

                    b.ToTable("Biletler");
                });

            modelBuilder.Entity("UcakBiletiSitesi.Models.Havaalani", b =>
                {
                    b.Property<int>("HavaalaniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HavaalaniId"));

                    b.Property<string>("HavaalaniAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("SehirAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HavaalaniId");

                    b.ToTable("Havaalanlari");
                });

            modelBuilder.Entity("UcakBiletiSitesi.Models.Ucak", b =>
                {
                    b.Property<int>("UcakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UcakId"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UcakId");

                    b.ToTable("Ucaklar");
                });

            modelBuilder.Entity("UcakBiletiSitesi.Models.Ucus", b =>
                {
                    b.Property<int>("UcusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UcusId"));

                    b.Property<int>("NeredenHavaalaniId")
                        .HasColumnType("int");

                    b.Property<int>("NereyeHavaalaniId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UcakId")
                        .HasColumnType("int");

                    b.Property<string>("UcusNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("UcusId");

                    b.HasIndex("NeredenHavaalaniId");

                    b.HasIndex("NereyeHavaalaniId");

                    b.HasIndex("UcakId");

                    b.ToTable("Ucuslar");
                });

            modelBuilder.Entity("UcakBiletiSitesi.Models.Yolcu", b =>
                {
                    b.Property<int>("YolcuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YolcuId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KimlikNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YolcuId");

                    b.ToTable("Yolcular");
                });

            modelBuilder.Entity("UcakBiletiSitesi.Models.Bilet", b =>
                {
                    b.HasOne("UcakBiletiSitesi.Models.Ucus", "Ucus")
                        .WithMany()
                        .HasForeignKey("UcusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UcakBiletiSitesi.Models.Yolcu", "Yolcu")
                        .WithMany()
                        .HasForeignKey("YolcuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ucus");

                    b.Navigation("Yolcu");
                });

            modelBuilder.Entity("UcakBiletiSitesi.Models.Ucus", b =>
                {
                    b.HasOne("UcakBiletiSitesi.Models.Havaalani", "Nereden")
                        .WithMany()
                        .HasForeignKey("NeredenHavaalaniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UcakBiletiSitesi.Models.Havaalani", "Nereye")
                        .WithMany()
                        .HasForeignKey("NereyeHavaalaniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UcakBiletiSitesi.Models.Ucak", "Ucak")
                        .WithMany()
                        .HasForeignKey("UcakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nereden");

                    b.Navigation("Nereye");

                    b.Navigation("Ucak");
                });
#pragma warning restore 612, 618
        }
    }
}
