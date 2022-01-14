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
    public class ContentURLController : ControllerBase
    {
        private readonly Context _context;
        private readonly ContentURLRepository ContentURLRepository;
        private readonly BlockOfExerciseRepository  blockOfExerciseRepository;
        private readonly ExercisesRepository exercisesRepository;
        public ContentURLController(Context context)
        {
            _context = context;
            ContentURLRepository = new ContentURLRepository(_context);
            blockOfExerciseRepository = new BlockOfExerciseRepository(context);
            exercisesRepository = new ExercisesRepository(context);

        }
        // GET: api/Disciplines
        [HttpGet]
       public async Task<ActionResult<IEnumerable<ContentURL>>> GetContentURL()
        {
            return await ContentURLRepository.GetAllAsync();
        }
       

        


        // GET: api/Disciplines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContentURL>> GetContentURL(int id)
        {
            var ContentURL = await ContentURLRepository.GetByIdAsync(id);

            if (ContentURL == null)
            {
                return NotFound();
            }

            return ContentURL;
        }

        [HttpGet("all/{id}")]
        public async Task<ActionResult<IEnumerable<ContentURL>>> GetAllBlockOfExercise(int id)
        {

            return await ContentURLRepository.GetAllByIdDBlockAsync(id);
        }

        [HttpGet("allEx/{id}")]
        public async Task<ActionResult<IEnumerable<ContentURL>>> GetAllExerOfExercise(int id)
        {

            return await ContentURLRepository.GetAllByIdDExerAsync(id);
        }

        // PUT: api/Disciplines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutContentURL(ContentURL ContentURL)
        {
            if (ContentURL.Id == 0)
            {
                return BadRequest();
            }

            await ContentURLRepository.UpdateAsync(ContentURL);
            return NoContent();
        }

        // POST: api/Disciplines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContentURL>> PostContentURL(ContentURL ContentURL)
        {
            if (ContentURL.blockOfExercise != null)
            {
                BlockOfExercise blockOfExercise = await blockOfExerciseRepository.GetByIdAsync(ContentURL.blockOfExercise.Id);
                ContentURL.blockOfExercise = blockOfExercise;
            }
            else
                if
                (ContentURL.exercise != null)
                {
                    Exercise exercise = await exercisesRepository.GetByIdAsync(ContentURL.exercise.Id);
                ContentURL.exercise = exercise;
            }   
            await ContentURLRepository.AddAsync(ContentURL);

            return CreatedAtAction("GetContentURL", new { id = ContentURL.Id }, ContentURL);
        }


        // DELETE: api/Disciplines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContentURL(int id)
        {
            var ContentURL = await ContentURLRepository.GetByIdAsync(id);
            if (ContentURL == null)
            {
                return NotFound();
            }

            //_context.Disciplines.Remove(discipline);
            //await _context.SaveChangesAsync();
            await ContentURLRepository.DeleteAsync(id);

            return NoContent();
        }

        private bool ContentURLExists(int id)
        {
            return _context.ContentURLs.Any(e => e.Id == id);
        }
    }
}
