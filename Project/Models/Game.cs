using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Game : IGame
  {
    public IRoom CurrentRoom { get; set; }
    public IPlayer CurrentPlayer { get; set; }

    //NOTE Make yo rooms here...
    public void Setup()
    {
      //NOTE Creating the Rooms
      Room RoomOne = new Room("Room-One", "During your slumber you have woken up in a dark and mysterious place. You wake up, groggy, to look around to gather your surroundings. To the East you See a door that is barely cracked open. To the north you see a mysterious door that is intriguing. If you head through the door to the north you will fall into a pit with spikes at the bottom. What would you like to do?");
      Room RoomTwo = new Room("Room-Two", "You enter into a room that has small lighting. As you've gathered your surroundings you realize you are trapped in some sort of dungeon and you will need to find your way out. You start searching the room to find anything that can help out.");
      Room RoomThree = new Room("Room-Three", "You are once again trapped in another room. This room is much darker than last time, realizing you do not have a light source you maybe try feeling the wall for a brick that is out of place. During this process you come across a peep hole that is shining a tiny amount of light.");
      Room RoomFour = new Room("Room-Four", "You enter into the last room realizing the peep hole was a retina scanner and proved great success. Congratulations, you have won the game!");
      //NOTE Creating the relationships
      Item key = new Item("key", "this is a key to open the locked door");

      //NOTE Creating the relationships between each room


    }
  }
}