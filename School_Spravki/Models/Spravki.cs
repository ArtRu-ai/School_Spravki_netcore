using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Spravki.Models
{
    public class Spravki
    {
        public int ID { get; set; }
        public int Student_ID { get; set; }
        public int User_ID { get; set; }
        public DateTime Date_Created { get; set; }

    }
}
