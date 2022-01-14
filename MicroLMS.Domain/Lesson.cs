
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMS.Domain
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int HourseQuantity { get; set; }
        // Свойства навигации
        //public int? DisciplineId { get; set; }
        public Discipline Discipline { get; set; }

        public List<BlockOfExercise> BlockOfExercises;
    }
}
