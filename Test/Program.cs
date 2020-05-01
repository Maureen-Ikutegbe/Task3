using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Task task1 = new Task("Assignments", "Tuesday", false);
            Task task2 = new Task("Updates", "Saturday", true);
            Task task3 = new Task("Practice", "Monday", false);


            MyList Todolist = new MyList();
            Todolist.Tasks.Add(task1);
            Todolist.Tasks.Add(task2);
            Todolist.Tasks.Add(task3);

            Console.WriteLine("Enter your command: 'A' to add, 'S' to view To-do list, and 'E' to edit list");
            var command = Convert.ToChar(Console.ReadLine());

            if (command == 'A')
            {
                Console.WriteLine("Please enter the name of task activity: ");
                string NameOfActivity = Console.ReadLine();

                Console.WriteLine("Please enter the task day: ");
                string DayOfTheWeek = Console.ReadLine();

                Task n = new Task(NameOfActivity, DayOfTheWeek, false);

                Todolist.Tasks.Add(n);

                Console.WriteLine("Your task has been added");

                Console.WriteLine("This your updated to-do list:");

                foreach (var items in Todolist.Tasks)
                {
                    Console.WriteLine(items.NameOfActivity + ", deadline is on " + items.DayOfTheWeek);
                }
            }

            else if (command == 'S')
            {
                Console.WriteLine("This your to-do list:");

                foreach (var items in Todolist.Tasks)
                {
                    Console.WriteLine(items.NameOfActivity + ", deadline is on " + items.DayOfTheWeek);
                }
            }

            else if (command == 'E')
            {
                Console.WriteLine("Select item to be modified: 'N' for name of activity and 'D' for date");
                var selection = Convert.ToChar(Console.ReadLine());

                if (selection == 'N')
                {
                    Console.WriteLine("Enter old name of activity: ");
                    string oldName = Console.ReadLine();

                    Console.WriteLine("Enter new name of activity: ");
                    string newName = Console.ReadLine();

                    for (int y = 0; y < Todolist.Tasks.Count; y++)

                    {
                        if (Todolist.Tasks[y].NameOfActivity == oldName)
                        {
                            Todolist.Tasks[y].NameOfActivity = newName;
                            Console.WriteLine("Your task has been modified");
                            Console.WriteLine("");
                            Console.WriteLine("This is your updated to-do list:");

                            foreach (var items in Todolist.Tasks)
                            {
                                Console.WriteLine(items.NameOfActivity + ", deadline is on " + items.DayOfTheWeek);
                            }

                        }
                       
                    }
               
                }

                else if (selection == 'D')
                {
                    Console.WriteLine("Enter old day for activity: ");
                    string oldDay = Console.ReadLine();

                    Console.WriteLine("Enter new day for activity: ");
                    string newDay = Console.ReadLine();

                    for (int y = 0; y < Todolist.Tasks.Count; y++)
                    {

                        if (Todolist.Tasks[y].DayOfTheWeek == oldDay)
                        {
                            Todolist.Tasks[y].DayOfTheWeek = newDay;
                            Console.WriteLine("Your task has been modified");
                            Console.WriteLine("");
                            Console.WriteLine("This your updated to-do list:");

                            foreach (var items in Todolist.Tasks)
                            {
                                Console.WriteLine(items.NameOfActivity + ", deadline is on " + items.DayOfTheWeek);
                            }
                        }
                    }
                    
                    
                }

                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}
