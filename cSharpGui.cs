using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
// Namespace thingy
namespace outofideafornamespacename
{
  class cSharpGui
  {
    static void Main(string[] args)
    {
      // Declaring string
      string query;
      // Defining and assigning String variables
      string intro = "Thanks for downloading this C# simple program created by BrokeWebDeveloper!";
      string desc = "This is a C# GUI app, In here you can see Graphics and other Visual \n things rather than CONSOLE WHICH IS VERY BORING FOR THE AVERAGE USER!";
      string startornot = "Do you want to start the GUI App or not? (y/n)";
      string ifyes = "Ok... the program will start....";
      string ifno = "Ok... the program will close....";
      string wronganswer = "Err code 0, Please run the program again.";
      // Making the console foreground color green
      Console.ForegroundColor = ConsoleColor.Green;
      // printing the strings
      Console.WriteLine(intro);
      Console.WriteLine(desc);
      Console.WriteLine(startornot);
      query = Console.ReadLine();
      // Doing some if else conditionals
      if (query == ("y"))
      {
        Console.WriteLine(ifyes);
        label1.Text = "FIRST LABEL IN C#!";
        label1.BorderStyle = BorderStyle.FixedSingle;
        label1.TextAlignment = ContentAlignment.MiddleCenter;
      }
    
      else if (query == ("n"))
      {
        Console.WriteLine(ifno);
        Environment.Exit(0);
      }
    
      else  
      {
        Console.WriteLine(wronganswer);
        Environment.Exit(0);
      }
      // Using ReadKey command because it will prevent the console from closing instantly
      Console.ReadKey();
    }
  }
}
