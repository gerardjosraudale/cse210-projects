using System;
using System.Collections.Generic;

class Comment
{
    public string CommenterName { get; }
    public string CommentText { get; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        comments.Add(comment);
    }

    public int NumComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating 3-4 videos
        List<Video> videos = new List<Video>
        {
            new Video("Title 1", "Author 1", 120),
            new Video("Title 2", "Author 2", 180),
            new Video("Title 3", "Author 3", 150)
        };

        // Adding comments to each video
        videos[0].AddComment("User1", "Great video!");
        videos[0].AddComment("User2", "I learned a lot from this.");

        videos[1].AddComment("User3", "Nice content!");
        videos[1].AddComment("User4", "Keep up the good work.");

        videos[2].AddComment("User5", "Interesting topic.");
        videos[2].AddComment("User6", "Could you provide more details?");

        // Displaying information for each video
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.NumComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine("- Comment by " + comment.CommenterName + ": " + comment.CommentText);
            }
            Console.WriteLine();
        }
    }
}
