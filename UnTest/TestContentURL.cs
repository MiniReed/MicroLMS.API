using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MicroLMS.Domain;
using  TestProject;

namespace TestContentURL
{
    public class TestContentURLRepository
    {
        [Fact]
        public void TestAdd()
        {
            var testHelper = new TestHelper();
            var ContentURLRepository = testHelper.ContentURLRepository;

            ContentURL ContentURL = new ContentURL { Id = 1, Type = "typ1", URL="URL1" };

            ContentURLRepository.AddAsync(ContentURL).Wait();

            Assert.Equal(1, ContentURLRepository.GetByIdAsync(1).Result.Id);
            Assert.Equal("typ1", ContentURLRepository.GetByIdAsync(1).Result.Type);

        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void TestMultipleAdd(int id, int expected)
        {
            var testHelper = new TestHelper();
            var ContentURLRepository = testHelper.ContentURLRepository;

            ContentURL ContentURL = new ContentURL { Id = id, Type = "typ1", URL = "URL1" };

            ContentURLRepository.AddAsync(ContentURL).Wait();

            Assert.Equal(expected, ContentURLRepository.GetByIdAsync(id).Result.Id);
        }
    }
}
