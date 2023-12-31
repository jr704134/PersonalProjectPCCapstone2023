﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalProjectPCCapstone2023.Data;
using PersonalProjectPCCapstone2023.Models;

namespace PersonalProjectPCCapstone2023.Controllers
{
    public class testController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext _context;

        public testController(RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            _context = context;
        }

        // GET: testController
        public ActionResult Index()
        {
            return View();
        }

        // GET: testController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: testController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: testController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: testController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: testController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: testController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: testController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //[HttpGet]
        //public IActionResult testViewItem(int Id)
        //{
        //    Merchandise? merch = _context.Merch.Include(m => m.MerchCategories)
        //        .ThenInclude(m => m.Category)
        //        .Where(m => m.MerchId == Id).FirstOrDefault() ?? new Merchandise();

        //    return View(Id);
        //}
    }
}
