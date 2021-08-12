using System;
using System.Collections.Generic;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 11
            Console.WriteLine("Indtast et tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast endnu et tal");
            int tal2 = int.Parse(Console.ReadLine());


            Console.ReadKey();
        }

        static void Matematik()
        {
            Console.WriteLine("Indtast tal1");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast tal2");
            double tal2 = double.Parse(Console.ReadLine());

            double adder = tal1 + tal2;
            double divider = tal1 / tal2;
            Console.WriteLine(divider);
            double opløft = Math.Pow(tal1, tal2);
            Console.ReadKey();
        }

        static void Pythagoras()
        {
            Console.WriteLine("Indtast tal1");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast tal2");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Pow(a, 2) + Math.Pow(b, 2);
            if (a > b)
            {
                Console.WriteLine("a er størst");
            }
            else
            {
                Console.WriteLine("b er størst");
            }
            Console.ReadKey();
        }

        static void Alder()
        {
            Console.WriteLine("Indtast navn");
            string navn = (Console.ReadLine());
            Console.WriteLine("Indtast alder");
            int alder = int.Parse(Console.ReadLine());

            if (alder < 3)
            {
                Console.WriteLine(navn + ", du må gå med ble");
            }
            else if (alder < 15)
            {
                Console.WriteLine(navn + ", du må ingenting");
            }
            else if (alder < 18)
            {
                Console.WriteLine(navn + ", du må drikke");
            }
            else
            {
                Console.WriteLine(navn + ", du må stemme og køre bil");
            }
        }

        static void Løkker()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Indtast et tal");
            int tal = int.Parse(Console.ReadLine());
            int nyTal = 0;
            for (int i = tal; i <= tal + 32; i++)
            {
                Console.WriteLine(i);
                nyTal = i;
            }
            for (int i = nyTal; i >= nyTal - 16; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void Array()
        {
            int[] tal = new int[9];

            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = i + 1;
                if (i == 5)
                {
                    tal[5] = tal[4] * 2;
                    Console.WriteLine(tal[i]);
                }
            }
            Console.ReadKey();
        }

        static void ListeB()
        {
            List<int> listeB = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            listeB[2] = 17;
            for (int i = 0; i < listeB.Count; i++)
            {
                if (listeB[i] % 3 == 0)
                {
                    listeB.RemoveAt(i);
                }
                Console.WriteLine(listeB[i]);
            }
            List<int> listA = new List<int>(listeB);
            listA.Reverse();
            for (int i = 0; i < listA.Count; i++)
            {
                Console.WriteLine(listA[i]);
            }
            Console.ReadKey();
        }

        static void Lotto()
        {
            Random r = new Random();
            int[] vinderKupon = new int[7];
            int[] brugerKupon = { 6, 8, 15, 13, 1, 19, 2 };
            int rigtige = 0;

            foreach (int i in vinderKupon)
            {
                int ran = r.Next(1, 21);
                vinderKupon[i] = ran;
                if (vinderKupon[i] == brugerKupon[i])
                {
                    rigtige++;
                }
            }
            int gevinst = r.Next(10000, 10000000);

            if (rigtige >= 2)
            {
                Console.WriteLine("Du har vundet: " + gevinst + " Kr.");
            }
            else
            {
                Console.WriteLine("Du havde: " + rigtige + " Rigtige, og vandt ikke denne gang");
            }
            Console.ReadKey();
        }

        static void GætTallet()
        {
            Random random = new Random();
            int tal = random.Next(1, 101);
            int antalGæt = 0;
            Console.WriteLine("Gæt et tal");

            while (true)
            {
                int gæt = int.Parse(Console.ReadLine());
                antalGæt++;
                if (gæt < tal)
                {
                    Console.WriteLine("For lavt");
                }
                else if (gæt > tal)
                {
                    Console.WriteLine("For højt");
                }
                else
                {
                    Console.WriteLine("Godt gættet, du brugte: " + antalGæt + " Gæt");
                    break;
                }
                Console.ReadKey();
            }   
        }   
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Divider(int a, int b)
        {
            return a / b;
        }
        static string AntalGange(int a, int b)
        {
            int divider = a / b;
            string antalGange = divider.ToString() + " gange";
            return antalGange;
        }
        static void FindStørsteElement(List<int> liste)
        {
           int størsteTal = liste.Max();
            
        }
        static bool BooleanIndeholder(List<int> x)
        {
            bool indeholderX = x.Contains(4);
            return indeholderX;

        }
        static void Gennemsnit(List<int> liste1)
        {
            int gennemsnit = liste1.Sum() / liste1.Count();
        }
        static void Sorteret(List<int> liste2)
        {
            List<int> sorteretListe = new List<int>(liste2);
            sorteretListe.Sort();

            for(int i = 0; i < liste2.Count; i++)

            {
                if(liste2[i ] == sorteretListe[i ])
                {
                    if(i == liste2.Count -1)
                    {
                        Console.WriteLine("Listen er sorteret");
                        
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Listen er ikke sorteret");
                    break;
                }
            }

        }

        
    }   
}   