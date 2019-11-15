using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar objektet _shop och hämtar shop menyn
            Shop _shop = new Shop(0);
            _shop.showMenu();
        }
    }
}
