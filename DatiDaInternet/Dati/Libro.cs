using System;
using System.Collections.Generic;
using System.Text;

namespace DatiDaInternet
{
	/// <summary>
	/// Classe per costruire un cassetto a forma di libro
	/// </summary>
	public class Libro
	{
		/// <summary>
		/// identificativo univoco del libro
		/// </summary>
		public int idLibro;
		/// <summary>
		/// Codice univoco del libro
		/// </summary>
		public double ISBN;
		/// <summary>
		/// Titolo del libro
		/// </summary>
		public string Titolo;
		/// <summary>
		/// Numero di pagine
		/// </summary>
		public int Pagine;
		/// <summary>
		/// Prezzo se presente
		/// </summary>
		public double Prezzo;
		/// <summary>
		/// numero di riferimento della collana a cui appartiene l'opera
		/// </summary>
		public int idCollana;
	}
}
