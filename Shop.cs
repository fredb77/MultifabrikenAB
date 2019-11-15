using System;
using System.Collections.Generic;

namespace Multifabriken
{
    // Skapar klassen Shop
    class Shop
    {
        int navigateTo = 0;

        // Konstruktor för Shop
        public Shop(int navigateTo)
        {
            this.navigateTo = navigateTo;
        }

        public int check(string input) {

            int checkInput = 0; 
            try {
                checkInput = int.Parse(input); 
            }
            catch {
                Console.Write("\nFel inmatning... Tryck enter.");
            }
            
            return checkInput;
        }

        // Detta sköter menyn och navigering i affären
        public void showMenu()
        {

            List<string> shopList = new List<string>();

            while (navigateTo != 9)
            {
                switch(navigateTo)
                {

                    case 1:     
                        // Inmatning för Bilar
                        Console.Write("\nBeställ bil:\n");
                        Console.Write("Registreringsnummer:");
                        string regnr = Console.ReadLine();

                        Console.Write("Färg:");
                        string color = Console.ReadLine();

                        Console.Write("Modell:");
                        string model = Console.ReadLine();

                        Car _car = new Car(regnr, color, model);
    
                        shopList.Add(_car.toString());

                        navigateTo = 0;

                    break;

                    case 2:
                        // Inmatning för Godis
                        Console.Write("\nBeställ godis:\n");
                        Console.Write("Smak:");
                        string taste = Console.ReadLine();
                        Console.Write("Antal:");

                        string sAntal = Console.ReadLine();
                        int quantity = check(sAntal);

                        if(quantity >= 1){
                            Candy _candy = new Candy(taste, quantity);
                            shopList.Add(_candy.toString()); 
                        }
    
                        navigateTo = 0;

                    break;

                    case 3:
                        // Inmatning för rör
                        Console.Write("\nBeställ rör:\n");
                        Console.Write("Diameter:");
                        string diameter = Console.ReadLine();

                        Console.Write("Längd:");
                        string length = Console.ReadLine();

                        Pipe _pipe = new Pipe(diameter, length);
                        shopList.Add(_pipe.toString());
                      
                        navigateTo = 0;

                    break;

                    case 4:     
                        // Inmatning för havremjölk
                        Console.Write("\nBeställ Havremjölk:\n");
                        Console.Write("Fetthalt:");
                        string fatContent = Console.ReadLine();

                        Console.Write("Litermängd:");
                        string liter = Console.ReadLine();

                        OatMilk _oatmilk = new OatMilk(fatContent, liter);

                        shopList.Add(_oatmilk.toString());

                        navigateTo = 0;

                    break;

                    case 5:

                        // Checkar om varukorgen är tom. 
                        // skriver ur varukorgen om det finns varor
                        if(shopList.Count <= 0){
                            Console.WriteLine("\n===============================");
                            Console.WriteLine("Din varukorg är tom.");
                        }else {
                            Console.WriteLine("\n===============================");
                            Console.WriteLine("Din beställning:\n");
                            foreach (string value in shopList)
                            {
                                Console.WriteLine(value);
                            }
                        }
                        
                        Console.WriteLine("===============================");
                        Console.Write("\nTryck enter:");
                        Console.ReadKey();
                        navigateTo = 0;

                    break;

                    default:
                        // listan till shopen
                        Console.Clear();
                        Console.WriteLine("\nVälkommen till Multfabriken AB");
                        Console.WriteLine("===============================");
                        Console.WriteLine("[1] Bilar");
                        Console.WriteLine("[2] Godis");
                        Console.WriteLine("[3] Rör");
                        Console.WriteLine("[4] Havremjölk");
                        Console.WriteLine("[5] Varukorg(" + shopList.Count + ")");
                        Console.WriteLine("[9] Avsluta");
                        Console.WriteLine("===============================");
                        Console.Write("\nVälj:");

                        try{
                            navigateTo = int.Parse(Console.ReadLine());
                        }
                        catch{
                            Console.Write("\nFel inmatning... Tryck enter.");
                            Console.ReadKey();
                        }

                    break;
                }
            }
        }
    }
}