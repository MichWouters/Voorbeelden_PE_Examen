// List<double> prijzen = [];

// Console.Clear();
// VraagPrijzen(prijzen);
// double totaalPrijs = BerekenTotaalPrijs(prijzen);
// PrintResultaat(prijzen, totaalPrijs);

// void VraagPrijzen(List<double> prijzen)
// {
//     double prijs;
//     Console.WriteLine("Geef een prijs in. Negatieve prijs om te stoppen");
//     bool kanOmzetten = double.TryParse(Console.ReadLine(), out prijs);

//     while (prijs >= 0)
//     {
//         while (!kanOmzetten)
//         {
//             Console.WriteLine("Ongeldige prijs. Probeer opnieuw");
//             kanOmzetten = double.TryParse(Console.ReadLine(), out prijs);
//         }

//         prijzen.Add(prijs);

//         Console.WriteLine("Geef een prijs in. Negatieve prijs om te stoppen");
//         double.TryParse(Console.ReadLine(), out prijs);
//     }
// }

// double BerekenTotaalPrijs(List<double> prijzen)
// {
//     double totaalPrijs = prijzen.Sum();

//     if (totaalPrijs >= 100)
//     {
//         totaalPrijs = totaalPrijs * 0.9;
//     }

//     return totaalPrijs;
// }

// void PrintResultaat(List<double> prijzen, double totaalPrijs)
// {
//     Console.WriteLine($"Totaal aantal producten: {prijzen.Count}");
//     Console.WriteLine($"TotaalPrijs: {totaalPrijs}");
//     Console.WriteLine($"Gemiddelde prijs: {prijzen.Average()}");
//     Console.WriteLine($"Duurste prijs: {prijzen.Max()}");
// }