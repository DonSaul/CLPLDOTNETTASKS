using System;

class Homework1b
{
    static void Main()
    {
        String? name;
        int age;

        try
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            name = name == "" ? throw new Exception("Tu nombre no puede ser nulo"):name; 
            Console.WriteLine( String.Format("What old are you {0}? ", name) );
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Tu nombre es " + name );
            Console.WriteLine( "Tu edad es  " + age );
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

}
