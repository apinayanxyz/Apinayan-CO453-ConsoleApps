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
        /// Generates array used to store posts
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();
        }

        ///<summary>
        /// Main method to call app
        /// Calls the display menu
        ///</summary>
        public void run()
        {
            DisplayMenu();
        }

        ///<summary>
        /// Displays the menu for this app 
        /// Also alows the user to choose which option they would like to do
        ///</summary>
        public void DisplayMenu()
        {
            bool quit = false;

            OutputHeading("News Feed");

            string[] choices = new string[]
            {
                "Add Message post", "Add Photo", "Like a post" , "Display All" , "Display From Author", "Display Posts with likes" , "Quit"
            };

            do 
            {
                int choice = SelectChoice(choices);

                switch (choice)
                {
                    case 1: AddMessagePost(); break;
                    case 2: AddPhotoPost(); break;
                    case 3: LikePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayFromAuthor(); break;
                    case 6: DisplayWithLikes(); break;
                    default: quit=true; break;
                }
            } while (!quit);
        }
        ///<summary>
        /// Creates a Message post
        ///</summary>
        public void AddMessagePost() 
        {
            OutputTitle("Adding a Message Post");
            Console.WriteLine("Name > ");
            string name = Console.ReadLine();
            Console.WriteLine("Message > ");
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(name, message);
            AddPost(post);
        }

        ///<summary>
        /// Creates a photo post
        ///</summary>
        public void AddPhotoPost()
        {
            OutputTitle("Adding a Photo");
            Console.WriteLine("Name > ");
            string name = Console.ReadLine();
            Console.WriteLine("Filename > ");
            string filename = Console.ReadLine();
            Console.WriteLine("Caption");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(name, filename ,caption);
            AddPost(post);
        }

        ///<summary>
        /// Likes a given post
        ///</summary>
        public void LikePost() 
        {
            Console.WriteLine("Id of post");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Post post in Posts)
            {
                if (Posts.IndexOf(post) == id)
                {
                    post.Like();
                }
            }

        }

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
        public void DisplayAll()
        {
            
            foreach (Post post in Posts)
            {   
                int i = Posts.IndexOf(post);
                Console.WriteLine("Post id >" + (i + 1) + "  > ");
                post.Display();
                Console.WriteLine();
            }

        }
        ///<summary>
        /// Shows the posts from a specific author  
        ///</summary>
        public void DisplayFromAuthor() 
        {
            Console.WriteLine("Name of Author");
            string author = Console.ReadLine();
            foreach (Post post in Posts)
            {
                if (post.Username == author) {
                    int i = Posts.IndexOf(post);
                    Console.WriteLine("Post id >" + (i + 1) + "  > ");
                    post.Display();
                    Console.WriteLine();
                }
            }
        }
        ///<summary>
        /// Shows all posts with likes  
        ///</summary>
        public void DisplayWithLikes()
        {
            foreach (Post post in Posts)
            {
                if (post.likes > 0)
                {
                    int i = Posts.IndexOf(post);
                    Console.WriteLine("Post id >" + (i + 1) + "  > ");
                    post.Display();
                    Console.WriteLine();
                }
            }
        }
    }

}
