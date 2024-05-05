using System.Net.Sockets;
using System.Numerics;

public class Desifreleme
{
    public long msgcozucu(long a, long b)
    {
        System.Console.Write("----- Deşifreleme -----\nŞifreli metni çözmek için sifrelenmis veriyi giriniz: ");
        long msg = Convert.ToInt64(Console.ReadLine());

        BigInteger sonuc = BigInteger.Pow(msg, (int)a);

        BigInteger kalan = sonuc % b;

        System.Console.WriteLine("Sifrelenmis veriniz: {0} ", kalan);
        return 0;
    }
}