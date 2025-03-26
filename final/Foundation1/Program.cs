using System;
using System.Diagnostics.Contracts;

class Program
{
    static List<Video> Videos = new List<Video>();
    static void Main(string[] args)
    {
        Video vid1 = new Video("So... how exactly did they port Sonic Unleashed to PC?", "MattKC Bytes", 870);
        Video vid2 = new Video("The Biggest myth in Speedrunning History", "LunaticJ", 1176);
        Video vid3 = new Video("Lego Games - Scott The Woz", "Scott The Woz", 6642);
        Video vid4 = new Video("Microsoft Sucks at Everything", "NakeyJakey", 1625);
        vid1.InsertComment("@RAFMnBgaming", "shows Wallace in professor pickle's lab 'In many ways this is closer to the game the original developers intended to release'");
        vid1.InsertComment("@Goalringmod27", "Hey I was part of this (a little bit)! We were hoping for a vid from you haha glad it's out!");
        vid1.InsertComment("@isaacryu", "Hey Matt, I'm one of the folks working on the Mac port. Fantastic video, really well explained!");
        vid2.InsertComment("@scpWyatt", "A cosmic ray traveled 92mil miles to flip a bit at Google HQ so this video got recommended to me.");
        vid2.InsertComment("@sickcivilian1569", "It was originally 'speed run', until we found a glitch to drop the space, so now its 'speedrun'");
        vid2.InsertComment("@fellowWanderer1420", "I feel like I just got dragged by the ankles into a dark wet cave full of confirmation bias.");
        vid3.InsertComment("@ianchandler4649", "My favorite thing about this Lego video is when he covered the non-Lego Kung Fu Panda game.");
        vid3.InsertComment("@matheusnobre5880", "Never thought i would ever hear scott saying the word 'spinjitzu'");
        vid3.InsertComment("@teleportato", "I love how Kung Fu Panda seemed to be brought up for a gag only to be teasing the point about how Lego became the standard tie-in game as time went on.");
        vid4.InsertComment("@Exo-riah", "My favourite thing about Windows is that the search function hasn’t worked properly for three iterations");
        vid4.InsertComment("@Thafnine", "i still find it funny that attempting to download any other browser from microsoft edge makes them start spamming pop-ups begging you to stay");
        vid4.InsertComment("@dustyt6226", "As an IT technician, I'm grateful to Microsoft for mucking everything up every few months to keep me employed.");
        Videos.Add(vid1);
        Videos.Add(vid2);
        Videos.Add(vid3);
        Videos.Add(vid4);
        Display(Videos);
    }

    public static void Display(List<Video> vids)
    {
        int count = 1;
        foreach (Video vid in vids)
        {
            Console.WriteLine($"Video #{count}:");
            Console.WriteLine($"Video Title: {vid.GetTitle()}\nAuthor: {vid.GetAuthor()}\nLength (in seconds): {vid.GetLength()}\nNumber of comments: {vid.GetCommentNum()}");
            vid.DisplayComments();
            Console.WriteLine("");
            count++;
        }
    }
}