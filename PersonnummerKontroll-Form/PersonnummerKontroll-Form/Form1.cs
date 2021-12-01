using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnummerKontroll_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCalc_Click(object sender, EventArgs e)
        {

            //Lägg till och konvertera variabler för löptid, ränta och belopp. De ska konverterad från string till double

            string persNum = cmbPersNum.Text;

            //Konvertera till int
            int LastNum = int.Parse(persNum.Substring(persNum.Length - 1, 1));

            //Räkna ut ålder
            //string persNum = "";

            //var today = DateTime.Today;

            //string persAgeText = persNum.Substring(0, 2);
            //int persAgeNum = int.Parse(persAgeText);

            //int lastAge = 0;

            //var birthday = 2021 - (persAgeNum + 1900);

  

            //var age = today.Year - birthday.Year;





            //Console.WriteLine("Ange personnummer: ");
            //persNum = Console.ReadLine();



            int personNummerInt = 0;

            string persNumKont = persNum.Substring(8, 2);

            personNummerInt = int.Parse(persNumKont);

            string man = "Man";
            string kvinna = "Kvinna";

            if (personNummerInt % 2 == 0)
            {
                //Console.WriteLine("Kvinna");
                txtGender.Text = kvinna; //Convert.ToString(personNummerInt);
            }
            else
            {
                //Console.WriteLine("Man");
                txtGender.Text = man;//Convert.ToString(personNummerInt);
            }


            //Skriv ut till en textruta
            txtAngiven.Text = Convert.ToString(LastNum);
            //txtCalc.Text = Convert.ToString();



            int[] ValueArr = new int[9];

            for (int i = 0; i < 9; i++)
            {

                if (i % 2 != 0)
                {
                    ValueArr[i] = int.Parse(persNum.Substring(i, 1));
                }
                else if (i % 2 == 0)
                {
                    ValueArr[i] = int.Parse(persNum.Substring(i, 1)) * 2;
                }
            }

            //Sätt ihop alla positioner i arrayen till en sträng
            string TextV = "";
            string[] strArr = new string[9];

            for (int i = 0; i < 9; i++)
            {
                strArr[i] = Convert.ToString(ValueArr[i]);
                TextV = TextV + strArr[i];
            }

            int Summa = 0;
            int AntTecken = TextV.Length;
            int[] intArr = new int[AntTecken];

            //Läs in varje tecken i strängen till en ny int array och summera
            for (int i = 0; i < AntTecken; i++)
            {
                intArr[i] = int.Parse(TextV.Substring(i, 1));
                Summa += intArr[i];
            }

            //Beräkna kontrollsiffra
            double KontrollSiffra = (10 - (Summa % 10)) % 10;

            //Console.Write("Beräknad Kontrollsiffra {0}: ", KontrollSiffra);
            //Console.WriteLine();

            txtCalc.Text = Convert.ToString(KontrollSiffra);

            //string korrekt = "korrekt angiven kontrolsiffra";
            //string fel = "fel angiven kontrollsiffra";

            if (LastNum == KontrollSiffra)
            {
                //MessageBox.Show(");
            }
            else
            {
                MessageBox.Show("Fel angivet kontrollnummer");
            }

            //Console.ReadLine();


            //Console.Write("Angiven kontrollsiffra {0}: ", LastNum);
            //Console.WriteLine();



            //double interest = Double.Parse(cmbInterest.Text);
            //double loanAmount = Double.Parse(cmbLoan.Text);

            //================================================================

            Console.WriteLine("Ange ett personnummer");

            //string PersNr = Console.ReadLine();



            int TheYear = int.Parse("19" + persNum.Substring(0, 2));

            int GenNum = int.Parse(persNum.Substring(persNum.Length - 2, 1));



            // Beräkna ålder 

            System.DateTime DagensDat = System.DateTime.Now;

            int Age = DagensDat.Year - TheYear;

            txtAge.Text = Convert.ToString(Age);


            //Console.WriteLine("Längd på sträng: {0}", persNum.Length);

            //Console.WriteLine("Gendervalue: {0}", GenNum);

            //Console.WriteLine("Året: {0}", TheYear);

            //Console.WriteLine("Året dagens datum: {0}", DagensDat.Year);

            //Console.WriteLine("Ålder angivet personnummer: {0}", Age);



            //if (GenNum % 2 == 0)

            //{

            //    Console.WriteLine("Angivet personnummer är en kvinna");

            //}

            //else

            //{

            //    Console.WriteLine("Angivet personnummer är en man");

            //}



            Console.ReadLine();
            //================================================================

        }
    }
}
