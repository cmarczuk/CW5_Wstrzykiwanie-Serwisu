// <auto-generated />
using System;
using CW5_Wstrzykiwanie_Serwisu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CW5_Wstrzykiwanie_Serwisu.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210418160955_InitSchema")]
    partial class InitSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CW5_Wstrzykiwanie_Serwisu.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(99)")
                        .HasMaxLength(99);

                    b.Property<string>("Id_json")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Maker")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(99)")
                        .HasMaxLength(99);

                    b.Property<string>("Url")
                        .HasColumnType("varchar(99)")
                        .HasMaxLength(99);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CW5_Wstrzykiwanie_Serwisu.Models.Product", b =>
                {
                    b.HasOne("CW5_Wstrzykiwanie_Serwisu.Models.Product", null)
                        .WithMany("Products")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
