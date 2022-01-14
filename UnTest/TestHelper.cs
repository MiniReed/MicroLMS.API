using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroLMS.Domain;
using MicroLMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MicroLMS.Infrastructure.Repository;

namespace TestProject
{
    public class TestHelper
    {
        private readonly Context _context;
        public TestHelper()
        {
            var builder = new DbContextOptionsBuilder<Context>();
            builder.UseInMemoryDatabase(databaseName: "PersonDB");

            var dbContextOptions = builder.Options;
            _context = new Context(dbContextOptions);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        public ExercisesRepository ExercisesRepository
        {
            get
            {
                return new ExercisesRepository(_context);
            }
        }
        public LessonRepository LessonRepository
        {
            get
            {
                return new LessonRepository(_context);
            }
        }
        public DisciplineRepository DisciplineRepository
        {
            get
            {
                return new DisciplineRepository(_context);
            }
        }
        public BlockOfExerciseRepository BlockOfExerciseRepository
        {
            get
            {
                return new BlockOfExerciseRepository(_context);
            }
        }
        public ContentURLRepository ContentURLRepository
        {
            get
            {
                return new ContentURLRepository(_context);
            }
        }
        public TestLinkRepository TestLinkRepository
        {
            get
            {
                return new TestLinkRepository(_context);
            }
        }
    }
}