using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create videos
        Video video1 = new Video("C# Abstraction Guide", "CodeAcademy", 600);
        Video video2 = new Video("Top 10 EV Conversions", "CleanMobility", 840);
        Video video3 = new Video("Intro to PySide6", "TechDev", 450);

        // 2. Add 3-4 comments to Video 1
        video1.Comments.Add(new Comment("Alice", "Great explanation of classes!"));
        video1.Comments.Add(new Comment("Bob", "Very helpful, thank you."));
        video1.Comments.Add(new Comment("Charlie", "Can you cover interfaces next?"));

        // Add 3-4 comments to Video 2
        video2.Comments.Add(new Comment("David", "Awesome progress on green tech."));
        video2.Comments.Add(new Comment("Eve", "Super interesting topic."));
        video2.Comments.Add(new Comment("Frank", "Looking forward to more videos like this."));

        // Add 3-4 comments to Video 3
        video3.Comments.Add(new Comment("Grace", "PySide6 is so smooth to work with."));
        video3.Comments.Add(new Comment("Heidi", "Clear and concise explanation."));
        video3.Comments.Add(new Comment("Ivan", "Helped me fix my GUI layout!"));

        // 3. Put videos in a list
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        // 4. Iterate and display information
        foreach (Video video in videoList)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.Name}: \"{comment.Text}\"");
            }
            Console.WriteLine();
        }
    }
}