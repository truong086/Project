using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebGames.Models;
using X.PagedList;

namespace WebGame.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminTakhoansController : Controller
    {
        private readonly webGameContext _context;
        public INotyfService _notyfService { get; }

        public AdminTakhoansController(webGameContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminTakhoans
        public async Task<IActionResult> Index(string name, int? to, int? from, int page = 1)
        {
            //return _context.Takhoans != null ? 
            //            View(await _context.Takhoans.ToListAsync()) :
            //            Problem("Entity set 'webGameContext.Takhoans'  is null.");

            var pageSize = 1;
            page = page < 1 ? 1 : page;
            var lsDonhang = _context.Takhoans.ToPagedList(page, pageSize);
            if (!string.IsNullOrEmpty(name))
            {
                // Cách 1: Chuyển từ chuỗi sang số nguyên sử dụng "int.Parse()"
                //int so = int.Parse(name); // Chuyển từ chuỗi sang số nguyên

                // Cách 2: Chuyển từ chuỗi sang số nguyên sử dụng "Convert.ToInt32()"
                //int so1 = Convert.ToInt32(name);

                if (to != null && from != null)
                {
                    lsDonhang = lsDonhang.Where(x => x.Tentaikhoan.Contains(name) && x.Phanquyen >= to && x.Phanquyen <= from).ToPagedList(page, pageSize);
                }
                else
                {
                    lsDonhang = lsDonhang.Where(x => x.Tentaikhoan.Contains(name)).ToPagedList(page, pageSize);
                }
            }
            else
            {
                if (to != null && from != null)
                {
                    lsDonhang = lsDonhang.Where(x => x.Phanquyen >= to && x.Phanquyen <= from).ToPagedList(page, pageSize);
                }
            }
            return View(lsDonhang);

        }

        // GET: Admin/AdminTakhoans/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Takhoans == null)
            {
                return NotFound();
            }

            var takhoan = await _context.Takhoans
                .FirstOrDefaultAsync(m => m.Tentaikhoan == id);
            if (takhoan == null)
            {
                return NotFound();
            }

            return View(takhoan);
        }

        // GET: Admin/AdminTakhoans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminTakhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tentaikhoan,Matkhau,Fullname,Email,Phanquyen")] Takhoan takhoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(takhoan);
                await _context.SaveChangesAsync();
                _notyfService.Success("Add thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(takhoan);
        }

        // GET: Admin/AdminTakhoans/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Takhoans == null)
            {
                return NotFound();
            }

            var takhoan = await _context.Takhoans.FindAsync(id);
            if (takhoan == null)
            {
                return NotFound();
            }
            return View(takhoan);
        }

        // POST: Admin/AdminTakhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Tentaikhoan,Matkhau,Fullname,Email,Phanquyen")] Takhoan takhoan)
        {
            if (id != takhoan.Tentaikhoan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takhoan);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Update thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakhoanExists(takhoan.Tentaikhoan))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(takhoan);
        }

        // GET: Admin/AdminTakhoans/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Takhoans == null)
            {
                return NotFound();
            }

            var takhoan = await _context.Takhoans
                .FirstOrDefaultAsync(m => m.Tentaikhoan == id);
            if (takhoan == null)
            {
                return NotFound();
            }

            return View(takhoan);
        }

        // POST: Admin/AdminTakhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Takhoans == null)
            {
                return Problem("Entity set 'webGameContext.Takhoans'  is null.");
            }
            var takhoan = await _context.Takhoans.FindAsync(id);
            if (takhoan != null)
            {
                _context.Takhoans.Remove(takhoan);
                _notyfService.Success("Delete thành công");
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TakhoanExists(string id)
        {
          return (_context.Takhoans?.Any(e => e.Tentaikhoan == id)).GetValueOrDefault();
        }
    }
}
