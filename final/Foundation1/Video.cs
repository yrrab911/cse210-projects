using System.Collections.Generic;

namespace YouTubeTracker
{
    public class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int Length { get; }
        private List<Comment> _comments;

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}
