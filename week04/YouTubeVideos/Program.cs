using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Programming for Beginners", "John Doe", 3000);
        video1.AddComment(new Comment("user9123", "Thank you this is really helpful!"));
        video1.AddComment(new Comment("user8878", "Please make another video for C# tutorial."));
        video1.AddComment(new Comment("user9999", "I like how you interpret the concept of abstraction."));


        Video video2 = new Video("Most recommended watch of 2025", "Jane Doe", 200);
        video2.AddComment(new Comment("Jake Johnson", "Thank you for making this video. I'm going to get my first SEIKO this week"));
        video2.AddComment(new Comment("moonrock661", "The new Rolex Submariner is gorgeous. I think I find my dream watch."));
        video2.AddComment(new Comment("yilongma", "All these are not my type..."));


        Video video3 = new Video("One underrated company in U.S stock market", "WeeklyEconAnalysis", 720);
        video3.AddComment(new Comment("investorbro72", "Never heard of this company before. Adding it to my watchlist now."));
        video3.AddComment(new Comment("Marketqueen878", "Interesting pick. Hope you do a follow-up video next quarter!"));
        video3.AddComment(new Comment("econgeek99", " Great perspective. I like how you analyze the finalcial report."));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.GetVideoInfo();
            video.GetCommentNumber();
            Console.WriteLine();
            
            foreach (Comment comment in video.GetComments())
            {
                comment.GetCommentText();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

        }
        
    }
}