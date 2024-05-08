internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Giai phuong trinh bac 1");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Phuong trinh co dang ax + b = 0");

        Console.WriteLine("Nhap vao so a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap vao so b:");
        double b = Convert.ToDouble(Console.ReadLine());
if(a != 0)
{
    Console.WriteLine($"Phuong trinh co nghiem la: {-b}/{a}");
}
else
{
    if(b != 0)  
    {
        Console.WriteLine("phuong trinh vo nghiem");
    }
    else
    {
        Console.WriteLine("phuong trinh luon dung");
    }
}
        
    }
    
}