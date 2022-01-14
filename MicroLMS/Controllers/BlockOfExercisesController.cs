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
    public class BlockOfExercisesController : ControllerBase
    {
        private readonly Context _context;
        private readonly BlockOfExerciseRepository _BlockOfExerciseRepository;
        private readonly LessonRepository _LessonRepository;
        private readonly ExercisesRepository _ExercisesRepository;
        public BlockOfExercisesController(Context context)
        {
            _context = context;
            _BlockOfExerciseRepository = new BlockOfExerciseRepository(_context);
            _LessonRepository = new LessonRepository(context);
            _ExercisesRepository = new ExercisesRepository(context);
        }
        // GET: api/Disciplines
        [HttpGet]
       public async Task<ActionResult<IEnumerable<BlockOfExercise>>> GetBlockOfExercise()
        {
            return await _BlockOfExerciseRepository.GetAllAsync();
        }
       

        


        // GET: api/Disciplines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BlockOfExercise>> GetBlockOfExercise(int id)
        {
            var BlockOfExercise = await _BlockOfExerciseRepository.GetByIdAsync(id);

            if (BlockOfExercise == null)
            {
                return NotFound();
            }

            return BlockOfExercise;
        }

        [HttpGet("all/{id}")]
        public async Task<ActionResult<IEnumerable<Exercise>>> GetAllExercises(int id)
        {

            return await _ExercisesRepository.GetAllByIdDicAsync(id);
        }


        // PUT: api/Disciplines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutBlockOfExercise(BlockOfExercise BlockOfExercise)
        {
            if (BlockOfExercise.Id == 0)
            {
                return BadRequest();
            }

            await _BlockOfExerciseRepository.UpdateAsync(BlockOfExercise);
            return NoContent();
        }

            // POST: api/Disciplines
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
        public async Task<ActionResult<BlockOfExercise>> PostBlockOfExercise(BlockOfExercise BlockOfExercise)
        {
            Lesson lesson = await _LessonRepository.GetByIdAsync(BlockOfExercise.Lesson.Id);
            BlockOfExercise.Lesson = lesson;
            await _BlockOfExerciseRepository.AddAsync(BlockOfExercise);
            return CreatedAtAction("GetBlockOfExercise", new { id = BlockOfExercise.Id }, BlockOfExercise);
        }


        // DELETE: api/Disciplines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlockOfExercise(int id)
        {
            // var discipline = await _context.Disciplines.FindAsync(id);
            var BlockOfExercise = await _BlockOfExerciseRepository.GetByIdAsync(id);
            if (BlockOfExercise == null)
            {
                return NotFound();
            }

            //_context.Disciplines.Remove(discipline);
            //await _context.SaveChangesAsync();
            await _BlockOfExerciseRepository.DeleteAsync(id);

            return NoContent();
        }

        private bool BlockOfExerciseExists(int id)
        {
            return _context.BlockOfExercise.Any(e => e.Id == id);
        }
    }
}
