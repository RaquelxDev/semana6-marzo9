static void suma()
{
    //ejercicio 1
    int num1, num2, resultado = 0;
    Console.WriteLine("Ingrese num1: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese num2: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    resultado = num1 + num2;
}

static int sumatoria(int num1, int num2, int num3)
{
    int resultado = 0;
    resultado = num1 + num2 + num3;
    return resultado;

}

static string datos()
{
    //ejercicio 2
    Console.WriteLine("Ingrese nombre: ");
    string nombre = Console.ReadLine()!;
    return nombre;
}


static void calculoEdad()
{
    //ejercicio 3
    Console.WriteLine("Ingrese su año de nacimiento");
    int año_nacimiento = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - año_nacimiento;
    Console.WriteLine("su edad es: " + edad);
}



string nombre = datos();
int promedio = sumatoria(20, 25, 40) / 3;
Console.WriteLine($"hola {nombre} su promedio es {promedio} su edad es");


//escribir un programa que solicite valores positivos, hasta que el usuario
//ingrese un cero, luego muestre cual fue el numero mayor ingresado y el menor



    int num, max, min;
    max = 0;
    min = 100;

    Console.WriteLine("ingrese un numero");
    num=Convert.ToInt32(Console.ReadLine());

    if (num > max){
        Console.WriteLine("es numero ingresado es mayor");
    }
    else
    {
        Console.WriteLine("el numero es menor");
    }

    static void valores()
{
    int num, max, min;
    max = 0;
    min = 100;

    Console.WriteLine("ingrese un numero");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > max)
    {
        Console.WriteLine("es numero ingresado es mayor");
    }
    else
    {
        Console.WriteLine("el numero es menor");
    }

}























//int opc;
//do
//{
//    Console.WriteLine("1. Suma");
//    Console.WriteLine("2. datos");
//    Console.WriteLine("3. Nacimiento");
//    Console.WriteLine("4 salida");
//    opc = Convert.ToInt32(Console.Read());

//    switch (opc)
//    {
//        case 1: suma()

//    }

//} while (opc >= 4);



//calculoEdad();
//datos();
//suma();
