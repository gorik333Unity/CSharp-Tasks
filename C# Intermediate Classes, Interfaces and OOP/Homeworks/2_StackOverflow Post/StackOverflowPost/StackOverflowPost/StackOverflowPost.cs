using System;

namespace Learning
{
    public class StackOverflowPost
    {
        public StackOverflowPost(string title, string description)
        {
            Title = title;
            Description = description;
            DateOfCreation = DateTime.Now;
        }

        public StackOverflowPost(string title, string description, DateTime dateOfCreation)
            : this(title, description)
        {
            DateOfCreation = dateOfCreation;
        }

        public DateTime DateOfCreation { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public int VoteRating { get; private set; }
        /// <summary>
        /// Increases rating of the post
        /// </summary>
        public void UpVote()
        {
            VoteRating++;
        }
        /// <summary>
        /// Decreases rating of the post
        /// </summary>
        public void DownVote()
        {
            VoteRating--;
        }
        /// <summary>
        /// Sets a new post description
        /// </summary>
        public void SetDescription(string text)
        {
            if (text == null || text.Equals(string.Empty)) return;

            Description = text;
        }
    }
}
