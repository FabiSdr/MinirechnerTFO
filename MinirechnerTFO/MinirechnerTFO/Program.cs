﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO
{
    class Program
    {
        //Erstellt von Fabian Sieder am 23.04.2020
        static void Main(string[] args)
        {
            Console.Write("Geben Sie Zahl1 ein: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie Zahl2 ein: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            int ErgAddition = Addiere(Zahl1, Zahl2);
            Console.WriteLine("Zahl1 + Zahl2 = " + ErgAddition);

            int ErgSubtraktion = Subtrahiere(Zahl1, Zahl2);
            Console.WriteLine("Zahl1 - Zahl2 = " + ErgSubtraktion);

            int ErgMultiplikation = Multipliziere(Zahl1, Zahl2);
            Console.WriteLine("Zahl1 * Zahl2 = " + ErgMultiplikation);

            Console.ReadKey();
        }

        static int Addiere(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 + Zahl2;
            return Erg;
        }

        static int Subtrahiere(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 - Zahl2;
            return Erg;
        }

        static int Multipliziere(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 * Zahl2;
            return Erg;
        }
    }
}
