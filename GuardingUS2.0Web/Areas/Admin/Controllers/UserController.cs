using GuardingUS2._0.DataAccess.Repository.IRepository;
using GuardingUS2._0.Models;
using GuardingUS2._0.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;

namespace GuardingUS2._0Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IWebHostEnvironment _hostEnvironment;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Users()
        {
            
            return View();
        }

        public IActionResult Upsert(string? id)
        {
            //UserVM userVM = new()
            //{
            //    User = new(),
            //    RoleList = _unitOfWork.IdentityRole.GetAll().Select(i => new SelectListItem
            //    {
            //        Text = i.Name,
            //        Value = i.Id
            //    })
            //};

            ApplicationUser user = new();
            
            if (id == null || id == "")
            {

                return View(user);
            }
            else
            {
                user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == id);
                //update product

            }
            return View(user);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ApplicationUser obj)
        {   
            if (ModelState.IsValid)
            {
                if (obj.Id == null || obj.Id == "")
                {
                    obj.StartDate = DateTime.Now;
                    _unitOfWork.ApplicationUser.Add(obj);
                    _unitOfWork.Save();
                    TempData["success"] = "User created successfully";
                }
                else
                {
                    _unitOfWork.ApplicationUser.Update(obj);
                    _unitOfWork.Save();
                    TempData["success"] = "User updated successfully";
                }

                return RedirectToAction("Users");
            }
            return View(obj);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var userList = _unitOfWork.ApplicationUser.GetAll();
            return Json(new { data = userList });
        }

        #endregion
    }
}
