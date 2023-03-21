using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

public class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T num1,T num2,T num3)
    {
        dynamic sum = num1;
        dynamic sum2 = num2;
        dynamic sum3 = num3;

        return (sum + sum2 + sum3) ;

        
    }
}

public class program
{
    static void Main(string[] args)
    {
        Penjumlahan penjumlahan= new Penjumlahan();
        double num1 = 13;
        double num2 = 22;
        double num3 = 13;

        Penjumlahan.JumlahTigaAngka(num1,num2,num3);

    }
}