
//Implicit Conversion (Biliçsiz Dönüşüm)
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*****Implicit Conversion*****");
        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a + b + c;
        Console.WriteLine("d:" + d);

        long h = d;
        Console.WriteLine("h:" + h);

        float i = h;
        Console.WriteLine("i:" + i);
        string e = "Zikriye";
        char f = 'k';
        object g = e + f + d;
        Console.WriteLine("g:" + g);

        //Explicit Conversion(Bilinçi Dönüşüm)
        Console.WriteLine("*****Explicit Conversion*****");
        int x = 4;
        byte y = (byte)x; //dönüştürmeye çalışıyor (byte)
        Console.WriteLine("y:" + y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" + t);

        float w = 10.3f;
        byte v = (byte)w; //10.3 ü tam sayıya çevirdi,yuvarladı
        Console.WriteLine("v:" + v);

        // ** ToString metodu **
        Console.WriteLine("*****ToString metodu*****");

        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" + yy);

        string zz = 12.5.ToString();
        Console.WriteLine("zz:" + zz);

        //**System.Convert

        Console.WriteLine("*****System.Convert*****");

        string s1 = "10", s2 = "20";
        int sayi1, sayi2, Toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);
        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam:" + Toplam);

        //Parse

        Console.WriteLine("*****Parse*****");
        int ad = 0110;
        ad.ToString();

        ParseMethod();
    }

    public static void ParseMethod()
    {
       string metin1 = "10";
       string metin2 = "10.25";
       int rakam1;
       double rakam2;
       rakam1 = Int32.Parse(metin1); //parse string dönüştürmek için kullanılır ve sadece string alır string -> int
       rakam2 = Double.Parse(metin2);
       Console.WriteLine(rakam1);
       Console.WriteLine(metin2);
       string dee = "55";
       byte xxx = Convert.ToByte(dee);
       Console.WriteLine(xxx);
       
    }
}