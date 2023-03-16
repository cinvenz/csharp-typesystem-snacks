using System;

Console.WriteLine("scegli uno snack da 1 a 12");
var snack = Convert.ToInt32(Console.ReadLine());
switch (snack)
{
    case 1:
        snack1();
        break;
    case 2:
        snack2();
        break;
    case 3:
        snack3();
        break;
    case 4:
        snack4();
        break;
    case 5:
        snack5();
        break;
    case 6:
        snack6();
        break;
    case 7:
        snack7();
        break;
    case 8:
        snack8();
        break;
    case 9:
        snack9();
        break;
    case 10:
        snack10();
        break;
    case 11:
        snack11();
        break;
    case 12:
        snack12();
        break;
}

//SNACK 2
void snack1()
{
    Console.WriteLine("Dammi il primo numero:");
    int num1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Dammi il secondo numero:");
    int num2 = Convert.ToInt16(Console.ReadLine());
    if (num1 > num2)
    {
        Console.WriteLine(num1);
    }
    else if (num1 == num2)
    {
        Console.WriteLine("I numeri sono uguali");
    }
    else
    {
        Console.WriteLine(num2);
    }
}

//SNACK 2
void snack2()
{
    string str1 = Console.ReadLine() ?? "";
    string str2 = Console.ReadLine() ?? "";

    if (str1.Length > str2.Length)
    {
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
    else
    {
        Console.WriteLine(str2);
        Console.WriteLine(str1);
    }
}

//SNACK 3
void snack3()
{
    int sum = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.Write("Inserisci il " + i + "° numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        sum = sum + num;

    }
    Console.Write("la somma è uguale a " + sum);


}

//SNACK 4
void snack4()
{
    int sum = 0;

    for (int i = 2; i <= 10; i++)
    {

        sum = sum + i;

    }

    double media = sum / 9;
    Console.WriteLine("La somma dei numeri da 2 a 10 è " + sum);
    Console.WriteLine("La media dei numeri da 2 a 10 è " + media);
}

//SNACK 5
void snack5()
{
    int num = Convert.ToInt32(Console.ReadLine());
    var even = num % 2 == 0;
    var result = even ? num : num + 1;
    Console.WriteLine(result);
}

//SNACK 6
void snack6()
{
    string[] names = { "Dario", "Francesco", "Giovanni", "Marco", "Vincenzo" };
    Console.WriteLine("Dimmi il tuo nome");
    string name = Console.ReadLine() ?? "";
    if (names.Contains(name, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("Sei invitato");
    }
    else
    {
        Console.WriteLine("Non sei stato invitato");
    }
}

//SNACK 7
void snack7()
{
    int[] numeriDispari = new int[6];

    for (int i = 0; i < 6; i++)
    {
        Console.Write("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 != 0)
        {
            numeriDispari[i] = num;
        }
    }

    Console.WriteLine("Numeri dispari inseriti:");
    foreach (int i in numeriDispari)
    {
        if (i % 2 != 0) Console.Write($"{i}; ");
    }
    Console.WriteLine("");
}

//SNACK 8
void snack8()
{
    int[] numeri = { 5, 2, 1, 8, 4, 6, 3, 9 };
    int sumDispari = 0;

    for (int i = 1; i < numeri.Length; i += 2)
    {
        sumDispari += numeri[i];
    }

    Console.WriteLine("La somma degli elementi in posizione dispari è: " + sumDispari);

}

//SNACK 9
void snack9()
{
    int[] numeri = new int[0];
    int somma = 0;
    int index = 0;

    while (somma < 50)
    {
        Console.Write("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] newArray = new int[numeri.Length + 1];

        for (int i = 0; i < numeri.Length; i++)
        {
            newArray[i] = numeri[i];
        }

        newArray[newArray.Length - 1] = num;

        numeri = newArray;
        index++;

        somma += num;
    }

    Console.WriteLine("La somma degli elementi è maggiore o uguale a 50.");
}


//SNACK 10
void snack10()
{
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];

        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }

        foreach (var num in ints)
        {
            Console.Write($"{num}; ");
        }

        Console.WriteLine();
    }
}

//SNACK 11
void snack11()
{
    Console.WriteLine("Prima Parola:");
    string str1 = Console.ReadLine() ?? "";
    Console.WriteLine("Seconda Parola:");
    string str2 = Console.ReadLine() ?? "";
    lenght(str1, str2);

    void lenght(string str1, string str2)
    {
        if (str1.Length == str2.Length)
        {
            Console.WriteLine(str1 + " " + str2);
        }
        else if (str1.Length > str2.Length)
        {
            Console.WriteLine(str1);
        }
        else
        {
            Console.WriteLine(str2);
        }
    }
}

//SNACK 12
void snack12()
{
    Console.WriteLine("Dammi un numero");
    int number = Convert.ToInt32(Console.ReadLine());
    checkNum(number);
    void checkNum(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            Console.WriteLine("Il numero è dispari");
        }
    }
}