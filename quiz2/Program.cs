using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Introduction_to_class
{
    class Program
    {


        class Sun_Flower
        {
            public int ID;
            public string name;
            public string desc;
            public int amount;
            public string height;
            public string circumference;

            public Sun_Flower(int ID, string name, string desc, int amount, string height, string circumference)
            {
                this.ID = ID;
                this.name = name;
                this.desc = desc;
                this.amount = amount;
                this.height = height;
                this.circumference = circumference;
            }
        }

        class Rose
        {
            public int ID;
            public string name;
            public string desc;
            public int amount;
            public string height;
            public string circumference;

            public Rose(int ID, string name, string desc, int amount, string height, string circumference)
            {
                this.ID = ID;
                this.name = name;
                this.desc = desc;
                this.amount = amount;
                this.height = height;
                this.circumference = circumference;
            }
        }

        static void Main(string[] args)
        {
            double rAmount, sAmount;

            Console.Write("Input Total Rose: ");
            rAmount = double.Parse(Console.ReadLine());

            Console.Write("Input Total Sun Flower: ");
            sAmount = double.Parse(Console.ReadLine());

            List<Rose> newRose = new List<Rose>();

            for (int i = 0; i < rAmount; i++)
            {

                Console.WriteLine("ID: ");
                int rInt = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Plant Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Plant Description: ");
                string description = Console.ReadLine();

                Console.WriteLine("Amount: ");
                int Amount = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Height: ");
                string Height = Console.ReadLine();

                Console.WriteLine("Circumference: ");
                string Circumference = Console.ReadLine();

                Rose Name = new Rose(rInt, name, description, Amount, Height, Circumference);
            }


            List<Sun_Flower> newSun_Flower = new List<Sun_Flower>();

                for (int i1 = 0; i1 < sAmount; i1++)
                {

                    Console.WriteLine("ID: ");
                    int rInt1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Plant Name: ");
                    string name1 = Console.ReadLine();

                    Console.WriteLine("Plant Description: ");
                    string description1 = Console.ReadLine();

                    Console.WriteLine("Amount: ");
                    int Amount1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Height: ");
                    string Height1 = Console.ReadLine();

                    Console.WriteLine("Circumference: ");
                    string Circumference1 = Console.ReadLine();

                    Sun_Flower Name1 = new Sun_Flower(rInt1, name1, description1, Amount1, Height1, Circumference1);

                }


            Console.Clear();
            Console.WriteLine("Rose Information");
            Console.WriteLine("________________");
            for (int i = 0; i < newRose.Count; i++)
            {
                Console.WriteLine(newRose[i]);
            }

            Console.Clear();
            Console.WriteLine("Sun Flower Information");
            Console.WriteLine("________________");
            for (int i = 0; i < newSun_Flower.Count; i++)
            {
                Console.WriteLine(newSun_Flower[i]);
            }


        }
    }
}
