using Business.Service;
using CommonModel.Model;
using Event.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IEventService eventService;

        public SignInManager<IdentityUser> signInManager { get; }

        public CommentController(ICommentService commentService, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IEventService eventService)
        {
            this.commentService = commentService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.eventService = eventService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PostComment(EditEventViewModel editEventViewModel)
        {
            if (signInManager.IsSignedIn(User))
            {
                var model = new Comment
                {
                    EventId = editEventViewModel.Id,
                    Description = editEventViewModel.CommentDescription,
                    UserId = Guid.Parse(userManager.GetUserId(User)),
                    DateAdded = DateTime.Now
                };
                await commentService.AddAsync(model);
                return RedirectToAction("EventView", "Event", new { id = editEventViewModel.Id });

            }
            return RedirectToAction("List", "Event");
        }

        public async Task<IActionResult> EventComments(Guid id)
        {
            var eventViewModel = await eventService.GetAsync(id);
            var comments = await commentService.GetCommentsByEventId(id);

            if (eventViewModel == null)
            {
                return NotFound();
            }

            var commentViewModels = comments.Select(comment => new CommentViewModel
            {
                Id = comment.Id,
                Description = comment.Description,
                EventId = eventViewModel.Id, 
                UserId = comment.UserId,
                DateAdded = comment.DateAdded
            }).ToList();


            var model = new EditEventViewModel()
            {
                Id = eventViewModel.Id,
                title = eventViewModel.title,
                date = eventViewModel.date,
                location = eventViewModel.location,
                startTime = eventViewModel.startTime,
                Visible = eventViewModel.Visible,
                durationInHours = eventViewModel.durationInHours,
                description = eventViewModel.description,
                otherDetails = eventViewModel.otherDetails,
                InviteByEmail = eventViewModel.InviteByEmail,
                Organiser = eventViewModel.Organiser,
                Comments = commentViewModels
            };

            return PartialView("_CommentsPartial", model);
        }
    }
}
