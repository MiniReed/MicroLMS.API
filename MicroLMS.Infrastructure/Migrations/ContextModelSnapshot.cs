// <auto-generated />
using System;
using MicroLMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroLMS.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicroLMS.Domain.BlockOfExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Manual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("BlockOfExercise");
                });

            modelBuilder.Entity("MicroLMS.Domain.ContentURL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("blockOfExerciseId")
                        .HasColumnType("int");

                    b.Property<int?>("exerciseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("blockOfExerciseId");

                    b.HasIndex("exerciseId");

                    b.ToTable("ContentURLs");
                });

            modelBuilder.Entity("MicroLMS.Domain.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("MicroLMS.Domain.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TaskNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("blockOfExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("difficulty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("blockOfExercisesId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("MicroLMS.Domain.ExerciseOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int?>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseOption");
                });

            modelBuilder.Entity("MicroLMS.Domain.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("HourseQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("MicroLMS.Domain.TestLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("exerciseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("exerciseId");

                    b.ToTable("TestLinks");
                });

            modelBuilder.Entity("MicroLMS.Domain.BlockOfExercise", b =>
                {
                    b.HasOne("MicroLMS.Domain.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("MicroLMS.Domain.ContentURL", b =>
                {
                    b.HasOne("MicroLMS.Domain.BlockOfExercise", "blockOfExercise")
                        .WithMany()
                        .HasForeignKey("blockOfExerciseId");

                    b.HasOne("MicroLMS.Domain.Exercise", "exercise")
                        .WithMany()
                        .HasForeignKey("exerciseId");

                    b.Navigation("blockOfExercise");

                    b.Navigation("exercise");
                });

            modelBuilder.Entity("MicroLMS.Domain.Exercise", b =>
                {
                    b.HasOne("MicroLMS.Domain.BlockOfExercise", "blockOfExercises")
                        .WithMany()
                        .HasForeignKey("blockOfExercisesId");

                    b.Navigation("blockOfExercises");
                });

            modelBuilder.Entity("MicroLMS.Domain.ExerciseOptions", b =>
                {
                    b.HasOne("MicroLMS.Domain.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("MicroLMS.Domain.Lesson", b =>
                {
                    b.HasOne("MicroLMS.Domain.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId");

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("MicroLMS.Domain.TestLink", b =>
                {
                    b.HasOne("MicroLMS.Domain.Exercise", "exercise")
                        .WithMany()
                        .HasForeignKey("exerciseId");

                    b.Navigation("exercise");
                });
#pragma warning restore 612, 618
        }
    }
}
