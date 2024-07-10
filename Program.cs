using System;
using System.Runtime.CompilerServices;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program sorts Customers based on their ID, Name, Salary or Gender.");

        START:
        Console.WriteLine("----------------------------------------------------------------------------------");

        Costumer C1 = new Costumer();
        C1.ID = 101;
        C1.Name = "John Lorusso";
        C1.Salary = 5000;
        C1.Gender = "Male";

        Costumer C2 = new Costumer();
        C2.ID = 102;
        C2.Name = "Ibrahim Arabaki";
        C2.Salary = 6000;
        C2.Gender = "Male";

        Costumer C3 = new Costumer();
        C3.ID = 103;
        C3.Name = "Mary Luisse";
        C3.Salary = 7000;
        C3.Gender = "Female";

        List<Costumer> LC = new List<Costumer>();
        LC.Add(C1);
        LC.Add(C2);
        LC.Add(C3);

        Console.WriteLine("Please choose a sorting criteria (id, name, salary, gender): ");
        string criteria = Console.ReadLine().ToLower();

        List<Costumer> SL = new List<Costumer>();

        SL.AddRange(LC);

        switch (criteria)
        {
            case "id":
                LC.Sort((x, y) => x.ID.CompareTo(y.ID));
                break;
            case "name":
                LC.Sort((x, y) => x.Name.CompareTo(y.Name));
                break;
            case "salary":
                LC.Sort((x,y) => y.Salary.CompareTo(x.Salary));
                break;
            case "gender":
                LC.Sort((x, y) => x.Gender.CompareTo(y.Gender));
                break;
            default:
                Console.WriteLine("Invalid Choice! Please Try Again!");
                goto START;
        }

        Console.WriteLine("List Before Sorting");
        Console.WriteLine("----------------------------------------------------------------------------------");


        foreach (Costumer C in SL)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.Gender);
            Console.WriteLine("----------------------------------------------------------------------------------");
        }

        Console.WriteLine("List After Sorting in Ascending Order w.r.t. {0}", criteria);
        Console.WriteLine("----------------------------------------------------------------------------------");

        foreach (Costumer C in LC)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.Gender);
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }

    public static void PrintList(List<Costumer> list)
    {
        foreach (Costumer C in list)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.Gender);
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
}

public class Costumer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Gender { get; set; }
}