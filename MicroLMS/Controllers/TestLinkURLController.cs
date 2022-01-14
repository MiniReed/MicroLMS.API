using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MicroLMS.Domain;
using MicroLMS.Infrastructure;
using MicroLMS.Infrastructure.Repository;

namespace MicroLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestLinkController : ControllerBase
    {
        private readonly Context _context;
        private readonly TestLinkRepository TestLinkRepository;
        private readonly ExercisesRepository exercisesRepository;
        public TestLinkController(Context context)
        {
            _context = context;
            TestLinkRepository = new TestLinkRepository(_context);
            exercisesRepository = new ExercisesRepository(context);
        }
        // GET: api/Disciplines
        [HttpGet]
       public async Task<ActionResult<IEnumerable<TestLink>>> GetTestLink()
        {
            return await TestLinkRepository.GetAllAsync();
        }
       

        


        // GET: api/Disciplines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestLink>> GetTestLink(int id)
        {
            var TestLink = await TestLinkRepository.GetByIdAsync(id);

            if (TestLink == null)
            {
                return NotFound();
            }

            return TestLink;
        }


        [HttpGet("all/{id}")]
        public async Task<ActionResult<IEnumerable<TestLink>>> GetAllExer(int id)
        {

            return await TestLinkRepository.GetAllByIdDExerAsync(id);
        }

        // PUT: api/Disciplines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutTestLink( TestLink TestLink)
        {
            if (TestLink.Id == 0)
            {
                return BadRequest();
            }

            await TestLinkRepository.UpdateAsync(TestLink);
            return NoContent();
        }

        // POST: api/Disciplines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestLink>> PostTestLink(TestLink TestLink)
        {
            Exercise exercise = await exercisesRepository.GetByIdAsync(TestLink.exercise.Id);
            TestLink.exercise = exercise;
            await TestLinkRepository.AddAsync(TestLink);

            return CreatedAtAction("GetTestLink", new { id = TestLink.Id }, TestLink);
        }


        // DELETE: api/Disciplines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestLink(int id)
        {
            var TestLink = await TestLinkRepository.GetByIdAsync(id);
            if (TestLink == null)
            {
                return NotFound();
            }

            await TestLinkRepository.DeleteAsync(id);

            return NoContent();
        }

        private bool TestLinkExists(int id)
        {
            return _context.TestLinks.Any(e => e.Id == id);
        }
    }
}
