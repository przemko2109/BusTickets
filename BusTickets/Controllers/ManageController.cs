using BusTickets.Data;
using BusTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BusTickets.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManageController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddAge()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAge([Bind("AgeId,AgeName")] Age age)
        {
            if (ModelState.IsValid)
            {
                _context.ages.Add(age);
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }

            return View(age);
        }

        public IActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCity([Bind("CityId,CityName")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.cities.Add(city);
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(city);
        }

        public IActionResult AddMap()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMap([Bind("ExitCityId,DestinationCityId,Distance")] Map map)
        {
            if (ModelState.IsValid)
            {
                _context.map.Add(map);
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(map);
        }

        public IActionResult AddSchedule()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSchedule([Bind("Id,Hour,CityId,DayId")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.schedule.Add(schedule);
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(schedule);
        }

        public IActionResult DeleteAge(int ? id)
        {
            Age age = _context.ages.Find(id);
            return View(age);
        }
        [HttpPost, ActionName("DeleteAge")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteAgeConfirmed(int id)
        {
            Age age = _context.ages.Find(id);
            _context.ages.Remove(age);
            _context.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

        public IActionResult DeleteCity(int ? id)
        {
            City city = _context.cities.Find(id);
            return View(city);
        }
        [HttpPost, ActionName("DeleteCity")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCityConfirmed(int id)
        {
            City city = _context.cities.Find(id);
            _context.cities.Remove(city);
            _context.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

        public IActionResult DeleteSchedule(int? id)
        {
            Schedule schedule = _context.schedule.Find(id);
            return View(schedule);
        }
        [HttpPost, ActionName("DeleteSchedule")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteScheduleConfirmed(int id)
        {
            Schedule schedule = _context.schedule.Find(id);
            _context.schedule.Remove(schedule);
            _context.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

        public IActionResult DeleteMap(int ? id)
        {
            Map map = _context.map.Find(id);
            return View(map);
        }
        [HttpPost, ActionName("DeleteMap")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMapConfirmed(int id)
        {
            Map map = _context.map.Find(id);
            _context.map.Remove(map);
            _context.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

        public IActionResult EditAge(int ? id)
        {
            Age age = _context.ages.Find(id);
            return View(age);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAge([Bind("AgeId,AgeName")] Age age)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(age).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(age);
        }

        public IActionResult EditCity(int ? id)
        {
            City city = _context.cities.Find(id);
            return View(city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCity([Bind("CityId,CityName")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(city).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(city);
        }

        public IActionResult EditMap(int ? id)
        {
            Map map = _context.map.Find(id);
            return View(map);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMap([Bind("Id,ExitCityId,DestinationCityId,Distance")] Map map)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(map).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(map);
        }

        public IActionResult EditSchedule(int ? id)
        {
            Schedule schedule = _context.schedule.Find(id);
            return View(schedule);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSchedule([Bind("Id,Hour,CityId,DayId")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(schedule).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(schedule);
        }

        public IActionResult ShowAge()
        {
            return View(_context.ages.ToList());
        }

        public IActionResult ShowCity()
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

        public IActionResult AdminIndex()
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
