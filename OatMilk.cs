using System;

namespace Multifabriken
{
    // Skapar klassen OatMilk
    public class OatMilk
    { 
        String fatContent; 
        String liter;
    
        // Konstruktor för Candy
        public OatMilk(String fatContent, String liter) 
        { 
            this.fatContent = fatContent; 
            this.liter = liter;
        }
    
        public String toString() 
        { 
            return ($"{liter} liter havremjölk med {fatContent}% fetthalt");
        }
    }
}