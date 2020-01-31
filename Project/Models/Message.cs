
using System;
using System.Threading;

namespace ConsoleAdventure.Models
{
  class Message
  {
    public ConsoleColor Color { get; set; }
    public int PostTimeout { get; set; }
    public string Body { get; set; }
    public bool ReadKeyWait { get; set; }

    public void Print()
    {
      var defaultColor = Console.ForegroundColor;
      Console.ForegroundColor = Color;
      Console.WriteLine(Body);
      if (PostTimeout > 0)
      {
        Thread.Sleep(PostTimeout);
      }
      if (ReadKeyWait)
      {
        System.Console.WriteLine("Press any key to Continue");
        Console.ReadKey();
        Console.Clear();
      }
      Console.ForegroundColor = defaultColor;
    }


    public Message(string body)
    {
      Body = body;
      Color = Console.ForegroundColor;
    }
    public Message(string body, ConsoleColor color)
    {
      Body = body;
      Color = color;
    }
    public Message(string body, int timeout)
    {
      Body = body;
      Color = Console.ForegroundColor;
      PostTimeout = timeout;
    }
    public Message(string body, ConsoleColor color, int timeout)
    {
      Body = body;
      Color = color;
      PostTimeout = timeout;
    }
    public Message(string body, ConsoleColor color, bool readkeyWait)
    {
      Color = color;
      Body = body;
      ReadKeyWait = readkeyWait;
    }
    public Message(string body, ConsoleColor color, int timeout, bool readkeyWait)
    {
      Color = color;
      PostTimeout = timeout;
      Body = body;
      ReadKeyWait = readkeyWait;
    }
  }
}