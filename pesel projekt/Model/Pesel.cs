using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel_projekt.Model
{
    class Pesel
    {

        private string numerPesel;

        int LiczbaMiesiac;
        int LiczbaRok;
        int LiczbaDzien;
        string Miesiac;
        string Rok;
        string Dzien;


        public string Plec
        {

            get
            {
                char cyfraPlec = numerPesel[9];
                int liczbaPlec = int.Parse(cyfraPlec.ToString());
                if (liczbaPlec % 2 == 0)

                    return "Kobieta";

                else
                    return "Mężczyzna";
            }
        }


        public Pesel(string numer)
        {

            numerPesel = numer;
            WalidacjaNumeruPesel();




        }

        public string MiesiacData
        {

            get
            {


                string miesiac_urodzenia = numerPesel[2].ToString() + numerPesel[3].ToString();

                int LiczbaMiesiacUrodzenia = Int32.Parse(miesiac_urodzenia);

                string poprawny_miesiac_urodzenia;

                poprawny_miesiac_urodzenia = LiczbaMiesiacUrodzenia.ToString();

                if (LiczbaMiesiacUrodzenia > 80 && LiczbaMiesiacUrodzenia <= 92)
                {
                    LiczbaMiesiac = LiczbaMiesiac - 80;
                }
                else if (LiczbaMiesiacUrodzenia > 20 && LiczbaMiesiacUrodzenia <= 32)
                {
                    LiczbaMiesiacUrodzenia = LiczbaMiesiacUrodzenia - 20;
                }
                else if (LiczbaMiesiacUrodzenia > 40 && LiczbaMiesiacUrodzenia <= 52)
                {
                    LiczbaMiesiacUrodzenia = LiczbaMiesiacUrodzenia - 40;
                }
                else if (LiczbaMiesiacUrodzenia > 60 && LiczbaMiesiacUrodzenia <= 72)
                {
                    LiczbaMiesiacUrodzenia = LiczbaMiesiacUrodzenia - 60;
                }

                poprawny_miesiac_urodzenia = LiczbaMiesiacUrodzenia.ToString();

                if (LiczbaMiesiacUrodzenia <= 12)
                {

                    poprawny_miesiac_urodzenia = "0" + poprawny_miesiac_urodzenia;


                }



               
                return poprawny_miesiac_urodzenia;
    
            }


        }


        public string DataData
        {

            get
            {
                Miesiac = numerPesel[2].ToString() + numerPesel[3].ToString();
                Rok = numerPesel[0].ToString() + numerPesel[1].ToString();

                LiczbaMiesiac = Int32.Parse(Miesiac);
                LiczbaRok = Int32.Parse(Rok);

                string rok_urodzenia;
                rok_urodzenia = LiczbaRok.ToString();
                if (LiczbaMiesiac > 80 && LiczbaMiesiac < 93)
                {
                    LiczbaRok += 1800;
                }
                else if (LiczbaMiesiac > 0 && LiczbaMiesiac < 13)
                {
                    LiczbaRok += 1900;
                }
                else if (LiczbaMiesiac > 20 && LiczbaMiesiac < 33)
                {
                    LiczbaRok += 2000;
                }
                else if (LiczbaMiesiac > 40 && LiczbaMiesiac < 53)
                {
                    LiczbaRok += 2100;
                }
                else if (LiczbaMiesiac > 60 && LiczbaMiesiac < 73)
                {
                    LiczbaRok += 2200;
                }

                rok_urodzenia = LiczbaRok.ToString();
                return rok_urodzenia;
            }
    }


        public string DzienData
        {


            get
            {
                Dzien = numerPesel[4].ToString() + numerPesel[5].ToString();
                LiczbaDzien = Int32.Parse(Dzien);
                string poprawny_dzien;
                poprawny_dzien = LiczbaDzien.ToString();
                return poprawny_dzien;

            }


        }
   
        private void WalidacjaNumeruPesel()
        {
            WalidacjaIloscZnakow();
            WalidacjaPoprawnosciZnakow();
            WalidacjaMiesiaca();
            RokKonwersja();
            WalidacjaDnia();
            WalidacjaCyfryKontrolnej();





        }
        private void WalidacjaIloscZnakow()
        {

            if (numerPesel.Length != 11)
            {

                throw new Exception("Błędna ilosc znakow");

            }
        }
        private void WalidacjaPoprawnosciZnakow()
        {
            for (int x = 0; x < 11; x++)

            {

                bool znakiPesel = char.IsNumber(numerPesel, x);

                if (znakiPesel == false)
                {

                    throw new Exception("Niepoprawne znaki");

                }
            }
        }
        private void WalidacjaMiesiaca()
        {
            string miesiac_urodzenia = numerPesel[2].ToString() + numerPesel[3].ToString();

            int LiczbaMiesiacUrodzenia = Int32.Parse(miesiac_urodzenia);

            string poprawny_miesiac_urodzenia;

            poprawny_miesiac_urodzenia = LiczbaMiesiacUrodzenia.ToString();

            if (LiczbaMiesiacUrodzenia > 92 || LiczbaMiesiacUrodzenia < 01)


            {

                throw new Exception("Niepoprawny miesiac");

            }
            else


            {
                if (LiczbaMiesiacUrodzenia > 80 && LiczbaMiesiacUrodzenia <= 92)
                {
                    LiczbaMiesiac = LiczbaMiesiac - 80;
                }
                else if (LiczbaMiesiacUrodzenia > 20 && LiczbaMiesiacUrodzenia <= 32)
                {
                    LiczbaMiesiacUrodzenia = LiczbaMiesiacUrodzenia - 20;
                }
                else if (LiczbaMiesiacUrodzenia > 40 && LiczbaMiesiacUrodzenia <= 52)
                {
                    LiczbaMiesiacUrodzenia = LiczbaMiesiacUrodzenia - 40;
                }
                else if (LiczbaMiesiacUrodzenia > 60 && LiczbaMiesiacUrodzenia <= 72)
                {
                    LiczbaMiesiacUrodzenia = LiczbaMiesiacUrodzenia - 60;
                }

               
               
            }
        }
        private void RokKonwersja()
        {
            Miesiac = numerPesel[2].ToString() + numerPesel[3].ToString();
            Rok = numerPesel[0].ToString() + numerPesel[1].ToString();

            LiczbaMiesiac = Int32.Parse(Miesiac);
            LiczbaRok = Int32.Parse(Rok);

            string rok_urodzenia;
            if (LiczbaMiesiac > 80 && LiczbaMiesiac < 93)
            {
                LiczbaRok += 1800;
            }
            else if (LiczbaMiesiac > 0 && LiczbaMiesiac < 13)
            {
                LiczbaRok += 1900;
            }
            else if (LiczbaMiesiac > 20 && LiczbaMiesiac < 33)
            {
                LiczbaRok += 2000;
            }
            else if (LiczbaMiesiac > 40 && LiczbaMiesiac < 53)
            {
                LiczbaRok += 2100;
            }
            else if (LiczbaMiesiac > 60 && LiczbaMiesiac < 73)
            {
                LiczbaRok += 2200;
            }

            rok_urodzenia = LiczbaRok.ToString();



        }
        private void WalidacjaDnia()
        {
            Dzien = numerPesel[4].ToString() + numerPesel[5].ToString();
            LiczbaDzien = Int32.Parse(Dzien);
            string poprawny_dzien;

            if (LiczbaRok % 4 == 0)
            {

                if (LiczbaDzien > 29)
                {

                    throw new Exception("Niepoprawna liczba dnia");
                }


            }
            else
            if (LiczbaDzien > 31)
            {

                throw new Exception("Niepoprawna liczba dnia");

            }
            else if (LiczbaDzien > 28)
            {
                if (LiczbaMiesiac == 82 || LiczbaMiesiac == 02 || LiczbaMiesiac == 22 || LiczbaMiesiac == 42 || LiczbaMiesiac == 62)
                {
                    throw new Exception("Niepoprawna liczba miesiąca");
                }

            }

            poprawny_dzien = LiczbaDzien.ToString();

        }
        private void WalidacjaCyfryKontrolnej()
        {

            int iloczyn;

            char numer_pesel1 = numerPesel[0];

            int numerPesel1 = (int)char.GetNumericValue(numer_pesel1);


            char numer_pesel2 = numerPesel[1];

            int numerPesel2 = (int)char.GetNumericValue(numer_pesel2);


            char numer_pesel3 = numerPesel[2];

            int numerPesel3 = (int)char.GetNumericValue(numer_pesel3);

            char numer_pesel4 = numerPesel[3];


            int numerPesel4 = (int)char.GetNumericValue(numer_pesel4);

            char numer_pesel5 = numerPesel[4];

            int numerPesel5 = (int)char.GetNumericValue(numer_pesel5);

            char numer_pesel6 = numerPesel[5];

            int numerPesel6 = (int)char.GetNumericValue(numer_pesel6);

            char numer_pesel7 = numerPesel[6];

            int numerPesel7 = (int)char.GetNumericValue(numer_pesel7);

            char numer_pesel8 = numerPesel[7];

            int numerPesel8 = (int)char.GetNumericValue(numer_pesel8);
            char numer_pesel9 = numerPesel[8];

            int numerPesel9 = (int)char.GetNumericValue(numer_pesel9);

            char numer_pesel10 = numerPesel[9];

            int numerPesel10 = (int)char.GetNumericValue(numer_pesel10);



            int liczba1 = numerPesel1 * 1;
            int liczba2 = numerPesel2 * 3;
            int liczba3 = numerPesel3 * 7;
            int liczba4 = numerPesel4 * 9;
            int liczba5 = numerPesel5 * 1;
            int liczba6 = numerPesel6 * 3;
            int liczba7 = numerPesel7 * 7;
            int liczba8 = numerPesel8 * 9;
            int liczba9 = numerPesel9 * 1;
            int liczba10 = numerPesel10 * 3;
            int liczbaK;




            iloczyn = liczba1 + liczba2 + liczba3 +
                liczba4 + liczba5 + liczba6 + liczba7 + liczba8 + liczba9 + liczba10;


            int M = iloczyn % 10;

            int pesel_porownanie = (int)char.GetNumericValue(numerPesel[10]);


            if (M == 0)
            {

                liczbaK = 0;

            }
            else
            {

                liczbaK = 10 - M;

                if (liczbaK != pesel_porownanie)
                {

                    throw new Exception("Niepoprawna liczba kontrolna");


                }
            }

        }

 }

}