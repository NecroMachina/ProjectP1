using UnityEngine;

public class GameScript : MonoBehaviour
{
    // States zorgen er voor dat mensen niet randon kunnen switchen tussen verschillende stages van de game, als je een nieuwe chapter toevoegd, voeg dan ook een state toe
    private enum states
    {
        start,
        intro,
        intro2,
        intro3,
        scenario1,
        scenario2,
        scenario3,
        scenario4,
        scenario5,
        scenario6,
        scenario7,
        scenario8,
        scenario9,
        scenario10,
        scenario11,
    }

    // Start is called before the first frame update
    private states currentState = states.start;
    void Start()
    {
        MainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnUserInput(string input)
    {
        if (currentState == states.start)
        {
            if (input == "start")
            {
                Intro();
            }
            else if (input == "comic sans")
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("NEE! DOE HET NIET! JESSE VERMOORD JE!");
            }
            else if (input == "menu")
            {
                MainMenu();
            }
            else
            {
                Terminal.WriteLine("Nee geen random zooi, gewoon 'start' typen");
            }
        }
        if (currentState == states.intro)
        {
            if (input == "verder")
            {
                Intro2();
            }
        }
        if (currentState == states.intro2)
        {
            if (input == "volgende")
            {
                Intro3();
            }
        }
        if (currentState == states.intro3)
        {
            if (input == "begin")
            {
                Scenario1();
            }
        }
        if (currentState == states.scenario1)
        {
            if (input == "smoes")
            {
                Scenario3();
            }
            else if (input == "eerlijk")
            {
                Scenario2();
            }
        }
        if (currentState == states.scenario2)
        {
            if (input == "alleen")
            {
                Scenario4();
            }
            else if (input == "samen")
            {
                Scenario4();
            }
        }
        if (currentState == states.scenario3)
        {
            if (input == "eentje")
            {
                Scenario4();
            }
            else if (input == "groepje")
            {
                Scenario4();
            }
        }
        if (currentState == states.scenario4)
        {
            if (input == "optie 1")
            {
                Scenario5();
            }
            else if (input == "optie 2")
            {
                Scenario5();
            }
        }
        if (currentState == states.scenario5)
        {
            if (input == "optie 1")
            {

            }
            else if (input == "optie 2")
            {

            }
        }
        if (currentState == states.scenario6)
        {
            if (input == "optie 1")
            {

            }
            else if (input == "optie 2")
            {

            }
        }
        if (currentState == states.scenario7)
        {
            if (input == "optie 1")
            {

            }
            else if (input == "optie 2")
            {

            }
        }
        if (currentState == states.scenario8)
        {
            if (input == "optie 1")
            {

            }
            else if (input == "optie 2")
            {

            }
        }
        if (currentState == states.scenario9)
        {
            if (input == "optie 1")
            {

            }
            else if (input == "optie 2")
            {

            }
        }
        if (currentState == states.scenario10)
        {
            if (input == "optie 1")
            {

            }
            else if (input == "optie 2")
            {

            }
        }
        if (currentState == states.scenario11)
        {
            if (input == "optie 1")
            {

            }
            else if (input == "optie 2")
            {

            }
            else if (input == "optie 3")
            {

            }
        }

    }
    void MainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to the game of MBOUtrecht");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ 'start' om te beginnen");
        Terminal.WriteLine("aan je eerste avontuur op deze school");
        Terminal.WriteLine("");

    }
    void Intro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("U begint uw schooljaar op MBO Utrecht.");
        Terminal.WriteLine("U heeft een heerlijke eerste week kamp gehad.");
        Terminal.WriteLine("Ook heeft u uw eerste echte werkweek gehad.");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'verder' om verder te gaan");
        currentState = states.intro;
    }
    void Intro2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Toch blijkt dat mensen u minder mogen dan u had gehoopt.");
        Terminal.WriteLine("2 leerlingen mogen u niet, en nu heeft al 2 aanvaringen gehad met een docent.");
        Terminal.WriteLine("Toch wilt u graag een betere relatie hebben met uw schoolgenoten en besluit om hiervoor hard te werken.");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'volgende' om verder te gaan");
        currentState = states.intro2;

    }
    void Intro3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("In de komende week gaat u extra letten op uw keuzes en wilt u proberen om een betere relatie met deze mensen op te bouwen.");
        Terminal.WriteLine("Dit doet u door de juiste keuzes te maken. Aan het einde van deze week hoopt u een betere indruk te hebben gemaakt.");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'begin' om je eerste scenario te zien");
        currentState = states.intro3;
    }
    void Scenario1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Card1: U heeft zichzelf verslapen en komt te laat bij uw eerste les: Web. Meneer de Vierkant is niet heel blij en denkt dat u niet gemotiveerd ben. U heeft 2 opties:");
        Terminal.WriteLine("1. Vertel een smoes in de hoop dat u ermee wegkomt.");
        Terminal.WriteLine("2. Wees eerlijk, met alle gevolgen indien.");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ 'smoes' voor optie 1, en 'eerlijk' voor optie 2");
        currentState = states.scenario1;
    }
    void Scenario2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Meneer Vierkanter vind het goed van u dat u eerlijk antwoord geeft en besluit om het door te vingers te zien. " +
            "Hij gaat verder met zijn les en verteld over een project die jullie aan het einde van de week af moeten hebben. " +
            "Een aantal klasgenoten vragen u om met hun samen te werken. " +
            "U heeft 2 opties:");
        Terminal.WriteLine("1: U maakt de opdracht 'alleen'." +
            "2: U besluit om 'samen' te werken.");
        currentState = states.scenario2;
    }
    void Scenario3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("U bedenkt een geweldige smoes wat 10 minuten kost om uit te leggen, maar helaas gelooft de docent u niet. " +
            "Had u toch maar eerlijk geweest! " +
            "Wel heeft u de klas aan het lachen gekregen. " +
            "De klas is nu onrustig en juicht. " +
            "Een groepje staat erop om samen met hun te werken.");
        Terminal.WriteLine("1: U gaat in uw 'eentje' werken." +
            "2: U doet met het 'groepje' mee");
        currentState = states.scenario3;
    }
    void Scenario4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("U bedenkt een heel leuk idee voor het project. " +
            "De leerlingen moeten een educatieve game maken over het kamp dat u heeft gehad. " +
            "Maar u wilt liever heel veel humor aan de game toevoegen. " +
            "Zo geeft u liever de leerling de mogelijkheid lm met een stink spray een vieze lucht door de gangen te verspreiden inplaats van een database opgave.");
        Terminal.WriteLine("1: U besluit om uw idee van de stink spray te gebruiken.");
        Terminal.WriteLine("2: U besluit om toch de opdracht te volgen.");
        currentState = states.scenario4;
    }
    void Scenario5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("scenario 5");
        currentState = states.scenario5;
    }
    void Scenario6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("scenario 6");
        currentState = states.scenario6;
    }
    void Scenario7()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("scenario 7");
        currentState = states.scenario7;
    }
    void Scenario8()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("scenario 8");
        currentState = states.scenario8;
    }
    void Scenario9()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("scenario 9");
        currentState = states.scenario9;
    }
    void Scenario10()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("scenario 10");
        currentState = states.scenario10;
    }
    void Scenario11()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("scenario 1-1");
        currentState = states.scenario11;
    }
}
