using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var video1 = new Video("Amazing C# Tricks", "TechGuru", 300);
            var video2 = new Video("How to Cook Perfect Pasta", "ChefMike", 480);
            var video3 = new Video("10 Minute Yoga for Beginners", "YogaLife", 600);

            video1.AddComment(new Comment("Alice", "This was so helpful, thanks!"));
            video1.AddComment(new Comment("Bob", "Great tricks, learned a lot."));
            video1.AddComment(new Comment("Charlie", "Wow, C# is awesome!"));

            video2.AddComment(new Comment("Dave", "Tried this recipe, turned out amazing!"));
            video2.AddComment(new Comment("Eva", "Simple and easy to follow."));
            video2.AddComment(new Comment("Frank", "Cooking made simple!"));

            video3.AddComment(new Comment("Grace", "Loved this routine."));
            video3.AddComment(new Comment("Hannah", "So relaxing, just what I needed."));
            video3.AddComment(new Comment("Ian", "Perfect for a beginner like me!"));

            var videos = new List<Video> { video1, video2, video3 };

            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
                }
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
