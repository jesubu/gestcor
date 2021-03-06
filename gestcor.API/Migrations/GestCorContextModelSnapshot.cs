﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gestcor.API.Data;

namespace gestcor.API.Migrations
{
    [DbContext(typeof(GestCorContext))]
    partial class GestCorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gestcor.api.Entidades.GastosEntity", b =>
                {
                    b.Property<int>("IdGasto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gasto");

                    b.HasKey("IdGasto");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("gestcor.api.Entidades.TipoGastosEntity", b =>
                {
                    b.Property<int>("IdTipoGasto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoGasto");

                    b.HasKey("IdTipoGasto");

                    b.ToTable("TipoGastos");
                });
#pragma warning restore 612, 618
        }
    }
}
