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
    public class ExercisesController : ControllerBase
    {
        private readonly Context _context;
        private readonly ExercisesRepository _ExercisesRepository;
        private readonly BlockOfExerciseRepository _BlockOfExerciseRepository;

        public ExercisesController(Context context)
        {
            _context = context;
            _BlockOfExerciseRepository = new BlockOfExerciseRepository(_context);
            _ExercisesRepository = new ExercisesRepository(context);
        }

        // GET: api/Exercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exercise>>> GetExercises()
        {
            return await _ExercisesRepository.GetAllAsync();
        }

        // GET: api/Exercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exercise>> GetExercise(int id)
        {
            var exercise = await _ExercisesRepository.GetByIdAsync(id);

            if (exercise == null)
            {
                return NotFound();
            }

            return exercise;
        }

        // PUT: api/Exercises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutExercise( Exercise exercise)
        {
            if (exercise.Id == 0)
            {
                return BadRequest();
            }

            await _ExercisesRepository.UpdateAsync(exercise);
            return NoContent();
        }

        // POST: api/Exercises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Exercise>> PostExercise(Exercise exercise)
         {
            BlockOfExercise BlockOfExercise = await 
                _BlockOfExerciseRepository.GetByIdAsync(exercise.blockOfExercises.Id);
            exercise.blockOfExercises = BlockOfExercise;
            await _ExercisesRepository.AddAsync(exercise);
            return CreatedAtAction("GetBlockOfExercise", new { id = exercise.Id }, exercise);
        }

        // DELETE: api/Exercises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExercise(int id)
        {
            var exercise = await _ExercisesRepository.GetByIdAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            await _ExercisesRepository.DeleteAsync(id);

            return NoContent();
        }

        private bool ExerciseExists(int id)
        {
            return _context.Exercises.Any(e => e.Id == id);
        }
    }
}
