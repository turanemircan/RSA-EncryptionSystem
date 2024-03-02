using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace Rsa_sifreleme;

 public class Program{
 
      
      public static void Main(string[] args){

        tersMod M = new tersMod();
        
        

        System.Console.WriteLine("p asal sayisini giriniz:");
        int a = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("q asal sayisini giriniz:");
        int b = Convert.ToInt32(Console.ReadLine());

      /*  System.Console.WriteLine("Asal sayi olmak şarti ile ortak anahtar(e) değerini giriniz:");
        int c =Convert.ToInt32(Console.ReadLine()); */

        
    /*    findN(a,b); */
        findR(a,b); 

      /*     static int findN(int x, int y){
              
              
              System.Console.WriteLine("N = {0} ", x*y);
              return x*y;
           } */

           static int findR(int x, int y){

            System.Console.WriteLine("r = {0}", (x-1)*(y-1));
            return (x-1)*(y-1);
        }  

           
        M.tersmod(a,b);
        
      }


      }
 
