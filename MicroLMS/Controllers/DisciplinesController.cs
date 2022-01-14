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
    public class DisciplinesController : ControllerBase
    {
        private readonly Context _context;
        private readonly DisciplineRepository _disciplineRepository;
        private readonly LessonRepository _lessonRepository;
        public DisciplinesController(Context context)
        {
            _context = context;
            _disciplineRepository = new DisciplineRepository(_context);
            _lessonRepository = new LessonRepository(_context);
        }
        // GET: api/Disciplines
        [HttpGet]
       public async Task<ActionResult<IEnumerable<Discipline>>> GetDisciplines()
        {
            return await _disciplineRepository.GetAllAsync();
        }
       

        


        // GET: api/Disciplines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Discipline>> GetDiscipline(int id)
        {
            var discipline = await _disciplineRepository.GetByIdAsync(id);

            if (discipline == null)
            {
                return NotFound();
            }

            return discipline;
        }
         [HttpGet("all/{id}")]
        public async Task<ActionResult<IEnumerable<Lesson>>> GetAllDiscipline(int id)
        {
            
            return  await _lessonRepository.GetAllByIdDicAsync(id);
        } 

        // PUT: api/Disciplines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutDiscipline(Discipline discipline)
        {
            if (discipline.Id == 0)
            {
                return BadRequest();
            }

            await _disciplineRepository.UpdateAsync(discipline);
            return NoContent();
        }

        // POST: api/Disciplines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Discipline>> PostDiscipline(Discipline discipline)
        {
            await _disciplineRepository.AddAsync(discipline);
            return CreatedAtAction("GetDiscipline", new { id = discipline.Id }, discipline);
        }


        // DELETE: api/Disciplines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscipline(int id)
        {
            var discipline = await _disciplineRepository.GetByIdAsync(id);
            if (discipline == null)
            {
                return NotFound();
            }

            await _disciplineRepository.DeleteAsync(id);

            return NoContent();
        }

        private bool DisciplineExists(int id)
        {
            return _context.Disciplines.Any(e => e.Id == id);
        }
    }
}
