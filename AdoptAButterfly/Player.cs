using static System.Console;
using System.Globalization;

namespace AdoptAButterfly
{
    public class Player
    {
        public static string Name = "Anonymous Player";
        public static string Gender = "Anonymous Gender";

        public void Start()
        {
  
            BackgroundColor = System.ConsoleColor.White;
            ForegroundColor = System.ConsoleColor.Black;

            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
           

            WriteLine("Welcome to Adopt A Butterfly by Hope Pham. In this application, you will be able to adapt your very own butterfly. To get you started, please introduce yourself. What is your name?");

            Name = ReadLine();
            Name = TitleCase.ToTitleCase(Name);
            WriteLine("Hello " + Name +"!");
            ReadLine();



            WriteLine("Please include your pronoun.");

            Gender = ReadLine();
            WriteLine(Name + " like to be addressed as " + Gender + "." + " Now let's begin adopting your butterfly. Press enter to continue.");
            ReadLine();

            Clear();


        }
    }
}