//Begin met de input
int aantalStudenten, score, minimum, maximum, aantalGeslaagdeStudenten = 0;
int[] scores = [];
double gemiddelde;

aantalStudenten = VraagAantalStudenten();
scores = new int[aantalStudenten];

VoegScoresToe(scores);

maximum = scores.Max();
minimum = scores.Min();
gemiddelde = scores.Average();
aantalGeslaagdeStudenten = BerekenAantalGeslaagdeStudenten(scores, aantalGeslaagdeStudenten);

OutputScores(gemiddelde, minimum, maximum, aantalGeslaagdeStudenten);

Console.WriteLine("Naar welke score wilt u zoeken?");
int gezochteScore = int.Parse(Console.ReadLine());
int aantalKeerDatScoreVoorkomt = ZoekAantalScore(gezochteScore);
Console.WriteLine($"Score {gezochteScore} komt {aantalKeerDatScoreVoorkomt} keer voor.");

int ZoekAantalScore(int gezochteScore)
{
    int aantal = 0;

    for (int i = 0; i < scores.Length; i++)
    {
        if(scores[i] == gezochteScore)
        {
            aantal++;
        }
    }

    return aantal;
}

void OutputScores(double gemiddelde, int minimum, int maximum, int aantalGeslaagdeStudenten)
{
    Console.WriteLine($"Gemiddelde:{gemiddelde.ToString("F2")}");
    Console.WriteLine($"Minimum:{minimum}");
    Console.WriteLine($"Maximum:{maximum}");
    Console.WriteLine($"Aantal geslaagden: {aantalGeslaagdeStudenten}");
}

int BerekenAantalGeslaagdeStudenten(int[] scores, int aantalGeslaagdeStudenten)
{
    // Business code -> Is een student geslaagd? Code > 10
    for (int i = 0; i < scores.Length; i++)
    {
        if (scores[i] >= 10)
        {
            aantalGeslaagdeStudenten++;
        }
    }

    return aantalGeslaagdeStudenten;
}

int VraagAantalStudenten()
{
    int aantalStudenten;
    // Controleer of input werkt
    Console.WriteLine("Aantal Studenten?");

    // Defensive coding -> Vooraleer we verdergaan, 
    // controleren we of de waardes geldig zij
    bool isGetal = int.TryParse(Console.ReadLine(), out aantalStudenten);

    // while -> Gebruiken we als we niet weten hoevaak iets moet herhalan
    while (isGetal == false || aantalStudenten <= 0) // while(!isGetal) { ... }
    {
        Console.WriteLine("Ongeldig getal! Probeer opnieuw");

        // Vergeet nooit om je eigen while af te sluiten
        // Meestal exact dezelfde code als vlak voor de while
        isGetal = int.TryParse(Console.ReadLine(), out aantalStudenten);
    }

    return aantalStudenten;
}

void VoegScoresToe(int[] scores)
{
    int score = 0;
    //Onbekend aantal iteraties, maar wel een collectie? -> Array
    for (int i = 0; i < scores.Length; i++)
    {
        Console.WriteLine($"Geef score {i + 1}");

        bool isGeldigeScore = int.TryParse(Console.ReadLine(), out score);

        while (!isGeldigeScore || score < 0 || score > 20)
        {
            Console.WriteLine("Ongeldige Score! Geef een getal tussen 0 en 20 in");
            isGeldigeScore = int.TryParse(Console.ReadLine(), out score);
        }


        scores[i] = score;
    }
}