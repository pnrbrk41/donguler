// See https://aka.ms/new-console-template for more information

using System;


    

	namespace switchh
	{


   class Program
   
   {
      static void Main (string[] args )
      {
        Console.WriteLine("Lütfen bir sayı giriniz:");
        int sayac = int.Parse(Console.ReadLine());
        for( int i=1; i<= sayac; i++)
        {
            if(i%2 == 1)
            Console.WriteLine(i);

        }
      int tektoplam= 0;
      int cifttoplam= 0;
      for( int i=1; i<=1000; i++)
{
    if( i%2 == 1)
    tektoplam += 1;

    else
    cifttoplam += 1;

}
      Console.WriteLine("Tek toplam: " +tektoplam);
      Console.WriteLine("Çift Toplam:" +cifttoplam);


      }
   }
    }