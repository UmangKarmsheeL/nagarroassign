using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookReadingEvent1.Data;
using BookReadingEvent1.Models;
using Business_Logic_Layer;
using AutoMapper;
using BookReadingEvent1.DTOs;

namespace BookReadingEvent1.Controllers
{
    public class EventController : Controller
    {
        private IBookReadingEventService _BLL;
        public EventController(IBookReadingEventService _bookReadingEvent_BLL)
        {
            _BLL = _bookReadingEvent_BLL;
        }

        // GET: EventModels
        public async Task<IActionResult> List()
        {
            return View(await _BLL.List());
        }
        

        // GET: EventModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await _BLL.Details(id);
            if (data == null)
            {
                return NotFound();
            }

            return View(data);
        }

        // GET: EventModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                var ans = await _BLL.Create(eventModel);
                return RedirectToAction(nameof(List));
            }
            return View(eventModel);
        }

        // GET: EventModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventModel = await _BLL.Edit(id);
            if (eventModel == null)
            {
                return NotFound();
            }
            return View(eventModel);
        }

        // POST: EventModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EventModel eventModel)
        {
            if (id != eventModel.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var ans = await _BLL.Edit(id,eventModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventModelExists(eventModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(eventModel);
        }

        // GET: EventModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventModel =await _BLL.Delete(id);
            if (eventModel == null)
            {
                return NotFound();
            }

            return View(eventModel);
        }

        // POST: EventModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventModel = await _BLL.DeleteConfirmed(id);
            return RedirectToAction(nameof(List));
        }

        private bool EventModelExists(int id)
        {
            return _BLL.EventModelExists(id);
        }
    }
}
