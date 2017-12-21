using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MVCCore2.Models;

namespace MVCCore2.Migrations
{
    [DbContext(typeof(PsiContext))]
    partial class PsiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCCore2.Models.Pas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatRod");

                    b.Property<string>("Ime");

                    b.Property<int>("VrstaId");

                    b.HasKey("Id");

                    b.HasIndex("VrstaId");

                    b.ToTable("Pas");
                });

            modelBuilder.Entity("MVCCore2.Models.Vrsta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Vrsta");
                });

            modelBuilder.Entity("MVCCore2.Models.Pas", b =>
                {
                    b.HasOne("MVCCore2.Models.Vrsta", "Vrsta")
                        .WithMany()
                        .HasForeignKey("VrstaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
