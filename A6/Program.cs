namespace A6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string choice;
            Boolean end = false;
        

            do
            {
                Console.WriteLine("Which media would you like to display?");
                //ask user a question
                Console.WriteLine("1)Movies");
                Console.WriteLine("2)Videos");
                Console.WriteLine("3)Shows");
                Console.WriteLine("4)End");
                // input response
                choice = Console.ReadLine().Trim();


                if (choice == "1")
                {
                    Context context = new Context();
                    var movies = context.Movies;
                    foreach (var m in movies)
                    {
                        m.Display();
                    }
                }
                else if (choice == "2")
                {
                    Context context = new Context();
                    var videos = context.Videos;
                    foreach (var m in videos)
                    {
                        m.Display();
                    }

                }
                else if (choice == "3")
                {
                    Context context = new Context();
                    var shows = context.Shows;
                    foreach (var m in shows)
                    {
                        m.Display();
                    }

                }

                else if (choice == "4")
                {
                    end = true;
                    Console.WriteLine("Thank you for using the Media Library.");
                    
                }
                else
                {
                    Console.WriteLine("Invalid key.");
                }

            } while (!end);


        }


    }
}

