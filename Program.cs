using System;

namespace challenges{
    class Program{
        static void Main(string[] args)
        {
            int breakfastset = 6;
            int weekendset = 3;
            int coffee = 4;
            int stop = 0;
            int n = int.Parse(Console.ReadLine());
            if (n <=7){
                Console.WriteLine(n);
            }
            else{
                Console.WriteLine("error");
            }
            int t = int.Parse(Console.ReadLine());
            if ((t >= 8) && (t <=18)){
            Console.WriteLine(t);
            }
            else{
                Console.WriteLine("error");
            }
            do
            {
                string menu = Console.ReadLine();
            switch (menu){
                case "breakfastset":
                    breakfastset--;
                    if (t >= 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    } 
                    if (breakfastset <= 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }                   
                    break;
                case "weekendset":
                    weekendset--;
                    if (n >= 6)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    if (weekendset <= 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    break;
                 case "coffee":  
                    coffee--;        
                    if (coffee <= 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    break;
                case "end":
                    stop = 1;
                    break;
                default:
                    Console.WriteLine("please enter a valid menu");
                    break;
                }
            }while (stop == 0);
                 
        }         
     }
}
       
    


