// Foundation #1: Abstraction with YouTube Videos
using System;
using System.Collections.Generic;

// Class to represent a Comment
class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string Display()
    {
        return $"{_commenterName}: {_text}";
    }
}

// Class to represent a Video
class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
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

    public void Display()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds\nNumber of Comments: {GetNumberOfComments()}\n");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.Display());
        }
        Console.WriteLine();
    }
}

// Main Program for Foundation #1
class Program
{
    static void Main(string[] args)
    {
        // Create sample videos
        Video video1 = new Video("Understanding OOP", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Really helpful."));
        video1.AddComment(new Comment("Charlie", "Can you cover encapsulation next?"));

        Video video2 = new Video("Design Patterns Overview", "Jane Smith", 450);
        video2.AddComment(new Comment("Dave", "Loved the content!"));
        video2.AddComment(new Comment("Eve", "Clear and concise."));

        Video video3 = new Video("Intro to C#", "Chris Johnson", 600);
        video3.AddComment(new Comment("Frank", "This is amazing."));
        video3.AddComment(new Comment("Grace", "Very detailed."));
        video3.AddComment(new Comment("Heidi", "Can you make one on LINQ?"));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
