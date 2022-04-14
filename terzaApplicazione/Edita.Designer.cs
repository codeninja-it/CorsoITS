
namespace terzaApplicazione
{
	partial class Edita
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAnnulla = new System.Windows.Forms.Button();
			this.btnSalva = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCognome = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.datNascita = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbNegozio = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnAnnulla
			// 
			this.btnAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAnnulla.Location = new System.Drawing.Point(346, 273);
			this.btnAnnulla.Name = "btnAnnulla";
			this.btnAnnulla.Size = new System.Drawing.Size(94, 29);
			this.btnAnnulla.TabIndex = 0;
			this.btnAnnulla.Text = "annulla";
			this.btnAnnulla.UseVisualStyleBackColor = true;
			this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
			// 
			// btnSalva
			// 
			this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalva.Location = new System.Drawing.Point(246, 273);
			this.btnSalva.Name = "btnSalva";
			this.btnSalva.Size = new System.Drawing.Size(94, 29);
			this.btnSalva.TabIndex = 1;
			this.btnSalva.Text = "salva";
			this.btnSalva.UseVisualStyleBackColor = true;
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cognome";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Telefono";
			// 
			// txtNome
			// 
			this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNome.Location = new System.Drawing.Point(116, 13);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(324, 27);
			this.txtNome.TabIndex = 5;
			// 
			// txtCognome
			// 
			this.txtCognome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCognome.Location = new System.Drawing.Point(116, 47);
			this.txtCognome.Name = "txtCognome";
			this.txtCognome.Size = new System.Drawing.Size(324, 27);
			this.txtCognome.TabIndex = 6;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefono.Location = new System.Drawing.Point(116, 81);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(324, 27);
			this.txtTelefono.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Indirizzo";
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Location = new System.Drawing.Point(116, 115);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(324, 27);
			this.txtEmail.TabIndex = 9;
			// 
			// datNascita
			// 
			this.datNascita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.datNascita.Location = new System.Drawing.Point(116, 149);
			this.datNascita.Name = "datNascita";
			this.datNascita.Size = new System.Drawing.Size(324, 27);
			this.datNascita.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 154);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Data Nascita";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Negozio";
			// 
			// cmbNegozio
			// 
			this.cmbNegozio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbNegozio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNegozio.FormattingEnabled = true;
			this.cmbNegozio.Location = new System.Drawing.Point(116, 184);
			this.cmbNegozio.Name = "cmbNegozio";
			this.cmbNegozio.Size = new System.Drawing.Size(324, 28);
			this.cmbNegozio.TabIndex = 13;
			this.cmbNegozio.SelectedIndexChanged += new System.EventHandler(this.cmbNegozio_SelectedIndexChanged);
			// 
			// Edita
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 314);
			this.Controls.Add(this.cmbNegozio);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.datNascita);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtCognome);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalva);
			this.Controls.Add(this.btnAnnulla);
			this.Name = "Edita";
			this.Text = "Edita";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAnnulla;
		private System.Windows.Forms.Button btnSalva;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtCognome;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.DateTimePicker datNascita;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbNegozio;
	}
}