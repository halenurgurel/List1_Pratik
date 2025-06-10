using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Patika Plus Gala Gecesine Hoş geldiniz!");

Console.WriteLine("--Davetli Listesi--");

List<string> guests = new List<string>();

guests.Add("Bülent Ersoy");
guests.Add("Ajda Pekkan");
guests.Add("Ebru Gündeş");
guests.Add("Hadise");
guests.Add("Hande Yener");
guests.Add("Tarkan");
guests.Add("Funda Arar");
guests.Add("Demet Akalın");

int counter = 1;

foreach (string guest in guests)
{
    Console.WriteLine($"{counter++}- {guest}");
}
Console.WriteLine("--");

//ya da 

int counter1 = 1;
for (int i =0; i < guests.Count; i++)
{
    Console.WriteLine($"{counter1++}- {guests[i]}");
}