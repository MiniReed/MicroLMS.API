using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMS.Domain
{
    public class BlockOfExercise
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Manual { get; set; }
        public string Comments { get; set; }
        // Свойства навигации
        public Lesson Lesson { get; set; }
        public List<Exercise> Exercises;
        public List<ContentURL> Content;
    }
}
