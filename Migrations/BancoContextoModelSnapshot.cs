﻿// <auto-generated />
using System;
using HD_SUPPORT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HD_SUPPORT.Migrations
{
    [DbContext(typeof(BancoContexto))]
    partial class BancoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

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

                    b.Property<DateTime>("DtEmprestimoFinal")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DtEmprestimoInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadSet")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Processador")
                        .HasColumnType("TEXT");

                    b.Property<string>("SistemaOperacional")
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