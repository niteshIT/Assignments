using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newassignment2._1
{
    public enum EquipmentType
    {
        Mobile,
        Immobile
    }
    class Program
    {
        static void Main(string[] args)
        {

            var equipment = new EquipmentManager();

            while (true)
            {

                Console.WriteLine("select one operation");
                Console.WriteLine("1. Create an equipment");
                Console.WriteLine("2. Delete an equipment");
                
                Console.WriteLine("3. List all equipment");
                Console.WriteLine("4. Show detail of  an equipment");
                Console.WriteLine("5. List all mobile equipment");
                Console.WriteLine("6. List all immobile equipment");
                Console.WriteLine("7. List all equipment that have not been moved till now");
                Console.WriteLine("8. Delete all equipment");
                Console.WriteLine("9. Delete all immobile equipment ");
                Console.WriteLine("10. Delete all mobile equipment");
                Console.WriteLine("11. Move equipment");
                Console.WriteLine("13. Exit");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("1. Mobile equipment");
                        Console.WriteLine("2. Immobile equipment");
                        Console.WriteLine("3. Back");
                        int input = int.Parse(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                var obj = new MobileEquipment();
                                Console.WriteLine("Enter Name");
                                obj.Name = Console.ReadLine();
                                Console.WriteLine("Enter Description");
                                obj.Description = Console.ReadLine();
                                Console.WriteLine("Enter Number of wheels");
                                obj.NumberOfWheels = int.Parse(Console.ReadLine());
                                equipment.AddEquipment(obj);

                                break;
                            case 2:
                                var obj1 = new ImmobileEquipment();
                                Console.WriteLine("Enter Name");
                                obj1.Name = Console.ReadLine();
                                Console.WriteLine("Enter Description");
                                obj1.Description = Console.ReadLine();
                                Console.WriteLine("Enter Weight");
                                obj1.Weight = int.Parse(Console.ReadLine());
                                equipment.AddEquipment(obj1);
                                break;
                            case 3:
                                break;


                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the equipment");
                        string deleteName = Console.ReadLine();
                        equipment.DeleteEquipment(deleteName);
                        break;
                    case 3:
                        List<Equipment> Allequipment = equipment.GetAllEquipment();
                        foreach (Equipment E1 in Allequipment)
                        {
                            E1.printdetail();
                        }
                        break;
                    case 4:
                        Console.WriteLine("enter the name");
                        equipment.ShowEquipmentDetails(Console.ReadLine());
                        break;
                    case 5:
                        List<Equipment> Mobileequipment = equipment.GetAllMobileEquipment();
                        foreach (Equipment E in Mobileequipment)
                        {
                            Console.WriteLine(E.Name);
                        }
                        break;
                    case 6:
                        List<Equipment> immobileequipment = equipment.GetAllImmobileEquipment();
                        foreach (Equipment E in immobileequipment)
                        {
                            Console.WriteLine(E.Name);
                        }
                        break;
                    case 7:
                        List<Equipment> zerodistance = equipment.dontmove();
                        foreach (Equipment E in zerodistance)
                        {
                            Console.WriteLine(E.Name);
                        }
                        break;
                    case 8:
                        equipment.DeleteAll();
                        break;

                    case 9:
                        equipment.DeleteAllImmobile();
                        break;
                    case 10:
                        equipment.DeleteAllMobile();
                        break;
                    case 11:
                        Console.WriteLine("enter the name of the eqipment you want to move");

                        var name=Console.ReadLine();
                        Equipment eq = equipment.returnequip(name);
                        Console.WriteLine("enter the distance you wnat to move ");
                        double dist = int.Parse(Console.ReadLine());
                        equipment.MoveEquipment(eq, dist);
                        break;
                    case 12:

                        break;










                }
            }
        }


    }


}