using System;

class Test
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");


        int x = 21;
        int y = 22;
        int sum = x + y;

        double b = 24.6;
        double a= 25.4;
        double sum2 = a + b;

        char symbol = '!';
        String name = "Francis";

        const int n = 2;
        const double m = 2.2;

        Console.WriteLine($"The sum of {x} and {y} is {sum} ");
        Console.WriteLine($"The sum of {a} and {b} is {sum2}");
        Console.WriteLine($"Your character is {symbol}");
        Console.WriteLine($"My userName is {name} {symbol}");

        //type casting = Converting a value to different data type
        //used when we accept user input(string)

        double f = 3.14;
        int h= Convert.ToInt32( f );

        int r = 100;
        double g = Convert.ToDouble(r);

        Console.WriteLine(h);
        Console.WriteLine(h.GetType());
        Console.WriteLine(g);
        Console.WriteLine(g.GetType());

        Console.WriteLine("Please Write your name below");
        String name2 = Console.ReadLine();
        Console.WriteLine(name2);

        Console.WriteLine("What is your age");
        int age = Convert.ToInt32(Console.ReadLine());

        //math class

        double e = 3;
        double f2 = Math.Pow(e, 3);
        Console.WriteLine(f2);


        //randomizing numbers
        Random random =new Random();

        int num=random.Next(1,7);
        double num1 = random.NextDouble();
        Console.WriteLine(num);


        Console.ReadKey();


    }
}