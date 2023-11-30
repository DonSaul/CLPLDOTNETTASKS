using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Seleccione un ejercicio para ejecutar (1-7):");
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                Exercise1();
                break;
            case "2":
                Exercise2();
                break;
            case "3":
                Exercise3();
                break;
            case "4":
                Exercise4();
                break;
            case "5":
                Exercise5();
                break;
            case "6":
                Exercise6();
                break;
            case "7":
                Exercise7();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    public static void Exercise1()
    {
        //**Definimos a y b como números enteros.
        int a,b;
        //**try-catch para manejo de excepciones.
        try
        {
            //**Pedimos al usuario que ingrese el primer número.
            Console.WriteLine("Ingrese el primer número: ");
            a = Convert.ToInt32(Console.ReadLine());
            //**Pedimos al usuario que ingrese el segundo número.
            Console.WriteLine("Ingrese el segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());
            //**Calcular que números dentro de ese rango son divisibles por 3.
            IsInRange(a,b);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
    //**Método para calcular que números dentro de un rango son divisibles por 3 sin dejar residuo.
    public static void IsInRange(int a, int b)
    {
        //**Ciclo for que va a recorrer el rango de números capturados por el usuario.
        //!! Donde i es igual al primer número capturado por el usuario y i es menor o igual al segundo número capturado por el usuario, i se incrementa en 1.
        for(int i = a; i<=b; i++)
        {
            //**Condicional para saber si el número es divisible por 3 sin residuo.
            if(i % 3 == 0)
            {
                //**Imprimimos por consola el número ubicado dentro del rango que es divisible por 3 sin residuo.
                Console.WriteLine($"El número {i} es divisible por 3 sin residuo.");
            }
        }
    }
    public static void Exercise2()
    {
        //**Definimos una variable tipo string.
        string texto;
        //**try-catch para manejo de excepciones.
        try
        {
            //**Pedimos al usuario que ingrese un texto.
            Console.WriteLine("Ingrese un texto: ");
            texto = Console.ReadLine();
            //**Ciclo for que imprima cada 2 char del texto ingresado por el usuario.
            //!!Como los arreglos empiezan en la posición 0, i es igual a 1 (es decir, el "primer" segundo caracter), i es menor que el largo del texto ingresado por el usuario, i se incrementa en 2.
            for(int i = 1; i<texto.Length; i+=2)
            {
                //**Imprimimos por consola el caracter ubicado en la posición i del texto ingresado por el usuario.
                Console.WriteLine(texto[i]);
            }
        }
        catch(FormatException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
    //**Método que contiene el ejercicio 3 de la task 3.
    public static void Exercise3()
    {
        //**Se le pide al usuario que ingrese el nombre de la bebida.
        Console.Write("Ingrese el nombre de la bebida: ");
        //**Se guarda el nombre de la bebida en una variable tipo string. (asegurando que sea en minúscula).
        string name = Console.ReadLine().ToLower();
        //**Switch-case para manejar las diferentes ocpiones de bebidas.
        switch(name)
        {
            case "coffee":
                Console.WriteLine("The price of the coffee is $3.990 CLP");
                break;
            case "tea":
                Console.WriteLine("The price of the tea is $2.990 CLP");
                break;
            case "juice":
                Console.WriteLine("The price of the juice is $4.990 CLP");
                break;
            case "water":
                Console.WriteLine("The price of the water is $1.990 CLP");
                break;
            default:
                Console.WriteLine("The drink is not available / La bebida no está disponible");
                break;
        }
    }
    //**Método que contiene el ejercicio 4 de la task 3. Calcular la media aritmetica
    public static void Exercise4()
    {
        //**Definimos una variable que almacene la sumatoria de los números que ingrese el usuario.
        int sumatoria = 0;
        //**Definimos una variable que almacene la cantidad de numeros que ingrese el usuario.
        int contador = 0;

        //**Ciclo while para manejar la entrada de números por parte del usuario.
        //!!Mientras que el usuario ingrese valores positivos, el ciclo continuará.
        while(true)
        {
            //**try-catch para manejo de errores.
            try
            {
                //**Le pedimos un número al usuario.
                Console.WriteLine("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                //**Si el numero ingresado es negativo, se rompe el ciclo.
                if(numero < 0)
                {
                    break;
                }

                //**Sumamos el número ingresado por el usuario a la sumatoria.
                sumatoria += numero;
                //**Incrementamos el contador en 1.
                contador++;
            }
            catch(FormatException e)
            {
                //!!Imprimimos el error.
                Console.WriteLine("Error: " + e.Message);
            }
        }
        //**Definimos variable que calculará la media aritmetica de los números ingresados por el usuario.
        double media = sumatoria / contador;
        //**Imprimimos por la consola el resultado de la operación.
        Console.WriteLine($"La media aritmética de los números ingresados es: {media}");
    }
    //**Método que contiene el ejercicio 5 de la task 3.
    public static void Exercise5()
    {
        //**Definimos una variable que almacene el año ingresado por el usuario
        int anio;
        //**try-catch para manejo de errores.
        try
        {
            //**Pedimos al usuario que ingrese un año.
            Console.WriteLine("Ingrese un año: ");
            anio = Convert.ToInt32(Console.ReadLine());

            //**Condicional para saber si el año ingresado es bisiesto.
            /*
                Si el año es divisible por 4, es biciesto.
                Si el año es divisible por 4 y NO por 100, es biciesto.
                Si el año es divisible por 400, es biciesto.
                Pero si el año es divisible por 100 y no por 400, no es biciesto.
            */
            //!! En resumen, si el año es divisible por 4 y no por 100, o si el año es divisible por 400, es biciesto.
            if(anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
            {
                Console.WriteLine($"El año {anio} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {anio} no es bisiesto.");
            }
        }
        catch(FormatException e)
        {
            //!!Imprimimos el error.
            Console.WriteLine("Error: " + e.Message);
        }
    }
    public static void Exercise6()
    {
        //**Manejo de excepciones.
        try
        {
            //**Le pedimos al usuario un número entero.
            Console.Write("Ingrese un número entero (positivo): ");

            //**Convertimos el número ingresado por el usuario a entero y lo guardamos.
            int num = int.Parse(Console.ReadLine());

            //**Comprobar si el número es negativo.
            if (num < 0)
            {
                Console.WriteLine("Error: El número ingresado es negativo.");
                return;
            }

            //**Variable que almacena la suma de los dígitos del número ingresado por el usuario.
            int sum = 0;

            //**Ciclo while para sumar los dígitos del número ingresado por el usuario.
            while (num > 0)
            {
                //** Obtenemos el último dígito del número
                int digit = num % 10;

                //** Añadir el último dígito obtenido a la sumatoria.
                sum += digit;

                //** Eliminar el último dígito del número
                num /= 10;

                //** Se repite hasta que ya no queden mas dígitos.
            }

            //** Imprimimos el valor que nos de la sumatoria dentro del ciclo while.
            Console.WriteLine($"La suma de los digitos es: {sum}");
        }
        catch(FormatException)
        {
            //!!En caso de que se ingrese un valor que no es un numero entero.
            Console.WriteLine("Error: El valor ingresado no es un número entero.");
        }
    }
    //**Método que contiene el ejercicio 7 de la task 3.
    //!!PARA IMPLEMENTAR NUMEROS NEGATIVOS, BUSCAR FUNCION QUE CALCULE EL ABSOLUTO O MULTIPLICAR POR -1.
    public static void Exercise7()
    {
        //**Manejo de excepciones.
        try
        {
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            //**Ciclo while que recorre cada dígito del número
            while (numero > 0)
            {
                //** Obtener el último dígito del número
                int digito = numero % 10;

                // Comprobar si el dígito es par
                if (digito % 2 == 0)
                {
                    Console.WriteLine("El número contiene al menos un dígito par.");
                    return;
                }

                // Eliminar el último dígito del número
                numero /= 10;
            }

            // Imprimir que todos los dígitos son impares
            Console.WriteLine("Todos los dígitos del número son impares.");
        }
        catch(FormatException)
        {
            //!!En caso de que se ingrese un valor que no es un numero entero.
            Console.WriteLine("Error: El valor ingresado no es un número entero.");
        }
    }
}
