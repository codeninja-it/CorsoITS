using System;
using System.Collections.Generic;
using System.Text;

namespace DatiDaInternet
{
	/// <summary>
	/// Archivio dati dedicato ai libri
	/// </summary>
	class Archivio
	{
		/// <summary>
		/// collezione dei libri in archivio
		/// </summary>
		public List<Libro> libri;
		public List<Autore> autori;

		public Archivio()
		{
			libri = new List<Libro>();
		}
	}
}
