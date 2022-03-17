using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondaApplicazione
{
	class Contatto
	{
		// attributi del mio contatto
		public string nome;
		public string cognome;
		public string telefono;
		public string email;
		public int altezza;
		public double peso;
		public bool maschio;
		public DateTime creazione;

		// funzione di creazione
		public Contatto()
		{
			creazione = DateTime.Now;
		}
	}
}
