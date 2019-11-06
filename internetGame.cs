using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
// Oooh... I know! namespaces are like packages in Java right? namespace and package BOTH contains class!
namespace internetgame
{
  class internetGame
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      int lifePoints = 100;
      // declaring strings
      string doyouwantogo;
      string continu;
      string continuEE;
      // Assigning string variables
      string intro = "Thanks for downloading this C-Sharp program by (BrokeWebDeveloper)!";
      string desc = "This program is made by (BrokeWebDeveloper) for the purpose of (BrokeWebDeveloper) trying method in C#.\n while also making a game\n";
      string storyline = "Once UPON A TIME..... the world of Internet was SPLIT into 4 PARTS.... each one is a different area,";
      string mainstream = "One such place is called the mainstream area, \n where they do normal things.. like watching YouTube.";
      string notsousuall = "Another is called the Not So Usual area, \n where EVEN BABIES CODE!";
      string helloworld = "and another was called the Hello, World! area, \n where programmers can start their long Journey.";
      string gamingworld = "This is where everybody a gamer stay (ALOT), \n where to the point spent 10 hours a day here. ";
      string plot = "The unknown area of the internet called the Silk Road or Dark Web, \n has started to invade the Internet inc which controls the four area.";
      string quest = "Among the code rubble are an ARMY of Server Technician...\n with their help you can help restore peace..";
      string perils = "BUT! one does not simply searched the Server Technician as they are in another world called the Real World!";
      string toget = "To find them you must go to the Internet-RealWorld Portal..";
      string doyouwantotgo = "Do you want to risk the dangers of Internet-RealWorld Portal, \n as they can be unmerciful for ones like you? (y!/n!)";
      // Printing strings
      Console.WriteLine(intro);
      Console.WriteLine(desc);
      Console.WriteLine(storyline);
      Console.WriteLine(mainstream);
      Console.WriteLine(notsousuall);
      Console.WriteLine(helloworld);
      Console.WriteLine(gamingworld);
      Console.WriteLine(plot);
      Console.WriteLine(quest);
      Console.WriteLine(perils);
      Console.WriteLine(toget);
      Console.WriteLine(doyouwantotgo);
      doyouwantogo = Console.ReadLine();
      // If else statement for doyouwantotgo
      if (doyouwantogo == ("y!"))
      {
        Console.WriteLine("Ok... fighting the bots of the Internet...");
        lifePoints -= 10;
        Console.WriteLine("You lost 10 lifePoints.. you have 90 do you want to continue? (y/n)");
        continu = Console.ReadLine();
        if (continu == ("y"))
        {
          Console.WriteLine("You are Halfway! but lost 20 lifePoints from fighting Hackers! 70 lifePoints left!");
          lifePoints -= 10;
          Console.WriteLine("Do you want to CONTINUE? (y/n)");
          continuEE = Console.ReadLine();
          if (continuEE == ("y"))
          {
            continuethegameseventy();
          }
        }
      }
      
      else if (doyouwantogo == ("n!"))
      {
        Console.WriteLine("Ok.. you lost the BATTLE OF INTERNET! YOU WILL EXIT THE GAME!");
        Environment.Exit(0);
      }
      
      else 
      {
        Console.WriteLine("You wrote the wrong command! Please write only y! if you agree and write n! if you disagree.");
      }
      // so that the Console won't close instantly
      Console.ReadKey();
    }
    
    static void continuethegameseventy()
    {
       // Continue the game with 70 lifePoints
       int lifePoints = 70;
       // Declaring string variables
       string query;
       Console.ForegroundColor = ConsoleColor.Green;
       Console.WriteLine("Attacked! 60 lifePoints left!");
       lifePoints -= 10;
       Console.WriteLine("Player! avoid Trojan horse UP AHEAD!");
       Console.WriteLine("Do you want to continue! (y/n)");
       query = Console.ReadLine();
       if (query == ("y"))
       {
         Console.WriteLine("Attacking!");
         Console.WriteLine("Unexpected BLOW FROM TROJAN HORSE! 30 lifePoints left!");
         lifePoints -= 30;
         Console.WriteLine("You ARRIVED AT THE PORTAL..");
         Console.WriteLine("You WON THE GAME! YOU TALKED WITH THE Server Techinician, \n and Together fought the hacker until we WON!");
         System.Threading.Thread.Sleep(5000);
         Console.WriteLine("Thanks for Playing the Internet Game! (Made by BrokeWebDeveloper)");
         System.Threading.Thread.Sleep(2000);
         Environment.Exit(0);
      }
       
      else if (query == ("n"))
      {           
        Console.WriteLine("Ok.. you lost the BATTLE OF INTERNET! YOU WILL EXIT THE GAME!");
        Environment.Exit(0);
      }
        
      else 
      {
        Console.WriteLine("You wrote the wrong command! Please write only y! if you agree and write n! if you disagree.");
      }
      // so that the Console won't close instantly
      Console.ReadKey();
    }
  }
}
