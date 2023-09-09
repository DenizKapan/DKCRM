using DKCRM.Core.Entities;
using DKCRM.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DKCRM.UI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class UserController : Controller
    {
        private readonly IService<User> _service;

        public UserController(IService<User> service)
        {
            _service = service;
        }

        // GET: UserController
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User collection)
        {
            try
            {
                _service.Add(collection);
				await _service.SaveAsync();
				return RedirectToAction(nameof(Index));
			}
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
			var model = await _service.FindAsync(id);
			return View(model);
		}

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, User collection)
        {
            try
            {
				_service.Update(collection);
				await _service.SaveAsync();
				return RedirectToAction(nameof(Index));
			}
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
			var model = await _service.FindAsync(id);
			return View(model);
		}

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, User collection)
        {
            try
            {
				_service.Delete(collection);
				await _service.SaveAsync();
				return RedirectToAction(nameof(Index));
			}
            catch
            {
                return View();
            }
        }
    }
}
