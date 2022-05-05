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
using Newtonsoft.Json;
using System.IO;

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
				archivio.importaLibro(singolo.Groups);
				archivio.importaAutori(singolo.Groups[2].Value);
				archivio.abbinaAutori(singolo);
			}

			// UNIX
			// \"	virgoletta
			// \n	new line
			// \r	carriage return
			// \t	tab
			// \\	slash

			string bufferJson = JsonConvert.SerializeObject(archivio);
			File.WriteAllText("archivio.json", bufferJson);
		}
	}
}
