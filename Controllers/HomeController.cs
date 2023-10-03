using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {

        /*var client = new HttpClient();
        client.BaseAddress = new Uri("http://cache-service/Cache");*/
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public void Add(int leftNumber, int rightNumber)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://additionservice/");

            client.PostAsync(client.BaseAddress + "?leftNumber=" + leftNumber + "&rightNumber=" + rightNumber, null);
            Console.WriteLine("Added " + leftNumber + " + " + rightNumber);
        }

        public void Subtract(int leftNumber, int rightNumber)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://subtractionservice");

            client.PostAsync(client.BaseAddress + "?leftNumber=" + leftNumber + "&rightNumber=" + rightNumber, null);
            Console.WriteLine("subtracted " + leftNumber + " + " + rightNumber);

        }
    }
}
