using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MicroLMS.Domain;
using TestProject;

namespace TestProject4
{
    public class TestExercisesRepository
    {
        [Fact]
        public void TestAdd()
        {
            var testHelper = new TestHelper();
            var exercisesRepository = testHelper.ExercisesRepository;

            Exercise exercise = new Exercise
            {
                Id = 1,
                Type = "test",
                TaskNumber = 2,
                difficulty = 2,
                blockOfExercises = new BlockOfExercise(),
                content = new List<ContentURL>(),
                test = new List<TestLink>()
            };
            exercisesRepository.AddAsync(exercise).Wait();

            Assert.Equal(1, exercisesRepository.GetByIdAsync(1).Result.Id);
            Assert.Equal("test", exercisesRepository.GetByIdAsync(1).Result.Type);
        }
        
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void TestMultipleAdd(int id, int expected)
        {
            var testHelper = new TestHelper();
            var exercisesRepository = testHelper.ExercisesRepository;

            Exercise exercise = new Exercise
            {
                Id = id,
                Type = "test",
                TaskNumber = 2,
                difficulty = 2,
                blockOfExercises = new BlockOfExercise(),
                content = new List<ContentURL>(),
                test = new List<TestLink>()
            };
            exercisesRepository.AddAsync(exercise).Wait();

            Assert.Equal(expected, exercisesRepository.GetByIdAsync(id).Result.Id);
        }
        
    }
}
