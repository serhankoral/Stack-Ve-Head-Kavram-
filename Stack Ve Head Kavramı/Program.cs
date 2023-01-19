using System;

namespace Stack_Ve_Head_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Stack ve heap
             * Stack direk olarak ram da yer turar heap ise yerini gösterir
             * bir zamanların pointerları
             * stack int,double,char,bool v.b
             * head ise class,dizi,enum,string v.b
             */
            int[] dizi = new int[] { 5, -19 };
            Console.WriteLine(dizi[0]);
            Console.WriteLine(dizi[1]);
            degistir(dizi);
            Console.WriteLine(dizi[0]);
            Console.WriteLine(dizi[1]);
            /*
             * Direk olarak değeri olan değişkeni fonksiyona gönderdiğimizde değer değişmez
             * Ama yerini gösteren değişkeni diziye gönderdiğimizde değişkenin içerigini değiştiri 
             * çünkü gösterdiği yeri değiştiriyoruz
             */
            string varString = "serhan";
            Console.WriteLine(varString);
            stringdegistir(varString);
            Console.WriteLine(varString);
            /*
             * Class ile nasıl oluyor derseniz class da da aynı şekilde gerçekleşiyor
             */
            MyClass refType = new MyClass();
            refType.myVar = 5;
            Console.WriteLine(refType.myVar);
            classDegistir(refType);
            Console.WriteLine(refType.myVar);

        }
        static void degistir(int[] x)
        {
            x[0] = 10;
            x[1] = 15;
        }
        static void stringdegistir(string temp)
        {
            temp = temp+" KORAL";
        }
        
        static void classDegistir(MyClass temp)
        {
            temp.myVar = 15;
        }

    }
    class MyClass
    {
        public int myVar;
    }
}
