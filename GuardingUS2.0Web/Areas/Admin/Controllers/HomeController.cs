using GuardingUS.Services;
using GuardingUS2._0.DataAccess;
using GuardingUS2._0.DataAccess.Repository.IRepository;
using GuardingUS2._0.Models;
using GuardingUS2._0.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GuardingUS2._0Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        //private readonly ApplicationDbContext _db;

        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Homes()
        {

            //AdminDAO adminDAO = new AdminDAO();

            ////Make a list to get homes
            //List<GuardingUS2._0.Models.ViewModels.HomeVM> everyone = adminDAO.ReadHomes();

            

            //return View(everyone);

            return View();
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
             var homeList = _unitOfWork.Home.GetAll(includeProperties: "ApplicationUser");
;            return Json(new { data = homeList });
        }
        #endregion





    }
}
