﻿// <auto-generated />
using System;
using AutoEscolaPeDeChumbo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoEscolaPeDeChumbo.Migrations
{
    [DbContext(typeof(AutoEscolaPeDeChumboContext))]
    [Migration("20211019221817_Treinamento")]
    partial class Treinamento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoEscolaPeDeChumbo.Pages.Alunos.Alunos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AutoEscolaPeDeChumbo.Pages.Funcionarios.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SalBruto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("dtAmissao")
                        .HasColumnType("datetime2");

                    b.HasKey("FuncionarioID");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("AutoEscolaPeDeChumbo.Pages.Treinamentos.Treinamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoTreinamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Treinamento");
                });
#pragma warning restore 612, 618
        }
    }
}
