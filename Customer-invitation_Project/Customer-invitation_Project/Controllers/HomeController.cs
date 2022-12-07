using Customer_invitation_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_invitation_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AnswerForm()    //Bu forma görüntülmek için Viewse -> Home altına "AnswerForm" oluşturdum
        {
           
            return View();
        }

        [HttpPost]
        public ViewResult AnswerForm(Answer costumerAnswer)  //Bu forma görüntülmek için Viewse -> Home altına "Thanks" oluşturdum
        {
            if (ModelState.IsValid)
            {
                Repository.SendAnswer(costumerAnswer);          //Burda katılımcıların cevapları döner
                return View("Thanks", costumerAnswer);
            }
            else
            {
                return View();
            }
        }

        //Thanks sayfasındaki Katılımcılardan ComeorNot ="true" yapanları döndür
        public IActionResult ListAnswer()               //Bu forma görüntülmek için Viewse -> Home altına "ListAnswer" oluşturdum
        {
            return View(Repository.Answers.Where(x=>x.ComeorNot==true));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    
    }
}
