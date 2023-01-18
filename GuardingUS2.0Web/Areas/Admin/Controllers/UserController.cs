using GuardingUS2._0.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

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
    }
}
