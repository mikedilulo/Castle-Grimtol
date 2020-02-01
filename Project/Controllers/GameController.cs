using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project.Controllers
{

  public class GameController : IGameController
  {
    private GameService _gameService = new GameService();

    //NOTE This is the method that will keep the application running
    private bool _playing = true;

    //NOTE Makes sure everything is called to finish Setup and Starts the Game loop
    public void Run()
    {
      System.Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      _gameService.Setup(name);
      _gameService.PrintMenu();
      while (_playing)
      {
        Print();
        GetUserInput();
      }
    }

    //NOTE Gets the user input, calls the appropriate command, and passes on the option if needed.
    public void GetUserInput()
    {
      Console.WriteLine("What do you want to do?");
      string input = Console.ReadLine().ToLower() + " ";
      string command = input.Substring(0, input.IndexOf(" "));
      string option = input.Substring(input.IndexOf(" ") + 1).Trim();
      //NOTE this will take the user input and parse it into a command and option.
      //IE: take silver key => command = "take" option = "silver key"

      //NOTE Switch Statement that quites the game
      switch (command)
      {
        case "QUIT":
        case "Quit":
        case "quit":
          _playing = false;
          break;
        case "go":
          Console.Clear();
          _gameService.Go(option);
          break;
        case "look":
          Console.Clear();
          _gameService.Look();
          break;
        case "help":
          _gameService.Help();
          break;
        case "reset":
          //NOTE currently isnt working when I call reset which is calling setup in the service. Only prints out the room that I am in
          _gameService.Reset();
          break;
        case "inventory":
          _gameService.Inventory();
          break;
        case "take":
          _gameService.TakeItem("key");
          break;


      };

    }

    //NOTE this should print your messages for the game.
    private void Print()
    {
      foreach (string message in _gameService.Messages)
      {
        System.Console.WriteLine(message);
      }
      _gameService.Messages.Clear();
    }

  }
}