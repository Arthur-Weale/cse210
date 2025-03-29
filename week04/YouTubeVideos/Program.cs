using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Arthur Weale", "OOP Programming ", 3000);
        Video video2 = new Video("John Doe", "Principles of Programming", 3200);
        Video video3 = new Video("Jane Doe", "Principles of abstraction", 13200);

        video1.AddComment(new Comment("Crack Ed", "Fantastic stuff"));
        video1.AddComment(new Comment("Gi Joe", "love it"));
        video1.AddComment(new Comment("Dwayne Johnson", "Awesome stuff"));

        // Adding comments to video2
        video2.AddComment(new Comment("David", "This was confusing at first, but now I get it."));
        video2.AddComment(new Comment("Eve", "Nice examples!"));
        video2.AddComment(new Comment("Gi Joe", "love it"));
        video2.AddComment(new Comment("Dwayne Johnson", "Awesome stuff"));

        // Adding comments to video3
        video3.AddComment(new Comment("Frank", "Super helpful breakdown."));
        video3.AddComment(new Comment("Grace", "I wish there were more examples."));
        video3.AddComment(new Comment("Hank", "Nice video, thanks!"));
        video3.AddComment(new Comment("Gi Joe", "love it"));
        video3.AddComment(new Comment("Dwayne Johnson", "Awesome stuff"));

        List<Video> _video = new List<Video>{ video1, video2, video3 };

        foreach (var video in _video)
        {
            video.DisplayVideoInfo();
        }
    }
}