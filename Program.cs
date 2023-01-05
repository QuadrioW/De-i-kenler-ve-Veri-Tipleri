using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 1;  // 0 ile 255 arası değer alır. (1 byte)
            sbyte sb = 2; // -128 ile +127 arasında değer alır. (1 byte)

            short s = 1;  // -32768 ile +32768 arasında değer alır. (2 byte)
            ushort us = 2; // 0 ile 65365 arasında değer alır. (2 byte)

            Int16 i16 = 1; //(2 byte)
            int i = 2; // -2 Milyar ile +2 Milyar arasında değer alır. (4 byte)
            Int32 i32 = 3; // -2 Milyar ile +2 Milyar arasında değer alır. (4 byte)
            Int64 i64 = 4; //(8 byte)
            uint ui = 5; // (4 byte)
            
            long l = 1; // (8 byte)
            ulong ul = 2; // long'un artı değerdeki karşılığıdır. (8 byte)

            float f = 1; // Reel sayılar için kullanılır. (4 byte)
            double d = 2; // Reel sayılar için kullanılır. (8 byte)
            decimal de = 3; // Reel sayılar için kullanılır. (16 byte)

            char ch = '1'; // Tek karaterler için kullanılır. (2 byte)
            string str = "2"; // Sınırsızdır.

            bool bo = true; // True/False.

            DateTime dt = DateTime.Now;
            
            object o1 = 1; // Her türlü veriyi tutmak için kullanılır.
            object o2 = "a"; // Her türlü veriyi tutmak için kullanılır.
            object o3 = 16.3; // Her türlü veriyi tutmak için kullanılır.

            // string ifadeler:

            string str1 = string.Empty;
            str1 = "Utku KARAHÜSEYİN";
            string Ad = "Utku";
            string Soyad = "KARAHÜSEYİN";
            string Ad_Soyad = Ad + " " + Soyad;

            // integer tanımlama tipleri:

            int int1 = 8;
            int int2 = 12;
            int int3 = int1 * int2;

            // boolean:

            bool bl1 = 5>8;
            bool bl2 = 16<3;

            // Değişken Dönüşümleri

            string str2 = "6";
            int int4 = 8;
            string Yeni_Değer = str2 + int4.ToString();
            Console.WriteLine(Yeni_Değer); // çıktı "68"

            int int5 = int4 + Convert.ToInt32(str2);
            Console.WriteLine(int5); // çıktı "14"

            int int6 = int4 + int.Parse(str2); // string'ten dönüşümde kullanılır.
            Console.WriteLine(int6); // çıktı "14"

            // DateTime

            string Dt1 = DateTime.Now.ToString("MM.dd.yyyy");
            Console.WriteLine(Dt1);

            string Dt2 = DateTime.Now.ToString("MM-dd-yyyy");
            Console.WriteLine(Dt2);

            string Hm = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(Hm);

            // The End
        }
    }
}
