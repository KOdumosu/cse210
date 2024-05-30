using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Inside Largest Mormon Community - First Impressions", "Peter Santenello", 4320);
        video1.AddComment("@TravisseHansen", "Someone needs to get this kid a PR job. His ability to articulate clearly, with a positive bent, but not running away from issues is so impressive.");
        video1.AddComment("@b6894", "Good job Peter! As a member of the Church I am very grateful for your objective approach to understanding us. Very rare!!");
        video1.AddComment("@itsHeatherKay", "As an active LDS member, I thought this was a very fair and pretty accurate interview! Great job, both of you!");
        _videos.Add(video1);

        Video video2 = new Video("Elder David A. Bednar: How to Run a Global Organization", "Silicon Slopes", 2760);
        video2.AddComment("@chuxTube68", "That was enjoyable to watch.");
        video2.AddComment("@OURDAILYBREATH", "I've always love listening watching and learning from Elder Bednar he's a man full of wisdom.");
        video2.AddComment("@rossgarner363", "Can we please please please have more of this kind of candid discussion from the Apostles?");
        _videos.Add(video2);

        Video video3 = new Video("Try This Today: Find Relief From The World", "The Church of Jesus Christ of Latter-day Saints", 435);
        video3.AddComment("@angelazeman1375", "The mural is absolutely gorgeous!");
        video3.AddComment("@sharlynebeach2786", "Yes Sister, HE will listen when others do not.");
        video3.AddComment("@lukedav", "Such a powerful mural and message!");
        _videos.Add(video3);

        foreach(var video in _videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments() )
            {
                Console.WriteLine($"{comment.GetCommenter()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }

    }
}