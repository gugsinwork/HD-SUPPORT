﻿// <auto-generated />
using System;
using HD_SUPPORT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HD_SUPPORT.Migrations
{
    [DbContext(typeof(BancoContexto))]
    [Migration("20231220183206_BancoDadosSQLite")]
    partial class BancoDadosSQLite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("HD_SUPPORT.Models.CadastroEquip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DtEmeprestimoFinal")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DtEmeprestimoInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadSet")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdPatrimonio")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modelo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Processador")
                        .HasColumnType("TEXT");

                    b.Property<string>("SistemaOperacionar")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CadastroEmprestimos");
                });

            modelBuilder.Entity("HD_SUPPORT.Models.CadastroHelpDesk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CadastroHD");
                });

            modelBuilder.Entity("HD_SUPPORT.Models.CadastroUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cpf")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telegram")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CadastroUser");
                });
#pragma warning restore 612, 618
        }
    }
}
