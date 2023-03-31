using System;
using System.Collections.Generic;
using static ConsoleAppProject.Helpers.ConsoleHelper;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news Posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the Posts is currently simulated by printing the details to the
    /// terminal
    ///</summary>
    ///<author>
    ///  Apinayan Kanenthirarasa
    ///</author> 
    public class NewsFeed
    {
        private List<Post> Posts { get; }

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();
            run();
        }

        public void run()
        {
            DisplayMenu();
        }

        public void DisplayMenu()
        {
            bool quit = false;

            OutputHeading("News Feed");

            string[] choices = new string[]
            {
                "Add Message post", "Add Photo", "Like Post" , "Display All" , "Display From Author" , "Quit"
            };

        }

        public void UserChoiceInput()
        {

        }

        public void ChooseOption()
        {

        }

        /*public Post GetPost()
        {
            Post post;
            return post;
        }*/

        ///<summary>
        /// Add a post to the news feed.
        ///</summary>
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }

        ///<summary>
        /// Show the news feed.
        ///</summary>
        public void Display()
        {
            foreach (Post post in Posts)
            {
                post.Display();
                Console.WriteLine();
            }

        }
    }

}
