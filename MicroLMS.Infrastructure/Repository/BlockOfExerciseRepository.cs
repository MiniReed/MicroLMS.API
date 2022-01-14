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
   public class BlockOfExerciseRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public BlockOfExerciseRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<BlockOfExercise>> GetAllAsync()
        {
            return await _context.BlockOfExercise.Include(p=>p.Lesson).ToListAsync();
        }

        public async Task<BlockOfExercise> GetByIdAsync(int id)
        {
            return await _context.BlockOfExercise.FindAsync(id);
        }
        public async Task AddAsync(BlockOfExercise blockOfExercise)
        {
            _context.BlockOfExercise.Add(blockOfExercise);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(BlockOfExercise blockOfExercise)
        {
            var existblockOfExercise = await _context.BlockOfExercise.FindAsync(blockOfExercise.Id);
            _context.Entry(existblockOfExercise).CurrentValues.SetValues(blockOfExercise);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            BlockOfExercise blockOfExercise = await _context.BlockOfExercise.FindAsync(id);
            _context.Remove(blockOfExercise);
            await _context.SaveChangesAsync();
        }

        public async Task<List<BlockOfExercise>> GetAllByIdDicAsync(int id)
        {
            List<BlockOfExercise> BlockOfExercises = new List<BlockOfExercise>();

            var BlockOfExercise = from l in _context.BlockOfExercise
                                  where l.Lesson.Id.Equals(id) select l;
            return await BlockOfExercise.ToListAsync();
        }

    }
}
