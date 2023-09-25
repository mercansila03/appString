

string kursAdi=".NET 7 ile C# Programlama Dili";
//1-Kaç karaktere sahiptir?
int kacKarakter=kursAdi.Length;
Console.WriteLine(kacKarakter);

//2-Hepsini Küçük harf yapınız.
Console.WriteLine(kursAdi.ToLower());

//3- '.' ile mi başlamaktadır?
Console.WriteLine(kursAdi.StartsWith('.'));

//4-C# bilgisi hangi konumda bulunmaktadır?
Console.WriteLine(kursAdi.IndexOf("C#"));

//5-String 'C#' bilgisini içeriyor mu?
Console.WriteLine(kursAdi.Contains("C#"));

//6-'Dili' kelimesi yerine 'Dersleri' yazınız.
string update=kursAdi.Replace("Dili","Dersleri");
Console.WriteLine(update);