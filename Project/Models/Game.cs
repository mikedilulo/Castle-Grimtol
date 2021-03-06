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
      Room RoomZero = new Room("Room-Zero", "You have fallen into a pit with spikes at the bottom and have died. You have lost the game! Next time brave adventurer, you will need to make sure you follow the path and read the script", true);
      Room RoomOne = new Room("Room-One", "During your slumber you have woken up in a dark and mysterious place. You wake up, groggy, to look around to gather your surroundings. To the East you See a door that is barely cracked open. To the north you see a mysterious door that is intriguing. If you head through the door to the north you will fall into a pit with spikes at the bottom. What would you like to do?", true);
      Room RoomTwo = new Room("Room-Two", "You enter into a room that has some lighting. As you've gathered your surroundings you realize you are trapped in some sort of dungeon and you will need to find your way out. You start searching the room to find anything that can help out. I wonder if you get on your hands and knees you can maybe find something that is on the floor", false);
      Room RoomThree = new Room("Room-Three", "You are once again trapped in another room. This room is much darker than last time, realizing you do not have a light source you maybe try feeling the wall for a brick that is out of place. During this process you come across a door that is barely cracked open to the East.", true);
      Room RoomFour = new Room("Room-Four", "You enter into the last room realizing the peep hole was a retina scanner and proved great success. Congratulations, you have won the game!", true);


      //NOTE Creating the relationships
      Item light = new Item("light", "this is a light to brighten up the room");

      //NOTE Creating the relationships between each room
      RoomOne.Exits.Add("north", RoomZero);
      RoomOne.Exits.Add("east", RoomTwo);
      RoomTwo.Exits.Add("west", RoomOne);
      RoomTwo.Exits.Add("east", RoomThree);
      RoomThree.Exits.Add("west", RoomTwo);
      RoomThree.Exits.Add("east", RoomFour);

      //NOTE Adding items to rooms
      RoomTwo.Items.Add(light);


      //NOTE Starting room for the character
      CurrentRoom = RoomOne;


      //NOTE new Player
      Player Me = new Player("Mike");

      CurrentPlayer = Me;

    }

    public Game()
    {
      Setup();
    }
  }
}