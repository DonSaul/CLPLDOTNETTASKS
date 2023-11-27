//Calculando el área y perímetro de un cuadrado.
    Console.Write("Ingresa la longitud: ");
    int longitud = int.Parse(Console.ReadLine());

    int area = longitud * longitud;
    int perimetro = longitud * 4;

    Console.WriteLine($"Area del cuadrado: {area}");
    Console.WriteLine($"Perímetro del cuadrado: {perimetro}");

//Pregunta edad persona.
    Console.WriteLine("Cuál es tu nombre?");
    string nombre = Console.ReadLine();
    Console.WriteLine("Cuál es tu edad?");
    int edad = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 0;

    while (edad == 0)
    {
        Console.WriteLine($"{nombre} Por favor ingresa tu edad con un número");
        edad = int.TryParse(Console.ReadLine(), out resultado) ? 1 : 0;
    }
    Console.WriteLine($"Hola {nombre} tu edad es {edad}");

//Cálculo de longitud y area de un círculo.
    Console.WriteLine("Ingresar el radio: ");
    double r=int.Parse(Console.ReadLine());
    double length = 2 * Math.PI * r;
    double area2 = Math.PI * r * r;
    double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r,3);

    Console.WriteLine($"Valor de radio ingresado {r}\n la longitud corresponde a: {length}\n el área corresponde a: {area2} \n el volúmen corresponde a: {volume}");

