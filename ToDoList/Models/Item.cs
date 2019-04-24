using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
    Console.WriteLine("Welcome to the To Do List.");
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
    string userInput = Console.ReadLine();

    if (userInput == "Add" || userInput == "add")
    {
      Console.WriteLine("Please enter the new description: ");
      string userDescription = Console.ReadLine();
      Item userItem = new Item(userDescription);
      Console.WriteLine(userItem.GetDescription() + " has been added to the list!");
      Main();
    }
    else if (userInput == "View" || userInput == "view")
    {
      foreach (Item toDoItem in Item.GetAll())
      {
        Console.WriteLine(toDoItem.GetDescription());
      }
      Main();
    }
  }
}

    public class Item
    {
        private string _description;
        private static List<Item> _instances = new List<Item> {};

        public Item (string description)
        {
          _description = description;
          _instances.Add(this);
        }

        public string GetDescription()
        {
          return _description;
        }
        public void SetDescription(string newDescription)
        {
          _description = newDescription;
        }

        public static List<Item> GetAll()
        {
          return _instances;
        }

        public static void ClearAll()
        {
          _instances.Clear();
        }

    }

  }
