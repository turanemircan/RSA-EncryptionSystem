
using System.Net.Sockets;
using System.Numerics;

public class Sifreleme
{
    public long msgbulucu(long a, long b)
    {
        System.Console.Write("----- Şifreleme -----\nŞifrelenecek veriyi giriniz: ");
        long msg = Convert.ToInt64(Console.ReadLine());

        BigInteger sonuc = BigInteger.Pow(msg, (int)a);

        BigInteger kalan = sonuc % b;

        System.Console.WriteLine("Sifrelenmis veriniz: {0}", kalan);
        return 0;
    }
}