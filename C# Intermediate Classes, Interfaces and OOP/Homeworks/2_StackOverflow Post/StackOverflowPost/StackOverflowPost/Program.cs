using System;

namespace Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            var post = new StackOverflowPost("John", "John biography");

            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.DateOfCreation);

            post.UpVote();
            post.UpVote();

            post.DownVote();

            Console.WriteLine($"Post rate: {post.VoteRating}");
        }
    }
}