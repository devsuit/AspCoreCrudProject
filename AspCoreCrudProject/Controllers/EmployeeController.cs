using AspCoreCrudProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreCrudProject.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _Db;
        public EmployeeController(EmployeeDbContext context)
        {
            this._Db = context;
        }
        public async Task<IActionResult> Index()
        {
            var empList = await _Db.tblEmployees.ToListAsync();
            return View(empList);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee Obj)
        
        {
            {
                if (ModelState.IsValid)
                {
                    _Db.tblEmployees.Add(Obj);
                    await _Db.SaveChangesAsync();
                    TempData["success"] = "Employee Added Successfully";
                    return RedirectToAction("Index");
                }
            }
            return View(Obj);
        }
    }
}
