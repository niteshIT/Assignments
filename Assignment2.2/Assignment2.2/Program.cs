using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    public enum DuckType
    {
        RubberDuck,
        MallardDuck,
        RedheadDuck
    }
    class Program
    {
        static void Main(string[] args)
        {
            var duckmanagement = new DuckManagement();
            while (true)
            {
                //2.Add a duck
                //3.Remove a duck
                //4.Remove all ducks
                //5.Capability to iterate the duck collection in increasing order of their weights.
                //This should be the collections default iteration behaviour.
                //6.Capability to iterate the duck collection in increasing order of number of wings
                Console.WriteLine("1.Add a duck");
                Console.WriteLine("2.Remove a duck");
                Console.WriteLine("3.Remove all ducks");
                Console.WriteLine("4.Iterate the duck collection in increasing order of their weights.");
                
                Console.WriteLine("5.Iterate the duck collection in increasing order of number of wings");
                Console.WriteLine("6. Exit");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Type of Duck you want to add.");
                        Console.WriteLine("1.RubberDuck");
                        Console.WriteLine("2.Mallardduck");
                        Console.WriteLine("3.RedheadDuck");
                        int option2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the number of wings");
                        int wings = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the weight");
                        int weight = int.Parse(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                var rubberduck = new RubberDuck(name, wings, weight);
                                duckmanagement.AddDuck(rubberduck);
                                break;
                            case 2:
                                var mallardduck = new RubberDuck(name, wings, weight);
                                duckmanagement.AddDuck(mallardduck);
                                break;
                            case 3:
                                var redheadduck = new RubberDuck(name, wings, weight);
                                duckmanagement.AddDuck(redheadduck);
                                break;
                            default:
                                Console.WriteLine("No match found");
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the duck");
                        string name1 = Console.ReadLine();
                        duckmanagement.Deleteduck(name1);

                        break;
                    case 3:
                        duckmanagement.DeleteAll();
                        Console.WriteLine("All data have been deleted");
                        break;
                    case 4:
                        List<Duck> x = duckmanagement.SortByWeight();
                        foreach(Duck item in x)
                        {
                            Console.WriteLine("Name: {0} Weight: {1} Number of wings: {2}",item.Name,item.Weight,item.NoofWings);

                        }

                        break;
                    case 5:
                        List<Duck> y = duckmanagement.SortByWings();
                        foreach (Duck item in y)
                        {
                            Console.WriteLine("Name: {0} Weight: {1} Number of wings: {2}", item.Name, item.Weight, item.NoofWings);

                        }
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("No match found");
                        break;
                }
            }
            
        }
    }
}
//var rubberduck = new RubberDuck();
//rubberduck.Weight = 40;
//rubberduck.NoofWings = 100;
//rubberduck.ShowDetail();
//Console.WriteLine();
//var mallardduck = new MallardDuck();
//mallardduck.Weight = 20;
//mallardduck.NoofWings = 500;
//mallardduck.ShowDetail();
//Console.WriteLine();
//var redheadduck = new RedheadDuck();
//redheadduck.Weight = 30;
//redheadduck.NoofWings = 300;
//redheadduck.ShowDetail();
//Console.ReadLine();
