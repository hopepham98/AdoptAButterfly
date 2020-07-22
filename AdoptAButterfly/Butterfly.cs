using System;
using static System.Console;
using System.Globalization; 

namespace AdoptAButterfly
{
    public class Butterfly
    {
        public static string Name = "Anonymous Butterfly";
        public static string Type = "Anonymous Butterfly Type";
        public static string Personality = "Anonymous Butterfly Personality Type";
        public static string Location = "Anonymous Location";
        public static string Food = "Anonymous Food";
        public static int Time; 


        public void Explore()
        {
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;

            WriteLine("What will you name your butterfly?");

           
         
            Name = ReadLine();
            Name = TitleCase.ToTitleCase(Name);
            WriteLine(Player.Name + " has named " + Player.Gender + " butterfly, "  + Name + ".");
            ReadLine();
            Clear();

            WriteLine("Next you will pick your butterfly type. What type is your butterfly?");
            

            Type = ReadLine();
            WriteLine("Hello "  + Name + " the "  + Type + " butterfly.");
            ReadLine();
           
            Clear();

            WriteLine("Finally, you will add some personality to your butterfly. What is one personality trait you want your butterfly to have?");
 
            Personality = ReadLine();
            WriteLine(Player.Name + " has successfully adopted, "  + Name +  " the " + Personality + " butterfly " + Type + ".");
            ReadLine();

          
            Clear();

            WriteLine("Now it's time to go on a journey with your butterfly. Where will you go with your butterfly? Choose a destination."); 

            Location = ReadLine();
            Location = TitleCase.ToTitleCase(Location); 
            WriteLine(Player.Name + " has decided to travel to, " + Location + " with " + Player.Gender + " butterfly.");
            ReadLine();
            Clear(); 


        }

        public void Eat()
        {
            WriteLine("Your butterfly will get hungry. You need to feed it, so choose what food your butterfly might enjoy eating. What is one of your butterfly's favorit food?");

            Food = ReadLine();
            WriteLine(Name + " enjoy eating " + Food + ".");
            ReadLine();
            Clear();

        }

        public void Rest()
        {
          
            WriteLine("It is almost nightime and your butterfly will need to recharge his energy to contintue the next day. How long will your butterfly rest for?");

            Time = Convert.ToInt32(ReadLine());
            WriteLine("Your butterfly, " + Name + " rests for " + Time + " minutes. Thank you for playing. Until next time . . . bye. Press enter exit.");
            ReadKey(); 
             

        }
    }
}