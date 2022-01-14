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
    public class DisciplineRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public DisciplineRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Discipline>> GetAllAsync()
        {
            return await _context.Disciplines.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Discipline> GetByIdAsync(int id)
        {
            return await _context.Disciplines.FindAsync(id);
        }
        public async Task AddAsync(Discipline discipline)
        {
            _context.Disciplines.Add(discipline);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Discipline Discipline)
        {
            var existDiscipline = await _context.Disciplines.FindAsync(Discipline.Id);
            _context.Entry(existDiscipline).CurrentValues.SetValues(Discipline);
            await _context.SaveChangesAsync();
        }
        
        //переделать и добавить в лессонреп
        public async Task addlessonAsync(Discipline Discipline,Lesson lesson)
        {
            var existDiscipline = await _context.Disciplines.FindAsync(Discipline.Id);
            existDiscipline.Lessons.Add(lesson);
            _context.Entry(existDiscipline).CurrentValues.SetValues(Discipline);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Discipline Discipline = await _context.Disciplines.FindAsync(id);
            _context.Remove(Discipline);
            await _context.SaveChangesAsync();
        }


    }
}
