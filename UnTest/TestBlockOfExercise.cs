using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MicroLMS.Domain;
using TestProject;

namespace TestBlockOfExercise
{
    public class TestBlockOfExerciseRepository
    {
        [Fact]
        public void TestAdd()
        {
            var testHelper = new TestHelper();
            var BlockOfExerciseRepository = testHelper.BlockOfExerciseRepository;

            BlockOfExercise BlockOfExercise = new BlockOfExercise
            {
                Id = 1,
                Type = "type1",
                SubType = "SubType1",
                Manual = "Manual1",
                Comments = "Comments1",
                Exercises = new List<Exercise>(),
                Content = new List<ContentURL>(),
            };
            BlockOfExerciseRepository.AddAsync(BlockOfExercise).Wait();

            Assert.Equal(1, BlockOfExerciseRepository.GetByIdAsync(1).Result.Id);
            Assert.Equal("type1", BlockOfExerciseRepository.GetByIdAsync(1).Result.Type);
        }
        
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void TestMultipleAdd(int id, int expected)
        {
            var testHelper = new TestHelper();
            var BlockOfExerciseRepository = testHelper.BlockOfExerciseRepository;

            BlockOfExercise BlockOfExercise = new BlockOfExercise
            {
                Id = id,
                Type = "type1",
                SubType = "SubType1",
                Manual = "Manual1",
                Comments = "Comments1",
                Exercises = new List<Exercise>(),
                Content = new List<ContentURL>(),
            };
            BlockOfExerciseRepository.AddAsync(BlockOfExercise).Wait();

            Assert.Equal(expected, BlockOfExerciseRepository.GetByIdAsync(id).Result.Id);
        }
        
    }
}
