using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_8
{
    public enum Type_Akk
    {
        Balance,
        SberKniga
    }
    internal class Bank
    {
        private int id;
        private int balance;
        private Type_Akk _type;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Balance
        {
            get 
            { 
                return balance; 
            }
        }
        public Type_Akk _Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public void Transfer(int sum, Bank akk_Tr)
        {
            if ((sum > 0) && (akk_Tr.balance - sum >= 0))
            {
                akk_Tr.balance -= sum;
                balance += sum;
                Console.WriteLine("Перевод прошел успешно");
            }
            else
            {
                Console.WriteLine("Неудача!");
            }

        }
        public Bank(int id, int balance, Type_Akk _type)
        {
            this.id = id;
            this.balance = balance;
            this._type = _type;
        }
    }
}
