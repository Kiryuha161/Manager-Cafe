using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Cafe
{
    internal class Program
    {
        static int _maxPlaces = 8;
        static int _midPlaces = 4;
        static int _lowPlaces = 2;

     
        
         static Table[] table = { new Table(1, _lowPlaces), new Table(2, _midPlaces), new Table(3, _maxPlaces) }; 
       
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Добрый день! Подскажите, стол на сколько мест вас интересует?");
            int inputPlace = int.Parse(Console.ReadLine());

            if (inputPlace > _maxPlaces)
            {
                Console.WriteLine("Извините, стола на такое количество мест нет");
            }
            else if (inputPlace > _midPlaces && inputPlace <= _maxPlaces)
            {
                Console.WriteLine($"Вам подойдёт столик {table[2].NumberTable}");
            }
            else if (inputPlace > _lowPlaces && inputPlace <= _midPlaces)
            {
                Console.WriteLine($"Вам подойдёт столик {table[1].NumberTable}");

            }
            else if (inputPlace <= _lowPlaces && inputPlace > 0)
            {
                Console.WriteLine($"Вам подойдёт столик {table[0].NumberTable}");
            }




        }
    }

    class Table
    {
        public int NumberTable;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int numberTable, int maxPlaces)
        {
            NumberTable = numberTable;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }
    }
}
