using System;

public class ToDoList
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;

    public static void AddTask()
    {
        if (taskCount >= tasks.Length)
        {
            Console.WriteLine("Task list is full.");
            return;
        }

        Console.WriteLine("Enter Your Task:");
        tasks[taskCount++] = Console.ReadLine();
        Console.WriteLine("Task Added Successfully!");
    }

    public static void ViewTasks()
    {
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }
    }

    public static void CompleteTask()
    {
        Console.WriteLine("Enter Task Number to Complete:");
        if (!int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        taskNumber--; // convert to zero-based index

        if (taskNumber >= 0 && taskNumber < taskCount)
        {
            tasks[taskNumber] = tasks[taskNumber] + " - Completed";
            Console.WriteLine("Task Marked as Completed!");
        }
        else
        {
            Console.WriteLine("Invalid Task Number!");
        }
    }

    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark a task as complete");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
