// See https://aka.ms/new-console-template for more information

string percorso = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

double bmi = 0;
double peso = 0;
double altezza = 0;

peso = recuperaParametro("peso in Kg: ");
altezza = recuperaParametro("altezza in metri: ");


bmi = peso / (altezza * altezza);

Console.WriteLine("il tuo BMI è " + bmi.ToString("N2")  );


// funzione
double recuperaParametro(string label, int profondita = 0)
{
    if(profondita > 3)
    {
        Console.WriteLine("...basta, mi hai stufato");
        Environment.Exit(0);
    }
    double numero;
    Console.Write(label);
    string buffer = Console.ReadLine();
    try
    {
        numero = double.Parse(buffer);
    }
    catch
    {
        Console.WriteLine(buffer + " non è un numero");
        numero = recuperaParametro(label, profondita + 1);
    }
    
    return numero;
}

