using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTapDay09_CodeFirst.BusinessModels;
using BTapDay09_CodeFirst.Models.DataModels;

namespace BTapDay09_CodeFirst.Controllers
{
    public class LtynLoaiSanPhamsController : Controller
    {
        private readonly LtynQLBHContext _context;

        public LtynLoaiSanPhamsController(LtynQLBHContext context)
        {
            _context = context;
        }

        // GET: LtynLoaiSanPhams
        public async Task<IActionResult> ltynIndex()
        {
            return View(await _context.LtynLoaiSanPhams.ToListAsync());
        }

        // GET: LtynLoaiSanPhams/Details/5
        public async Task<IActionResult> ltynDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ltynLoaiSanPham = await _context.LtynLoaiSanPhams
                .FirstOrDefaultAsync(m => m.ltynID == id);
            if (ltynLoaiSanPham == null)
            {
                return NotFound();
            }

            return View(ltynLoaiSanPham);
        }

        // GET: LtynLoaiSanPhams/Create
        public IActionResult ltynCreate()
        {
            return View();
        }

        // POST: LtynLoaiSanPhams/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ltynCreate([Bind("ltynID,ltynMaLoai,ltynTenLoai,ltynTrangThai")] LtynLoaiSanPham ltynLoaiSanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ltynLoaiSanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ltynIndex));
            }
            return View(ltynLoaiSanPham);
        }

        // GET: LtynLoaiSanPhams/Edit/5
        public async Task<IActionResult> ltynEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ltynLoaiSanPham = await _context.LtynLoaiSanPhams.FindAsync(id);
            if (ltynLoaiSanPham == null)
            {
                return NotFound();
            }
            return View(ltynLoaiSanPham);
        }

        // POST: LtynLoaiSanPhams/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ltynEdit(int id, [Bind("ltynID,ltynMaLoai,ltynTenLoai,ltynTrangThai")] LtynLoaiSanPham ltynLoaiSanPham)
        {
            if (id != ltynLoaiSanPham.ltynID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ltynLoaiSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ltynLoaiSanPhamExists(ltynLoaiSanPham.ltynID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ltynIndex));
            }
            return View(ltynLoaiSanPham);
        }

        // GET: LtynLoaiSanPhams/Delete/5
        public async Task<IActionResult> ltynDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ltynLoaiSanPham = await _context.LtynLoaiSanPhams
                .FirstOrDefaultAsync(m => m.ltynID == id);
            if (ltynLoaiSanPham == null)
            {
                return NotFound();
            }

            return View(ltynLoaiSanPham);
        }

        // POST: LtynLoaiSanPhams/Delete/5
        [HttpPost, ActionName("ltynDeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ltynDeleteConfirmed(int id)
        {
            var ltynLoaiSanPham = await _context.LtynLoaiSanPhams.FindAsync(id);
            if (ltynLoaiSanPham != null)
            {
                _context.LtynLoaiSanPhams.Remove(ltynLoaiSanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ltynIndex));
        }

        private bool ltynLoaiSanPhamExists(int id)
        {
            return _context.LtynLoaiSanPhams.Any(e => e.ltynID == id);
        }
    }
}
