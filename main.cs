using System;

class Program
{
    static void Main(string[] args)
    {
        Pracownik p1 = null;
        Ksiegowa s1 = null;

        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Wprowadź nowego pracownika");
            Console.WriteLine("2. Wprowadź nową księgową");
            Console.WriteLine("3. Uzupełnij dane księgowej");
            Console.WriteLine("4. Wyświetl dane pracownika");
            Console.WriteLine("5. Wyjście");
            Console.Write("Wybierz opcję: ");

            string opcja = Console.ReadLine();
            Console.WriteLine();

            switch (opcja)
            {
                case "1":
                    p1 = DodajPracownika();
                    break;

                case "2":
                    if (p1 == null)
                    {
                        Console.WriteLine("Najpierw dodaj pracownika!");
                    }
                    else
                    {
                        s1 = DodajKsiegowa(p1);
                    }
                    break;

                case "3":
                    if (s1 == null)
                    {
                        Console.WriteLine("Najpierw dodaj księgową!");
                    }
                    else
                    {
                        PlanujUzupelnienie(s1);
                    }
                    break;

                case "4":
                    if (s1 == null || p1==null)
                    {
                        Console.WriteLine("Brak danych pracownika.");
                    }
                    else
                    {
                        s1.Wyswietl();
                    }
                    break;

                case "5":
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Nieprawidłowa opcja. Wybierz ponownie.");
                    break;
            }
        }
    }
  
    // Metoda do dodawania nowego pracownika
    static Pracownik DodajPracownika()
    {
        Pracownik pracownik = new Pracownik();

        Console.WriteLine("Dodawanie nowego pracownika");
        Console.Write("Imię: ");
        pracownik.imie = Console.ReadLine();

        Console.Write("Nazwisko: ");
        pracownik.nazwisko = Console.ReadLine();

        return pracownik;
    }
  
    // Metoda do dodawania nowej księgowej
    static Ksiegowa DodajKsiegowa(Pracownik pracownik)
    {
        Ksiegowa ksiegowa = new Ksiegowa("", "", pracownik);

        Console.WriteLine("\nDodawanie nowej księgowej");
        Console.Write("Imię: ");
        ksiegowa.imie = Console.ReadLine();

        Console.Write("Nazwisko: ");
        ksiegowa.nazwisko = Console.ReadLine();

        return ksiegowa;
    }
  
    // Metoda do planowania uzupełnienia danych księgowej
   static void PlanujUzupelnienie(Ksiegowa ksiegowa)
  {
    Console.WriteLine("\nPlanowanie uzupełnienia danych księgowej");
    Console.Write("PESEL: ");
    string pesel = Console.ReadLine();

    Console.Write("Wynagrodzenie: ");
    double wynagrodzenie = Convert.ToDouble(Console.ReadLine());

    Console.Write("Za miesiąc: ");
    ksiegowa.miesiac = Console.ReadLine();
    
    Console.Write("Czy jest studentem? (tak/nie): ");
    bool jestStudentem = CzyTak(Console.ReadLine());

    Console.Write("Czy ukończył/a 26 lat? (tak/nie): ");
    bool ukonczone26lat = CzyTak(Console.ReadLine());

    ksiegowa.Uzupelnij(pesel, wynagrodzenie, jestStudentem, ukonczone26lat);
}
  
// Metoda pomocnicza do konwersji odpowiedzi "tak" lub "nie" na wartość logiczną
static bool CzyTak(string odpowiedz)
{
    return odpowiedz.ToLower() == "tak";
}
}