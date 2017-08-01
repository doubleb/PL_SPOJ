/*
SPOJ
NAME: RNO_DOD - Proste dodawanie
TRESC ZADANIA : Twoim zadaniem jest dodać wszystkie liczby całkowite podane na wejściu.
Wejście
W pierwszym wierszu znajduje się liczba t testów (0 < t < 100)
Każdy test opisany jest w następujący sposób. W pierwszym wierszu dana jest liczba n - liczba 
liczb do zsumowania. Następnie podanych jest n liczb pooddzielanych spacją.
Link: http://pl.spoj.com/problems/RNO_DOD/
SPOJ_ID: @double_2b
link: http://pl.spoj.com/users/double_2b/
by: Blazej BOCZEK
STATUS: UNSOLVED


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNO_DOD___Proste_dodawanie
{
    class Program
    {
        //funcka zliczajaca ilosc elementow w lini:
        public static int mySum()
        {
            var input = Console.ReadLine();
            var liczby = input.Split(' ');
            var suma = 0;
            for (var i = 0; i < liczby.Length; ++i)
            {
                suma += Convert.ToInt32(liczby[i]);
            }
            return suma;
           
        }        
        static void Main(string[] args)
        {
            int t;//liczba testow
            // ile ma byc przypadkow w danym 
            //musi byc petla w petli w takim razie 
            /*
                jedna petla 
            
            */
            /*
                TODO 
                1)ile testow
                2)ile liczb w pojedynczym tescie -> utworzenie tabeli o takiej liczbie co podano
                3)wypelnienie tabeli z klaiwatury z wykorzystaniem funkcji .split(' ')zeby rozroznic wpisywane znaki  a nastepnie 
                zsumowac dana tablice...
                
                4) na ekran wyrzucic  wynik
                 
            
            */
            t = Convert.ToInt32(Console.ReadLine());
            var arr1 = new int[t];
            for (var i=0; i< t; ++i)
            {

                var x = Convert.ToInt32(Console.ReadLine());
                for (var j=0;j< x; ++j)
                {
                    //wypelnianie tabeli 
                    var input = Console.ReadLine();
                }
                
                /*var liczbaPrzypadkow = Convert.ToInt32(Console.ReadLine());///to musi byc tablica znakw 


                for (var j = 0; j < liczbaPrzypadkow; j++)
                {
                    arr1[i] = mySum();
                }*/
                
            }
            foreach (var number in arr1)
                Console.WriteLine(number);          
            Console.ReadKey();

        }
    }
}
