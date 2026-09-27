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

        // 2. Add comments using the AddComment method
        video1.AddComment(new Comment("Alice", "Great explanation of classes!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thank you."));
        video1.AddComment(new Comment("Charlie", "Can you cover interfaces next?"));

        video2.AddComment(new Comment("David", "Awesome progress on green tech."));
        video2.AddComment(new Comment("Eve", "Super interesting topic."));
        video2.AddComment(new Comment("Frank", "Looking forward to more videos like this."));

        video3.AddComment(new Comment("Grace", "PySide6 is so smooth to work with."));
        video3.AddComment(new Comment("Heidi", "Clear and concise explanation."));
        video3.AddComment(new Comment("Ivan", "Helped me fix my GUI layout!"));

        // 3. Put videos in a list
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        // 4. Iterate and display information using getter methods
        foreach (Video video in videoList)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: \"{comment.GetText()}\"");
            }
            Console.WriteLine();
        }
    }
}