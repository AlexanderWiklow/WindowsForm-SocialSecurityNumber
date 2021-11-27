using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olika_Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Uppgift 7: Tre klasser med olika metoder
            //• Du skall skapa en Consol - app med tre klasser.
            //• Den första klassen(med Main - metoden) skall vara startpunkt.Där skall en tvådimensionell
            //array deklareras och fyllas med slumptal mellan 10 och 20.
            //• Den andra klassen skall ha två metoder.En metod som beräknar medel av alla värden i en
            //array som skall kunna tas emot som indata.
            //Den andra metoden skall beräkna hur många värden > 15 som finns i en array.
            //• Den tredje klassen skall ha en metod som visar resultatet från den andra klassen.

            int rader = 0;
            int kolumner = 0;

            Random rnd = new Random();

            // Användaren anger antal rader som sparas i en int 
            Console.WriteLine("Hur många rader ska finnas med?");
            rader = int.Parse(Console.ReadLine());

            // Användaren anger antal kolumner som sparas i en int 
            Console.WriteLine("Hur många kolumner ska finnas med?");
            kolumner = int.Parse(Console.ReadLine());

            // Deklarera array med variablerna 
            int[,] talArray = new int[rader, kolumner];

            // Yttre loop som håller reda på raderna
            for (int i = 0; i < kolumner; i++)
            {
                // Inre loop som håller reda på kolumnerna i arrayen 
                // (j) används för att referera till kolumnerna i arrayen
                for (int j = 0; j < rader; j++)
                {
                    // Fyll sedan arrayen med slumptal mellan 1 och 20
                    talArray[i, j] = rnd.Next(10, 21);
                    // AntalTal++;
                    // sum += TalArray[i, j];
                    // Sum = TalArray[i] + TalArray[j];
                }
            }

            // int slumpTal = r.Next(10, 21);

            secondclass s = new secondclass();

            //int AntalV = s.TotResMethod();

            Console.WriteLine("resultat {0}", s.TotResMethod());

        }
    }

    class first
    {
        int avg = 0;
        public int CalcAverage(int[,] TalArray, int Row, int Col)
        {
            Random rnd = new Random();
            avg = 0;
            int AntalTal = 0;
            int sum = 0;

            // Yttre loop som håller reda på raderna
            for (int i = 0; i < Row; i++)
            {
                // Inre loop som håller reda på kolumnerna i arrayen 
                // (j) används för att referera till kolumnerna i arrayen
                for (int j = 0; j < Col; j++)
                {

                    sum += TalArray[i, j];
                    // Sum = TalArray[i] + TalArray[j];
                }
            }

            avg = sum / AntalTal;
            return avg;
        }



        public int CalcAntal(int[,] TalArray, int Row, int Col)
        {
            //Random rnd = new Random();
            //int avg = 0;
            //int sum = 0;

            int AntalTal = 0;

            // Yttre loop som håller reda på raderna
            for (int i = 0; i < Row; i++)
            {
                // Inre loop som håller reda på kolumnerna i arrayen 
                // (j) används för att referera till kolumnerna i arrayen
                for (int j = 0; j < Col; j++)
                {
                    // Fyll sedan arrayen med slumptal mellan 1 och 20
                    // TalArray[i, j] = rnd.Next(1, 21);
                    //AntalTal++;
                    //sum += TalArray[i, j];
                    // Sum = TalArray[i] + TalArray[j];

                    if (TalArray[i,j] > 15)
                    {
                        AntalTal++;
                    }
                }
            } 

            //avg = sum / AntalTal;
            return AntalTal;

            secondclass s = new secondclass();
            first f = new first();
            int tal23 = s.lastmethod(AntalTal,avg); 

        }

    }

    class secondclass
    {
        first f = new first();

        public int lastmethod(int tal1, int tal2)
        {

            return
        }

        // constructor? 
        public int totTal = ;
        public secondclass()
        {
            Console.WriteLine("Antal tal {0} ", metod1);
            Console.WriteLine("Antal tal > 5: {0} ", metod2);
        }
        public void TotResMethod()
        {



            // instansiera en klass
            //first f = new first();

            f.CalcAntal();

            //Console.WriteLine("test {0}", f.CalcAverage(Antal));

            //int valuefirst = f.CalcAverage(metod2);
            //int valueSecond = metod2;
            ////int AntalV = CalcVar.CalcAntal(TalArray, Rad, kolumn);

            //Console.WriteLine("Antal tal {0} ", metod1);
            //Console.WriteLine("Antal tal > 5: {0} ", metod2);
        }
    }
}
