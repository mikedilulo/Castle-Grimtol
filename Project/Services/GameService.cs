using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project
{
  public class GameService : IGameService
  {
    private IGame _game { get; set; }

    public List<string> Messages { get; set; }
    public GameService()
    {
      _game = new Game();
      Messages = new List<string>();
    }

    public void PrintMenu()
    {
      Messages.Add(new string($"{_game.CurrentRoom.Description}"));
    }
    public void Go(string direction)
    {
      if (_game.CurrentRoom.Exits.ContainsKey(direction))
      {
        _game.CurrentRoom = _game.CurrentRoom.Exits[direction];
      }
      Console.Clear();
      //NOTE changed from Invalid Input to the actual room description because it was hitting it and it worked! 
      Messages.Add(new string($"{_game.CurrentRoom.Description}"));
    }
    public void Help()
    {
      //NOTE This are helpful tips that a player can have during the game. Appears when you type in help.
      Messages.Add(new string("type go <direction> to move about the rooms"));
      Messages.Add(new string("type inventory to view inventory"));
      Messages.Add(new string("type take <item> to take item and place in inventory"));
      Messages.Add(new string("type use <item> to use item"));
      Messages.Add(new string("type look for the description of the room you are currently in"));
      Messages.Add(new string("type reset to restart the current game that you are in."));
    }

    public void Inventory()
    {
      foreach (var item in _game.CurrentPlayer.Inventory)
      {
        System.Console.WriteLine(item.Name);
      }
      System.Console.WriteLine("You have no items in your inventory");
    }

    public void Look()
    {
      //NOTE this displays the description of the room that you are currently in.
      Messages.Add(new string($"{_game.CurrentRoom.Description}"));
    }


    //NOTE DELETED QUIT TO BE ABLE TO CALL IT IN THE CONSOLE

    ///<summary>
    ///Restarts the game 
    ///</summary>
    public void Reset()
    {
      _game.Setup();
    }

    public void Setup(string playerName)
    {
      playerName = "Link";
    }
    ///<summary>When taking an item be sure the item is in the current room before adding it to the player inventory, Also don't forget to remove the item from the room it was picked up in</summary>
    public void TakeItem(string itemName)
    {
      throw new System.NotImplementedException();
    }
    ///<summary>
    ///No need to Pass a room since Items can only be used in the CurrentRoom
    ///Make sure you validate the item is in the room or player inventory before
    ///being able to use the item
    ///</summary>
    public void UseItem(string itemName)
    {
      throw new System.NotImplementedException();
    }
  }
}