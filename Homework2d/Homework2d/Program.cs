using System;

class Homework2d
{
    struct Dog
    {
        public int Age;
        public string Name;
        public string Mark;

        public override string ToString()
        {
            return string.Format("Name: {0}, Mark: {1}, Age:{2}", Name, Mark, Age);
        }
    }

    static void Main()
    {

        try
        {
            Dog myDog;
            Console.WriteLine("Ingrese el nombre");
            myDog.Name = Console.ReadLine();
            Console.WriteLine("Ingrese la Raza");
            myDog.Mark = Console.ReadLine();
            Console.WriteLine("Ingrese la edad (int)");
            myDog.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myDog.ToString()); ;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());

        }

    }

}

