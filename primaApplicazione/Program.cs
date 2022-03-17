using System;

namespace primaApplicazione
{
	class Program
	{
		static void Main(string[] args)
		{
			int primaVariabile = 2;
			int risultato;
			risultato = primaVariabile * 12;
			if(risultato > 20)
			{
				Console.WriteLine("Maggiore di 20!");
			} else
			{
				Console.WriteLine("Minore di 20!");
			}
		}
	}
}
