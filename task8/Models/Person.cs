public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    virtual public string Name { get {return name;} }

    virtual public void Print()
    {
        Console.WriteLine("Name: {0}", this.name);
    }
}

// La clase Staff hereda de la clase Person
public class Staff : Person
{
    // Declaración de la variable privada 'salary'
    private decimal salary;

    public decimal Salary  // Añade una propiedad 'Salary' a la clase Staff
    {
        get { return salary; }
        set { salary = value; }
    }

    // Constructor de la clase Staff que toma dos parámetros: 'name' y 'salary'
    public Staff(string name, decimal salary) : base(name)
    {
        // Asigna el valor del parámetro 'salary' a la variable privada 'salary'
        this.salary = salary;
    }

    // Sobrescribe la propiedad 'Name' de la clase base (Person)
    // Agrega "Staff" al final del nombre
    public override string Name { get { return base.Name + "Staff"; } }

    // Sobrescribe el método 'Print' de la clase base (Person)
    public override void Print()
    {
        // Imprime el nombre y el salario del empleado
        Console.WriteLine("Name: {0}, Salary: {1}", this.Name, this.salary);
    }
}

// La clase Student hereda de la clase Person
public class Student : Person
{
    // Declaración de la variable privada 'groupName'
    private string groupName;

    // Constructor de la clase Student que toma dos parámetros: 'name' y 'groupName'
    public Student(string name, string groupName) : base(name)
    {
        // Asigna el valor del parámetro 'groupName' a la variable privada 'groupName'
        this.groupName = groupName;
    }

    // Sobrescribe el método 'Print' de la clase base (Person)
    public override void Print()
    {
        // El código para imprimir la información del estudiante iría aquí
        base.Print();
        Console.WriteLine("Group: {0}", this.groupName);
    }
}

//** Creamos las clases Teacher y Developer respectivamente

public class Teacher : Staff
{
    // Declaración de la variable privada 'subject' la cual es el nombre de la materia que imparte
    private string subject;

    //Constructor de la clase Teacher, que toma tres parámetros: 'name', 'salary' y 'subject'.
    //El constructor llama al constructor de la clase base (Staff) y le pasa los parámetros 'name' y 'salary'
    public Teacher(string name, decimal salary, string subject) : base(name, salary)
    {
        this.subject = subject;
    }

    public override string Name { get { return base.Name + "Teacher"; } }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Subject: {0}", this.subject);
    }
}

//** Creamos la clase Developer que hereda de la clase Staff
public class Developer : Staff
{
    // Declaración de la variable privada 'level' la cual es el nivel del desarrollador
    private string level;

    //Constructor de la clase Developer, que toma tres parámetros: 'name', 'salary' y 'level'.
    //El constructor llama al constructor de la clase base (Staff) y le pasa los parámetros 'name' y 'salary'
    public Developer(string name, decimal salary, string level) : base(name, salary)
    {
        this.level = level;
    }

    public override string Name { get { return base.Name + "Developer"; } }

    //Sobreescribimos el método Print de la clase base (Staff)
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Level: {0}", this.level);
    }

}