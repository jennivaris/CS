﻿using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Anna luku: ");
        int luku1=int.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen luku: ");
        int luku2=int.Parse(Console.ReadLine());
        int tulos=luku1+luku2;

        Console.WriteLine("Vastaus on:"+ tulos);
            
        }
    }
}
