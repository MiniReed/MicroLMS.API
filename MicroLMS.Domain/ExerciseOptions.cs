using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MicroLMS.Domain
{
    public class ExerciseOptions
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Difficulty { get; set; }

        // Свойства навигации
        public List<ContentURL> content;
        public Exercise Exercise { get; set; }
    }
}
