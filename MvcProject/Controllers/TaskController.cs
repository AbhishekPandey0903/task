using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using Newtonsoft.Json;

namespace MvcProject.Controllers
{
    public class TaskController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ClassMod> emp = new List<ClassMod>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7258/");

            var res = await client.GetAsync("api/ApiControl/get");
            if (res.IsSuccessStatusCode)
            {
                var Result = res.Content.ReadAsStringAsync().Result;
                emp = JsonConvert.DeserializeObject<List<ClassMod>>(Result);
            }
            return View(emp);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Create(ClassMod mac)
        {
            if (!ModelState.IsValid)
            {

                return View(mac);
            }
            else
            {
               
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7258/");
                var res = client.PostAsJsonAsync<ClassMod>("api/ApiControl/create", mac);
                res.Wait();

                var res1 = res.Result;
                if (res1.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                return View();
            }
        }
        public async Task<IActionResult> Delete(int Id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7258/");
            var res = await client.GetAsync($"api/ApiControl/Delete/{Id}");
            if (res.IsSuccessStatusCode)
            {
                var resu = res.Content.ReadAsStringAsync().Result;
                bool a = JsonConvert.DeserializeObject<bool>(resu);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int Id)
        {
            var student = new ClassMod();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7258/");
            HttpResponseMessage res = await client.GetAsync($"api/ApiControl/Edit/{Id}");
            if (res.IsSuccessStatusCode)
            {
                var Result = res.Content.ReadAsStringAsync().Result;
                student = JsonConvert.DeserializeObject<ClassMod>(Result);
            }
            return View(student);
        }
       


    }
}