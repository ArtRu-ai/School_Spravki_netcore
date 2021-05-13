using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Spravki.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public int StudyYear { get; set; }

        public int StartYear { get; set; }

        public Char Litera { get; set; }
    }
}
