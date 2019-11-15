using System;

namespace Multifabriken
{
    // Skapar klassen Pipe
    public class Pipe
    { 
        string diameter; 
        string length;
    
        // Konstruktor för Pipe
        public Pipe(string diameter, string length) 
        { 
            this.diameter = diameter; 
            this.length = length;
        } 
    
        public String toString() 
        { 
            return ($"Rör med diametern {diameter} och är {length} långt");
        }
    }
}