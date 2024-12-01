using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Video Abstraction!");
        Console.WriteLine();
        string[] titles = {"10 Hacks in 2 Minutes!", "Is This the Future?", "How I Did It: Fast & Easy!" };
        string[] authors = {"Daily Spark", "NextWave Studio", "EpicEdge"};
        string[] usernames = {
            "ShadowPulse",
            "NeonNinja42",
            "PixelVoyager",
            "LunarEclipse7",
            "BlazeFalcon",
            "EchoWanderer",
            "FrostByteX",
            "CrimsonComet",
            "QuantumPioneer"
        };
        string[] bodies = {
            "This video is amazing!",
            "I learned so much, thanks for sharing!",
            "Can you make a tutorial on this topic?",
            "Wow, I didnt know that! Subscribed immediately.",
            "Haha, this made my day!",
            "This is exactly what I was looking for, great job!",
            "The editing is top-notch!",
            "Anyone else watching this in 2024?",
            "Keep up the great work, can't wait for the next video!"
        };
        Video video1 = new Video(titles[0], authors[0], 120);
        Video video2 = new Video(titles[1], authors[1], 300);
        Video video3 = new Video(titles[2], authors[2], 400);
        List<Video> videos = new List<Video>{video1, video2, video3};
        List<Comment> comments = new List<Comment>();
        for(int i = 0; i < 9; i++){
            comments.Add(new Comment(usernames[i], bodies[i]));
        }
        for(int i = 0; i < 9; i++){
            videos[i%3].AddComment(comments[i]);
        }

        foreach(Video video in videos){
            Console.WriteLine("-- Video Summary --");
            string result = video.GetVideoSummary();
            string[] summary = result.Split(',');
            int numberOfComments = video.GetNumberOfComments();
            foreach(string element in summary){
                Console.WriteLine(element);
            }
            Console.WriteLine($"-- {numberOfComments} Comments --");
            List<string> commentList = video.GetComments();
            foreach(string comment in commentList){
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }

    }
}