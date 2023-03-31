using System;
using System.Collections.Generic;


///<summary>
/// This class stores information about a post in a social network. 
/// Template used to create text and image posts
/// Contains the time elapsed from a post being made, likes the post has and it's author
///</summary>
/// <author>
/// Apinayan Kanenthirarasa
/// </author>
public class Post
{

        // username of the post's author
        public String Username { get; }

    public DateTime Timestamp { get; }

    public int Likes { get; set; }

    private List<String> comments;
    /// <summary>
    /// Record one more 'Like' indication from a user.
    /// </summary>

    public Post(String author)
    {
        Username = author;
        Timestamp = DateTime.Now;

        Likes = 0;
        comments = new List<String>();
    }

    ///<summary>
    /// Record that a user has added his/her 'Like' vote.
    ///</summary>
    public void Like()
    {
        Likes++;
    }

    ///<summary>
    /// Record that a user has withdrawn his/her 'Like' vote.
    ///</summary>
    public void Unlike()
    {
        if (Likes > 0)
        {
            Likes--;
        }
    }

    ///<summary>
    /// Add a comment to this post.
    /// </summary>
    /// <param name="text">
    /// The new comment to add.
    /// </param>        
    public void AddComment(String text)
    {
        comments.Add(text);
    }


    ///<summary>
    /// Displays All information from the post
    /// 
    /// </summary>
    public virtual void Display()

    {
        Console.WriteLine($"    Author: {Username}");

        Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
        Console.WriteLine();

        if (Likes > 0)
        {
            Console.WriteLine($"    Likes:  {Likes}  people like this.");
        }
        else
        {
            Console.WriteLine();
        }

        if (comments.Count == 0)
        {
            Console.WriteLine("    No comments.");
        }
        else
        {
            Console.WriteLine($"    {comments.Count}  comment(s). Click here to view.");
        }
    }

    ///<summary>
    /// Create a string describing a time point in the past in terms 
    /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
    /// Currently, only seconds and minutes are used for the string.
    /// </summary>
    /// <param name="time">
    ///  The time value to convert (in system milliseconds)
    /// </param> 
    /// <returns>
    /// A relative time string for the given time
    /// </returns> 
    private String FormatElapsedTime(DateTime time)
    {
        DateTime current = DateTime.Now;
        TimeSpan timePast = current - time;

        long seconds = (long)timePast.TotalSeconds;
        long minutes = seconds / 60;

        if (minutes > 0)
        {
            return minutes + " minutes ago";
        }
        else
        {
            return seconds + " seconds ago";
        }
    }

}
	


