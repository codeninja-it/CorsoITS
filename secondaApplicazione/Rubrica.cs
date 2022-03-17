using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace secondaApplicazione
{
	class Rubrica
	{
		// attributi della rubrica
		public string nome;
		public List<Contatto> contatti;

		// quando viene costruita una nuova rubrica
		public Rubrica()
		{
			// ricordati di costruire anche la lista dei contatti
			// al suo interno
			contatti = new List<Contatto>();
		}

		public void salva()
		{
			string buffer;
			buffer = JsonConvert.SerializeObject(contatti);
			File.WriteAllText("rubrica.json", buffer);
		}
	}
}
