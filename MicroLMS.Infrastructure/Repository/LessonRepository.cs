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
    public class LessonRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public LessonRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Lesson>> GetAllAsync()
        {   
            return await _context.Lessons.Include(p=>p.Discipline).ToListAsync();
        }

        public async Task<Lesson> GetByIdAsync(int id)
        {
          
            Lesson lesson = await _context.Lessons.FindAsync(id);

            return lesson;
        }
        public async Task<List<Lesson>> GetAllByIdDicAsync(int id)
        {
            List < Lesson > lessons = new List<Lesson>();

            var lessond = from l in _context.Lessons where l.Discipline.Id.Equals(id) select l;
            return await lessond.ToListAsync();
        }
        public async Task AddAsync(Lesson lesson)
        {
            _context.Lessons.Add(lesson);

            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Lesson lesson)
        {
            var existlesson = await _context.Lessons.FindAsync(lesson.Id);
            _context.Entry(existlesson).CurrentValues.SetValues(lesson);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Lesson lesson = await _context.Lessons.FindAsync(id);
            _context.Remove(lesson);
            await _context.SaveChangesAsync();
        }


    }
}
