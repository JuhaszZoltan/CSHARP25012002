namespace CSHARP25012002;

internal class Eredmeny
{
    public int Helyezes { get; set; }
    public int SportolokSzama { get; set; }
    public string Sportag { get; set; }
    public string Versenyszam { get; set; }
    public int OlimpiaiPont =>
        Helyezes == 1 ? 7 : 7 - Helyezes;

    public override string ToString()
    {
        return $"\tHelyezes: {Helyezes}\n" +
            $"\tSportag: {Sportag}\n" +
            $"\tVersenyszam: {Versenyszam}\n" +
            $"\tSportolok szama: {SportolokSzama}";
    }

    public Eredmeny(string sor)
    {
        var tmp = sor.Split(' ');
        Helyezes = int.Parse(tmp[0]);
        SportolokSzama = int.Parse(tmp[1]);
        Sportag = tmp[2];
        Versenyszam = tmp[3];
    }
}
