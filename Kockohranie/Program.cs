void VypisCislo(int cisloNaVypisanie)
{
    Console.WriteLine("Tvoje cislo je: " +cisloNaVypisanie+" !");
}

Boolean HadajCislo()
{
    Random generatorNahody = new Random();
    int vygenerovaneCislo = generatorNahody.Next(1,6);
    Console.WriteLine("Tipni si cislo!");
    string nacitanyText = Console.ReadLine();
    int nacitaneCislo = 0;
    int.TryParse(nacitanyText, out nacitaneCislo);
    if (nacitaneCislo == vygenerovaneCislo)
    {
        Console.WriteLine("Dobre hadas!");
        return true;
    }
    else
    {
        Console.WriteLine("Slabo hadas!");
        return false;
    }
}


Console.WriteLine("Podme sa hrat!"); 
Boolean uhadol = HadajCislo();
int pocetZlychUhadnuti = 1;
while (uhadol == false)
{
    pocetZlychUhadnuti++;
    uhadol = HadajCislo();
}
Console.WriteLine("Zle si hadal: "+pocetZlychUhadnuti+" krat.");


VypocitajDPH(100, 20);

double VypocitajDPH(double cena, double dphVpercentach)
{
    double cenaSDPH = 0;
    double mieraDPH = cena * (dphVpercentach/100);
    cenaSDPH = cena + mieraDPH;
    return cenaSDPH;
}









