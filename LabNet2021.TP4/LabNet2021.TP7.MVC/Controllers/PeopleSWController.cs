using LabNet2021.TP7.MVC.Models;
using Newtonsoft.Json;
using StarWarsApiCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LabNet2021.TP7.MVC.Controllers
{
    public class PeopleSWController : Controller
    {
        // GET: PeopleSW
        public async Task<ActionResult> Index()
        {
            try
            {
                string url = "https://swapi.dev/api/people/";
                var httpClient = new HttpClient();
                List<Person> peopleList = new List<Person>();

                for (int i = 1; i <= 15; i++)
                {
                    var json = await httpClient.GetStringAsync(url + i);
                    Person people = JsonConvert.DeserializeObject<Person>(json);
                    peopleList.Add(people);
                }

                List<PeopleSWView> peopleView = peopleList.Select(p => new PeopleSWView()
                {
                    Name = p.Name,
                    Height = p.Height,
                    Eye_color = p.EyeColor,
                    Gender = p.Gender
                }).ToList();

                return View(peopleView);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("~/Views/Error/Index.cshtml");
                throw;
            }
        }

        // GET: PeopleSW
        //public ActionResult Index()
        //{
        //    try
        //    {
        //        var people = new Repository<Person>();
        //        List<Person> peopleList = people.GetEntities(size: int.MaxValue).ToList();

        //        List<PeopleSWView> peopleView = peopleList.Select(p => new PeopleSWView()
        //        {
        //            Name = p.Name,
        //            Height = p.Height,
        //            Eye_color = p.EyeColor,
        //            Gender = p.Gender
        //        }).ToList();

        //        return View(peopleView);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Error = ex.Message;
        //        return View("~/Views/Error/Index.cshtml");
        //        throw;
        //    }
        //}
    }
}
