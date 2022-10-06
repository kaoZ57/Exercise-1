using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Cash> cashList = new List<Cash>();
            List<Cash> changeList = new List<Cash>();
            int amount_total = 0;
            int paid = 0;
            int change = 0;

            //รับค่าจำนวนเงินแต่ละแบบ
            Console.Write("Cash 1000 = ");
            cashList.Add(new Cash(1000, Int32.Parse(Console.ReadLine())));
            Console.Write("Cash 500 = ");
            cashList.Add(new Cash(500, Int32.Parse(Console.ReadLine())));
            Console.Write("Cash 100 = ");
            cashList.Add(new Cash(100, Int32.Parse(Console.ReadLine())));
            Console.Write("Cash 50 = ");
            cashList.Add(new Cash(50, Int32.Parse(Console.ReadLine())));
            Console.Write("Cash 10 = ");
            cashList.Add(new Cash(10, Int32.Parse(Console.ReadLine())));
            Console.Write("Cash 5 = ");
            cashList.Add(new Cash(5, Int32.Parse(Console.ReadLine())));
            Console.Write("Cash 1 = ");
            cashList.Add(new Cash(1, Int32.Parse(Console.ReadLine())));
            /*cashList.Add(new Cash(1000, 10));
            cashList.Add(new Cash(500, 5));
            cashList.Add(new Cash(100, 10));
            cashList.Add(new Cash(50, 10));
            cashList.Add(new Cash(20, 10));
            cashList.Add(new Cash(10, 100));
            cashList.Add(new Cash(5, 500));
            cashList.Add(new Cash(1, 1000));*/


            cashList.ForEach(item => { amount_total += item.amount * item.type; });

            foreach (Cash item in cashList)
            {
                Console.WriteLine(item.ToString() + " left " + item.amount * item.type);
            }

            Console.WriteLine("\namount_total: " + amount_total);

        UP:
            Console.Write("change = ");
            string InputNum = Console.ReadLine();
            try
            {
                if (change > amount_total)
                {
                    goto UP;
                }
                change = Int32.Parse(InputNum);
            }
            catch (Exception)
            {
                goto UP;
            }

            //change = 1999;

            Console.WriteLine("\nWant to change: " + change);

            paid = amount_total - change;
            Console.WriteLine("\npaid: " + paid);

            foreach (Cash item in cashList)
            {
                int i = 0;
                while (change >= item.type)
                {
                    change -= item.type;
                    i++;
                }
                changeList.Add(new Cash(item.type, i));
                //Console.WriteLine(change + " " + item.type + " " + i);
            }
            Console.WriteLine("\ndeducted money");
            foreach (Cash item in changeList)
            {
                Console.WriteLine(item.ToString() + "  " + item.amount * item.type);
            }
            Console.WriteLine("\nmoney left");
            for (int i = 0; i < cashList.LongCount(); i++)
            {
                Console.WriteLine("Cash" + cashList[i].type.ToString() + ": " + (cashList[i].amount - changeList[i].amount).ToString() + " left " + (cashList[i].amount - changeList[i].amount) * cashList[i].type);
            }
        }
    }
}
