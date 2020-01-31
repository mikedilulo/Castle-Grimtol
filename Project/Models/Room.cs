using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }



    //NOTE method for adding rooms in connections
    // public void RoomDestination(Room room)
    // {
    //       Exits.Add(room.Name, room);
    //       room.Exits.Add(Name, this);
    //     }


    //NOTE Contructor 
    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
      Exits = new Dictionary<string, IRoom>();
    }
  }
}