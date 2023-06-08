using System;

class Ksiegowa
{
    // Pola klasy
    public string imie;
    public string nazwisko;
    public string miesiac;
    public Pracownik pracownik;

    // Konstruktor
    public Ksiegowa(string imie, string nazwisko, Pracownik pracownik)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.pracownik = pracownik;
    }

    // Metoda do uzupełniania danych pracownika
    public void Uzupelnij(string pesel, double wynagrodzenie, bool jestStudentem, bool ukonczone26lat)
    {
        pracownik.pesel = pesel;
        pracownik.wynagrodzenie = wynagrodzenie;
        pracownik.jestStudentem = jestStudentem;
        pracownik.ukonczone26lat = ukonczone26lat;
    }

    // Metoda do obliczania kwoty brutto
    public double PobierzKwoteBrutto()
    {
        return pracownik.wynagrodzenie + (pracownik.iloscNadgodzin * 25);
    }

    // Metoda do wyświetlania danych księgowej
    public void Wyswietl()
    {
        Console.WriteLine("Rachunek za miesiąc: " + miesiac);
        Console.WriteLine("Wystawiony dla: " + pracownik.imie + " " + pracownik.nazwisko);
        Console.WriteLine("Do wypłaty Brutto: " + PobierzKwoteBrutto() + " złotych brutto");
        Console.WriteLine("Do wypłaty Netto: " + PobierzKwoteNetto(PobierzKwoteBrutto()) + " złotych Netto");
        Console.WriteLine("Dział księgowości: " + imie + " " + nazwisko);
    }

    // Metoda do obliczania kwoty netto
    public double PobierzKwoteNetto(double brutto)
    {
        brutto = PobierzKwoteBrutto();
        if (pracownik.jestStudentem == true && pracownik.ukonczone26lat == false)
        {
            return brutto;
        }
        else if (pracownik.jestStudentem == false && pracownik.ukonczone26lat == false)
        {
            return brutto * 0.8;
        }
        else
        {
            return brutto * 0.75;
        }
    }
}
