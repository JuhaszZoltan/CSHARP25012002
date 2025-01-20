using CSHARP25012002;
using System.Text;

const string PATH = "C:\\PROJECTS\\CSHARP25012002\\RESOURCES";

List<Eredmeny> eredmenyek = [];

using StreamReader sr = new($"{PATH}\\helsinki.txt");
while (!sr.EndOfStream) eredmenyek.Add(new(sr.ReadLine()));

Console.WriteLine($"f3: pontszerzo helyezesek szama: {eredmenyek.Count}");

Console.WriteLine("f4: ermek szama:");
var f4a = eredmenyek.Count(e => e.Helyezes == 1);
Console.WriteLine($"\tarany: {f4a}");
var f4e = eredmenyek.Count(e => e.Helyezes == 2);
Console.WriteLine($"\tezust: {f4e}");
var f4b = eredmenyek.Count(e => e.Helyezes == 3);
Console.WriteLine($"\tbronz: {f4b}");
Console.WriteLine($"\tosszesen: {f4a + f4e + f4b}");

var f5 = eredmenyek.Sum(e => e.OlimpiaiPont);
Console.WriteLine($"f5: olimpiai pontok osszesen: {f5}");

var f6t = eredmenyek.Count(e => e.Sportag == "torna");
var f6u = eredmenyek.Count(e => e.Sportag == "uszas");
if (f6u == f6t) Console.WriteLine("f6: egyenlo volt azt ermek sztama");
else Console.WriteLine($"f6: {(f6t > f6u ? "torna" : "uszas")} sportagban szereztek tobb ermet");

using StreamWriter sw = new($"{PATH}\\helsinki2.txt");
foreach (var e in eredmenyek)
    sw.WriteLine($"{e.Helyezes} {e.SportolokSzama} {e.OlimpiaiPont} " +
        $"{(e.Sportag == "kajakkenu" ? "kajak-kenu" : e.Sportag)} {e.Versenyszam}");

var f8 = eredmenyek.MaxBy(e => e.SportolokSzama);
Console.WriteLine($"f8:\n{f8}");