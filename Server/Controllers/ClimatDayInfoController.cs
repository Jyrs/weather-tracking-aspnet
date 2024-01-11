using Microsoft.AspNetCore.Http;
using WeatherApp.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Infrastructure.Data;
using AutoMapper;
using WeatherApp.AppCore.DTO;

namespace WeatherApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClimatDayInfoController : Controller
    {
        private readonly ClimatDayInfo_Repository _climatDayInfo_Repository;

        public ClimatDayInfoController(Context context, IMapper mapper)
        {
            _climatDayInfo_Repository = new ClimatDayInfo_Repository(context, mapper);
        }

        // GET
        [HttpGet]
        public async Task<List<ClimatDayInfoDTO>> Get()
        {
            return await _climatDayInfo_Repository.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ClimatDayInfoDTO> Get(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

        [HttpPost("{id}")]
        public async Task<ClimatDayInfoDTO> Post(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task<ClimatDayInfoDTO> Delete(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }


        //// GET: ClimatDayInfoController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ClimatDayInfoController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ClimatDayInfoController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ClimatDayInfoController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ClimatDayInfoController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ClimatDayInfoController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ClimatDayInfoController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
