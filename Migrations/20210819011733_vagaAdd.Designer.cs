﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto_gama_jobsnet.Servicos;

namespace projeto_gama_jobsnet.Migrations
{
    [DbContext(typeof(DbContexto))]
    [Migration("20210819011733_vagaAdd")]
    partial class vagaAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("projeto_gama_jobsnet.Models.Candidato", b =>
                {
                    b.Property<int>("CandidatoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("candidato_id")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<string>("Cpf")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("EmailCandidato")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("endereco");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("estado_civil");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("genero");

                    b.Property<string>("NomeCandidato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("numero");

                    b.Property<bool>("PossuiVeiculo")
                        .HasColumnType("bit")
                        .HasColumnName("possui_veiculo");

                    b.Property<string>("RG")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("rg");

                    b.Property<string>("TelefoneFixo")
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("telefone_fixo");

                    b.Property<string>("TelefoneMovel")
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("telefone_movel");

                    b.Property<string>("TipoHabilitacao")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("habilitacao");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("uf");

                    b.Property<int>("VagaId")
                        .HasColumnType("int")
                        .HasColumnName("vaga_id");

                    b.HasKey("CandidatoId");

                    b.HasIndex("VagaId");

                    b.ToTable("candidatos");
                });

            modelBuilder.Entity("projeto_gama_jobsnet.Models.Vaga", b =>
                {
                    b.Property<int>("VagaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("vaga_id")
                        .UseIdentityColumn();

                    b.Property<string>("DescricaoVaga")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao_vaga");

                    b.Property<string>("NomeVaga")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("vaga");

                    b.HasKey("VagaId");

                    b.ToTable("vagas");
                });

            modelBuilder.Entity("projeto_gama_jobsnet.Models.Candidato", b =>
                {
                    b.HasOne("projeto_gama_jobsnet.Models.Vaga", "Cargo")
                        .WithMany()
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });
#pragma warning restore 612, 618
        }
    }
}
