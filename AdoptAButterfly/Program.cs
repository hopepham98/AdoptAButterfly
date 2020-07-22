using static System.Console;
using System.Globalization;

namespace AdoptAButterfly
{

    /*
     * Adopt A Butterfly by Hope Pham
     * PROG 101 (01), June 08, 2020
     * [Assisted by professor Janell Baxter]
     * Title created at network-science.de
     * 
     */

    class Program
    {
        static void Main() 
        {
            BackgroundColor = System.ConsoleColor.White;
            ForegroundColor = System.ConsoleColor.Magenta;
            Clear();
            string TitleText = "Adopt A Butterfly by Hope Pham";
            TitleText = @"   


              _                    __      __                        _     
            /  )   /       _/_    /  )    /  )     _/__/_        /) //             
           /--/ __/ __ _   /     /--/    /--<  . . /  /  _  __  // // __  ,   
          /  (_(_/_(_)/_)_<__   /  (_   /___/_(_/_<__<__</_/ (_//_</_/ (_/_  (\o/)
                     /                                        />        /    (/|\)
              
                                      By Hope Pham   
                                  Assisted by professor
                                      Janell Baxter
                                  (press enter to play)
";

            Title = "Adopt A Butterfly by Hope Pham";
            Write(TitleText);
            
         

            ReadKey();
            Clear();

            Player player = new Player();
            player.Start();
            Clear();

            Butterfly butterfly = new Butterfly();
            butterfly.Explore();

            butterfly.Eat();

            butterfly.Rest();
            
        }
    }
}
