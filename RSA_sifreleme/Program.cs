using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace Rsa_sifreleme;

public class Program
{
    public static void Main(string[] args)
    {
        tersMod M = new tersMod();

        System.Console.Write("----- RSA Şifreleme -----\np asal sayısını giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("q asal sayısını giriniz: ");
        int b = Convert.ToInt32(Console.ReadLine());

        findR(a, b);

        M.tersmod(a, b);

        Console.ReadLine();
    }

    public static int findR(int x, int y)
    {
        System.Console.WriteLine("Totient Değeri (r) = {0}", (x - 1) * (y - 1));
        
        return (x - 1) * (y - 1);
    }
}

