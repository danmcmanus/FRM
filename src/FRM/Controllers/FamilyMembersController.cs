using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FRM.Data;
using FRM.Models;

namespace FRM.Controllers
{
    public class FamilyMembersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FamilyMembersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: FamilyMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.FamilyMembers.ToListAsync());
        }

        // GET: FamilyMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familyMember = await _context.FamilyMembers.SingleOrDefaultAsync(m => m.Id == id);
            if (familyMember == null)
            {
                return NotFound();
            }

            return View(familyMember);
        }

        // GET: FamilyMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FamilyMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Birthday,FirstName,LastName,RelationshipType,Username")] FamilyMember familyMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(familyMember);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(familyMember);
        }

        // GET: FamilyMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familyMember = await _context.FamilyMembers.SingleOrDefaultAsync(m => m.Id == id);
            if (familyMember == null)
            {
                return NotFound();
            }
            return View(familyMember);
        }

        // POST: FamilyMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Birthday,FirstName,LastName,RelationshipType,Username")] FamilyMember familyMember)
        {
            if (id != familyMember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familyMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamilyMemberExists(familyMember.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(familyMember);
        }

        // GET: FamilyMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familyMember = await _context.FamilyMembers.SingleOrDefaultAsync(m => m.Id == id);
            if (familyMember == null)
            {
                return NotFound();
            }

            return View(familyMember);
        }

        // POST: FamilyMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var familyMember = await _context.FamilyMembers.SingleOrDefaultAsync(m => m.Id == id);
            _context.FamilyMembers.Remove(familyMember);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FamilyMemberExists(int id)
        {
            return _context.FamilyMembers.Any(e => e.Id == id);
        }
    }
}
