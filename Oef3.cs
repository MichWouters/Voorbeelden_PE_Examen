

// int aantalDeelnemers, resultaat;

// static int VraagSeconden()
// {
//     Console.WriteLine("Geef een tijd in, in seconden");
//     int seconden;

//     while (!int.TryParse(Console.ReadLine(), out seconden) || seconden < 0)
//     {
//         Console.WriteLine("Ongeldig getal. Probeer nog eens");
//         int.TryParse(Console.ReadLine(), out seconden);
//     }

//     return seconden;
// }

// int[] resultaten;
// double gemiddelde;

// aantalDeelnemers = VraagAantalDeelnemers();
// resultaten = new int[aantalDeelnemers];
// VulResultatenIn();

// gemiddelde = resultaten.Average();
// int aantalSnellerDanGemiddelde = BerekenAantalSnellerDanGemiddelde(resultaten, gemiddelde);

// PrintResultaten(aantalSnellerDanGemiddelde, resultaten, gemiddelde);

// int seconden = VraagSeconden();
// int aantalZelfdeAlsGemiddelde = BerekenZelfdeAlsGemiddelde(resultaten, seconden);
// Console.WriteLine($"{aantalZelfdeAlsGemiddelde} aantal deelnemers hadden exact {seconden} seconden");

// int VraagAantalDeelnemers()
// {
//     int aantalDeelnemers;
//     Console.WriteLine("Geef het aantal deelnemers");
//     bool kanOmzetten = int.TryParse(Console.ReadLine(), out aantalDeelnemers);

//     while (!kanOmzetten || aantalDeelnemers < 1)
//     {
//         Console.WriteLine("Ongeldig getal. Probeer nog eens");
//         kanOmzetten = int.TryParse(Console.ReadLine(), out aantalDeelnemers);
//     }

//     return aantalDeelnemers;
// }

// void VulResultatenIn()
// {
//     int resultaat;
//     for (int i = 0; i < resultaten.Length; i++)
//     {
//         Console.WriteLine($"Geef resultaat {i + 1} in");
//         bool kanResultaatOmzetten = int.TryParse(Console.ReadLine(), out resultaat);

//         while (!kanResultaatOmzetten || resultaat < 0)
//         {
//             Console.WriteLine("Ongeldig resultaat. Probeer nogmaals.");
//             kanResultaatOmzetten = int.TryParse(Console.ReadLine(), out resultaat);
//         }

//         resultaten[i] = resultaat;
//     }
// }

// int BerekenZelfdeAlsGemiddelde(int[] resultaten, int seconden)
// {
//     int aantalZelfdeAlsGemiddelde = 0;

//     for (int i = 0; i < resultaten.Length; i++)
//     {
//         if (resultaten[i] == seconden)
//         {
//             aantalZelfdeAlsGemiddelde++;
//         }
//     }

//     return aantalZelfdeAlsGemiddelde;
// }

// void PrintResultaten(int aantalSnellerDanGemiddelde, int[] resultaten, double gemiddelde)
// {
//     Console.WriteLine($"Snelste resultaat: {resultaten.Max()}");
//     Console.WriteLine($"Traagste resultaat: {resultaten.Min()}");
//     Console.WriteLine($"Gemiddelde resultaat: {gemiddelde}");
//     Console.WriteLine($"Aantal deelnemers sneller dan gemiddelde: {aantalSnellerDanGemiddelde}");
// }

// int BerekenAantalSnellerDanGemiddelde(int[] resultaten, double gemiddelde)
// {
//     int aantalSnellerDanGemiddelde = 0;
//     for (int i = 0; i < resultaten.Length; i++)
//     {
//         if (resultaten[i] > gemiddelde)
//         {
//             aantalSnellerDanGemiddelde++;
//         }
//     }

//     return aantalSnellerDanGemiddelde;
// }