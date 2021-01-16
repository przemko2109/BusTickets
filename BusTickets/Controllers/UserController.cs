using BusTickets.Data;
using BusTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult BuyTicket()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BuyTicket([Bind("Id,ScheduleId,UserId,MapId,AgeId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.tickets.Add(ticket);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ticket);
        }

        public IActionResult DeleteTicket(int? id)
        {
            Ticket ticket = _context.tickets.Find(id);
            return View(ticket);
        }
        [HttpPost, ActionName("DeleteTicket")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTicket(int id)
        {
            Ticket ticket = _context.tickets.Find(id);
            _context.tickets.Remove(ticket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditTicket(int? id)
        {
            Ticket ticket = _context.tickets.Find(id);
            return View(ticket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTicket([Bind("Id,ScheduleId,UserId,MapId,AgeId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(ticket).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        public IActionResult ShowAge()
        {
            return View(_context.ages.ToList());
        }

        public IActionResult ShowCities()
        {
            return View(_context.cities.ToList());
        }

        public IActionResult ShowMap()
        {
            return View(_context.map.ToList());
        }

        public IActionResult ShowSchedule()
        {
            return View(_context.schedule.ToList());
        }

        public IActionResult ShowTicket()
        {
            return View(_context.tickets.ToList());
        }

        public IActionResult Index()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
