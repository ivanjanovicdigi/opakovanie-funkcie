void VypisCislo(int cisloNaVypisanie)
{
    Console.WriteLine("Tvoje cislo je: " +cisloNaVypisanie+" !");
}

void HadajCislo()
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
    }
    else
    {
        Console.WriteLine("Slabo hadas!");
    }
}


Console.WriteLine("Podme sa hrat!");
HadajCislo();

