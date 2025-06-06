﻿// <auto-generated />
using Cp2Mottu.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cp2Mottu.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cp2Mottu.Domain.Persistence.Filial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("Cp2Mottu.Domain.Persistence.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdFilial")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Modelo")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("NVARCHAR2(7)");

                    b.HasKey("Id");

                    b.HasIndex("IdFilial");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.ToTable("Motos");
                });

            modelBuilder.Entity("Cp2Mottu.Domain.Persistence.Moto", b =>
                {
                    b.HasOne("Cp2Mottu.Domain.Persistence.Filial", "Filial")
                        .WithMany("Motos")
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("Cp2Mottu.Domain.Persistence.Filial", b =>
                {
                    b.Navigation("Motos");
                });
#pragma warning restore 612, 618
        }
    }
}
