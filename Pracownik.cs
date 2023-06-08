class Pracownik
{
    public string imie;
    public string nazwisko;
    private string pesel;
    private double wynagrodzenie;
    public int iloscNadgodzin;
    public bool jestStudentem;
    public bool ukonczone26lat;


    //Wprowadzanie peselu
    public void wpiszPesel(string _pesel){
      pesel = _pesel;
    }

  // wpisywanie wynagrodzenia
    public void wpiszWynagrodzenie(double _wynagrodzenie){
      wynagrodzenie = _wynagrodzenie;
    }

  // pobieranie wynagrodzenia
  public double pobierzWynagrodzenie(){
    return wynagrodzenie;
  }
}