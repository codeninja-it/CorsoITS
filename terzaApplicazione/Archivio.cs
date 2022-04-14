using System;
using System.Collections.Generic;
using System.Text;

namespace terzaApplicazione
{
	public class Archivio
	{
		public List<Contatto> contatti;
		public List<Negozio> negozi;
		public DateTime creazione;

		public int ultimoNegozio;
		public int ultimoContatto;

		public Archivio()
		{
			contatti = new List<Contatto>();
			negozi = new List<Negozio>();
			creazione = DateTime.Now;
			ultimoContatto = 0;
			ultimoNegozio = 0;
		}
	}
}
