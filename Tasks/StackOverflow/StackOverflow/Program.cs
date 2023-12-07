using System;

public class Post
{
    private int votes;

    public string Title { get; }
    public string Description { get; }
    public DateTime CreationTime { get; }
    public int Votes => votes;

    public Post(string title, string description)
    {
        Title = title;
        Description = description;
        CreationTime = DateTime.Now;
        votes = 0;
    }

    public void UpVote()
    {
        votes++;
        Console.WriteLine("Post up-voted.");
    }

    public void DownVote()
    {
        votes--;
        Console.WriteLine("Post down-voted.");
    }
}

class Program
{
    static void Main()
    {
        // Create a post
        Post myPost = new Post("C# Programming", "An introduction to C# programming language.");

        // Up-vote and down-vote
        myPost.UpVote();
        myPost.UpVote();
        myPost.DownVote();

        // Display the current vote value
        Console.WriteLine($"Current vote value: {myPost.Votes}");
    }
}
