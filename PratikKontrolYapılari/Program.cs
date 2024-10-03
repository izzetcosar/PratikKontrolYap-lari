using System.ComponentModel.Design;

Console.Write("Bir Sayı Giriniz:");

string sayi = Console.ReadLine();

int sayi1 =int.Parse(sayi); //Girilen sayıyı stringden int e çevirdim

//kontrol yapılarıyla sayı 10 dan büyük,kücük veya eşit mi diye kontrol ettiğimiz kısım


if (sayi1 > 10)
{

    Console.WriteLine("Girilen Sayı 10'dan Büyüktür.");
}
else if (sayi1 < 10)
{

    Console.WriteLine("Girilen Sayı 10'dan Küçüktür");
}
else
{

    Console.WriteLine("Girilen Sayı 10'a eşittir.");
}

//kontrol yapılarıyla sayı çift mi tek mi cevabını aldıgım kısım

if (sayi1 %2==0)

{

    Console.WriteLine("Girdiğiniz Sayı Çift Sayıdır");
}

else
{
    Console.WriteLine("Girdiğiniz Sayı Tek Sayıdır");
}