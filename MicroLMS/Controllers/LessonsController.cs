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
    public class LessonsController : ControllerBase
    {
        private readonly Context _context;
        private readonly LessonRepository _lessonRepository;
        private readonly DisciplineRepository _disciplineRepository;
        private readonly BlockOfExerciseRepository _BlockOfExerciseRepository;
        public LessonsController(Context context)
        {
            _context = context;
            _lessonRepository = new LessonRepository(_context);
            _disciplineRepository = new DisciplineRepository(_context);
            _BlockOfExerciseRepository = new BlockOfExerciseRepository(_context);

        }
        // GET: api/Disciplines
        [HttpGet]
       public async Task<ActionResult<IEnumerable<Lesson>>> GetLessons()
        {
            return await _lessonRepository.GetAllAsync();
        }
       

        


        // GET: api/Disciplines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lesson>> GetLesson(int id)
        {
            var lesson = await _lessonRepository.GetByIdAsync(id);

            if (lesson == null)
            {
                return NotFound();
            }

            return lesson;
        }

        [HttpGet("all/{id}")]
        public async Task<ActionResult<IEnumerable<BlockOfExercise>>> GetAllBlockOfExercise(int id)
        {

            return await _BlockOfExerciseRepository.GetAllByIdDicAsync(id);
        }

        // PUT: api/Disciplines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutLesson(int id, Lesson lesson)
        {
            if (lesson.Id == 0)
            {
                return BadRequest();
            }

            await _lessonRepository.UpdateAsync(lesson);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Lesson>> PostLesson(Lesson lesson)
        {
            Discipline discipline = await _disciplineRepository.GetByIdAsync(lesson.Discipline.Id);
            lesson.Discipline = discipline;
            await _lessonRepository.AddAsync(lesson);
            return CreatedAtAction("GetLesson", new { id = lesson.Id }, lesson);
        }


        // DELETE: api/Disciplines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscipline(int id)
        {
            // var discipline = await _context.Disciplines.FindAsync(id);
            var lesson = await _lessonRepository.GetByIdAsync(id);
            if (lesson == null)
            {
                return NotFound();
            }

            //_context.Disciplines.Remove(discipline);
            //await _context.SaveChangesAsync();
            await _lessonRepository.DeleteAsync(id);

            return NoContent();
        }

        private bool DisciplineExists(int id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }
    }
}
