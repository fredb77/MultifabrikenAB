using System;

namespace Multifabriken
{
    // Skapar klassen Candy
    public class Candy
    { 
        String taste; 
        int quantity;
    
        // Konstruktor för Candy
        public Candy(String taste, int quantity) 
        { 
            this.taste = taste; 
            this.quantity = quantity;
        }
    
        public String toString() 
        { 
            return string.Format($"{quantity} godisar med {taste} smak");
        }
    }
}