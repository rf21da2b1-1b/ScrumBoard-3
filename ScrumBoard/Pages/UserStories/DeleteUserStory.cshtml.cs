using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScrumBoard.Services;
using ScrumBoardLib.model;

namespace ScrumBoard.Pages.UserStories
{
    public class DeleteUserStoryModel : PageModel
    {
        private UserStoryService _userStoryService;

        public DeleteUserStoryModel(UserStoryService userStoryService)
        {
            _userStoryService = userStoryService;
        }


        [BindProperty]
        public UserStory UserStory { get; set; }


        public void OnGet(int id)
        {
            UserStory = _userStoryService.GetUserStoryById(id);

        }

        public IActionResult OnPost(int id)
        {
            UserStory deletedUserStory = _userStoryService.DeleteUserStory(id);
            return RedirectToPage("Index");
        }
    }
}
