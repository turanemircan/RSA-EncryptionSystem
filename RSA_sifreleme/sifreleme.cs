
using System.Net.Sockets;

public class Sifreleme{
      
      
      public long msgbulucu(long a,long b){

        System.Console.WriteLine("sifrelenecek veriyi giriniz: ");
         long msg = Convert.ToInt64(Console.ReadLine());

         double sonuc=1;
         for (int i = 0; i<a ; i++){

                sonuc *= msg;
                
             } 
            string sonucstr = sonuc.ToString("N0");
         System.Console.WriteLine("üs alma sonucu:{0} ",sonucstr);
        
        sonuc=double.Parse(sonucstr);
       
         
        double kalan= sonuc % b;

        System.Console.WriteLine("sifrelenmis veriniz: {0}",kalan);
            return 0;
           }
 }