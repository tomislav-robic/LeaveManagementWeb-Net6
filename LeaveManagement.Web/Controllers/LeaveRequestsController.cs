using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using AutoMapper;
using LeaveManagement.Web.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Controllers
{
    [Authorize]
    public class LeaveRequestsController : Controller
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly ILogger<LeaveRequestsController> _logger;

        public LeaveRequestsController(ILeaveRequestRepository leaveRequestRepository, ILeaveTypeRepository leaveTypeRepository,
            ILogger<LeaveRequestsController> logger)

        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.leaveTypeRepository = leaveTypeRepository;
            this._logger = logger;
        }

        [Authorize(Roles = Roles.Administrator)]
        // GET: LeaveRequests
        public async Task<IActionResult> Index()
        {
            var model = await leaveRequestRepository.GetAdminLeaveRequestList();
            return View(model);
        }

        public async Task<IActionResult> MyLeave()
        {
            var model = await leaveRequestRepository.GetMyLeaveDetails();
            return View(model);
        }

        // GET: LeaveRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var model = await leaveRequestRepository.GetLeaveRequestAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveRequest(int id, bool approved)
        {
            try
            {
                await leaveRequestRepository.ChangeApprovalStatus(id, approved);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error Approving Request");
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: LeaveRequests/Create
        public async Task<IActionResult> Create()
        {
            var model = new LeaveRequestCreateVM
            {
                LeaveTypes = new SelectList(await leaveTypeRepository.GetAllAsync(), "Id", "Name")
            };
            return View(model);
        }

        // POST: LeaveRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await leaveRequestRepository.CreateLeaveRequest(model);
                    return RedirectToAction(nameof(MyLeave));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Creating Request");
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            model.LeaveTypes = new SelectList(await leaveTypeRepository.GetAllAsync(), "Id", "Name");
            return View(model);
        }

        // GET: LeaveRequests/Cancel/5
        public async Task<IActionResult> Cancel(int? id)
        {
            if (id == null || leaveTypeRepository.GetAllAsync() == null)
            {
                return NotFound();
            }

            var leaveRequest = await leaveRequestRepository.GetAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            leaveRequest.Cancelled = true;
            await leaveRequestRepository.UpdateAsync(leaveRequest);
            return RedirectToAction(nameof(MyLeave));
        }
    }
}
