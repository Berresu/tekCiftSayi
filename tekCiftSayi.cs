using System;
class HelloWorld {
  static void Main() {
    Console.Write("Sayı Giriniz: ");
	int sayi = Convert.ToInt32(Console.ReadLine());
	int sonuc = sayi/2;
		
	if(sonuc==1){
	    Console.WriteLine("Girdiğiniz Sayı Tek Sayıdır.");
	}
	else if(sonuc==2){
	    Console.WriteLine("Girdiğiniz Sayı Çift Sayıdır.");
	}
  }
}
