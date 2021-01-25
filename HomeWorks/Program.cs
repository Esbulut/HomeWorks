using System;
using System.Linq;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add();                      //Add

            //int result = Add2(5, 6);         //Parametre döndürüyor. Add2

            //int number1;                                                //Add3
            //int number2 = 100;
            //var result2= Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.ReadLine();

            // Console.WriteLine(Multiply(9,5));                      //Default

            //Console.WriteLine(Multiply(4, 5, 2));                       //Overloading

            Console.WriteLine(Add4(21,11,6,9,33));                                  // params
        }
        static int Add3(out int number1, int number2)
        // Ref=değer tiplerinin referans tip gibi kullanılmasını sağlıyor.Ref kullanımın da ana methodta verilen başlangıç değişken değerleri olma zorunluluğu tutar.
        //Out = Ref ile aynı görevi görüyor tek farkı metoda verilen başlangıç değerini zorunlu tutmaz.
        {
            number1 = 30;
            return number1 + number2;
        }

        static void Add()
        {
            Console.WriteLine("Merhaba");
        }
        static int Add2(int number1, int number2)
        {
            int result = number1 + number2;
            return number1 + number2;
            //Veri döndürüyor.
        }
        static int Multiply(int number1, int number2 = 30) // number2'ye default değer verildi.

        {
            return number1 * number2;                         //Default
            //Default parametre. 
            // Eğer number2 verilmezse ozaman default değeri olarak 30'u kullan, verilirse kaç verilirse onu kullan
            // Default değerler her zaman metodun en sonunda olması gerekiyor.
        }
        static int Multiply(int number1, int number2, int number3) // Overloading

        {
            return number1 * number2 * number3;

            //Farklı parametrelerde aynı değişken ismi (örn.Multiply) kullanmak istediğimizde her hangi bir problem göstermemekte.
            //Buna metotların Overloadingi yani aşırı yükleme denir.
        }

        static int Add4(params int[] numbers)              //params
        {
            return numbers.Sum();                    //numbers listesindeki tüm sayıları toplamak için kullanılan hazır metot "sum()"
        }

        // params: Aynı tipte istediğimiz kadar parametre(10- 20 belki daha fazla ) işlem yapmak istediğimiz de Overloading değildi daha dinamik olmak için params kullanıyoruz.
    }
}
