using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMS.Domain
{
    public class ContentURL
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        // Свойства навигации
        public BlockOfExercise blockOfExercise { get; set; }
        public Exercise exercise { get; set; }
    }
}
