﻿// <auto-generated />
using Back_Aplicación_Bancaria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back_Aplicación_Bancaria.Migrations
{
    [DbContext(typeof(BaseDatos))]
    [Migration("20230922235244_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back_Aplicación_Bancaria.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Back_Aplicación_Bancaria.Cuenta_Bancaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DueñoId")
                        .HasColumnType("int");

                    b.Property<int>("Numero_Cuenta")
                        .HasColumnType("int");

                    b.Property<double>("saldo")
                        .HasColumnType("float");

                    b.Property<string>("tipo_cuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DueñoId");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("Back_Aplicación_Bancaria.Tarjeta_de_Crédito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DueñoTarjetaId")
                        .HasColumnType("int");

                    b.Property<double>("MontoDeuda")
                        .HasColumnType("float");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("limiteCredito")
                        .HasColumnType("int");

                    b.Property<int>("numeroTarjeta")
                        .HasColumnType("int");

                    b.Property<double>("saldoDisponible")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DueñoTarjetaId");

                    b.ToTable("Tarjetas");
                });

            modelBuilder.Entity("Back_Aplicación_Bancaria.Cuenta_Bancaria", b =>
                {
                    b.HasOne("Back_Aplicación_Bancaria.Cliente", "Dueño")
                        .WithMany()
                        .HasForeignKey("DueñoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dueño");
                });

            modelBuilder.Entity("Back_Aplicación_Bancaria.Tarjeta_de_Crédito", b =>
                {
                    b.HasOne("Back_Aplicación_Bancaria.Cliente", "DueñoTarjeta")
                        .WithMany()
                        .HasForeignKey("DueñoTarjetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DueñoTarjeta");
                });
#pragma warning restore 612, 618
        }
    }
}
