using System;
using System.Collections.Generic;

namespace Unit3Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // MOVIE CODE
            Movie myMovie = new Movie() {
                Title = "Jurassic Park",
                Director = "Steven Spielberg",
                Year = 1993,
            };

            Movie anotherMovie = new Movie();
            anotherMovie.Title = "The Shining";
            anotherMovie.Director = "Stanley Kubrick";
            anotherMovie.Year = 1980;
            
            myMovie.PrintDetails();
            anotherMovie.PrintDetails();

            // Getting
            Console.WriteLine(myMovie.Title);

            // Setting
            myMovie.Title = "Some new movie";
            myMovie.PrintDetails();



            // SOCIAL MEDIA POST CODE
            string myText = "Hello world";
            var theDate = new DateTime(2010, 6, 29);
            var firstPost = new SocialMediaPost(myText, theDate, 5);

            firstPost.PrintPostDetails();
            firstPost.Like();
            firstPost.PrintPostDetails();
        }
    }



    class SocialMediaPost {
        //Constructor
        public SocialMediaPost(string textArgument, DateTime timeOfPostArgument, int numberOfLikesArgument) {
            text = textArgument;
            timeOfPost = timeOfPostArgument;
            numberOfLikes = numberOfLikesArgument;
        }

        // Data
        private string text;
        private DateTime timeOfPost;
        private int numberOfLikes;

        // Methods
        public void PrintPostDetails() {
            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Time of post: {timeOfPost}");
            Console.WriteLine($"Number of likes: {numberOfLikes}\n");
        }

        public void Like() {
            Console.WriteLine("Somebody liked this post!\n");
            numberOfLikes++;
        }
    }


    class Movie {
        // Properties
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        
        // Methods 
        public void PrintDetails() {
            Console.WriteLine($"Movie Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Year: {Year}\n");
        }
    }

}
