# Adopt A Butterfly :butterfly:
This application was part of an assignment for my Summer 2020 Intro Programming class. It's an application that enables players to create a custom 
butterfly.

## Assignment Challenge(s)
The challenge for this assignment was to figure out what to include in the UML diagram and how to organize my codes within classes and methods. To solve my concern for the UML diagram, I first figure out what classes and methods I want to include in my application based on my application name. I watched my class meeting videos for my other concern since my instructor had some coding in there and watching my instructor code, which helps me figure out how to organize my codes.


![Image of Adopt A Butterfly Intro](https://user-images.githubusercontent.com/67672827/88245790-0e78a080-cc5e-11ea-815c-4ba40d0e567f.png)

## Assignment's Title Code Example:

```markdown
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
        }
    }
```
