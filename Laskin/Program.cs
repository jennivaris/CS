using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa käyttämään laskinta.\n");
        
            while(true){
                Console.WriteLine("Suoritetaan yhteenlasku.\n");
                Console.WriteLine("Anna joku luku: ");

                
                
                    int luku1= int.Parse(Console.ReadLine());
                
                    Console.WriteLine("Hyvä. Anna toinen luku: ");
                    int luku2=int.Parse(Console.ReadLine());
                    int tulos=luku1+luku2;

                    Console.WriteLine(luku1+" + "+ luku2+" = "+ tulos);

                    Console.WriteLine("Haluatko jatkaa ohjelman käyttöä? Y/N");
                    string vastaus=Console.ReadLine();
            
                    if(vastaus=="N"||vastaus=="n"){
                        break;
                    }
                }
            
            Console.WriteLine("Ohjelma on päättynyt. Näkemiin.");
        }

        }    
    }
