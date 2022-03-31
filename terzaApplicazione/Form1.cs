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
			if(nuovaFinestra.DialogResult == DialogResult.OK)
			{
				indirizzi.Add(nuovaFinestra.inModifica);
				lstIndirizzi.Items.Add(nuovaFinestra.inModifica.nome + " " + nuovaFinestra.inModifica.cognome);
				string buffer = JsonConvert.SerializeObject(indirizzi);
				File.WriteAllText("rubrica.json", buffer);
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if( File.Exists("rubrica.json"))
			{
				string buffer = File.ReadAllText("rubrica.json");
				indirizzi = JsonConvert.DeserializeObject<List<Contatto>>(buffer);
				foreach (Contatto singolo in indirizzi)
				{
					lstIndirizzi.Items.Add(singolo.nome + " " + singolo.cognome);
				}
			}
		}

		private void lstIndirizzi_DoubleClick(object sender, EventArgs e)
		{
			int daModificare = lstIndirizzi.SelectedIndex;
			Contatto elemento = indirizzi[daModificare];
			Edita editazione = new Edita(elemento);
			editazione.ShowDialog();
			if(editazione.DialogResult == DialogResult.OK)
			{
				indirizzi[daModificare] = editazione.inModifica;
				lstIndirizzi.Items[daModificare] = editazione.inModifica.nome + " " + editazione.inModifica.cognome;
				string buffer = JsonConvert.SerializeObject(indirizzi);
				File.WriteAllText("rubrica.json", buffer);
			}
		}

		private void lstIndirizzi_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnCancella_Click(object sender, EventArgs e)
		{
			foreach(int numero in lstIndirizzi.SelectedIndices)
			{
				indirizzi.RemoveAt(numero);
				//lstIndirizzi.Items.RemoveAt(numero);
				MessageBox.Show( numero.ToString() );
			}
		}
	}
}
