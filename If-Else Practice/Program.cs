// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Girilen sayı: {sayi}");


if (sayi > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");

}
 else if (sayi < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else 
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}

if (sayi %2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else if (sayi %2 == 1)
{
    Console.WriteLine("Girilen sayı tektir.");
}

