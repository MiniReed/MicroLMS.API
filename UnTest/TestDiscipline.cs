using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MicroLMS.Domain;
using TestProject;

namespace TestProject1
{
    public class TestPersonRepository
    {
        [Fact]
        public void TestAdd()
        {
            var testHelper = new TestHelper();
            var disciplineRepository = testHelper.DisciplineRepository;

            Discipline discipline = new Discipline { Id = 1, Name = "math" };
            disciplineRepository.AddAsync(discipline).Wait();

            Assert.Equal(1, disciplineRepository.GetByIdAsync(1).Result.Id);
            Assert.Equal("math", disciplineRepository.GetByIdAsync(1).Result.Name);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void TestMultipleAdd(int id, int expected)
        {
            var testHelper = new TestHelper();
            var disciplineRepository = testHelper.DisciplineRepository;

            Discipline discipline = new Discipline { Id = id, Name = "Nic" };
            disciplineRepository.AddAsync(discipline).Wait();

            Assert.Equal(expected, disciplineRepository.GetByIdAsync(id).Result.Id);
        }
    }
}
