using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Program
{
  class hypercodes
  {
    static void Main(string[] args)
    {
      // Setting the foreground color
      Console.ForegroundColor = ConsoleColor.Green;
      // Assigning string variables
      string intro = "Thanks for downloading Hyper Codes! by BrokeWebDeveloper";
      string desc = "Made by BrokeWebDeveloper and made with C#.\n";
      string storyline = "A cyber outbreak has begun in the year 2156..\n" +
      "Employees of the National Security Agency of USA has been reporting unexpected outages in NSA's servers..\n" +
      "A hacker organisation named the E.O.1 or E.Coli Of the 1nternet... has formed.\n" +
      "Anonymous and other hacker organisations has gone (under_the_radar)..\n" +
      "A mysterious anti-hacker group under the code name ''Hyper Codes'' has formed.\n" +
      "You are one of the members of the anti-hacker group.\n" +
      "The fourth pience of Kryptos is solved by a unknown man...\n" +
      "FBI's have investigated E.O.1's activity and founded the leader of the group to be named as Player 0.\n";
      string mission = "Your mission is to uncover the real identity of Player 0 AND special bonus game is going to be given..";
      string endcard = "Credits to" +
        "Bug fixes = BayoDino, Ergastolator1, BrokeWebDeveloper\n" +
        "Creator and Storyline and Code Creation = BrokeWebDeveloper\n";
      // Printing the strings
      Console.WriteLine(intro);
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine(desc);
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine(storyline);
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine(mission);
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("Your default attack points is 189 and your lifePoints is 4000 and your defense points is 2000..");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("A Bug attribute's attack points is 5-6 average..");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("A malware or ransomware attribute's attack points is 20-200 average..");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("How the game works : \n");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("If a monster hits you with the random number,\nthe damage will be subtracted from the no of your defense points");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("You also have attack points\nif you hit a monster, you will subtract the lifePoints of that monster,\nfrom the attack points of you.\nif the monster's lifePoints hits zero you won against the monster");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("NOW! there are options [a] start the journey,\n [b] run like a coward,\n close the program.");
      System.Threading.Thread.Sleep(1000);
      string readtheline = Console.ReadLine();
      // Using if-else statements *_*
      if (readtheline == ("a"))
      {
        a();
      }
      
      else if (readtheline == ("b"))
      {
        b();
      }
      
      else 
      {
        Console.WriteLine("Whooops! you run the command : ''ERR''");
      }
      // Using the "ReadKey" command so that the console in Windows will not be closed directly
      Console.ReadKey();
    }
    
    static void a()
    {
      // Setting the foreground color
      Console.ForegroundColor = ConsoleColor.Green;
      // Assigning Integer variables with value
      // Player's values
      int playerLifePoints = 4000;
      int playerAttackPoints = 189;
      int playerDefensePoints = 2000;
      // Trojan horse's values
      int trojanHorseLifePoints = 180;
      int trojanHorseAttackPoints = 200;
      // Scurvy's values
      int scurvyLifePoints = 168;
      int scurvyAttackPoints = 30;
      // bufferOverFlow's values
      int bufferOverFlowLifePoints = 10;
      int bufferOverflowAttackPoints = 5;
      // wannaCry's values
      int wannaCryLifePoints = 70;
      int wannaCryAttackPoints = 20;
      // Player 0's values
      int playerZeroLifePoints = 5000;
      int playerZeroAttackPoints = 200;
      Console.WriteLine("Ok...[a] we need to be strategic. show the maps! [b] come on! fight the horsies already!");
      string readtheline = Console.ReadLine(); // For @sanjay1dragon or whatever his name THIS VARIABLE IS NOT USELESS
      if (readtheline == ("a"))
      {
        Console.WriteLine("Places:\n1. Trojan HomeWorld. where trojan horses live note: Trojan horses are MOST POWERFUL OF THE CREATURES! atk points : 200\n2. Pirate's lagoon, where Scurvys live\n3. Bug town, where bugs live ");
        Console.WriteLine("Where do you want to go? [a]Trojan HomeWorld\n [b] Pirate's Lagoon\n [c] Bug Town\nNote that Trojan homewworld is the closest to E.O.1's HQ\nPirate's lagoon is a bit longer route.\nBug town is miles away..");
        readtheline = Console.ReadLine();
        if (readtheline == ("a"))
        {
          Console.WriteLine("Ok...TROJAN HORSE VIRUS FOUND which attack do you want to use?\n [a] ANTI-HORSE, 201 atk point\ns [b] Code Of Conduct, 94 atk points\n [c] Annoyance, 10 atk points.");   
          readtheline = Console.ReadLine();
          if (readtheline == ("a"))
          {
             Console.WriteLine("Wait! you aren't prepared! Trojan horse have 200 atk points while you have only 189.\n Do you want to sacrifice 12 lifePoints to get 201 atk points? (yes!/no!)");
             readtheline = Console.ReadLine();
             if (readtheline == ("yes!"))
             {
               playerLifePoints -= 12;
               playerAttackPoints += 12;
               Console.WriteLine("lifePoints/XP = 3988 [a] attack! [b] defense!");
               readtheline = Console.ReadLine();
               if (readtheline == ("a"))
               {
                 Console.WriteLine("OK! AAAAAATTTTTAAACCCKKKK!");
                 System.Threading.Thread.Sleep(3000);
                 Console.WriteLine("Taken a BIG HIT but STILL ATTACKING!");
                 playerLifePoints -= 50;
                 trojanHorseLifePoints -= 201;
                 System.Threading.Thread.Sleep(500);
                 Console.WriteLine("TROJAN HORSE KILLED! PROCEEDING TO E.0.1's HQ!");
                 System.Threading.Thread.Sleep(3000);
                 Console.WriteLine("Proceeding to Player 0!");
                 System.Threading.Thread.Sleep(15000);
                 Console.WriteLine("BOSS BATTLE! Player 0!");
                 System.Threading.Thread.Sleep(1000);
                 Console.WriteLine("Be CAREFUL!");
                 System.Threading.Thread.Sleep(1000);
                 Console.WriteLine("Player 0's lifePoints = 5000!\nPlayer 0's attackPoints = 200!");
                 System.Threading.Thread.Sleep(1000);
                 Console.WriteLine("Player 0 has 2012 more lifePoints than you! be careful!");
                 System.Threading.Thread.Sleep(1000);
                 Console.WriteLine("AAAAAATTTTTTAAAACCCKKK PLAYER 0!");
                 System.Threading.Thread.Sleep(10000);
                 playerZeroLifePoints -= 5000;
                 Console.WriteLine("YOU WON! Player 0 is killed!");
                 System.Threading.Thread.Sleep(1000);
                 Console.WriteLine("Searching Player 0's identity..");
                 System.Threading.Thread.Sleep(5000);
                 Console.WriteLine("Player 0's identity is.......");
                 System.Threading.Thread.Sleep(1000);
                 Console.WriteLine("Alexander HAX!");
                 endCard();
               }
               
                 else if (readtheline == ("b"))
                 {
                   Console.WriteLine("DEFENDING!!!!");
                   System.Threading.Thread.Sleep(3000);
                 }
               
                 else 
                 {
                   Console.WriteLine("Hmm... you answered wrong..");
                 }
             }
            
             else if (readtheline == ("no!"))
             {
               Console.WriteLine("Ok.. ");
             }
          }
          
          else if (readtheline == ("b"))
          {
            Console.WriteLine("Sorry, that attack's attack points is too low");
          }
          
          else if (readtheline == ("c"))
          {
            Console.WriteLine("Nope... way too low attack points, the attack points of Trojan horse is 200..");
          }
        }
        
        else if (readtheline == ("b"))
        {
          Console.WriteLine("Ok..SCURVYS FOUND! which attack do you want to use?\n [a] anti-scurvy, 50 atk points\n [b] scurio, 10 atk points");
          readtheline = Console.ReadLine();
          if (readtheline == ("a"))
          {
            Console.WriteLine("Whoops! man! Scurvys are fast! they attacked you first! defense points = 1970");
            Console.WriteLine("Attacking back!");
            scurvyLifePoints -= 168;
            Console.WriteLine("SCURVY KILLED!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Proceeding to Player 0..");
            System.Threading.Thread.Sleep(15000);
            Console.WriteLine("BOSS BATTLE! Player 0!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("BE CAREFUL!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Player 0's lifePoints = 5000!\nPlayer 0's attackPoints = 200!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Player 0 has 1000 more lifePoints than you! be careful!");
            if (playerAttackPoints < playerZeroAttackPoints)
            {
              Console.WriteLine("Ooops! you need more attack points, 30 more!\n Do how much lifePoints do you want to sacrifice?\n [a] 30 [b] 40 [c] 50");
              readtheline = Console.ReadLine();
              if (readtheline == ("a"))
              {
                Console.WriteLine("Ok... sacrificing 30 lifePoints/XP for 30 more atk points");
                playerLifePoints -= 30;
                playerAttackPoints += 30;
                if (playerAttackPoints > playerZeroAttackPoints)
                {
                   Console.WriteLine("ATTTTAAAAAACCCKKK!!!!");
                   System.Threading.Thread.Sleep(3000);
                   playerZeroLifePoints -= 5000;
                   Console.WriteLine("aaannnddd.... YOU WON!");
                  System.Threading.Thread.Sleep(1000);
                   Console.WriteLine("Searching Player 0's identity..");
                   System.Threading.Thread.Sleep(5000);
                   Console.WriteLine("Player 0's identity is.......");
                  System.Threading.Thread.Sleep(1000);
                   Console.WriteLine("Alexander HAX!");
                   endCard();
                }
              
                else if(playerLifePoints == 4000)
                {
                  Console.WriteLine("There appears to be a problem in the process.. come back later");
                }
              
                else 
                {
                  Console.WriteLine("Well, that's unexpected!");
                }
              }
            
              else if (readtheline == ("b"))
              {
                Console.WriteLine("Okay.... sacrificing 40 lifePoints/XP for 40 more atk points");
                playerLifePoints -= 40;
                playerAttackPoints += 40;
                if (playerAttackPoints > playerZeroAttackPoints)
                {
                   Console.WriteLine("ATTTTAAAAAACCCKKK!!!!");
                   System.Threading.Thread.Sleep(3000);
                   playerZeroLifePoints -= 5000;
                   Console.WriteLine("aaannnddd.... YOU WON!");
                  System.Threading.Thread.Sleep(1000);
                   Console.WriteLine("Searching Player 0's identity..");
                   System.Threading.Thread.Sleep(5000);
                   Console.WriteLine("Player 0's identity is.......");
                  System.Threading.Thread.Sleep(1000);
                   Console.WriteLine("Alexander HAX!");
                   endCard();
                }
              
                else if(playerLifePoints == 4000)
                {
                  Console.WriteLine("There appears to be a problem in the process.. come back later");
                }
              
                else 
                {
                  Console.WriteLine("Well, that's unexpected!");
                }
              }
            
              else if(readtheline == ("c"))
              {
                Console.WriteLine("Ok.. sacrificing 50 lifePoints/XP for 50 more atk points");
                playerLifePoints -= 50;
                playerAttackPoints += 50;
                if (playerAttackPoints > playerZeroAttackPoints)
                {
                   Console.WriteLine("ATTTTAAAAAACCCKKK!!!!");
                   System.Threading.Thread.Sleep(3000);
                   playerZeroLifePoints -= 5000;
                   Console.WriteLine("aaannnddd.... YOU WON!");
                   System.Threading.Thread.Sleep(1000);
                   Console.WriteLine("Searching Player 0's identity..");
                   System.Threading.Thread.Sleep(5000);
                   Console.WriteLine("Player 0's identity is.......");
                   Console.WriteLine("Alexander HAX!");
                   endCard();
                }
              
                else if(playerLifePoints == 4000)
                {
                  Console.WriteLine("There appears to be a problem in the process.. come back later");
                }
              
                else 
                {
                  Console.WriteLine("Well, that's unexpected!");
                }
              }
            
              else 
              {
                Console.WriteLine("That's unexpected!");
              }
            }
          }
          
          else if(readtheline == ("b"))
          {
            Console.WriteLine("mEh... that's too little. closing the game");
            System.Threading.Thread.Sleep(1000);
            endCard();
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
          }
        }
        else if(readtheline == ("c"))
        {
          Console.WriteLine("THIS SHOULD BE EASY FOR YOU!");
          Console.WriteLine("Ok... Proceeding to Bug town");
          System.Threading.Thread.Sleep(15000);
          Console.WriteLine("Ok....bufferOverFlow FOUND!");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Whoah... those bugs have a special ability! they can attack you with 100 atk DIRECTLY TO THE LIFEPOINTS!");
          System.Threading.Thread.Sleep(1000);
          playerLifePoints -= 100;
          Console.WriteLine("Our lifePoints is now 89! CLOSE CALL!");
          System.Threading.Thread.Sleep(500);
          Console.WriteLine("but as long as we have lifePoints we'll ATTTTTAAACKKKK!");
          System.Threading.Thread.Sleep(1000);
          bufferOverFlowLifePoints -= 189;
          Console.WriteLine("AAAAHHHH UNEXPECTED ATTACK FROM Player 0! you lost 70 lifePoints!");
          System.Threading.Thread.Sleep(1000);
          playerLifePoints -= 70;
          Console.WriteLine("YOU HAVE 10 LIFEPOINTS LEFT!");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("AAAAATTTTAAACCCCKKKK!!!");
          System.Threading.Thread.Sleep(1000);
          playerZeroLifePoints -= 5000;
          Console.WriteLine("Searching Player 0's identity....");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("ITTTSSS.... Alexander HAX!");
          endCard();
        }
        
          else 
          {
            Console.WriteLine("Whoops! you typed the wrong answer! please try again!");
          }
      }
      
      else if(readtheline == ("b"))
      {
        Console.WriteLine("Hmm.. you seem to be rushing.. ok then..");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("WAIT! your atk points is 189 while Trojan Horses' atk points is 200.");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("You need to sacrifice 12 lifePoints to get additional 12 lifePoints\n So that your atk points is more than the horses'");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Ok.. sacrificing 12 lifePoints");
        playerLifePoints -= 12;
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Adding 12 atk points");
        playerAttackPoints += 12;
        Console.WriteLine("Attack? (YES!/NO!)");
        readtheline = Console.ReadLine();
        if (readtheline == ("YES!"))
        {
          Console.WriteLine("ATTACKKKK!");
          trojanHorseLifePoints -= 180;
          System.Threading.Thread.Sleep(500);
          Console.WriteLine("YOU WON!");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Proceeding to Player 0..");
          System.Threading.Thread.Sleep(15000);
          Console.WriteLine("BOSS BATTLE! Player 0!");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("BE CAREFUL!");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Player 0's lifePoints = 5000!\nPlayer 0's attackPoints = 200!");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Player 0 has 1012 more lifePoints than you! be careful!");    
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("ATTTTAAAAAACCCKKK!!!!");
          System.Threading.Thread.Sleep(3000);
          playerZeroLifePoints -= 5000;
          Console.WriteLine("aaannnddd.... YOU WON!");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Searching Player 0's identity..");
          System.Threading.Thread.Sleep(5000);
          Console.WriteLine("Player 0's identity is.......");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Alexander HAX!");
          endCard();
        }
        
        else if (readtheline == ("NO!"))
        {
          Console.WriteLine("I guess start the endCards now?");
          endCard();
        }
      }
      // Using the ReadKey command so that users in windows will not close the console instantly!
      Console.ReadKey();
    }
    
    static void b()
    {
      // Setting the foreground color
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Ok.. closing in 3!");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("2!");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("1!");
      System.Threading.Thread.Sleep(500);
      Console.WriteLine("Closing....");
      Environment.Exit(0);
    }
    
    static void endCard()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nCredits to\n Bug fixes = BayoDino, Ergastolator1, BrokeWebDeveloper\n Creator and Storyline and Code Creation = BrokeWebDeveloper\n");
      Console.ReadKey();
    }
  }
}
