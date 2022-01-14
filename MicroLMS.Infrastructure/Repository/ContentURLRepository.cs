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
    public class ContentURLRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public ContentURLRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<ContentURL>> GetAllAsync()
        {
            return await _context.ContentURLs.OrderBy(p => p.Id).ToListAsync();
        }
        public async Task<ContentURL> GetByIdAsync(int id)
        {
            return await _context.ContentURLs.FindAsync(id);
        }
        public async Task AddAsync(ContentURL ContentURL)
        {
            _context.ContentURLs.Add(ContentURL);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(ContentURL ContentURL)
        {
            var existContentURL = await _context.ContentURLs.FindAsync(ContentURL.Id);
            _context.Entry(existContentURL).CurrentValues.SetValues(ContentURL);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ContentURL>> GetAllByIdDBlockAsync(int id)
        {
            List<ContentURL> ContentURLs = new List<ContentURL>();

            var contentURL = from l in _context.ContentURLs where l.blockOfExercise.Id.Equals(id) select l;
            return await contentURL.ToListAsync();
        }

        public async Task<List<ContentURL>> GetAllByIdDExerAsync(int id)
        {
            List<ContentURL> ContentURLs = new List<ContentURL>();

            var contentURL = from l in _context.ContentURLs where l.exercise.Id.Equals(id) select l;
            return await contentURL.ToListAsync();
        }
        public async Task DeleteAsync(int id)
        {
            ContentURL ContentURL = await _context.ContentURLs.FindAsync(id);
            _context.Remove(ContentURL);
            await _context.SaveChangesAsync();
        }

    }
}
