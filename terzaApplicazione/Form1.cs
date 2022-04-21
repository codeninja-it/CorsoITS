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
		private Archivio indirizzi;

		public Form1()
		{
			InitializeComponent();
			indirizzi = new Archivio();
		}

		private void btnNuovo_Click(object sender, EventArgs e)
		{
			Contatto nuovo = new Contatto();
			Edita nuovaFinestra = new Edita(nuovo, indirizzi);
			nuovaFinestra.ShowDialog();
			if(nuovaFinestra.DialogResult == DialogResult.OK)
			{
				indirizzi.contatti.Add(nuovaFinestra.inModifica);
				lstIndirizzi.Items.Add(nuovaFinestra.inModifica.nome + " " + nuovaFinestra.inModifica.cognome);
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if( File.Exists(Properties.Settings.Default.ultimoFileLetto))
			{
				string buffer = File.ReadAllText(Properties.Settings.Default.ultimoFileLetto);
				indirizzi = JsonConvert.DeserializeObject<Archivio>(buffer);
				foreach (Contatto singolo in indirizzi.contatti)
				{
					lstIndirizzi.Items.Add(singolo.nome + " " + singolo.cognome);
				}
			}
		}

		private void lstIndirizzi_DoubleClick(object sender, EventArgs e)
		{
			int daModificare = lstIndirizzi.SelectedIndex;
			Contatto elemento = indirizzi.contatti[daModificare];
			Edita editazione = new Edita(elemento, indirizzi);
			editazione.ShowDialog();
			if(editazione.DialogResult == DialogResult.OK)
			{
				indirizzi.contatti[daModificare] = editazione.inModifica;
				lstIndirizzi.Items[daModificare] = editazione.inModifica.nome + " " + editazione.inModifica.cognome;
			}
		}

		private void lstIndirizzi_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnCancella_Click(object sender, EventArgs e)
		{

			for(int contatore = lstIndirizzi.SelectedIndices.Count - 1; contatore > 0; contatore--)
			{
				int numero = lstIndirizzi.SelectedIndices[contatore];
				indirizzi.contatti.RemoveAt(numero);
				lstIndirizzi.Items.RemoveAt(numero);
			}
		}

		private void mnuEsci_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mnuApri_Click(object sender, EventArgs e)
		{
			dlgApri.FileName = Properties.Settings.Default.ultimoFileLetto;
			DialogResult risultato = dlgApri.ShowDialog();
			if(risultato == DialogResult.OK)
			{
				Properties.Settings.Default.ultimoFileLetto = dlgApri.FileName;
				Properties.Settings.Default.Save();
				string buffer = File.ReadAllText(Properties.Settings.Default.ultimoFileLetto);
				indirizzi = JsonConvert.DeserializeObject<Archivio>(buffer);
			}
		}

		private void mnuSalva_Click(object sender, EventArgs e)
		{
			dlgSalva.FileName = Properties.Settings.Default.ultimoFileLetto;
			DialogResult risultato = dlgSalva.ShowDialog();
			if(risultato == DialogResult.OK)
			{
				Properties.Settings.Default.ultimoFileLetto = dlgSalva.FileName;
				Properties.Settings.Default.Save();
				string buffer = JsonConvert.SerializeObject(indirizzi);
				File.WriteAllText(Properties.Settings.Default.ultimoFileLetto, buffer);
			}
		}

		private void mnuNegozi_Click(object sender, EventArgs e)
		{
			Negozi dlgNegozi = new Negozi();
			dlgNegozi.archivio = indirizzi;
			dlgNegozi.ShowDialog();
			indirizzi = dlgNegozi.archivio;
		}
	}
}
