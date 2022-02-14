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
    public class IndexModel : PageModel
    {

        private UserStoryService _userStoryService;

        public List<UserStory> UserStories { get; private set; }

        public IndexModel(UserStoryService userStoryService)
        {
            _userStoryService = userStoryService;
        }

        public void OnGet()
        {
            UserStories = _userStoryService.GetUserStories();
        }
    }
}
