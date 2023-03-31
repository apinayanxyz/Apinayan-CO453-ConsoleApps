using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a text message.
    /// </summary>
    /// <author>
    /// Apinayan Kanenthirarasa
    /// </author>
    public class MessagePost : Post
    {
        // an arbitrarily long, multi-line message
        public String Message { get; }


        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, String text):base(author)
        {
            Message = text;
        }

        ///<summary>
        /// Display the details of this post.
        ///</summary>
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Message: {Message}");

            base.Display();
        }
    }
}
