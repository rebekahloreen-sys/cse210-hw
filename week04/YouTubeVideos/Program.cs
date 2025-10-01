using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video video1 = new Video("How to fale clas, GARRUNTEED!", "me", 600);
        video1.AddComment(new Comment("jarom", "hi"));
        video1.AddComment(new Comment("emily", "thanks ftor tje info!"));
        video1.AddComment(new Comment("jacob", "im 12, amd i failed for the first time!"));
        video1.AddComment(new Comment("Sarah", "Why are so many children watching this video?"));
        videos.Add(video1);

        Video video2 = new Video("Today I stayed up to 5am", "us", 900);
        video2.AddComment(new Comment("anime reference", "Don't we all do that?"));
        video2.AddComment(new Comment("Bob", "Me, watching this at 5am: 👀"));
        video2.AddComment(new Comment("Janice", "Isn't that usually unhealthy?"));
        videos.Add(video2);        

        Video video3 = new Video("You can be an idiot too, if you try hard enough", "everyone", 1200);
        video3.AddComment(new Comment("Gojo", "People have told me I am, but I think they just don't get my genius!"));
        video3.AddComment(new Comment("Nanami", "I happen to know one, maybe this will help me understand him."));
        video3.AddComment(new Comment("Megumi", "Forget it, Nanami, He'll never get it."));
        video3.AddComment(new Comment("Sukuna", "I can't do crime right now, so I'll settle for being a nuissance."));
        videos.Add(video3);

        
        Console.Clear();
        foreach (Video vid in videos)
        {
            vid.DisplayAll();
            Console.WriteLine();
        }
    }
}