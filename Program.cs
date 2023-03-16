using System;

//snack1();
//snack2();
//snack3();
snack4();
//snack10();

//SNACK 1
void snack1()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    int sum = num1 - num2;

    if (num1 == num2)
    {
        Console.WriteLine("Numbers are equal");
    }
    else
    {
        Console.WriteLine(sum);
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

//SNACK 3
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