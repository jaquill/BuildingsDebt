using System;

namespace BuildingsDebt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] buildingName = { "22", "22A", "22B", "22C" };          // tablica nazw budynków
            string [] staircaseName = {"221", "22A1", "22A2", "22B1", "22B2", "22B3", "22B4", "22C1", "22C2", "22C3", "22C4"};          // tablica nazw klatek
            float [] staircaseDebt = {4193.78f, 15931.97f, 2818.34f, 3108.29f, 9229.35f, 4877.80f, 22553.32f, 7776.69f, 5623.01f, 34608.33f, 9551.37f};         // tablica zadłużenia klatek

            Console.WriteLine();
            Console.WriteLine("Cześć! W tym programie możesz sprawdzić zadłużenie czynszowe wspólnoty mieszkaniowej \"Myśliwska 22\".");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("MENU GŁÓWNE");
                Console.WriteLine("1    Chcesz sprawdzić zadłużenie całego osiedla.");
                Console.WriteLine("2    Chcesz sprawdzić zadłużenie jednego budynku.");
                Console.WriteLine("3    Chcesz sprawdzić zadłużenie jednej klatki.");
                Console.WriteLine("4    Chcesz wyjść z programu.");
                Console.WriteLine();
                Console.WriteLine("Twój wybór to: ");

                string choice = Console.ReadLine();         // zmienna wyboru wprowadzana z klawiatury
                Console.WriteLine();

                if (choice.Contains("1") == true)
                {
                    float estateDebt = 0;           // zmienna zadłużenia osiedla (suma zadłużenia wszystkich klatek)

                    for (int i = 0; i < staircaseDebt.Length; i++)          // pętla sumująca wszystkie elementy tablicy zadłużenia klatek
                    {
                        estateDebt += staircaseDebt[i];
                    }

                    Console.WriteLine("Osiedle jest zadłużone na kwotę " + estateDebt + " PLN.");
                }

                else if (choice.Contains("2") == true)
                {
                    Console.WriteLine();
                    Console.Write("Którego budynku zadłużenie chcesz sprawdzić?\n22\n22A\n22B\n22C\n");
                    Console.WriteLine();
                    Console.Write("Twój wybór to: ");

                    string buildingChoice = Console.ReadLine();         // zmienna wyboru budynku wprowadzana z klawiatury
                    Console.WriteLine();

                    switch (buildingChoice)
                    {
                        case "22": Console.WriteLine("Budynek " + buildingName[0] + " jest zadłużony na kwotę " + staircaseDebt[0] + " PLN."); break;
                        case "22A": Console.WriteLine("Budynek " + buildingName[1] + " jest zadłużony na kwotę " + (staircaseDebt[1] + staircaseDebt[2]) + " PLN."); break;
                        case "22B": Console.WriteLine("Budynek " + buildingName[2] + " jest zadłużony na kwotę " + (staircaseDebt[3] + staircaseDebt[4] + staircaseDebt[5] + staircaseDebt[6]) + " PLN."); break;
                        case "22C": Console.WriteLine("Budynek " + buildingName[3] + " jest zadłużony na kwotę " + (staircaseDebt[7] + staircaseDebt[8] + staircaseDebt[9] + staircaseDebt[10]) + " PLN."); break;

                        default: Console.WriteLine("Błędny wybór, spróbuj ponownie."); break;
                    }
                }

                else if (choice.Contains("3") == true)
                {
                    Console.WriteLine();
                    Console.Write("Której klatki zadłużenie chcesz sprawdzić?\n221\n22A1\n22A2\n22B1\n22B2\n22B3\n22B4\n22C1\n22C2\n22C3\n22C4\n");          // \n pozwala wyświetlać w kolejnych liniach zamiast ciągiem
                    Console.WriteLine();
                    Console.Write("Twój wybór to: ");

                    string staircaseChoice = Console.ReadLine();            // zmienna wyboru klatki wprowadzana z klawiatury
                    Console.WriteLine();

                    switch (staircaseChoice)
                    {
                        case "221": Console.WriteLine("Klatka " + staircaseName[0] + " jest zadłużona na kwotę " + staircaseDebt[0] + " PLN."); break;
                        case "22A1": Console.WriteLine("Klatka " + staircaseName[1] + " jest zadłużona na kwotę " + staircaseDebt[1] + " PLN."); break;
                        case "22A2": Console.WriteLine("Klatka " + staircaseName[2] + " jest zadłużona na kwotę " + staircaseDebt[2] + " PLN."); break;
                        case "22B1": Console.WriteLine("Klatka " + staircaseName[3] + " jest zadłużona na kwotę " + staircaseDebt[3] + " PLN."); break;
                        case "22B2": Console.WriteLine("Klatka " + staircaseName[4] + " jest zadłużona na kwotę " + staircaseDebt[4] + " PLN."); break;
                        case "22B3": Console.WriteLine("Klatka " + staircaseName[5] + " jest zadłużona na kwotę " + staircaseDebt[5] + " PLN."); break;
                        case "22B4": Console.WriteLine("Klatka " + staircaseName[6] + " jest zadłużona na kwotę " + staircaseDebt[6] + " PLN."); break;
                        case "22C1": Console.WriteLine("Klatka " + staircaseName[7] + " jest zadłużona na kwotę " + staircaseDebt[7] + " PLN."); break;
                        case "22C2": Console.WriteLine("Klatka " + staircaseName[8] + " jest zadłużona na kwotę " + staircaseDebt[8] + " PLN."); break;
                        case "22C3": Console.WriteLine("Klatka " + staircaseName[9] + " jest zadłużona na kwotę " + staircaseDebt[9] + " PLN."); break;
                        case "22C4": Console.WriteLine("Klatka " + staircaseName[10] + " jest zadłużona na kwotę " + staircaseDebt[10] + " PLN."); break;

                        default: Console.WriteLine("Błędny wybór, spróbuj ponownie."); break;
                    }
                }

                else if (choice.Contains("4") == true)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Błędny wybór, spróbuj ponownie.");
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
