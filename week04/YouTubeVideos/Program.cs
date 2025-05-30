using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to make Ghanaian jollof", "Chef Paaqwesi", 300);
        video1.AddComment(new Comment("Kojo", "Thanks for this recipe"));
        video1.AddComment(new Comment("Kingsley", "I really needed this"));
        video1.AddComment(new Comment("Kwame", "Great recipe!!!"));

        Video video2 = new Video("A visit to Ghana, the country of love", "Scanty", 1500);
        video2.AddComment(new Comment("Jerry Daylan", "Didn't know Ghana is this beautiful, I would love to visit"));
        video2.AddComment(new Comment("Frimpong Gyan", "Ghana is indeed beautiful"));
        video2.AddComment(new Comment("Johnson May", "I am visiting Ghana in my summer break"));

        Video video3 = new Video("Web Development Roadmap", "Big Flo", 3000);
        video3.AddComment(new Comment("Georgina", "Great video, I recommend it everyone"));
        video3.AddComment(new Comment("Prince Gamor", "This is exactly what I need"));
        video3.AddComment(new Comment("Asare Donkoh", "Fantastic video"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Console.WriteLine("\n Displying all videos and comments...");
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }

        
    }
}