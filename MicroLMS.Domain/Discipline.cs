using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMS.Domain
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Свойства навигации
        public List<Lesson> Lessons;


    }
}
