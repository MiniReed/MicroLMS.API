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
    public class TestLinkRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public TestLinkRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<TestLink>> GetAllAsync()
        {
            return await _context.TestLinks.OrderBy(m => m.Name).ToListAsync();
        }

        public async Task<TestLink> GetByIdAsync(int id)
        {
            return await _context.TestLinks.FindAsync(id);
        }
        public async Task AddAsync(TestLink testLink)
        {
            _context.TestLinks.Add(testLink);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(TestLink testLink)
        {
            var existTestLink = await _context.TestLinks.FindAsync(testLink.Id);
            _context.Entry(existTestLink).CurrentValues.SetValues(testLink);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TestLink>> GetAllByIdDExerAsync(int id)
        {
            List<TestLink> TestLink = new List<TestLink>();

            var testLink = from l in _context.TestLinks where l.exercise.Id.Equals(id) select l;
            return await testLink.ToListAsync();
        }
        public async Task DeleteAsync(int id)
        {
            TestLink testLink = await _context.TestLinks.FindAsync(id);
            _context.Remove(testLink);
            await _context.SaveChangesAsync();
        }

    }
}
