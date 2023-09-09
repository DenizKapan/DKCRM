using DKCRM.Core.Entities;
using DKCRM.Service.Abstract;
using DKCRM.Service.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DKCRM.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DistrictsController : Controller
    {
        private readonly IService<District> _serviceDistrict;
        private readonly IService<City> _serviceCity;

        public DistrictsController(IService<District> serviceDistrict, IService<City> serviceCity)
        {
            _serviceDistrict = serviceDistrict;
            _serviceCity = serviceCity;
        }

        // GET: DistrictsController
        public async Task<ActionResult> Index()
        {
            var model = await _serviceDistrict.GetAllAsync();
            return View(model);
            return View();
        }

        // GET: DistrictsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DistrictsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DistrictsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DistrictsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DistrictsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DistrictsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DistrictsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
