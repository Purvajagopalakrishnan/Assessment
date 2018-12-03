using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentList.Models;

namespace StudentList.Controllers
{
    public class CreateController : Controller
    {
        List<Student> stud = new List<Student>() {
                new Student {Name="John", Age=2},
                new Student {Name="Priya", Age=20},
                new Student {Name="Jim", Age=22},
                new Student {Name="Sowmiya", Age=23},
                new Student {Name="Nithya", Age=24},
                new Student {Name="Sree", Age=25},
                new Student {Name="Jack", Age=26},
                new Student {Name="Divya", Age=27},
                new Student {Name="John", Age=28},
                new Student {Name="Sai", Age=29},
                new Student {Name="Riya", Age=30}
                };

        public IActionResult Index()
        {
             
            var studentmodel = new StudentsModel()
            {
                Students = stud
            };
            return View(studentmodel);
        }




        [HttpPost]
        public IActionResult Index(StudentsModel input)
        {
            var element = stud.Where(x => x.Name.Contains(input.search)).ToList();
            var studentmodel = new StudentsModel()
            {
                Students = element
            };
            return View(studentmodel);
        }
   

    }
}