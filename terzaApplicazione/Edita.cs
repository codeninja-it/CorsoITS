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

		public Edita(Contatto passato)
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
		}

		private void btnSalva_Click(object sender, EventArgs e)
		{
			inModifica.nome = txtNome.Text;
			inModifica.cognome = txtCognome.Text;
			inModifica.telefono = txtTelefono.Text;
			inModifica.email = txtEmail.Text;
			inModifica.nascita = datNascita.Value;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnAnnulla_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
