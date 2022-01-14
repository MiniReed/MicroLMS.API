using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MicroLMS.Domain;
using  TestProject;

namespace TestURL
{
    public class TestLinkRepository
    {
        [Fact]
        public void TestAdd()
        {
            var testHelper = new TestHelper();
            var TestLinkRepository = testHelper.TestLinkRepository;

            TestLink TestLink = new TestLink { Id = 1, Name = "name1", URL="URL1" };

            TestLinkRepository.AddAsync(TestLink).Wait();

            Assert.Equal(1, TestLinkRepository.GetByIdAsync(1).Result.Id);
            Assert.Equal("name1", TestLinkRepository.GetByIdAsync(1).Result.Name);

        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void TestMultipleAdd(int id, int expected)
        {
            var testHelper = new TestHelper();
            var TestLinkRepository = testHelper.TestLinkRepository;

            TestLink TestLink = new TestLink { Id = id, Name = "name1", URL = "URL1" };

            TestLinkRepository.AddAsync(TestLink).Wait();

            Assert.Equal(expected, TestLinkRepository.GetByIdAsync(id).Result.Id);
        }
    }
}
