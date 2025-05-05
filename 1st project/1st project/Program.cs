using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace _1st_project
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;
        static void Main(string[] args)
        {
            //welcome user 
        
            Console.WriteLine("Welcome to my tasks tracker ");
            Console.WriteLine("-------------------------------------");

            while (true)
            {
                Console.WriteLine("Please choose number from (1 to 5) ");
                Console.WriteLine(" 1 -> Add task ");
                Console.WriteLine(" 2 -> view all tasks ");
                Console.WriteLine(" 3 -> mark task complete ");
                Console.WriteLine(" 4 -> remove task ");
                Console.WriteLine(" 5 -> Exit ");
                Console.WriteLine("-------------------------------------");
                String userChoice = Console.ReadLine();

                switch (userChoice)

                {
                    case "1":
                        //1. add task
                        AddTask();
                        Console.WriteLine("-------------------------------------");
                        break;

                    case "2":
                        //2. view all tasks 
                        viewTasks();
                        Console.WriteLine("-------------------------------------");
                        break;

                    case "3":
                        //3. mark task complete 
                        markcomplete();
                        Console.WriteLine("-------------------------------------");
                        break;

                    case "4":
                        //4. remove task
                        removetask();
                        Console.WriteLine("-------------------------------------");
                        break;

                    case "5":
                        //5. Exit 
                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Please enter number from 1 to 5 only ");
                        Console.WriteLine("TRY AGAIN");
                        Console.WriteLine("-------------------------------------");
                        break;
                }
            }
        }
        private static void AddTask()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter task title : ");

            string taskTitle = Console.ReadLine();

            tasks[taskIndex] = taskTitle;
         
            Console.WriteLine("task add");

            taskIndex++;

        }
        private static void viewTasks()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tasks list: ");

            for (int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i + 1} - task title :{tasks[i]}");
            }
        }
        private static void markcomplete()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter task number : ");
           int taskID = Convert.ToInt32( Console.ReadLine());

            tasks[taskID] = tasks[taskID] + "---COMPLETED";
        }
        private static void removetask()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter  task number you want to delete : "); 
            
            int taskID = Convert.ToInt32(Console.ReadLine());

            tasks[taskID]=string.Empty;

        }
    }
    }