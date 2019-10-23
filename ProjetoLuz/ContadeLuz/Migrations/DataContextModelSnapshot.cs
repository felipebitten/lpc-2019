﻿// <auto-generated />
using System;
using ContadeLuz.Models;
using ContaRepository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ContadeLuz.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ContadeLuz.Models.Conta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataLeitura");

                    b.Property<DateTime>("dataPagamento");

                    b.Property<double>("mediaConsumo");

                    b.Property<double>("numeroLeitura");

                    b.Property<double>("qtdKw");

                    b.Property<double>("valorConta");

                    b.HasKey("id");

                    b.ToTable("contas");
                });
#pragma warning restore 612, 618
        }
    }
}