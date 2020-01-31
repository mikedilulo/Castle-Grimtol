using System;
using ConsoleAdventure.Project;
using ConsoleAdventure.Project.Controllers;

namespace ConsoleAdventure
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //NOTE Need to have the controller in here with the .Run() method to keep the application running. This is where the application will be running from Program.cs. Need to implement Adventures.Project.Controllers
      GameController gc = new GameController();
      gc.Run();
    }
  }
}
