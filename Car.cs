using System;

namespace Multifabriken
{
    // Skapar klassen Car
    public class Car
    { 
        String regNr; 
        String color; 
        String model; 
    
        // Konstruktor för Car
        public Car(String regNr, String color, String model) 
        { 
            this.regNr = regNr; 
            this.color = color;
            this.model = model; 
        }
    
        public String toString() 
        { 
            return ($"Bil av märket {model} som är {color} och har registreringsnummer {regNr}");
        }
    }
}