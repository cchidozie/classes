

using System;


namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, startDate, endDate, status, assignee;
            Console.Write("Enter project name: ");
            name = Console.ReadLine();

            Console.Write("Enter project start date: ");
            startDate = Console.ReadLine();

            Console.Write("Enter project end date: ");
            endDate = Console.ReadLine();

            Console.Write("Enter project status: ");
            status = Console.ReadLine();

            Console.Write("Who is the project assigned to? : ");
            assignee = Console.ReadLine();

            AddProject addProject = new AddProject(name, startDate, endDate, status, assignee);

            Console.WriteLine(addProject.printProject());
            Console.ReadLine();

        }
    }
}
