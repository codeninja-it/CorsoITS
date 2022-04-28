using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace DatiDaInternet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCarica_Click(object sender, EventArgs e)
		{
			
			HttpClient richiesta = new HttpClient();
			HttpResponseMessage risposta = richiesta.GetAsync(txtIndirizzo.Text).Result;
			if (risposta.IsSuccessStatusCode)
			{
				HttpContent risultato = risposta.Content;
				txtRisultato.Text = risultato.ReadAsStringAsync().Result;
			}
		}

		private void btnTrasforma_Click(object sender, EventArgs e)
		{
			Archivio archivio = new Archivio();

			string buffer = txtRisultato.Text;
			buffer = buffer.Replace("\"", "");
			buffer = buffer.Trim();

			RegexOptions opzioni = RegexOptions.Multiline;
			string pattern = @"^(\d+)\t([^\t]*)\t([^\t]*)\t([^\t]*)\t([^\t]*)\t([^\t]*)\t(\d*)\t(\d*)\t(.*)$";
			MatchCollection trovati = Regex.Matches(buffer, pattern, opzioni);
			foreach(Match singolo in trovati)
			{
				Libro nuovo = new Libro();
				nuovo.ISBN = double.Parse(singolo.Groups[1].Value);
				nuovo.Titolo = singolo.Groups[3].Value;
				nuovo.Pagine = int.Parse(singolo.Groups[8].Value);
				nuovo.Prezzo = int.Parse(singolo.Groups[7].Value)/100;
				archivio.libri.Add(nuovo);
			}

			// UNIX
			// \"	virgoletta
			// \n	new line
			// \r	carriage return
			// \t	tab
			// \\	slash
		}
	}
}
