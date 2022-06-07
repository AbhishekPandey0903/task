using Microsoft.AspNetCore.Mvc;
using ApiTask1.Models;
using ApiTask1.Repository;

namespace ApiTask1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class ApiControl : Controller
    {
        private ITaskRepository tasRepo = null;

        public ApiControl(ITaskRepository _tasRepo)
        {
            tasRepo = _tasRepo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var a = tasRepo.Get();
            return Ok(a);
        }
        [HttpPost]
        public IActionResult Create(ModApi mod)
        {
            var a = tasRepo.Create(mod);
            return Ok(a);
        }
        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            var a = tasRepo.Edit(id);
            return Ok(a);
        }
        
        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            tasRepo.Delete(id);
            return Ok();
        }

    }
}
