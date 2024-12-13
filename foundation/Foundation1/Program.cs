using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        var video1 = new Video("Learning C#", "John Doe", 300);
        var video2 = new Video("Cooking Basics", "Jane Smith", 600);
        var video3 = new Video("Travel Vlog: Japan", "Alex Lee", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "This is very helpful."));
        video1.AddComment(new Comment("Charlie", "I love this tutorial!"));

        // Add comments to video2
        video2.AddComment(new Comment("Daisy", "Can't wait to try this recipe!"));
        video2.AddComment(new Comment("Eve", "Looks delicious."));
        video2.AddComment(new Comment("Frank", "Thanks for sharing."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Japan looks amazing!"));
        video3.AddComment(new Comment("Hank", "This video inspired me to travel."));
        video3.AddComment(new Comment("Ivy", "I can't wait to visit there!"));

        // Add videos to a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display video details
        Console.Clear();
        Console.WriteLine("YouTube Video Details\n");
        foreach (var video in videos)
        {
            video.DisplayDetails();
        }
    }
}
