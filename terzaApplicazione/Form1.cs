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
		private String path;

		public Form1()
		{
			InitializeComponent();
			indirizzi = new Archivio();
			path = "archivio.json";
		}

		private void btnNuovo_Click(object sender, EventArgs e)
		{
			Contatto nuovo = new Contatto();
			Edita nuovaFinestra = new Edita(nuovo);
			nuovaFinestra.ShowDialog();
			if(nuovaFinestra.DialogResult == DialogResult.OK)
			{
				indirizzi.contatti.Add(nuovaFinestra.inModifica);
				lstIndirizzi.Items.Add(nuovaFinestra.inModifica.nome + " " + nuovaFinestra.inModifica.cognome);
				string buffer = JsonConvert.SerializeObject(indirizzi);
				File.WriteAllText(path, buffer);
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if( File.Exists(path))
			{
				string buffer = File.ReadAllText(path);
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
			Edita editazione = new Edita(elemento);
			editazione.ShowDialog();
			if(editazione.DialogResult == DialogResult.OK)
			{
				indirizzi.contatti[daModificare] = editazione.inModifica;
				lstIndirizzi.Items[daModificare] = editazione.inModifica.nome + " " + editazione.inModifica.cognome;
				string buffer = JsonConvert.SerializeObject(indirizzi);
				File.WriteAllText(path, buffer);
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
			dlgApri.FileName = path;
			DialogResult risultato = dlgApri.ShowDialog();
			if(risultato == DialogResult.OK)
			{
				path = dlgApri.FileName;
				string buffer = File.ReadAllText(path);
				indirizzi = JsonConvert.DeserializeObject<Archivio>(buffer);
			}
		}

		private void mnuSalva_Click(object sender, EventArgs e)
		{
			dlgSalva.FileName = path;
			DialogResult risultato = dlgSalva.ShowDialog();
			if(risultato == DialogResult.OK)
			{
				path = dlgSalva.FileName;
				string buffer = JsonConvert.SerializeObject(indirizzi);
				File.WriteAllText(path, buffer);
			}
		}
	}
}
