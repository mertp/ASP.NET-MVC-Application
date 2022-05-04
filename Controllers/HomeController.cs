using System;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController:Controller
    {
        //localhost:5000/home/index

    public IActionResult Index(){  //view geri dönüş türü
        int saat=DateTime.Now.Hour;
        ViewBag.Greeting=saat>=12 ? "İyi Günler " : "Günaydın"; 
        ViewBag.UserName="Deniz";
        return View();
    }


    

    public IActionResult about(){
        return View();
    }

    }
}