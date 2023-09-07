using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class Student : Person
    {
        public int StudentID { get; set; }
        public decimal GPA { get; set; }
        public string Major { get; set; }
    }
}
