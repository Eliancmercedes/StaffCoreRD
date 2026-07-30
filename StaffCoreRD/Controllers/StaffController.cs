using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StaffCoreRD.Data;
using StaffCoreRD.Models;

namespace StaffCoreRD.Controllers
{
    [Authorize]
    public class StaffController : Controller
    {
        private readonly StaffDbContext _context;

        public StaffController(StaffDbContext context)
        {
            _context = context;
        }

        // GET: Staff
        [Authorize(Roles = "Administrador,RRHH,Viewer")]
        public async Task<IActionResult> Index()
        {
            var personal = await _context.Personal
                .Where(s => s.Activo)
                .OrderBy(s => s.Nombre)
                .ToListAsync();

            return View(personal);
        }
    }
}