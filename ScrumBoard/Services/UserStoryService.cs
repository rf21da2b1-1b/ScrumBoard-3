using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumBoard.MockData;
using ScrumBoardLib.model;

namespace ScrumBoard.Services
{
    public class UserStoryService
    {
        private readonly List<UserStory> _userStories;

        public UserStoryService()
        {
            _userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return new List<UserStory>(_userStories);
        }

        public UserStory GetUserStoryById(int id)
        {
            UserStory us = _userStories.Find(u => u.Id == id);
            if (us == null)
            {
                throw new KeyNotFoundException();
            }

            return us;
        }

        public UserStory DeleteUserStory(int id)
        {
            UserStory us = GetUserStoryById(id);

            _userStories.Remove(us);

            return us;
        }
    }
}
