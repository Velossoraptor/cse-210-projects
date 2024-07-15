using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> playlist = new List<Video>();

        Comment com1 = new Comment("anon", "Great video!");
        Comment com2 = new Comment("Jo", "Love this");
        Comment com3 = new Comment("DonkeyKong", "How'd they do this???");
        Video vid1 = new Video("Generic Title One", "Mr.Beast", 400);
        vid1._comments.Add(com1);
        vid1._comments.Add(com2);
        vid1._comments.Add(com3);

        Comment com4 = new Comment("anon", "Woah");
        Comment com5 = new Comment("Jo", "??");
        Comment com6 = new Comment("Bizzare", "First");
        Video vid2 = new Video("Generic Title Two", "SMI77Y", 400);
        vid2._comments.Add(com4);
        vid2._comments.Add(com5);
        vid2._comments.Add(com6);

        Comment com7 = new Comment("Kim", "Awesome");
        Comment com8 = new Comment("Jo", "Great play");
        Comment com9 = new Comment("DonkeyKong", "Amazing!");
        Video vid3 = new Video("Generic Title Three", "5UP", 400);
        vid3._comments.Add(com7);
        vid3._comments.Add(com8);
        vid3._comments.Add(com9);

        Comment com0 = new Comment("anon", "Meh");
        Comment com10 = new Comment("ExtinctDoDo", "Good Job!");
        Comment com11 = new Comment("DonkeyKong", "Love your art!");
        Video vid4 = new Video("Generic Title Four", "Jazza", 400);
        vid4._comments.Add(com0);
        vid4._comments.Add(com10);
        vid4._comments.Add(com11);

        playlist.Add(vid1);
        playlist.Add(vid2);
        playlist.Add(vid3);
        playlist.Add(vid4);

        foreach (Video video in playlist)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");
            Console.WriteLine();
            Console.WriteLine($"Comments: ");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}