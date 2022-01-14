using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MicroLMS.Domain;
using  TestProject;

namespace TestLesson
{
    public class TestLessonRepository
    {
        [Fact]
        public void TestAdd()
        {
            var testHelper = new TestHelper();
            var lessonRepository = testHelper.LessonRepository;

            Lesson lesson = new Lesson { Id = 1, Name = "les1" };
            Discipline discipline = new Discipline { Id = 1, Name = "math" };
            lesson.Discipline = discipline;

            lessonRepository.AddAsync(lesson).Wait();

            Assert.Equal(1, lessonRepository.GetByIdAsync(1).Result.Id);
            Assert.Equal("les1", lessonRepository.GetByIdAsync(1).Result.Name);
            Assert.Equal("math", lessonRepository.GetByIdAsync(1).Result.Discipline.Name);

        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void TestMultipleAdd(int id, int expected)
        {
            var testHelper = new TestHelper();
            var lessonRepository = testHelper.LessonRepository;

            Lesson lesson = new Lesson { Id = id, Name = "les1" };
            Discipline discipline = new Discipline { Id = 1, Name = "math" };
            lesson.Discipline = discipline;

            lessonRepository.AddAsync(lesson).Wait();

            Assert.Equal(expected, lessonRepository.GetByIdAsync(id).Result.Id);
        }
    }
}
