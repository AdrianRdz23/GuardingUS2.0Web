using GuardingUS2._0.DataAccess;
using GuardingUS2._0.DataAccess.Repository.IRepository;
using GuardingUS2._0.Models;
using GuardingUS2._0.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GuardingUS2._0Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        //private readonly ApplicationDbContext _db;

        private readonly IUnitOfWork _unitOfWork;
        //private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_hostEnvironment = hostEnvironment;
        }

        public IActionResult Homes()
        {
            return View();
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            HomeVM homeVM = new()
            {
                Home = new(),
                UserList = _unitOfWork.ApplicationUser.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            if (id == null || id == 0)
            {

                return View(homeVM);
            }
            else
            {
                homeVM.Home = _unitOfWork.Home.GetFirstOrDefault(u => u.Id == id);
                //update product

            }

            return View(homeVM);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(HomeVM obj)
        {

            if (ModelState.IsValid)
            {
                if (obj.Home.Id == 0)
                {
                    _unitOfWork.Home.Add(obj.Home);
                    _unitOfWork.Save();
                    TempData["success"] = "Product created successfully";
                }
                else
                {
                    _unitOfWork.Home.Update(obj.Home);
                    _unitOfWork.Save();
                    TempData["success"] = "Product updated successfully";
                }

                return RedirectToAction("Homes");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var homeFromDbFirst = _unitOfWork.Home.GetFirstOrDefault(c => c.Id == id);

            if (homeFromDbFirst == null)
            {
                return NotFound();
            }
            return View(homeFromDbFirst);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Home obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Home.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Home edited successfully";

                return RedirectToAction("Homes");
            }
            return View(obj);
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
             var homeList = _unitOfWork.Home.GetAll(includeProperties: "ApplicationUser");
;            return Json(new { data = homeList });
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var obj = _unitOfWork.Home.GetFirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Home.Remove(obj);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion





    }
}
