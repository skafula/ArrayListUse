using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //ArrayList is capable to store any type and still a dynamic list. It works like list except not Generic so every method works here
        ArrayList arrList = new ArrayList();

        arrList.Add(RandomReturns.GetString());
        arrList.Add(RandomReturns.GetNumber());
        arrList.Add(RandomReturns.GetDouble());
        arrList.Add(new Employee() { Name = "Andre Onana" });

        //Because of the object of Employee i have to typecast item to Employee (used pattern matching) to access and writes its name
        //default value of an object as Console.WriteLine writes: namespace.className 

        foreach (var item in arrList)
        {
            if (item is Employee emp)
            {
                Console.WriteLine(emp.Name);
            }
            else
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Employee
    {
        public string Name { get; set; }
    }
    public static class RandomReturns
    {
        public static int GetNumber()
        {
            return 2;
        }
        public static double GetDouble()
        {
            return 3.22;
        }
        public static string GetString()
        {
            return "Hello";
        }
    }
}