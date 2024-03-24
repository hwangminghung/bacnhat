using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập hệ số a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập hệ số b:");
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiệm của phương trình là: x = " + x);
        }
    }
}