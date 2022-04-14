using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace terzaApplicazione
{
	public partial class Edita : Form
	{
		public Contatto inModifica;
		private Archivio archivio;

		public Edita(Contatto passato, Archivio archivio)
		{
			InitializeComponent();
			inModifica = passato;
			txtNome.Text = inModifica.nome;
			txtCognome.Text = inModifica.cognome;
			txtTelefono.Text = inModifica.telefono;
			txtEmail.Text = inModifica.email;
			if(inModifica.nascita.Year > 1753)
			{
				datNascita.Value = inModifica.nascita;
			}
			this.archivio = archivio;
			foreach(Negozio singolo in this.archivio.negozi)
			{
				cmbNegozio.Items.Add(singolo.nome);
			}
		}

		private void btnSalva_Click(object sender, EventArgs e)
		{
			inModifica.nome	= txtNome.Text;
			inModifica.cognome = txtCognome.Text;
			inModifica.telefono = txtTelefono.Text;
			inModifica.email = txtEmail.Text;
			inModifica.nascita = datNascita.Value;
			if (cmbNegozio.SelectedIndex != -1) {
				int indiceSelezionato = cmbNegozio.SelectedIndex;
				Negozio usato = archivio.negozi[indiceSelezionato];
				inModifica.idnegozio = usato.idnegozio;
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnAnnulla_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void cmbNegozio_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
