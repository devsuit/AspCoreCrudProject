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
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var emp = await _Db.tblEmployees.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
        [HttpPost]
    public async Task<IActionResult> Edit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _Db.tblEmployees.Update(obj);
                await _Db.SaveChangesAsync();
                TempData["success"] = "Employee Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var emp = await _Db.tblEmployees.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        public async Task<IActionResult> Delete (int id)
            {
            var emp = await _Db.tblEmployees.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            _Db.tblEmployees.Remove(emp);
            await _Db.SaveChangesAsync();
            TempData["success"] = "Employee Deleted Successfully";
            return RedirectToAction("Index");
        }



    }
}
