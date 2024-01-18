namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their favorite school subject
            Console.WriteLine("What is your favorite school subject?");
            string userFavoriteSubject = Console.ReadLine();

            // Use a switch statement to provide custom messages based on the user's choice
            switch (userFavoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Mathematics is a fascinating subject! Keep solving those equations.");
                    break;
                case "science":
                    Console.WriteLine("Science opens up the wonders of the world! Stay curious and explore.");
                    break;
                case "english":
                    Console.WriteLine("English is the key to effective communication. Keep honing your language skills.");
                    break;
                case "history":
                    Console.WriteLine("History teaches us valuable lessons from the past. Keep learning and understanding.");
                    break;
                case "art":
                    Console.WriteLine("Art allows creativity to flourish! Keep expressing yourself through your creations.");
                    break;
                default:
                    Console.WriteLine("Interesting choice! Every subject has its unique charm. Keep enjoying your studies.");
                    break;
            }
        }
    }
}