/*
Class: MSSA Cloud Application Development 
Cohort: Fort Bragg Cohort 9
Student: Tim Tieng
Description: MSSA Individual Course Project - MSSA Job Application Tracker
Revised By: Tim Tieng
Revised On: 30 September 2020
Revisions Made: 
    1. Added links to careers page on InterestedJobsView
    2. Added Company description to each hiring partner block
    3. Started and implemented pagination feature in InterestedJobs View - NOT COMPETE
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiengInClassWebApp.Data;
using TiengInClassWebApp.Models;

namespace TiengInClassWebApp.Controllers
{
    public class JobApplicationsController : Controller
    {
        private readonly JobApplicationContext _context;

        public JobApplicationsController(JobApplicationContext context)
        {
            _context = context;
        }

        // GET: JobApplications
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jobs.ToListAsync());  
        }

        // GET: JobApplications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobApplication = await _context.Jobs
                .FirstOrDefaultAsync(m => m.jobRequisitionNumber == id);
            if (jobApplication == null)
            {
                return NotFound();
            }

            return View(jobApplication);
        }

        // GET: JobApplications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobApplications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("jobRequisitionNumber,jobTitle,hiringCompany,jobLocation,applicationSubmissionDate, applicationNotes")] JobApplication jobApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobApplication);
        }

        // GET: JobApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobApplication = await _context.Jobs.FindAsync(id);
            if (jobApplication == null)
            {
                return NotFound();
            }
            return View(jobApplication);
        }

        // POST: JobApplications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("jobRequisitionNumber,jobTitle,hiringCompany,jobLocation,applicationSubmissionDate,applicationNotes")] JobApplication jobApplication)
        {
            if (id != jobApplication.jobRequisitionNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobApplicationExists(jobApplication.jobRequisitionNumber))
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
            return View(jobApplication);
        }

        // GET: JobApplications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobApplication = await _context.Jobs
                .FirstOrDefaultAsync(m => m.jobRequisitionNumber == id);
            if (jobApplication == null)
            {
                return NotFound();
            }

            return View(jobApplication);
        }

        // POST: JobApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobApplication = await _context.Jobs.FindAsync(id);
            _context.Jobs.Remove(jobApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobApplicationExists(int id)
        {
            return _context.Jobs.Any(e => e.jobRequisitionNumber == id);
        }
    }
}
