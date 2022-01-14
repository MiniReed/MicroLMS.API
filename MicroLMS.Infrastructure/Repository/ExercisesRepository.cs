using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroLMS.Domain;
using Microsoft.EntityFrameworkCore;
using MicroLMS.Infrastructure;

namespace MicroLMS.Infrastructure.Repository
{
   public class ExercisesRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public ExercisesRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Exercise>> GetAllAsync()
        {
            return await _context.Exercises.Include(p=>p.blockOfExercises).ToListAsync();
        }

        public async Task<Exercise> GetByIdAsync(int id)
        {
            return await _context.Exercises.FindAsync(id);
        }
        public async Task AddAsync(Exercise Exercise)
        {
            _context.Exercises.Add(Exercise);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Exercise Exercise)
        {
            var existExercise = await _context.Exercises.FindAsync(Exercise.Id);
            _context.Entry(existExercise).CurrentValues.SetValues(Exercise);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Exercise Exercise = await _context.Exercises.FindAsync(id);
            _context.Remove(Exercise);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Exercise>> GetAllByIdDicAsync(int id)
        {
            List<Exercise> Exercises = new List<Exercise>();

            var Exercise = from l in _context.Exercises
                            where l.blockOfExercises.Id.Equals(id)
                                  select l;
            return await Exercise.ToListAsync();
        }
    }
}
