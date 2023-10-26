using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_8
{
    internal class Program
    {
        static string Reverse_str(string s)
        {
            char[] temp = s.ToCharArray();
            Array.Reverse(temp);
            return new string(temp);
        }
        static bool Format(object k)
        {
            if (k is IFormattable)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        static void Main(string[] args)
        {
            // упр 8.1 
            Console.WriteLine("УПР 8.1 Добавить в банковский счет возможность перекидывать деньги");
            int bal_1, bal_2, sum;
            bool ch1;
            do
            {
                Console.WriteLine("Введите баланс 1-го аккаунта");
                ch1 = int.TryParse(Console.ReadLine(), out bal_1);
            }
            while (!ch1);
            do
            {
                Console.WriteLine("Введите баланс 2-го аккаунта");
                ch1 = int.TryParse(Console.ReadLine(), out bal_2);
            }
            while (!ch1);
            Bank bank1 = new Bank(213, bal_1, Type_Akk.Balance);
            Bank bank2 = new Bank(313, bal_2, Type_Akk.Balance);
            do
            {
                Console.WriteLine("Введите сумму которую вы хотите передать 1 акк-ту");
                ch1 = int.TryParse(Console.ReadLine(), out sum);
            }
            while (!ch1);
            bank1.Transfer(sum, bank2);
            // УПР 8.2
            Console.WriteLine("УПР 8.2 На вход строка на выход инвертированная строка");
            string nolan, dovod;
            nolan = Console.ReadLine();
            dovod = Reverse_str(nolan);
            Console.WriteLine("Старая строка:{0}\nНовая:{1}", nolan, dovod);
            // УПР 8.4
            Console.WriteLine("УПР 8.4 Реализуется ли входной параметр метода интерфейс System.IFormattable.\n Введите что-нибудь");
            object o = Console.ReadLine(); // o = 1   =>   Format(o)##True
            if (Format(o)) 
            {
                Console.WriteLine("Параметр реализует интерфейс");
            }
            else
            {
                Console.WriteLine("Параметр не реализует интерфейс");
            }
        }
    }
}
