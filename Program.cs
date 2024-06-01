// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.Collections.Generic;


//Tapsiriq 1
//Bir string list yaradın və onu 5 fərqli ad ilə doldurun. Bu listin elementlərini konsola çap edin ve
// listə yeni bir ad əlavə edin və sonra yenidən konsolda çap edin.
//Console.WriteLine("Azerbaycanin seherleri");
//List<string> seherler = new List<string>();
//seherler.Add("seki");
//seherler.Add("baki");
//seherler.Add("semkir");
//seherler.Add("qax");
//seherler.Add("samaxi");
//for (int i = 0; i < seherler.Count; i++)
//{
//    Console.WriteLine(seherler[i]);
//}
//Console.WriteLine(seherler.Count);
//Console.WriteLine(seherler.Capacity);

//Console.WriteLine("Elave olunduqdan sonra Azerbaycanin seherleri");
//seherler.Add("qax");
//seherler.Add("samaxi");
//for (int i = 0; i < seherler.Count; i++)
//{
//    Console.WriteLine(seherler[i]);
//}
//Console.WriteLine(seherler.Count);
//Console.WriteLine(seherler.Capacity);


//Tapsiriq 2
//Bir integer List yaradın və onu 10 fərqli dəyərlə doldurun. Bu List-in elementlərini konsola çap 
//edin, müəyyən bir elementi silin və yenidən çap edin.
//Console.WriteLine("Cut ededler");
//List<int> cutEdedler = new List<int>();
//cutEdedler.Add(2);
//cutEdedler.Add(4);
//cutEdedler.Add(6);
//cutEdedler.Add(10);
//cutEdedler.Add(8);
//cutEdedler.Add(14);
//cutEdedler.Add(20);
//cutEdedler.Add(26);
//cutEdedler.Add(40);
//cutEdedler.Add(30);
//for (int i = 0; i < cutEdedler.Count; i++)
//{
//    Console.WriteLine(cutEdedler[i]);
//}
//Console.WriteLine("ededlerin sayi ");
//Console.WriteLine(cutEdedler.Count);

//Console.WriteLine("silinenden sonra ededler");
//cutEdedler.Remove(2);
//for (int i = 0; i < cutEdedler.Count; i++)
//{
//    Console.WriteLine(cutEdedler[i]);
//}
//Console.WriteLine("silinenden sonra ededlerin sayi");
//Console.WriteLine(cutEdedler.Count);

//Tapsiriq 3
//   Bir ArrayList yaradın və onu fərqli tipli 5 element ilə doldurun. Bu ArrayList-in elementlərini konsola çap edin.

//ArrayList exercise = new ArrayList();
//exercise.Add(2);
//exercise.Add("ders");    
//exercise.Add('h');
//exercise.Add(2.5);
//exercise.Add(true);
//for (int i = 0; i < exercise.Count; i++)
//{
//    Console.WriteLine(exercise[i]);
//}
//Console.WriteLine("elementlerin sayi");
//Console.WriteLine(exercise.Count);
//Console.WriteLine("elementin tutumu");
//Console.WriteLine(exercise.Capacity);


//Tapsiriq 4
//Bir ArrayList yaradın və onu integer dəyərlərlə doldurun. ArrayList-in elementlərini konsola çap edin,
// sonra yeni elementlər əlavə edin və yenidən çap edin.
//ArrayList reqemler = new ArrayList();
//reqemler.Add(3);
//reqemler.Add(4);
//reqemler.Add(5);
//reqemler.Add(6);
//reqemler.Add(7);
//for (int i = 0; i < reqemler.Count; i++)
//{
//    Console.WriteLine(reqemler[i]); 
//}
//Console.WriteLine("elementlerin sayi");
//Console.WriteLine(reqemler.Count);
//Console.WriteLine("elementlerin tutumu");
//Console.WriteLine(reqemler.Capacity);
//reqemler.Add(10);
//reqemler.Add(78);
//for (int i = 0; i < reqemler.Count; i++)
//{
//    Console.WriteLine(reqemler[i]);
//}
//Console.WriteLine("elave olunduqdan sonra elemetlerin sayi");
//Console.WriteLine(reqemler.Count);
//Console.WriteLine("elave olunduqdan sonra elementlerin tutumu");
//Console.WriteLine(reqemler.Capacity);


//Tapsiriq 5
//Bir Dictionary yaradın və onu 5 fərqli tələbə adı və onların yaşları ilə doldurun. Bu Dictionary-nin
//elementlərini konsola çap edin.


//Console.WriteLine("Proseslerin avtomatlasdirilmasi muhendisliyinde oxuyan 4 telebenin adi ve yaslari ");
//Dictionary<string, int> telebeler = new Dictionary<string, int>();
//telebeler.Add("Huseyin", 19);
//telebeler.Add("Eli", 20);
//telebeler.Add("Adil", 23);
//telebeler.Add("Ceyhun", 18);
//ICollection<string> keys = telebeler.Keys;
//ICollection<int> values = telebeler.Values;
//for (int i = 0; i < keys.Count; i++)
//{
//    string key = keys.ToArray()[i];
//    int value = values.ToArray()[i];
//    Console.WriteLine(key + ": " + value);
//}

//Tapsiriq 6
//Bir Dictionary yaradın və onu 5 fərqli tələbə adı və onların yaşları ilə doldurun.
//Dictionary-dən müəyyən bir tələbəni silin və yenilənmiş Dictionary-ni konsola çap edin.


Console.WriteLine("Proseslerin avtomatlasdirilmasi muhendisliyinde oxuyan 4 telebenin adi ve yaslari ");
Dictionary<string, int> telebeler = new Dictionary<string, int>();
telebeler.Add("Huseyin", 19);
telebeler.Add("Yadigar", 20);
telebeler.Add("Eli", 23);
telebeler.Add("Ceyhun", 18);
ICollection<string> keys = telebeler.Keys;
ICollection<int> values = telebeler.Values;
for (int i = 0; i < keys.Count; i++)
{
    string key = keys.ToArray()[i];
    int value = values.ToArray()[i];
    Console.WriteLine(key + " " + value);
}
Console.WriteLine("silinenden sonra telebelerin siyahisi");
telebeler.Remove("Huseyin");
ICollection<string> adlar = telebeler.Keys;
ICollection<int> yaslar = telebeler.Values;
for (int i = 0; i < keys.Count; i++)
{
    string ad = keys.ToArray()[i];
    int yas = values.ToArray()[i];
    Console.WriteLine(ad + " " + yas);
}

//Tapsiriq 7
//Bir SortedList yaradın və onu 3 fərqli kitab adı və onların müəllifləri ilə doldurun.
//SortedList-ə yeni bir kitab əlavə edin və yenilənmiş SortedList-i konsola çap edin.
//Console.WriteLine("Dunyaca meshur 3 kitab adlari ve muellifleri");
//SortedList<string,string> kitablar = new SortedList<string,string>();
//kitablar.Add("elifba sirasi ile qetl","Aqata Kristie");
//kitablar.Add("Cinayet ve ceza", "Dostoyevski");
//kitablar.Add("The Scream", "Edvard Munk");

//ICollection<string> keys = kitablar.Keys;
//ICollection<string> values = kitablar.Values;
//for (int i = 0; i < keys.Count; i++)
//{
//    string key= keys.ToArray()[i];
//    string value = values.ToArray()[i];
//    Console.WriteLine(key + "=" + value);
//}

