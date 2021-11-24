using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Egendefinierad class
    public class Time
    {
        // Lokala variabler i klassen
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second;


        // Det här är en metod som inte returnerar ett värde, det ser man på void. Men man måste kalla metoden i main för att få nån info 
        public void DisplayCurrentTime()
        {
            if (Month > 9)
            {
                Console.WriteLine("{0}-{1}-{2} {3}:{4}:{5}", Year, Month, Date, Hour, Minute, Second);
            }
            else
            {
                Console.WriteLine("{0}-0{1}-{2} {3}:{4}:{5}", Year, Month, Date, Hour, Minute, Second);
            }

        }

        // Konstruktor som skapar ett objekt av klassen Time.
        public Time(System.DateTime td)
        {
            // Konstruktorn sätter värden på variablerna
            Year = td.Year;
            Month = td.Month;
            Date = td.Day;
            Hour = td.Hour;
            Minute = td.Minute;
            Second = td.Second;
        }
    }

    class Tester
    {
        static void Main()
        {
            // Variabel av typen System.DateTime som får värdet
            System.DateTime CurrentDateTime = System.DateTime.Now;
            // Deklarera en variabel av typen Time (Vår egendeklarerade klass)
            // Instansiera en variabel med värdet från variabel CurrentDateTime
            Time t = new Time(CurrentDateTime);

            // Anropa metoden DisplayCurrentTime med hjälp av variabeln t 
            // Som är av typen Time (vår egendeklarerade klass)

            //t är obj av klassen Time, och DisplayCurrentTime är en metod inne i den klassen. 
            t.DisplayCurrentTime();

            Console.ReadLine(); 
        }

    }
}
