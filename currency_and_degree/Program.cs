using System;

namespace currency_and_degree
{
    class Program
    {
        public enum Currency {Usd=1, Eur, Try }
        static void Main(string[] args)
        {
            #region task
            //            Currecy enum

            //- Usd - dollar
            //- Eur - yevro
            //- Try - türk lirası

            //1.2 Program class
            //- Exchange() - bu method parametr olaraq bir Enum tipindən obyekt qəbul edəcək
            //birdə double tipindən azn,
            //method daxilində ilk olaraq yoxlamaq lazımdır ki gələn Enum obyekti Currecy enumıdırmı
            //daha sonra daha sonra hansı valyuta göndərilibsə göndərilən azn-i həmin valyutaya uyğun konvertasiya edib
            //geriyə qaytaracaq.
            //Məsələn: method-a parametr olaraq azn dəyəri 2 göndərildisə və valyuta usd göndərildisə geriyə 2 * 0.59 = 1.18 qaytarılmalıdır.


            //2. Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var
            //ve Degree adli property-leri var.
            //Celcius uchun implicit operatorunu yazmaginizi isteyirem.(0C= 273K)
            #endregion
            Console.WriteLine("1.Usd\n2.Eur\n3.Try");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case (int)Currency.Usd:
                    Console.WriteLine(Exchange(Currency.Usd));
                    break;

                case (int)Currency.Eur:
                    Console.WriteLine(Exchange(Currency.Eur));
                    break;
                case (int)Currency.Try:
                    Console.WriteLine(Exchange(Currency.Try));
                    break;
            }

            Kelvin degr = new Kelvin(0);
            Celcius celcius = kelvin;
            Console.WriteLine(celcius.degree);
            
            
        }

     

        public static double Exchange(double azn, Currency currency)
        {
 
            if (currency is Currency)
            {
                if (Currency.Usd==currency)
                {
                    return azn * 1.7;  
                }
                else if (Currency.Eur==currency)
                {
                    return azn*1.89;  
                }
                else if (Currency.Try==currency)
                {
                    return azn * 0.12;  
                }

            }
            return 1;
            
            
        }
    }
}
