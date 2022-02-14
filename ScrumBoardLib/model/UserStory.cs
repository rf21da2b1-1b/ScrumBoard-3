using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib.model
{
    public class UserStory
    {
        private static int nextId = 1;

        private int _id;
        private String _title;
        private String _description;
        private int _storyPoints;
        private int _businessValue;

        public UserStory():this("dummy", "dummydummy")
        {
        }

        public UserStory(string title, string description)
        {
            _id = nextId++;
            Title = title;
            Description = description;
            _storyPoints = 0;
            _businessValue = 0;
        }

        public int Id
        {
            get => _id;
        }

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("title must be at least 3 char. long");

                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("title must be at least 3 char. long");
                }

                _title = value;
            }
        }

        public string Description
        {
            get => _description;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Description must be at least 10 char. long");

                }
                if (value.Length < 10)
                {
                    throw new ArgumentException("Description must be at least 10 char. long");
                }
                _description = value; }
        }

        public int StoryPoints
        {
            get => _storyPoints;
            set {
                if (value < 0)
                {
                    throw new ArgumentException("StoryPoints must be Zero or positive");
                }
                _storyPoints = value;
            }
        }

        public int BusinessValue
        {
            get => _businessValue;
            set
            {
                if (value < 0 || 10 < value)
                {
                    throw new ArgumentException("BusinessValue must be between 0-10 both incl.");
                }
                _businessValue = value;
            }
        }


        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Description)}: {Description}, {nameof(StoryPoints)}: {StoryPoints}, {nameof(BusinessValue)}: {BusinessValue}";
        }
    }
}
