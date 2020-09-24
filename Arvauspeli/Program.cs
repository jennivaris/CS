using System;

namespace Arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd= new Random();

            int luku=rnd.Next(1, 21);

            Console.Write("Tervetuloa pelaamaan arvaa numero-peliä.");
            

            while(true){
                Console.Write("arvaa mikä luku?");
                string syotetty=Console.ReadLine();
                int syote=int.Parse(syotetty);

                    if(syote==luku){
                        Console.Write("Onneksi olkoon! Oikein arvattu!");
                        Console.Write("Peli on päättynyt. Näkemiin.");
                        break;
                    }
                    if(syote<luku){
                         Console.Write("Luku on suurempi.");
                    }
                    if(syote>luku){
                        Console.Write("Luku on pienempi.");
                    }
                    
                }
                
            }
        }
    }

