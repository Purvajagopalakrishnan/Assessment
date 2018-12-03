using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentList.Models
{
    public class StudentsModel
    {
        public List<Student> Students { get; set; }
        public string search { get; set; }
    }
}
