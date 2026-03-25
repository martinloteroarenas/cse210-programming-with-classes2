using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Tottomori ~ Dream Merchant [Full Album] (Imaginary Game Soundtrack)", "Tottomori" , 2427);
        Comment comment1Vid1 = new Comment("I currently have my 2 small children playing a game called “peaceful bed” where we all just cuddle in my bed and rest. This music is 10/10 peaceful bed vibes.", "StMichaelsHomeschool");
        Comment comment2Vid1 = new Comment("I love the final note: 'Made for humans by humans :^)' It's beautiful to find some certainty in this ocean of bots. I love this album.", "chimPa-c6j");
        Comment comment3Vid1 = new Comment("I am SO happy this is human made. This is beautiful. Can't wait to add to my chill n study playlist", "gothkid6510");
        Comment comment4Vid1 = new Comment("This music is so Spiritfarer coded, I love that.. <3", "loislowest");
        video1.AddComment(comment1Vid1);
        video1.AddComment(comment2Vid1);
        video1.AddComment(comment3Vid1);
        video1.AddComment(comment4Vid1);

        Video video2 = new Video("Liquid Drum and Bass Mix #60", "Sound Territory", 3698);
        Comment comment1Vid2 = new Comment("Who is listening in 2026? 10th anniversary of the great set!", "kirnevo");
        Comment comment2Vid2 = new Comment("I’ve listened to this exact mix hundreds of times at this point. It feels like visiting an old friend.", "NomadicEmcee");
        Comment comment3Vid2 = new Comment("Note 2025: still the best liquid drum and bass mix", "ma-de-bo");
        Comment comment4Vid2 = new Comment("24 million people know what time it is. The BEST SET EVER on YT", "LueRo22");
        video2.AddComment(comment1Vid2);
        video2.AddComment(comment2Vid2);
        video2.AddComment(comment3Vid2);
        video2.AddComment(comment4Vid2);

        Video video3 = new Video("Skyrim - Music & Ambience", "Everness", 8940);
        Comment comment1Vid3 = new Comment("I was born too late to explore the seas, and born too early to explore the universe, but I was born on time to explore Skyrim", "sovietgiraffe5380");
        Comment comment2Vid3 = new Comment("It almost feels like I lived a second life in this game", "briggsyg9731");
        Comment comment3Vid3 = new Comment("I'd pay an absurd amount of money to replay this game for the first time one more time", "wythore");
        Comment comment4Vid3 = new Comment("Every time I listen to music from this game , I get homesick for a place I’ve never been", "noellebrown4067");
        video3.AddComment(comment1Vid3);
        video3.AddComment(comment2Vid3);
        video3.AddComment(comment3Vid3);
        video3.AddComment(comment4Vid3);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}