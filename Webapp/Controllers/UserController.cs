﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Webapp.Helper;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class UserController : Controller
    {
        Initial apiConnect =  new Initial();
       
        public async  Task< IActionResult> Index()
        {
            List<StudentModel> students = new List<StudentModel>();
            HttpClient client =  apiConnect.init();
            HttpResponseMessage res = await client.GetAsync("/api/User/getall");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<StudentModel>>(result);
            }
            return View(students);
        }
    }
}
