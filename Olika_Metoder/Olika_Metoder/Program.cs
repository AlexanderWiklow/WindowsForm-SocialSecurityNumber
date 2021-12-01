using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olika_Metoder
{

    public class first
    {

        //========= METOD 1 ========================================
        public int CalcAverage(int[,] TalArray, int Row, int Col)
        {
            Random rnd = new Random();
            int avg = 0;
            int AntalTal = 0;
            int sum = 0;

            // Yttre loop som håller reda på raderna
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    sum += TalArray[i, j];
                    AntalTal++;
                }
            }

            avg = sum / AntalTal;
            return avg;
        }

        //================ METOD 2 ==================================
        // Denna metod tar också inparametrar från main där vi skrev in informationen i arrayen.
        public int CalcAntal(int[,] TalArray, int Row, int Col)
        {
            int AntalTal = 0;

            // Yttre loop som håller reda på raderna
            for (int i = 0; i < Row; i++)
            {
                // Inre loop som håller reda på kolumnerna i arrayen 
                // (j) används för att referera till kolumnerna i arrayen
                for (int j = 0; j < Col; j++)
                {
                    if (TalArray[i, j] > 15)
                    {
                        AntalTal++;
                    }
                }
            }
            return AntalTal;
        }
    }

    // ==================== KLASS #2 SAMT METOD #3 =====================
    class secondclass
    {
        // Den här metoden kan nå värdena i de två tidigare metoderna. Observera metoden är void. Alltså ingen return. Den tar två inparametrar, båda int. Kan nå båda metoderna eftersom dom är public int?
        public void Method3(int avgTal, int AntalTalNum)
        {
            Console.WriteLine("Här är medel av alla värden: {0} och antalet värden under 15 = {1} st", avgTal, AntalTalNum);
        }

    }

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
                }
            }

            // Man måste instansiera varje klass i main för att kunna nå innehållet. Instansierar i ett variabel för varje. Sedan sparar jag varje värde från metoderna var för sig i varsina variabler. class - metoder - inparametrar. Först metoderna och deras värden, sist metoden som returnerar båda metoders värden. 
            secondclass s = new secondclass();
            first f = new first();

            int test11 = f.CalcAverage(talArray, rader, kolumner);


            int result1 = f.CalcAverage(talArray, rader, kolumner);
            int result2 = f.CalcAntal(talArray, rader, kolumner);

            s.Method3(result1, result2);

            Console.ReadLine();
        }
    }
}
