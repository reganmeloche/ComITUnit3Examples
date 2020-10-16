using System;

namespace Unit3Examples
{
    /*
    Challenge:
    - 1. Add a data member for a unique Id to the Movie class
    - 2. Add a data member for a collection of numerical ratings
    - 3. Add a constructor that initializes all the data members of a movie
    - 4. Add a method that allows you to add a rating between 1 and 5 (inclusive) to the movie
    - 5. Add a mechanism that allows you to get the average rating of a movie
    */
    public class Movie {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        public void PrintDetails() {
            Console.WriteLine($"Movie Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Year: {Year}\n");
        }
    }

}
