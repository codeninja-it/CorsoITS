using DatiDaInternet.Dati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DatiDaInternet
{
	/// <summary>
	/// Archivio dati dedicato ai libri
	/// </summary>
	public class Archivio
	{
		/// <summary>
		/// collezione dei libri in archivio
		/// </summary>
		public List<Libro> libri;
		public List<Autore> autori;
		public List<ScrittoDa> abbinamenti;
		public List<Collana> collane;

		public Archivio()
		{
			libri = new List<Libro>();
			autori = new List<Autore>();
			abbinamenti = new List<ScrittoDa>();
			collane = new List<Collana>();
		}

		public int importaCollana(string grezzo)
        {
			Collana nuova = new Collana();
			if (collane.Where(x => x.nome == grezzo).Any())
            {
				nuova = collane.Where(x => x.nome == grezzo).First();
            } else
            {
				nuova.nome = grezzo;
                if (collane.Any())
                {
					nuova.idCollana = collane.Max(x => x.idCollana) + 1;
                } else
                {
					nuova.idCollana = 1;
                }
				collane.Add(nuova);
            }
			return nuova.idCollana;
        }

		public void importaLibro(GroupCollection valori)
        {
			Libro nuovo = new Libro();
			nuovo.ISBN = double.Parse(valori[1].Value);
			nuovo.Titolo = valori[3].Value;
			nuovo.Pagine = int.Parse(valori[8].Value);
			nuovo.Prezzo = int.Parse(valori[7].Value) / 100;
			nuovo.idCollana = importaCollana(valori[6].Value);
            if (libri.Any())
            {
				nuovo.idLibro = libri.Max(x => x.idLibro) + 1;
            } else
            {
				nuovo.idLibro = 1;
            }
			libri.Add(nuovo);
		}

		public void importaAutori(string grezzo) // mario rossi-giuseppe verdi-igor bianchi
        {
			string[] pezzi = grezzo.Split('-');
			foreach(string singola in pezzi)
            {
				if(!autori.Where(x => x.nome == singola ).Any())
                {
					Autore nuovo = new Autore();
					nuovo.nome = singola;
                    if (autori.Any())
                    {
						nuovo.idAutore = autori.Max(x => x.idAutore) + 1;
					} else
                    {
						nuovo.idAutore = 1;
                    }
					
					autori.Add(nuovo);
                }
            }
        }

		public void abbinaAutori(Match elemento)
        {
			double ISBN = double.Parse(elemento.Groups[1].Value);
			int idLibro = libri.Where(x => x.ISBN == ISBN).First().idLibro;
			string[] nomi = elemento.Groups[2].Value.Split('-');
			foreach(string nome in nomi)
            {
				int idAutore = autori.Where(x => x.nome == nome).First().idAutore;
				ScrittoDa nuovo = new ScrittoDa();
				nuovo.idLibro = idLibro;
				nuovo.idAutore = idAutore;
				abbinamenti.Add(nuovo);
            }
        }
	}
}
