using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace terzaApplicazione
{
	public partial class Negozi : Form
	{
		// passato dall'utente
		public Archivio archivio = new Archivio();

		public Negozi()
		{
			InitializeComponent();
		}

		private void Negozi_Load(object sender, EventArgs e)
		{
			foreach(Negozio singolo in archivio.negozi)
			{
				lstNegozi.Items.Add(singolo.nome);
			}
		}

		private void btnChiudi_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnCancella_Click(object sender, EventArgs e)
		{
			if (lstNegozi.SelectedIndex == -1)
			{
				MessageBox.Show("Per cancellare un contatto, prima selezionalo", "Cancella contatto");
			}
			else
			{
				int indiceSelezionato = lstNegozi.SelectedIndex;
				lstNegozi.Items.RemoveAt(indiceSelezionato);
				archivio.negozi.RemoveAt(indiceSelezionato);
			}
			
		}

		private void btnNuovo_Click(object sender, EventArgs e)
		{
			txtNome.Text = "";
			txtIndirizzo.Text = "";
			txtTelefono.Text = "";
			lstNegozi.SelectedIndex = -1;
		}

		private void lstNegozi_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstNegozi.SelectedIndex != -1)
			{
				int indiceSelezionato = lstNegozi.SelectedIndex;
				Negozio elemento = archivio.negozi[indiceSelezionato];
				txtNome.Text = elemento.nome;
				txtIndirizzo.Text = elemento.indirizzo;
				txtTelefono.Text = elemento.telefono;
			}
		}

		private void btnSalva_Click(object sender, EventArgs e)
		{
			int indiceSelezionato = lstNegozi.SelectedIndex;
			if(indiceSelezionato == -1)
			{
				// l'utente vuole aggiungere un nuovo contatto
				Negozio nuovo = new Negozio();
				nuovo.nome = txtNome.Text;
				nuovo.indirizzo = txtIndirizzo.Text;
				nuovo.telefono = txtTelefono.Text;
				nuovo.idnegozio = archivio.ultimoNegozio + 1;
				archivio.ultimoNegozio = nuovo.idnegozio;
				archivio.negozi.Add(nuovo);
				lstNegozi.Items.Add(nuovo.nome);
			}
			else
			{
				// l'utente vuole modificare un contatto già presente
				Negozio daModificare = archivio.negozi[indiceSelezionato];
				daModificare.nome = txtNome.Text;
				daModificare.indirizzo = txtIndirizzo.Text;
				daModificare.telefono = txtTelefono.Text;
				archivio.negozi[indiceSelezionato] = daModificare;
				lstNegozi.Items[indiceSelezionato] = txtNome.Text;
			}
			txtNome.Text = "";
			txtIndirizzo.Text = "";
			txtTelefono.Text = "";
			MessageBox.Show("dati salvati");
		}
	}
}
