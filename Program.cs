namespace osoba_konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nazwisko;
            double wzrost, masa, obwodPasa, prawidlowyObwodPassa;
            char plec;
            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj wzrost:");
            wzrost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj masę:");
            masa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj obwodPasa:");
            obwodPasa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj płeć (M/K):");
            plec = Convert.ToChar(Console.ReadLine());
            Osoba osoba1 = new Osoba();
            osoba1.Nazwisko = nazwisko;
            osoba1.Wzrost = wzrost;
            osoba1.Masa = masa;
            osoba1.ObwodPasa = obwodPasa;
            osoba1.Plec = plec;

            prawidlowyObwodPassa =  osoba1.obliczPrawidlowyObwodPasa(wzrost, plec);
            if(obwodPasa == prawidlowyObwodPassa || obwodPasa>prawidlowyObwodPassa-10|| obwodPasa < prawidlowyObwodPassa + 10)
            {
                Console.WriteLine("Twój obwód pasa jest prawidłowy");
            }

            Console.ReadKey();
        }

        public class Osoba : AbstrajcyjnaKlasa
        {
            public string Nazwisko {  get; set; }
            public double Wzrost { get; set; }
            public double Masa { get; set; }
            public double ObwodPasa { get; set; }
            public char Plec { get; set; }
        }
        public class AbstrajcyjnaKlasa
        {
            public virtual double obliczPrawidlowyObwodPasa(double wzrost, char plec)
            {
                double PrawidlowyObwodPasa = 0;
                if(plec == 'M')
                {
                    PrawidlowyObwodPasa = (wzrost / 2);
                }
                if(plec == 'K')
                {
                    PrawidlowyObwodPasa = (wzrost / 2.2);
                }
                return PrawidlowyObwodPasa;
            }
        }
    }
}