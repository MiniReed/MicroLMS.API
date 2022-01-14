using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MicroLMS.Domain;

namespace MicroLMS.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }

        public DbSet<Discipline> Disciplines { get; set; }
          public DbSet<Lesson> Lessons { get;set;}
         public DbSet<Exercise> Exercises { get; set; }
         public DbSet<BlockOfExercise> BlockOfExercise { get; set; }
         public DbSet<TestLink> TestLinks { get; set; }
         public DbSet<ContentURL> ContentURLs { get; set; }
         public DbSet<ExerciseOptions> ExerciseOption { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}

