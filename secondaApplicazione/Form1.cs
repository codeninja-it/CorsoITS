using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondaApplicazione
{
	public partial class Form1 : Form
	{
		Rubrica mieiContatti;

		public Form1()
		{
			InitializeComponent();
			mieiContatti = new Rubrica();
			mieiContatti.nome = "I miei contatti di lavoro";
		}

		private void btnSalva_Click(object sender, EventArgs e)
		{
			Contatto nuovoContatto;
			nuovoContatto = new Contatto();
			nuovoContatto.nome = txtNone.Text;
			nuovoContatto.cognome = txtCognome.Text;
			nuovoContatto.telefono = txtTelefono.Text;
			mieiContatti.contatti.Add(nuovoContatto);
			mieiContatti.salva();
			MessageBox.Show("Contatto salvato!");
		}
	}
}
