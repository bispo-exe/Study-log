using System;

class FirstProgram
{
    static void Main ()
    {
        string product;
        double price;
        int sale;

        Console.WriteLine("What product are you selling?");
        product=Console.ReadLine();
    
        Console.WriteLine("what price?");
        price=double.Parse(Console.ReadLine());

        Console.WriteLine("how many sales?");
        sale=int.Parse(Console.ReadLine());

        decimal profit=sale*(decimal)price*30/100;
        
        Console.WriteLine("product = {0}",product);
        Console.WriteLine("price = {0}",price);
        Console.WriteLine("sales = {0}",sale);
        Console.WriteLine("your profit = {0}",profit);

        Console.ReadLine();

    }

}
