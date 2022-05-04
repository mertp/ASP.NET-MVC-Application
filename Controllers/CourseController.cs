using System.Linq;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class CourseController:Controller
    {
        //localhost:5000/course/index

        public IActionResult Index(){
            return View();
        }

        //localhost:5000/course/list
        public IActionResult List(){

            var std=Repository.Students.Where(i=> i.confirm==true);
            return View(std);
        }

        public IActionResult Details(){
            var NewCourse=new Course();
            NewCourse.name="ASP.NET CORE";
            NewCourse.description="Good Course";
            NewCourse.isPublished=true;

            return View(NewCourse);
        }

        [HttpGet]  //localhost:5000/course/apply
        public IActionResult Apply(){
        return View();
    }

    [HttpPost]
    public IActionResult Apply(Student std){
       
       if(ModelState.IsValid){
            Repository.AddStudent(std);
            return View("Thanks",std);
       }
       else{
           return View(std);
       }
        
    }
}
}
