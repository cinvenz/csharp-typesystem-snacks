using System;

//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
//snack6();
snack7();
//snack10();

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