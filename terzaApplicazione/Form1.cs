using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace terzaApplicazione
{
	public partial class Form1 : Form
	{
		private List<Contatto> indirizzi;
		public Form1()
		{
			InitializeComponent();
			indirizzi = new List<Contatto>();
		}

		private void btnNuovo_Click(object sender, EventArgs e)
		{
			Contatto nuovo = new Contatto();
			Edita nuovaFinestra = new Edita(nuovo);
			nuovaFinestra.ShowDialog();
			indirizzi.Add(nuovaFinestra.inModifica);
			lstIndirizzi.Items.Add( nuovaFinestra.inModifica.nome + " " + nuovaFinestra.inModifica.cognome  );
			string buffer = JsonConvert.SerializeObject(indirizzi);
			File.WriteAllText("rubrica.json", buffer);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int contatore = 0;
			int finoA = 100;
			while(contatore < finoA)
			{
				string contatto = "casella numero " + contatore.ToString("0.00");
				lstIndirizzi.Items.Add(contatto);
				contatore++;
				Contatto primo = new Contatto();
				primo.nome = "Daniele";
				primo.cognome = "Simoncini";
			}
		}
	}
}
