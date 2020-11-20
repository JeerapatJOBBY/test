using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Your money : ");
            //double money = double.Parse(Console.ReadLine());
            //Console.Write("Price : ");
            //double price = double.Parse(Console.ReadLine());
            //double Exchange = (money - price);
            //Console.WriteLine("Exchange : {0}",Exchange);

            //if (money < price) 
            //{
            //    Console.WriteLine("Not enough money");
            //}    
            //if (Exchange >= 1000) 
            //{
            //    Console.WriteLine("1000 Bath :" + Math.Floor(Exchange / 1000));
            //    Exchange = Exchange % 1000;
            //}
            //if (Exchange >= 500) 
            //{
            //    Console.WriteLine("500 Bath : " + Math.Floor(Exchange / 500));
            //    Exchange = Exchange % 500;
            //}
            //if (Exchange >= 100) 
            //{
            //    Console.WriteLine("100 Bath :" + Math.Floor(Exchange / 100));
            //    Exchange = Exchange % 100;
            //}
            //if (Exchange >= 50) 
            //{
            //    Console.WriteLine("50 Bath :" + Math.Floor(Exchange / 50));
            //    Exchange = Exchange % 50;
            //}
            //if (Exchange >= 20)
            //{
            //    Console.WriteLine("20 Bath :" + Math.Floor(Exchange / 20));
            //    Exchange = Exchange % 20;
            //}
            //if (Exchange >= 10)
            //{
            //    Console.WriteLine("10 Bath :" + Math.Floor(Exchange / 10));
            //    Exchange = Exchange % 10;
            //}
            //if (Exchange >= 5)
            //{
            //    Console.WriteLine("5 Bath :" + Math.Floor(Exchange / 5));
            //    Exchange = Exchange % 5;
            //}
            //if (Exchange >= 2)
            //{
            //    Console.WriteLine("2 Bath :" + Math.Floor(Exchange / 2));
            //    Exchange = Exchange % 2;
            //}
            //if (Exchange >= 1)
            //{
            //    Console.WriteLine("1 Bath :" + Math.Floor(Exchange / 1));
            //    Exchange = Exchange % 1;
            //}
            //else
            //{
            //    Console.WriteLine("NO Exchange ");
            //}

            //Console.ReadLine();







            // Console.Write("Your magarong : ");
            // double number = double.Parse(Console.ReadLine());
            // Console.WriteLine("Your box : ");
            // double boxL = 0;
            // double boxM = 0;
            // double boxlS = 0;

            // if (number >= 10)
            // {

            //     boxL = Math.Floor(number / 10);
            //     number = number % 10;
            // }

            // if (number > 4 && number < 10)
            // {
            //     boxM = Math.Floor(number / 6);
            //     number = number % 6;
            // }

            // if (number <= 4)
            // {
            //     boxlS = Math.Ceiling(number / 4);
            //     number = number % 4;
            // }
            // Console.WriteLine("box size L = {0}", boxL);
            // Console.WriteLine("box size M = {0},",boxM);
            // Console.WriteLine("box size S = {0}", boxlS);

            //Console.ReadLine();


            //    Console.Write("Number preplo :");
            //    double NP = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Room : ");
            //    double RoomL = 0;
            //    double RoomM = 0;
            //    double RoomS = 0;
            //    if (NP >= 15)
            //    {
            //        RoomL = Math.Floor(NP / 15);
            //        NP = NP % 15;
            //    }
            //    if (NP > 5 && NP < 15)
            //    {
            //        RoomM = Math.Floor(NP / 10);
            //        NP = NP % 10;
            //    }
            //    if (NP <= 5)
            //    {
            //        RoomS = Math.Ceiling(NP / 5);

            //    }
            //    Console.WriteLine("Room sizeL : {0}", RoomL);
            //    Console.WriteLine("Room sizeM : {0}", RoomM);
            //    Console.WriteLine("Room sizeS : {0}", RoomS);

            //    double normalpayL = (15 * 80) * RoomL;
            //    double normalpayM = (10 * 90) * RoomM;
            //    double normalpayS = (5 * 100) * RoomS;
            //    Console.WriteLine("Pay Money RoomL : {0}", normalpayL);
            //    Console.WriteLine("Pay Money RoomM : {0}", normalpayM);
            //    Console.WriteLine("Pay Money RoomS : {0}", normalpayS);



            //Console.ReadLine();

            Console.Write("Input : ");
            int X = int.Parse(Console.ReadLine());
            int Z, i;
            for (Z=0;Z<X;Z++ ) 
            {
                for (i = 0;  i< X; i++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}

