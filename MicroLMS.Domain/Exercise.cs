using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MicroLMS.Domain
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int TaskNumber { get; set; }
        public int difficulty { get; set; }
        // Свойства навигации
        public List<ContentURL> content;
        public BlockOfExercise blockOfExercises { get; set; }
        public List<TestLink> test;

    }

    }
