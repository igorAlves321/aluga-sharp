﻿// <auto-generated />
using System;
using AgendaSalas.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaSalas.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20221010032721_Inicial10")]
    partial class Inicial10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AgendaSalas.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"), 1L, 1);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("AgendaSalas.Models.DisponibilidadeSala", b =>
                {
                    b.Property<int>("DisponibilidadeSalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisponibilidadeSalaId"), 1L, 1);

                    b.Property<int?>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("DisponibilidadeSalaId");

                    b.HasIndex("ReservaId");

                    b.ToTable("DisponibilidadeSala");
                });

            modelBuilder.Entity("AgendaSalas.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoId"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("EnderecoId");

                    b.HasIndex("SalaId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AgendaSalas.Models.Equipamento", b =>
                {
                    b.Property<int>("EquipamentosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipamentosId"), 1L, 1);

                    b.Property<float>("CustoHora")
                        .HasColumnType("real");

                    b.Property<float>("CustoSeguro")
                        .HasColumnType("real");

                    b.Property<float>("CustoTotal")
                        .HasColumnType("real");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservaId")
                        .HasColumnType("int");

                    b.Property<string>("Voltagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Volume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipamentosId");

                    b.HasIndex("ReservaId");

                    b.ToTable("Equipamento");
                });

            modelBuilder.Entity("AgendaSalas.Models.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HorarioId"), 1L, 1);

                    b.Property<DateTime>("Final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PeriodoId")
                        .HasColumnType("int");

                    b.HasKey("HorarioId");

                    b.HasIndex("PeriodoId");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("AgendaSalas.Models.Obgetos", b =>
                {
                    b.Property<int>("ObgetosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObgetosID"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<int?>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("ObgetosID");

                    b.HasIndex("ReservaId");

                    b.ToTable("Obgetos");
                });

            modelBuilder.Entity("AgendaSalas.Models.Periodo", b =>
                {
                    b.Property<int>("PeriodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PeriodoId"), 1L, 1);

                    b.Property<int>("Dia")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<int?>("DisponibilidadeSalaId")
                        .HasColumnType("int");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<bool?>("estaAtiva")
                        .HasColumnType("bit");

                    b.HasKey("PeriodoId");

                    b.HasIndex("DisponibilidadeSalaId");

                    b.ToTable("Periodo");
                });

            modelBuilder.Entity("AgendaSalas.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaId"), 1L, 1);

                    b.Property<bool?>("FazerContratacao")
                        .HasColumnType("bit");

                    b.HasKey("ReservaId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("AgendaSalas.Models.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaId"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int?>("DisponibilidadeSalaId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacao")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<string>("Janelas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voltagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medidaLado1EmMetros")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("medidaLado2EmMetros")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("numeroMaximoDePessoas")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("SalaId");

                    b.HasIndex("DisponibilidadeSalaId");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("AgendaSalas.Models.Servicos", b =>
                {
                    b.Property<int>("ServicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoID"), 1L, 1);

                    b.Property<string>("Custo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("ServicoID");

                    b.HasIndex("ReservaId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("AgendaSalas.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AgendaSalas.Models.DisponibilidadeSala", b =>
                {
                    b.HasOne("AgendaSalas.Models.Reserva", null)
                        .WithMany("DisponibilidadeSalas")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("AgendaSalas.Models.Endereco", b =>
                {
                    b.HasOne("AgendaSalas.Models.Sala", null)
                        .WithMany("Localizacao")
                        .HasForeignKey("SalaId");
                });

            modelBuilder.Entity("AgendaSalas.Models.Equipamento", b =>
                {
                    b.HasOne("AgendaSalas.Models.Reserva", null)
                        .WithMany("Equipamentos")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("AgendaSalas.Models.Horario", b =>
                {
                    b.HasOne("AgendaSalas.Models.Periodo", null)
                        .WithMany("Horarios")
                        .HasForeignKey("PeriodoId");
                });

            modelBuilder.Entity("AgendaSalas.Models.Obgetos", b =>
                {
                    b.HasOne("AgendaSalas.Models.Reserva", null)
                        .WithMany("Objetos")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("AgendaSalas.Models.Periodo", b =>
                {
                    b.HasOne("AgendaSalas.Models.DisponibilidadeSala", null)
                        .WithMany("Periodo")
                        .HasForeignKey("DisponibilidadeSalaId");
                });

            modelBuilder.Entity("AgendaSalas.Models.Sala", b =>
                {
                    b.HasOne("AgendaSalas.Models.DisponibilidadeSala", null)
                        .WithMany("Sala")
                        .HasForeignKey("DisponibilidadeSalaId");
                });

            modelBuilder.Entity("AgendaSalas.Models.Servicos", b =>
                {
                    b.HasOne("AgendaSalas.Models.Reserva", null)
                        .WithMany("Servicos")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("AgendaSalas.Models.DisponibilidadeSala", b =>
                {
                    b.Navigation("Periodo");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("AgendaSalas.Models.Periodo", b =>
                {
                    b.Navigation("Horarios");
                });

            modelBuilder.Entity("AgendaSalas.Models.Reserva", b =>
                {
                    b.Navigation("DisponibilidadeSalas");

                    b.Navigation("Equipamentos");

                    b.Navigation("Objetos");

                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("AgendaSalas.Models.Sala", b =>
                {
                    b.Navigation("Localizacao");
                });
#pragma warning restore 612, 618
        }
    }
}
