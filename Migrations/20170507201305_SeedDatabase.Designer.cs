using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AracTescil.Persistence;

namespace AracTescil.Migrations
{
    [DbContext(typeof(AracTescilDbContext))]
    [Migration("20170507201305_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AracTescil.Models.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Markalar");
                });

            modelBuilder.Entity("AracTescil.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("MarkaId");

                    b.HasKey("Id");

                    b.HasIndex("MarkaId");

                    b.ToTable("Modeller");
                });

            modelBuilder.Entity("AracTescil.Models.Model", b =>
                {
                    b.HasOne("AracTescil.Models.Marka", "Marka")
                        .WithMany("Modeller")
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
